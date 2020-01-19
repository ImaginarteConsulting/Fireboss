namespace Estimador
{
    partial class AboutUS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUS));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlContainer = new System.Windows.Forms.Panel();
            this.nameData = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.companyData = new System.Windows.Forms.Label();
            this.VersionData = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.licenseAgreementLabel = new System.Windows.Forms.Label();
            this.licenseAgreementText = new System.Windows.Forms.RichTextBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(615, 44);
            this.headerPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(146, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Acerca de Fireboss";
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Estimador.Properties.Resources.close_window_48px;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(576, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 44);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(63, 428);
            this.leftPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fireboss";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estimador.Properties.Resources.fireboss_white;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // controlContainer
            // 
            this.controlContainer.AutoScroll = true;
            this.controlContainer.BackColor = System.Drawing.Color.White;
            this.controlContainer.Controls.Add(this.nameData);
            this.controlContainer.Controls.Add(this.nameLabel);
            this.controlContainer.Controls.Add(this.companyData);
            this.controlContainer.Controls.Add(this.VersionData);
            this.controlContainer.Controls.Add(this.CompanyLabel);
            this.controlContainer.Controls.Add(this.VersionLabel);
            this.controlContainer.Controls.Add(this.licenseAgreementLabel);
            this.controlContainer.Controls.Add(this.licenseAgreementText);
            this.controlContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer.Location = new System.Drawing.Point(63, 44);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(552, 428);
            this.controlContainer.TabIndex = 3;
            // 
            // nameData
            // 
            this.nameData.AutoSize = true;
            this.nameData.Location = new System.Drawing.Point(88, 3);
            this.nameData.Name = "nameData";
            this.nameData.Size = new System.Drawing.Size(52, 17);
            this.nameData.TabIndex = 7;
            this.nameData.Text = "Fireboss";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Nombre:";
            // 
            // companyData
            // 
            this.companyData.AutoSize = true;
            this.companyData.Location = new System.Drawing.Point(88, 43);
            this.companyData.Name = "companyData";
            this.companyData.Size = new System.Drawing.Size(176, 17);
            this.companyData.TabIndex = 5;
            this.companyData.Text = "© 2020 Imaginarte Consulting";
            // 
            // VersionData
            // 
            this.VersionData.AutoSize = true;
            this.VersionData.Location = new System.Drawing.Point(89, 22);
            this.VersionData.Name = "VersionData";
            this.VersionData.Size = new System.Drawing.Size(31, 17);
            this.VersionData.TabIndex = 4;
            this.VersionData.Text = "1.1.0";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(6, 43);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(63, 17);
            this.CompanyLabel.TabIndex = 3;
            this.CompanyLabel.Text = "Company:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(7, 22);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(51, 17);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version:";
            // 
            // licenseAgreementLabel
            // 
            this.licenseAgreementLabel.AutoSize = true;
            this.licenseAgreementLabel.Location = new System.Drawing.Point(6, 69);
            this.licenseAgreementLabel.Name = "licenseAgreementLabel";
            this.licenseAgreementLabel.Size = new System.Drawing.Size(113, 17);
            this.licenseAgreementLabel.TabIndex = 1;
            this.licenseAgreementLabel.Text = "License agreement";
            // 
            // licenseAgreementText
            // 
            this.licenseAgreementText.BackColor = System.Drawing.Color.White;
            this.licenseAgreementText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseAgreementText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseAgreementText.Location = new System.Drawing.Point(6, 91);
            this.licenseAgreementText.Name = "licenseAgreementText";
            this.licenseAgreementText.ReadOnly = true;
            this.licenseAgreementText.Size = new System.Drawing.Size(534, 324);
            this.licenseAgreementText.TabIndex = 0;
            this.licenseAgreementText.Text = "";
            // 
            // AboutUS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(615, 472);
            this.Controls.Add(this.controlContainer);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AboutUS_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlContainer.ResumeLayout(false);
            this.controlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel controlContainer;
        private System.Windows.Forms.Label licenseAgreementLabel;
        private System.Windows.Forms.RichTextBox licenseAgreementText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameData;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label companyData;
        private System.Windows.Forms.Label VersionData;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}

