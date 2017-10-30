namespace DFe.App
{
    partial class frmCreateEditCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFriendlyName = new LollipopTextBox();
            this.txtPassword = new LollipopTextBox();
            this.txtSerialNumber = new LollipopTextBox();
            this.btnCertificateSelect = new LollipopButton();
            this.btnSave = new LollipopButton();
            this.btnFindByCnpj = new LollipopFlatButton();
            this.btnClose = new LollipopFlatButton();
            this.txtEstate = new LollipopTextBox();
            this.txtCnpj = new LollipopTextBox();
            this.txtName = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.SuspendLayout();
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.FocusedColor = "#508ef5";
            this.txtFriendlyName.FontColor = "#999999";
            this.txtFriendlyName.IsEnabled = true;
            this.txtFriendlyName.Location = new System.Drawing.Point(16, 145);
            this.txtFriendlyName.MaxLength = 32767;
            this.txtFriendlyName.Multiline = false;
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.ReadOnly = false;
            this.txtFriendlyName.Size = new System.Drawing.Size(506, 24);
            this.txtFriendlyName.TabIndex = 8;
            this.txtFriendlyName.Text = "Nome Amigável";
            this.txtFriendlyName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendlyName.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.FocusedColor = "#508ef5";
            this.txtPassword.FontColor = "#999999";
            this.txtPassword.IsEnabled = true;
            this.txtPassword.Location = new System.Drawing.Point(16, 175);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(506, 24);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "Senha";
            this.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.FocusedColor = "#508ef5";
            this.txtSerialNumber.FontColor = "#999999";
            this.txtSerialNumber.IsEnabled = true;
            this.txtSerialNumber.Location = new System.Drawing.Point(16, 115);
            this.txtSerialNumber.MaxLength = 32767;
            this.txtSerialNumber.Multiline = false;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = false;
            this.txtSerialNumber.Size = new System.Drawing.Size(432, 24);
            this.txtSerialNumber.TabIndex = 6;
            this.txtSerialNumber.Text = "Número de Série";
            this.txtSerialNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSerialNumber.UseSystemPasswordChar = false;
            // 
            // btnCertificateSelect
            // 
            this.btnCertificateSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnCertificateSelect.BGColor = "#33b679";
            this.btnCertificateSelect.FontColor = "#ffffff";
            this.btnCertificateSelect.Location = new System.Drawing.Point(454, 115);
            this.btnCertificateSelect.Name = "btnCertificateSelect";
            this.btnCertificateSelect.Size = new System.Drawing.Size(68, 24);
            this.btnCertificateSelect.TabIndex = 7;
            this.btnCertificateSelect.Text = "Selecionar";
            this.btnCertificateSelect.Click += new System.EventHandler(this.btnCertificateSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BGColor = "#2196F3";
            this.btnSave.FontColor = "#ffffff";
            this.btnSave.Location = new System.Drawing.Point(416, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 20);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFindByCnpj
            // 
            this.btnFindByCnpj.BackColor = System.Drawing.Color.Transparent;
            this.btnFindByCnpj.Enabled = false;
            this.btnFindByCnpj.FontColor = "#2196F3";
            this.btnFindByCnpj.Location = new System.Drawing.Point(227, 31);
            this.btnFindByCnpj.Name = "btnFindByCnpj";
            this.btnFindByCnpj.Size = new System.Drawing.Size(110, 20);
            this.btnFindByCnpj.TabIndex = 2;
            this.btnFindByCnpj.Text = "Pesquisar CNPJ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FontColor = "#F44336";
            this.btnClose.Location = new System.Drawing.Point(472, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 20);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Fechar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEstate
            // 
            this.txtEstate.FocusedColor = "#508ef5";
            this.txtEstate.FontColor = "#999999";
            this.txtEstate.IsEnabled = true;
            this.txtEstate.Location = new System.Drawing.Point(357, 31);
            this.txtEstate.MaxLength = 2;
            this.txtEstate.Multiline = false;
            this.txtEstate.Name = "txtEstate";
            this.txtEstate.ReadOnly = false;
            this.txtEstate.Size = new System.Drawing.Size(37, 24);
            this.txtEstate.TabIndex = 3;
            this.txtEstate.Text = "UF";
            this.txtEstate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstate.UseSystemPasswordChar = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.FocusedColor = "#508ef5";
            this.txtCnpj.FontColor = "#999999";
            this.txtCnpj.IsEnabled = true;
            this.txtCnpj.Location = new System.Drawing.Point(16, 31);
            this.txtCnpj.MaxLength = 20;
            this.txtCnpj.Multiline = false;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.ReadOnly = false;
            this.txtCnpj.Size = new System.Drawing.Size(321, 24);
            this.txtCnpj.TabIndex = 1;
            this.txtCnpj.Text = "C.N.P.J.";
            this.txtCnpj.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCnpj.UseSystemPasswordChar = false;
            this.txtCnpj.Enter += new System.EventHandler(this.txtCnpj_Enter);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtName
            // 
            this.txtName.FocusedColor = "#508ef5";
            this.txtName.FontColor = "#999999";
            this.txtName.IsEnabled = true;
            this.txtName.Location = new System.Drawing.Point(16, 61);
            this.txtName.MaxLength = 150;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(506, 24);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Razão Social";
            this.txtName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 93);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(79, 19);
            this.lollipopLabel2.TabIndex = 5;
            this.lollipopLabel2.Text = "Certificado";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 9);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(126, 19);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Dados da Empresa";
            // 
            // frmCreateEditCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.txtFriendlyName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.btnCertificateSelect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFindByCnpj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEstate);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Name = "frmCreateEditCompany";
            this.Text = "Company | Create or Edit";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCreateEditCompany_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel lollipopLabel1;
        private LollipopTextBox txtName;
        private LollipopTextBox txtEstate;
        private LollipopTextBox txtCnpj;
        private LollipopLabel lollipopLabel2;
        private LollipopFlatButton btnClose;
        private LollipopButton btnSave;
        private LollipopButton btnCertificateSelect;
        private LollipopFlatButton btnFindByCnpj;
        private LollipopTextBox txtSerialNumber;
        private LollipopTextBox txtPassword;
        private LollipopTextBox txtFriendlyName;
    }
}