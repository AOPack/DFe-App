using DFe.App.Core;
using DFe.App.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DFe.App
{
    public partial class frmCreateEditCompany : Form, IMessageFilter
    {
        private Company _company;
        public frmCreateEditCompany()
        {
            InitializeComponent();

            // Personaliza form
            this.ControlBox = false;
            this.BackColor = Color.White;
            this.Size = new Size(550, 250);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;

            Application.AddMessageFilter(this);

            //Add whatever controls here you want to move the form when it is clicked and dragged
            _controlsToMove.Add(this);

            if (App.Company != null)
                GetCompanyData(App.Company);
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

        private void GetCompanyData(Company company)
        {
            _company = new Company();

            if (company != null)
                _company = company;

            txtCnpj.Text = _company.Cnpj;
            txtEstate.Text = _company.Estate;
            txtName.Text = _company.Name;

            txtFriendlyName.Text = _company.CertificateFriendlyName;
            txtSerialNumber.Text = _company.CertificateSerialNumber;
            txtPassword.Text = _company.CertificatePassword;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtCnpj.Text))
                return false;

            if (string.IsNullOrEmpty(txtEstate.Text))
                return false;

            if (string.IsNullOrEmpty(txtName.Text))
                return false;

            return true;
        }

        private void frmCreateEditCompany_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                if (_company == null)
                    _company = new Company();

                _company.Cnpj = txtCnpj.Text;
                _company.Estate = txtEstate.Text.ToUpper();
                _company.Name = txtName.Text.ToUpper();

                _company.CertificateFriendlyName = txtFriendlyName.Text;
                _company.CertificateSerialNumber = txtSerialNumber.Text;
                _company.CertificatePassword = txtPassword.Text;

                App.Company = _company;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCnpj_Enter(object sender, EventArgs e)
        {
            var textBox = sender as LollipopTextBox;
            if (textBox.Text == "C.N.P.J.")
                textBox.ResetText();
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            var textBox = sender as LollipopTextBox;
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                textBox.Text = "C.N.P.J.";
        }

        private void btnCertificateSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var certificate = CertificateServices.CertificateSelect();
                txtFriendlyName.Text = certificate.FriendlyName;
                txtSerialNumber.Text = certificate.GetSerialNumberString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
