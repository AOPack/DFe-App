using DFe.App.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DFe.App
{
    public partial class frmMain : Form, IMessageFilter
    {
        public frmMain()
        {
            InitializeComponent();

            // Personaliza form
            this.ControlBox = false;
            this.BackColor = Color.White;
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            Application.AddMessageFilter(this);

            //Add whatever controls here you want to move the form when it is clicked and dragged
            _controlsToMove.Add(this);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private readonly HashSet<Control> _controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 _controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toggleSearchByXmlFile_CheckedChanged(object sender, EventArgs e)
        {
            toggleSearchByAccessKey.Checked = !toggleSearchByXmlFile.Checked;
        }

        private void toggleSearchByAccessKey_CheckedChanged(object sender, EventArgs e)
        {
            toggleSearchByXmlFile.Checked = !toggleSearchByAccessKey.Checked;
        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.nfe.fazenda.gov.br/portal/perguntasFrequentes.aspx?tipoConteudo=yjOJMwFOkA0=");
        }

        private void btnCreateEditCompany_Click(object sender, EventArgs e)
        {
            var screen = new frmCreateEditCompany();
            if (screen.ShowDialog() == DialogResult.OK)
            {
                cardCompany.Text = App.Company.Cnpj;
                cardCompany.Info = $"{App.Company.Name} [{App.Company.Estate}]";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ApplicationServices();
                var objReturned = service.SearchForDocumentDistribution(App.Company, inputAccessKey.Text);

                txtAccessKey.Text = objReturned.AccessKey;
                txtModel.Text = objReturned.Mod.ToString();
                txtNumber.Text = objReturned.Number.ToString();
                txtSerial.Text = objReturned.Serial.ToString();
                txtAmount.Text = objReturned.Amount.ToString();
                txtIssuerName.Text = objReturned.IssuerName.ToString();
                txtIssuerCnpj.Text = objReturned.IssuerCnpj.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEventBlue_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ApplicationServices();
                var result = service.ManifestDfe(1, 1, inputAccessKey.Text, App.Company);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEventGreen_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ApplicationServices();
                var result = service.ManifestDfe(1, 1, inputAccessKey.Text, App.Company, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEventOrange_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ApplicationServices();
                var result = service.ManifestDfe(1, 1, inputAccessKey.Text, App.Company, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEventRed_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ApplicationServices();
                var result = service.ManifestDfe(1, 1, inputAccessKey.Text, App.Company, 3, "Pedido não efetivado junto ao fornecedor!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
