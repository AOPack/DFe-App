using DFe.App.Common;
using DFe.App.Core;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.DistribuicaoDFe;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Utils;
using System;
using System.Net;

namespace DFe.App.Services
{
    public class ApplicationServices
    {
        private ConfiguracaoServico _configServico;

        private ConfiguracaoServico ConfiguraServico(Estado uf, ModeloDocumento mod,
            NFe.Classes.Informacoes.Identificacao.Tipos.TipoAmbiente ta, TipoEmissao te, int timeOut,
            SecurityProtocolType spt, ConfiguracaoCertificado certificate)
        {
            var cfgServico = NFe.Utils.ConfiguracaoServico.Instancia;

            cfgServico.ModeloDocumento = mod;
            cfgServico.tpAmb = ta;
            cfgServico.tpEmis = te;
            cfgServico.TimeOut = timeOut;
            cfgServico.ProtocoloDeSeguranca = spt;
            cfgServico.Certificado = certificate;
            cfgServico.VersaoNFeDistribuicaoDFe = VersaoServico.ve100;
            cfgServico.VersaoRecepcaoEventoManifestacaoDestinatario = VersaoServico.ve100;
            cfgServico.VersaoNfeDownloadNF = VersaoServico.ve310;
            cfgServico.cUF = uf;
            cfgServico.DiretorioSchemas = Constants.SchemasPath;
            cfgServico.DiretorioSalvarXml = Constants.DfeAppPath;

            _configServico = cfgServico;
            return _configServico;
        }

        //public NFe.Classes.NFe CarregarObjetoNFe(string arquivoXml)
        //{
        //    if (string.IsNullOrEmpty(arquivoXml))
        //        throw new Exception("Nenhum arquivo XML foi selecionado!");

        //    bool exists = System.IO.File.Exists(arquivoXml);

        //    if (!exists)
        //        throw new Exception("O arquivo selecionado não pode ser encontrado!");

        //    var nfe = new NFe.Classes.NFe().CarregarDeArquivoXml(arquivoXml);

        //    return nfe;
        //}

        private bool CheckIfIsNfeProc(string content)
        {
            if (content.StartsWith("\n<nfeProc") || content.StartsWith("<nfeProc"))
                return true;

            return false;
        }

        private bool CheckIfIsResNfe(string content)
        {
            if (content.StartsWith("<resNFe"))
                return true;

            return false;
        }

        private ConfiguracaoCertificado GetCertificateForConfig(string serialNumber, string password = "", TipoCertificado certificateType = TipoCertificado.A1Repositorio)
        {
            return new ConfiguracaoCertificado()
            {
                TipoCertificado = certificateType,
                Serial = serialNumber,
                //Senha = password
            };
        }

        private Estado GetEstateForConfig(string uf)
        {
            switch (uf)
            {
                case "AC":
                    return Estado.AC;
                    break;
                case "AL":
                    return Estado.AL;
                    break;
                case "AM":
                    return Estado.AM;
                    break;
                case "AP":
                    return Estado.AP;
                    break;
                case "BA":
                    return Estado.BA;
                    break;
                case "CE":
                    return Estado.CE;
                    break;
                case "DF":
                    return Estado.DF;
                    break;
                case "ES":
                    return Estado.ES;
                    break;
                case "GO":
                    return Estado.GO;
                    break;
                case "MA":
                    return Estado.MA;
                    break;
                case "MG":
                    return Estado.MG;
                    break;
                case "MS":
                    return Estado.MS;
                    break;
                case "MT":
                    return Estado.MT;
                    break;
                case "PA":
                    return Estado.PA;
                    break;
                case "PB":
                    return Estado.PB;
                    break;
                case "PE":
                    return Estado.PE;
                    break;
                case "PI":
                    return Estado.PI;
                    break;
                case "PR":
                    return Estado.PR;
                    break;
                case "RJ":
                    return Estado.RJ;
                    break;
                case "RN":
                    return Estado.RN;
                    break;
                case "RO":
                    return Estado.RO;
                    break;
                case "RR":
                    return Estado.RR;
                    break;
                case "RS":
                    return Estado.RS;
                    break;
                case "SC":
                    return Estado.SC;
                    break;
                case "SE":
                    return Estado.SE;
                    break;
                case "SP":
                    return Estado.SP;
                    break;
                case "TO":
                    return Estado.TO;
                    break;
                default:
                    return Estado.AN;
                    break;
            }
        }

        public bool ManifestDfe(int idLote, int seqEvent, string accessKey, Company company,
           int eventCodeManifest = 0, string reason = null)
        {
            TipoEventoManifestacaoDestinatario eventCode;
            switch (eventCodeManifest)
            {
                case 0:
                    eventCode = TipoEventoManifestacaoDestinatario.TeMdCienciaDaEmissao;
                    break;
                case 1:
                    eventCode = TipoEventoManifestacaoDestinatario.TeMdConfirmacaoDaOperacao;
                    break;
                case 2:
                    eventCode = TipoEventoManifestacaoDestinatario.TeMdDesconhecimentoDaOperacao;
                    break;
                case 3:
                    eventCode = TipoEventoManifestacaoDestinatario.TeMdOperacaoNaoRealizada;
                    break;
                default:
                    throw new Exception("Código de Manifestação não identificado!");
            }

            var configCertificado = GetCertificateForConfig(company.CertificateSerialNumber, company.CertificatePassword);

            ConfiguraServico(GetEstateForConfig(company.Estate), ModeloDocumento.NFe,
                NFe.Classes.Informacoes.Identificacao.Tipos.TipoAmbiente.taProducao, TipoEmissao.teNormal, 10000,
                SecurityProtocolType.Ssl3, configCertificado);

            using (var servicoNFe = new ServicosNFe(_configServico))
            {
                var retornoNFeDistDFe = servicoNFe.RecepcaoEventoManifestacaoDestinatario(idLote, seqEvent, accessKey,
                    eventCode, company.Cnpj, reason);

                if (retornoNFeDistDFe.Retorno.cStat == 128)
                    return true;
            }

            return false;
        }

        public Document SearchForDocumentDistribution(Company company, string accessKey = "")
        {
            var document = new Document();

            // Normalize CNPJ number
            var companyCnpj = company.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "").Trim();

            #region Essential Validation

            //if (!Validation.ValidaCpfCnpj(companyCnpj))
            //    throw new ArgumentException("CNPJ inválido!", companyCnpj);

            if (string.IsNullOrEmpty(company.Estate.Trim()))
                throw new ArgumentException("UF não informada!", company.Estate);

            if (string.IsNullOrEmpty(company.CertificateSerialNumber.Trim()))
                throw new ArgumentException("Nenhum certificado foi informado no cadastro da empresa!",
                    company.CertificateSerialNumber);

            if (string.IsNullOrEmpty(company.CertificatePassword.Trim()))
                throw new ArgumentException("A senha do certificado não foi informada no cadastro da empresa!",
                    company.CertificatePassword);

            #endregion Essential Validation

            var certConfiguration = GetCertificateForConfig(company.CertificateSerialNumber, company.CertificatePassword);

            ConfiguraServico(GetEstateForConfig(company.Estate), ModeloDocumento.NFe,
                NFe.Classes.Informacoes.Identificacao.Tipos.TipoAmbiente.taProducao, TipoEmissao.teNormal, 10000,
                SecurityProtocolType.Ssl3, certConfiguration);

            using (var servicoNFe = new ServicosNFe(_configServico))
            {
                // Get response from SEFAZ WS
                var response = servicoNFe.NfeDistDFeInteresse(company.Estate, companyCnpj, chNFE: accessKey);

                document = TurnIntoDFeDocument(response.Retorno.loteDistDFeInt);
            }

            return document;
        }

        private Document TurnIntoDFeDocument(loteDistDFeInt[] loteDistDFeInt)
        {
            var docToReturn = new Document();

            if (loteDistDFeInt != null)
            {
                for (int i = 0; i < loteDistDFeInt.Length; i++)
                {
                    var documentNsu = loteDistDFeInt[i].NSU;
                    var xmlInBytes = loteDistDFeInt[i].XmlNfe;
                    string content = Compressao.Unzip(xmlInBytes);

                    if (content.StartsWith("<resNFe"))
                    {
                        var resNFeContent =
                            FuncoesXml.XmlStringParaClasse<NFe.Classes.Servicos.DistribuicaoDFe.Schemas.resNFe>(content);

                        docToReturn.AccessKey = resNFeContent.chNFe;
                        docToReturn.Amount = resNFeContent.vNF;
                        docToReturn.IssuerName = resNFeContent.xNome;
                        docToReturn.IssuerCnpj = resNFeContent.CNPJ.ToString();
                    }

                    if (CheckIfIsNfeProc(content))
                    {
                        var procNFeContent = new NFe.Classes.nfeProc().CarregarDeXmlString(content);

                        if (procNFeContent != null)
                        {
                            docToReturn.AccessKey = procNFeContent.protNFe.infProt.chNFe;
                            docToReturn.Amount = procNFeContent.NFe.infNFe.total.ICMSTot.vNF;
                            docToReturn.IssuerName = procNFeContent.NFe.infNFe.emit.xNome;
                            docToReturn.IssuerCnpj = procNFeContent.NFe.infNFe.emit.CNPJ;
                        }
                    }
                }
            }
            return docToReturn;
        }
    }
}
