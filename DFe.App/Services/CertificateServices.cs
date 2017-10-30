using System;
using System.Security.Cryptography.X509Certificates;

namespace DFe.App.Services
{
    public static class CertificateServices
    {
        public static X509Certificate2 CertificateSelect()
        {
            X509Certificate2 certificate = null;

            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            var collection = store.Certificates;
            var fcollection = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            var scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Certificados válidos:",
                "Selecione o certificado que deseja usar",
                X509SelectionFlag.SingleSelection);

            if (scollection.Count == 0)
            {
                throw new Exception("Nenhum certificado foi selecionado!");
            }

            certificate = scollection[0];

            if (certificate == null)
            {
                throw new Exception("Nenhum certificado foi selecionado!");
            }

            store.Close();

            return certificate;
        }
    }
}
