namespace DFe.App
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new LollipopButton();
            this.lollipopLabel3 = new LollipopLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new LollipopButton();
            this.lollipopLabel9 = new LollipopLabel();
            this.lollipopLabel8 = new LollipopLabel();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.lblEventsManifest = new LollipopLabel();
            this.btnEventGreen = new LollipopButton();
            this.btnEventRed = new LollipopButton();
            this.btnEventBlue = new LollipopButton();
            this.btnEventOrange = new LollipopButton();
            this.txtIssuerCnpj = new LollipopTextBox();
            this.txtAmount = new LollipopTextBox();
            this.txtSerial = new LollipopTextBox();
            this.txtModel = new LollipopTextBox();
            this.txtNumber = new LollipopTextBox();
            this.txtIssuerName = new LollipopTextBox();
            this.txtAccessKey = new LollipopTextBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.btnReadMore = new LollipopFlatButton();
            this.btnCreateEditCompany = new LollipopFlatButton();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.toggleSearchByAccessKey = new LollipopToggle();
            this.toggleSearchByXmlFile = new LollipopToggle();
            this.inputAccessKey = new LollipopTextBox();
            this.inputXmlFile = new LollipopFileInput();
            this.cardCompany = new LollipopSmallCard();
            this.lollipopProgressBar1 = new LollipopProgressBar();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel12 = new LollipopLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lollipopLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 99;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BGColor = "#F44336";
            this.btnClose.FontColor = "#ffffff";
            this.btnClose.Location = new System.Drawing.Point(722, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 25);
            this.btnClose.TabIndex = 99;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Fechar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Roboto Medium", 15F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 9);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(95, 26);
            this.lollipopLabel3.TabIndex = 99;
            this.lollipopLabel3.Text = "DF-e App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DFe.App.Properties.Resources.background_nfe;
            this.pictureBox1.Location = new System.Drawing.Point(484, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BGColor = "#508ef5";
            this.btnSearch.FontColor = "#ffffff";
            this.btnSearch.Location = new System.Drawing.Point(368, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 24);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Consultar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lollipopLabel9
            // 
            this.lollipopLabel9.AutoSize = true;
            this.lollipopLabel9.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel9.Location = new System.Drawing.Point(16, 313);
            this.lollipopLabel9.Name = "lollipopLabel9";
            this.lollipopLabel9.Size = new System.Drawing.Size(465, 19);
            this.lollipopLabel9.TabIndex = 99;
            this.lollipopLabel9.Text = "____________________________________________________________________________";
            // 
            // lollipopLabel8
            // 
            this.lollipopLabel8.AutoSize = true;
            this.lollipopLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel8.Font = new System.Drawing.Font("Roboto", 10F);
            this.lollipopLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel8.Location = new System.Drawing.Point(13, 120);
            this.lollipopLabel8.Name = "lollipopLabel8";
            this.lollipopLabel8.Size = new System.Drawing.Size(536, 19);
            this.lollipopLabel8.TabIndex = 99;
            this.lollipopLabel8.Text = "É a manifestação sobre a participação comercial entre o destinatário e o forneced" +
    "or.";
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Roboto", 10F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(13, 94);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(62, 19);
            this.lollipopLabel7.TabIndex = 99;
            this.lollipopLabel7.Text = "O que é?";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(13, 61);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(196, 19);
            this.lollipopLabel6.TabIndex = 99;
            this.lollipopLabel6.Text = "Manifestação do Destinatário";
            // 
            // lblEventsManifest
            // 
            this.lblEventsManifest.AutoSize = true;
            this.lblEventsManifest.BackColor = System.Drawing.Color.Transparent;
            this.lblEventsManifest.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lblEventsManifest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblEventsManifest.Location = new System.Drawing.Point(16, 351);
            this.lblEventsManifest.Name = "lblEventsManifest";
            this.lblEventsManifest.Size = new System.Drawing.Size(167, 19);
            this.lblEventsManifest.TabIndex = 99;
            this.lblEventsManifest.Text = "Eventos de Manifestação";
            // 
            // btnEventGreen
            // 
            this.btnEventGreen.BackColor = System.Drawing.Color.Transparent;
            this.btnEventGreen.BGColor = "#4CAF50";
            this.btnEventGreen.FontColor = "#ffffff";
            this.btnEventGreen.Location = new System.Drawing.Point(136, 373);
            this.btnEventGreen.Name = "btnEventGreen";
            this.btnEventGreen.Size = new System.Drawing.Size(110, 20);
            this.btnEventGreen.TabIndex = 99;
            this.btnEventGreen.TabStop = false;
            this.btnEventGreen.Text = "Confirmação";
            this.btnEventGreen.Click += new System.EventHandler(this.btnEventGreen_Click);
            // 
            // btnEventRed
            // 
            this.btnEventRed.BackColor = System.Drawing.Color.Transparent;
            this.btnEventRed.BGColor = "#F44336";
            this.btnEventRed.FontColor = "#ffffff";
            this.btnEventRed.Location = new System.Drawing.Point(368, 373);
            this.btnEventRed.Name = "btnEventRed";
            this.btnEventRed.Size = new System.Drawing.Size(110, 20);
            this.btnEventRed.TabIndex = 99;
            this.btnEventRed.TabStop = false;
            this.btnEventRed.Text = "NÃO Realizada";
            this.btnEventRed.Click += new System.EventHandler(this.btnEventRed_Click);
            // 
            // btnEventBlue
            // 
            this.btnEventBlue.BackColor = System.Drawing.Color.Transparent;
            this.btnEventBlue.BGColor = "#508ef5";
            this.btnEventBlue.FontColor = "#ffffff";
            this.btnEventBlue.Location = new System.Drawing.Point(20, 373);
            this.btnEventBlue.Name = "btnEventBlue";
            this.btnEventBlue.Size = new System.Drawing.Size(110, 20);
            this.btnEventBlue.TabIndex = 99;
            this.btnEventBlue.TabStop = false;
            this.btnEventBlue.Text = "Ciência";
            this.btnEventBlue.Click += new System.EventHandler(this.btnEventBlue_Click);
            // 
            // btnEventOrange
            // 
            this.btnEventOrange.BackColor = System.Drawing.Color.Transparent;
            this.btnEventOrange.BGColor = "#FF9800";
            this.btnEventOrange.FontColor = "#ffffff";
            this.btnEventOrange.Location = new System.Drawing.Point(252, 373);
            this.btnEventOrange.Name = "btnEventOrange";
            this.btnEventOrange.Size = new System.Drawing.Size(110, 20);
            this.btnEventOrange.TabIndex = 99;
            this.btnEventOrange.TabStop = false;
            this.btnEventOrange.Text = "Desconhecimento";
            this.btnEventOrange.Click += new System.EventHandler(this.btnEventOrange_Click);
            // 
            // txtIssuerCnpj
            // 
            this.txtIssuerCnpj.FocusedColor = "#508ef5";
            this.txtIssuerCnpj.FontColor = "#999999";
            this.txtIssuerCnpj.IsEnabled = true;
            this.txtIssuerCnpj.Location = new System.Drawing.Point(550, 494);
            this.txtIssuerCnpj.MaxLength = 32767;
            this.txtIssuerCnpj.Multiline = false;
            this.txtIssuerCnpj.Name = "txtIssuerCnpj";
            this.txtIssuerCnpj.ReadOnly = false;
            this.txtIssuerCnpj.Size = new System.Drawing.Size(222, 24);
            this.txtIssuerCnpj.TabIndex = 11;
            this.txtIssuerCnpj.Text = "C.N.P.J";
            this.txtIssuerCnpj.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIssuerCnpj.UseSystemPasswordChar = false;
            // 
            // txtAmount
            // 
            this.txtAmount.FocusedColor = "#508ef5";
            this.txtAmount.FontColor = "#999999";
            this.txtAmount.IsEnabled = true;
            this.txtAmount.Location = new System.Drawing.Point(645, 464);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.Size = new System.Drawing.Size(127, 24);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "Valor Total (R$)";
            this.txtAmount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // txtSerial
            // 
            this.txtSerial.FocusedColor = "#508ef5";
            this.txtSerial.FontColor = "#999999";
            this.txtSerial.IsEnabled = true;
            this.txtSerial.Location = new System.Drawing.Point(589, 464);
            this.txtSerial.MaxLength = 32767;
            this.txtSerial.Multiline = false;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = false;
            this.txtSerial.Size = new System.Drawing.Size(50, 24);
            this.txtSerial.TabIndex = 8;
            this.txtSerial.Text = "Série";
            this.txtSerial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSerial.UseSystemPasswordChar = false;
            // 
            // txtModel
            // 
            this.txtModel.FocusedColor = "#508ef5";
            this.txtModel.FontColor = "#999999";
            this.txtModel.IsEnabled = true;
            this.txtModel.Location = new System.Drawing.Point(437, 464);
            this.txtModel.MaxLength = 32767;
            this.txtModel.Multiline = false;
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = false;
            this.txtModel.Size = new System.Drawing.Size(50, 24);
            this.txtModel.TabIndex = 6;
            this.txtModel.Text = "Modelo";
            this.txtModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtModel.UseSystemPasswordChar = false;
            // 
            // txtNumber
            // 
            this.txtNumber.FocusedColor = "#508ef5";
            this.txtNumber.FontColor = "#999999";
            this.txtNumber.IsEnabled = true;
            this.txtNumber.Location = new System.Drawing.Point(493, 464);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = false;
            this.txtNumber.Size = new System.Drawing.Size(90, 24);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.Text = "Número";
            this.txtNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumber.UseSystemPasswordChar = false;
            // 
            // txtIssuerName
            // 
            this.txtIssuerName.FocusedColor = "#508ef5";
            this.txtIssuerName.FontColor = "#999999";
            this.txtIssuerName.IsEnabled = true;
            this.txtIssuerName.Location = new System.Drawing.Point(17, 494);
            this.txtIssuerName.MaxLength = 32767;
            this.txtIssuerName.Multiline = false;
            this.txtIssuerName.Name = "txtIssuerName";
            this.txtIssuerName.ReadOnly = false;
            this.txtIssuerName.Size = new System.Drawing.Size(527, 24);
            this.txtIssuerName.TabIndex = 10;
            this.txtIssuerName.Text = "Emitente / Rementente";
            this.txtIssuerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIssuerName.UseSystemPasswordChar = false;
            // 
            // txtAccessKey
            // 
            this.txtAccessKey.FocusedColor = "#508ef5";
            this.txtAccessKey.FontColor = "#999999";
            this.txtAccessKey.IsEnabled = true;
            this.txtAccessKey.Location = new System.Drawing.Point(17, 464);
            this.txtAccessKey.MaxLength = 32767;
            this.txtAccessKey.Multiline = false;
            this.txtAccessKey.Name = "txtAccessKey";
            this.txtAccessKey.ReadOnly = false;
            this.txtAccessKey.Size = new System.Drawing.Size(414, 24);
            this.txtAccessKey.TabIndex = 5;
            this.txtAccessKey.Text = "Chave de Acesso";
            this.txtAccessKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAccessKey.UseSystemPasswordChar = false;
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(16, 430);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(115, 19);
            this.lollipopLabel4.TabIndex = 99;
            this.lollipopLabel4.Text = "Detalhes do DF-e";
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.Color.Transparent;
            this.btnReadMore.FontColor = "#4CAF50";
            this.btnReadMore.Location = new System.Drawing.Point(81, 95);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(86, 18);
            this.btnReadMore.TabIndex = 99;
            this.btnReadMore.TabStop = false;
            this.btnReadMore.Text = "Leia mais...";
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // btnCreateEditCompany
            // 
            this.btnCreateEditCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateEditCompany.FontColor = "#4CAF50";
            this.btnCreateEditCompany.Location = new System.Drawing.Point(674, 68);
            this.btnCreateEditCompany.Name = "btnCreateEditCompany";
            this.btnCreateEditCompany.Size = new System.Drawing.Size(90, 19);
            this.btnCreateEditCompany.TabIndex = 99;
            this.btnCreateEditCompany.TabStop = false;
            this.btnCreateEditCompany.Text = "Selecionar";
            this.btnCreateEditCompany.Click += new System.EventHandler(this.btnCreateEditCompany_Click);
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(70, 231);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(209, 19);
            this.lollipopLabel2.TabIndex = 99;
            this.lollipopLabel2.Text = "Consultar pela Chave de Acesso";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Enabled = false;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(70, 158);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(185, 19);
            this.lollipopLabel1.TabIndex = 99;
            this.lollipopLabel1.Text = "Consultar pelo Arquivo XML";
            // 
            // toggleSearchByAccessKey
            // 
            this.toggleSearchByAccessKey.AutoSize = true;
            this.toggleSearchByAccessKey.Checked = true;
            this.toggleSearchByAccessKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleSearchByAccessKey.EllipseBorderColor = "33; 150; 243";
            this.toggleSearchByAccessKey.EllipseColor = "33; 150; 243";
            this.toggleSearchByAccessKey.Location = new System.Drawing.Point(17, 232);
            this.toggleSearchByAccessKey.Name = "toggleSearchByAccessKey";
            this.toggleSearchByAccessKey.Size = new System.Drawing.Size(47, 19);
            this.toggleSearchByAccessKey.TabIndex = 2;
            this.toggleSearchByAccessKey.Text = "lollipopToggle1";
            this.toggleSearchByAccessKey.UseVisualStyleBackColor = true;
            this.toggleSearchByAccessKey.CheckedChanged += new System.EventHandler(this.toggleSearchByAccessKey_CheckedChanged);
            // 
            // toggleSearchByXmlFile
            // 
            this.toggleSearchByXmlFile.AutoSize = true;
            this.toggleSearchByXmlFile.EllipseBorderColor = "33; 150; 243";
            this.toggleSearchByXmlFile.EllipseColor = "33; 150; 243";
            this.toggleSearchByXmlFile.Enabled = false;
            this.toggleSearchByXmlFile.Location = new System.Drawing.Point(17, 158);
            this.toggleSearchByXmlFile.Name = "toggleSearchByXmlFile";
            this.toggleSearchByXmlFile.Size = new System.Drawing.Size(47, 19);
            this.toggleSearchByXmlFile.TabIndex = 0;
            this.toggleSearchByXmlFile.Text = "lollipopToggle1";
            this.toggleSearchByXmlFile.UseVisualStyleBackColor = true;
            this.toggleSearchByXmlFile.CheckedChanged += new System.EventHandler(this.toggleSearchByXmlFile_CheckedChanged);
            // 
            // inputAccessKey
            // 
            this.inputAccessKey.FocusedColor = "#508ef5";
            this.inputAccessKey.FontColor = "#999999";
            this.inputAccessKey.IsEnabled = true;
            this.inputAccessKey.Location = new System.Drawing.Point(20, 263);
            this.inputAccessKey.MaxLength = 44;
            this.inputAccessKey.Multiline = false;
            this.inputAccessKey.Name = "inputAccessKey";
            this.inputAccessKey.ReadOnly = false;
            this.inputAccessKey.Size = new System.Drawing.Size(339, 24);
            this.inputAccessKey.TabIndex = 3;
            this.inputAccessKey.Text = "00000000000000000000000000000000000000000000";
            this.inputAccessKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputAccessKey.UseSystemPasswordChar = false;
            // 
            // inputXmlFile
            // 
            this.inputXmlFile.Filter = "All Files (*.*)|*.*";
            this.inputXmlFile.FocusedColor = "#508ef5";
            this.inputXmlFile.FontColor = "#999999";
            this.inputXmlFile.IsEnabled = false;
            this.inputXmlFile.Location = new System.Drawing.Point(20, 189);
            this.inputXmlFile.MaxLength = 32767;
            this.inputXmlFile.Name = "inputXmlFile";
            this.inputXmlFile.ReadOnly = true;
            this.inputXmlFile.Size = new System.Drawing.Size(339, 24);
            this.inputXmlFile.TabIndex = 1;
            this.inputXmlFile.Text = "*.xml";
            this.inputXmlFile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputXmlFile.UseSystemPasswordChar = false;
            // 
            // cardCompany
            // 
            this.cardCompany.FontColor = "#4CAF50";
            this.cardCompany.Image = null;
            this.cardCompany.Info = "[EMPRESA]";
            this.cardCompany.Location = new System.Drawing.Point(327, 61);
            this.cardCompany.Name = "cardCompany";
            this.cardCompany.Size = new System.Drawing.Size(445, 52);
            this.cardCompany.TabIndex = 99;
            this.cardCompany.TabStop = false;
            this.cardCompany.Text = "[C.N.P.J]";
            this.cardCompany.ThumbnailColor = "#4CAF50";
            // 
            // lollipopProgressBar1
            // 
            this.lollipopProgressBar1.BGColor = "#0D47A1";
            this.lollipopProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lollipopProgressBar1.Location = new System.Drawing.Point(0, 50);
            this.lollipopProgressBar1.Name = "lollipopProgressBar1";
            this.lollipopProgressBar1.Size = new System.Drawing.Size(784, 5);
            this.lollipopProgressBar1.TabIndex = 99;
            this.lollipopProgressBar1.TabStop = false;
            this.lollipopProgressBar1.Text = "lollipopProgressBar1";
            this.lollipopProgressBar1.Value = 100;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(16, 396);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(294, 19);
            this.lollipopLabel5.TabIndex = 100;
            this.lollipopLabel5.Text = "[NÃO é necessário consultar para manifestar]";
            // 
            // lollipopLabel12
            // 
            this.lollipopLabel12.AutoSize = true;
            this.lollipopLabel12.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel12.Font = new System.Drawing.Font("Roboto", 10F);
            this.lollipopLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel12.Location = new System.Drawing.Point(13, 533);
            this.lollipopLabel12.Name = "lollipopLabel12";
            this.lollipopLabel12.Size = new System.Drawing.Size(656, 19);
            this.lollipopLabel12.TabIndex = 99;
            this.lollipopLabel12.Text = "*Informe os dados da empresa, após, a chave da NF-e desejada e consulte e/ou mani" +
    "feste o documento.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lollipopLabel9);
            this.Controls.Add(this.lollipopLabel12);
            this.Controls.Add(this.lollipopLabel8);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.lblEventsManifest);
            this.Controls.Add(this.btnEventGreen);
            this.Controls.Add(this.btnEventRed);
            this.Controls.Add(this.btnEventBlue);
            this.Controls.Add(this.btnEventOrange);
            this.Controls.Add(this.txtIssuerCnpj);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtIssuerName);
            this.Controls.Add(this.txtAccessKey);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.btnCreateEditCompany);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.toggleSearchByAccessKey);
            this.Controls.Add(this.toggleSearchByXmlFile);
            this.Controls.Add(this.inputAccessKey);
            this.Controls.Add(this.inputXmlFile);
            this.Controls.Add(this.cardCompany);
            this.Controls.Add(this.lollipopProgressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "DF-e App | Demonstração";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LollipopProgressBar lollipopProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private LollipopLabel lollipopLabel3;
        private LollipopButton btnClose;
        private LollipopSmallCard cardCompany;
        private LollipopFileInput inputXmlFile;
        private LollipopTextBox inputAccessKey;
        private LollipopToggle toggleSearchByXmlFile;
        private LollipopToggle toggleSearchByAccessKey;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private LollipopFlatButton btnCreateEditCompany;
        private LollipopLabel lollipopLabel4;
        private LollipopTextBox txtAccessKey;
        private LollipopTextBox txtIssuerName;
        private LollipopTextBox txtIssuerCnpj;
        private LollipopTextBox txtNumber;
        private LollipopTextBox txtModel;
        private LollipopTextBox txtSerial;
        private LollipopTextBox txtAmount;
        private LollipopButton btnEventOrange;
        private LollipopButton btnEventRed;
        private LollipopButton btnEventGreen;
        private LollipopButton btnEventBlue;
        private LollipopLabel lblEventsManifest;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel7;
        private LollipopLabel lollipopLabel8;
        private LollipopFlatButton btnReadMore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopLabel lollipopLabel9;
        private LollipopButton btnSearch;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel12;
    }
}