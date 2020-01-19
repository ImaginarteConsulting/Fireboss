namespace Estimador
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.loadTemplate = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.makeReportButton = new System.Windows.Forms.PictureBox();
            this.controlContainer = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.totalPriceData = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceHourData = new System.Windows.Forms.Label();
            this.priceHourLabel = new System.Windows.Forms.Label();
            this.totalTimeData = new System.Windows.Forms.Label();
            this.effortSavedData = new System.Windows.Forms.Label();
            this.effortTakenData = new System.Windows.Forms.Label();
            this.baseHoursData = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.baseHourLabel = new System.Windows.Forms.Label();
            this.effortSavedLabel = new System.Windows.Forms.Label();
            this.effortTakenLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeReportButton)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.saveButton);
            this.headerPanel.Controls.Add(this.loadTemplate);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.settingsButton);
            this.headerPanel.Controls.Add(this.makeReportButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(615, 44);
            this.headerPanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = global::Estimador.Properties.Resources.save_26px_w;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(435, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(27, 29);
            this.saveButton.TabIndex = 16;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadTemplate
            // 
            this.loadTemplate.BackgroundImage = global::Estimador.Properties.Resources.upload_26px;
            this.loadTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadTemplate.Location = new System.Drawing.Point(468, 8);
            this.loadTemplate.Name = "loadTemplate";
            this.loadTemplate.Size = new System.Drawing.Size(29, 27);
            this.loadTemplate.TabIndex = 15;
            this.loadTemplate.TabStop = false;
            this.loadTemplate.Click += new System.EventHandler(this.loadTemplate_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Estimador de proyectos";
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
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::Estimador.Properties.Resources.settings_26px;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Location = new System.Drawing.Point(538, 8);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(32, 30);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // makeReportButton
            // 
            this.makeReportButton.BackgroundImage = global::Estimador.Properties.Resources.combo_chart_26px;
            this.makeReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.makeReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeReportButton.Location = new System.Drawing.Point(503, 8);
            this.makeReportButton.Name = "makeReportButton";
            this.makeReportButton.Size = new System.Drawing.Size(29, 27);
            this.makeReportButton.TabIndex = 2;
            this.makeReportButton.TabStop = false;
            this.makeReportButton.Click += new System.EventHandler(this.makeReportButton_Click);
            // 
            // controlContainer
            // 
            this.controlContainer.AutoScroll = true;
            this.controlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.controlContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer.Location = new System.Drawing.Point(188, 44);
            this.controlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(427, 440);
            this.controlContainer.TabIndex = 3;
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.leftPanel.Controls.Add(this.totalPriceData);
            this.leftPanel.Controls.Add(this.totalPriceLabel);
            this.leftPanel.Controls.Add(this.priceHourData);
            this.leftPanel.Controls.Add(this.priceHourLabel);
            this.leftPanel.Controls.Add(this.totalTimeData);
            this.leftPanel.Controls.Add(this.effortSavedData);
            this.leftPanel.Controls.Add(this.effortTakenData);
            this.leftPanel.Controls.Add(this.baseHoursData);
            this.leftPanel.Controls.Add(this.totalTimeLabel);
            this.leftPanel.Controls.Add(this.baseHourLabel);
            this.leftPanel.Controls.Add(this.effortSavedLabel);
            this.leftPanel.Controls.Add(this.effortTakenLabel);
            this.leftPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 44);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(188, 440);
            this.leftPanel.TabIndex = 4;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // totalPriceData
            // 
            this.totalPriceData.AutoSize = true;
            this.totalPriceData.ForeColor = System.Drawing.Color.White;
            this.totalPriceData.Location = new System.Drawing.Point(94, 152);
            this.totalPriceData.Name = "totalPriceData";
            this.totalPriceData.Size = new System.Drawing.Size(13, 13);
            this.totalPriceData.TabIndex = 14;
            this.totalPriceData.Text = "0";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.White;
            this.totalPriceLabel.Location = new System.Drawing.Point(12, 152);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(76, 13);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.Text = "Precio total:";
            // 
            // priceHourData
            // 
            this.priceHourData.AutoSize = true;
            this.priceHourData.ForeColor = System.Drawing.Color.White;
            this.priceHourData.Location = new System.Drawing.Point(94, 130);
            this.priceHourData.Name = "priceHourData";
            this.priceHourData.Size = new System.Drawing.Size(13, 13);
            this.priceHourData.TabIndex = 12;
            this.priceHourData.Text = "0";
            // 
            // priceHourLabel
            // 
            this.priceHourLabel.AutoSize = true;
            this.priceHourLabel.ForeColor = System.Drawing.Color.White;
            this.priceHourLabel.Location = new System.Drawing.Point(12, 130);
            this.priceHourLabel.Name = "priceHourLabel";
            this.priceHourLabel.Size = new System.Drawing.Size(82, 13);
            this.priceHourLabel.TabIndex = 11;
            this.priceHourLabel.Text = "Precio por hora:";
            // 
            // totalTimeData
            // 
            this.totalTimeData.AutoSize = true;
            this.totalTimeData.ForeColor = System.Drawing.Color.White;
            this.totalTimeData.Location = new System.Drawing.Point(99, 87);
            this.totalTimeData.Name = "totalTimeData";
            this.totalTimeData.Size = new System.Drawing.Size(13, 13);
            this.totalTimeData.TabIndex = 10;
            this.totalTimeData.Text = "0";
            // 
            // effortSavedData
            // 
            this.effortSavedData.AutoSize = true;
            this.effortSavedData.ForeColor = System.Drawing.Color.White;
            this.effortSavedData.Location = new System.Drawing.Point(114, 61);
            this.effortSavedData.Name = "effortSavedData";
            this.effortSavedData.Size = new System.Drawing.Size(13, 13);
            this.effortSavedData.TabIndex = 9;
            this.effortSavedData.Text = "0";
            // 
            // effortTakenData
            // 
            this.effortTakenData.AutoSize = true;
            this.effortTakenData.ForeColor = System.Drawing.Color.White;
            this.effortTakenData.Location = new System.Drawing.Point(113, 39);
            this.effortTakenData.Name = "effortTakenData";
            this.effortTakenData.Size = new System.Drawing.Size(13, 13);
            this.effortTakenData.TabIndex = 8;
            this.effortTakenData.Text = "0";
            // 
            // baseHoursData
            // 
            this.baseHoursData.AutoSize = true;
            this.baseHoursData.ForeColor = System.Drawing.Color.White;
            this.baseHoursData.Location = new System.Drawing.Point(82, 16);
            this.baseHoursData.Name = "baseHoursData";
            this.baseHoursData.Size = new System.Drawing.Size(13, 13);
            this.baseHoursData.TabIndex = 7;
            this.baseHoursData.Text = "0";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.totalTimeLabel.Location = new System.Drawing.Point(12, 87);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(81, 13);
            this.totalTimeLabel.TabIndex = 6;
            this.totalTimeLabel.Text = "Tiempo total:";
            // 
            // baseHourLabel
            // 
            this.baseHourLabel.AutoSize = true;
            this.baseHourLabel.ForeColor = System.Drawing.Color.White;
            this.baseHourLabel.Location = new System.Drawing.Point(12, 16);
            this.baseHourLabel.Name = "baseHourLabel";
            this.baseHourLabel.Size = new System.Drawing.Size(64, 13);
            this.baseHourLabel.TabIndex = 5;
            this.baseHourLabel.Text = "Horas base:";
            // 
            // effortSavedLabel
            // 
            this.effortSavedLabel.AutoSize = true;
            this.effortSavedLabel.ForeColor = System.Drawing.Color.White;
            this.effortSavedLabel.Location = new System.Drawing.Point(12, 61);
            this.effortSavedLabel.Name = "effortSavedLabel";
            this.effortSavedLabel.Size = new System.Drawing.Size(96, 13);
            this.effortSavedLabel.TabIndex = 4;
            this.effortSavedLabel.Text = "Esfuerzo ahorrado:";
            // 
            // effortTakenLabel
            // 
            this.effortTakenLabel.AutoSize = true;
            this.effortTakenLabel.ForeColor = System.Drawing.Color.White;
            this.effortTakenLabel.Location = new System.Drawing.Point(12, 39);
            this.effortTakenLabel.Name = "effortTakenLabel";
            this.effortTakenLabel.Size = new System.Drawing.Size(95, 13);
            this.effortTakenLabel.TabIndex = 3;
            this.effortTakenLabel.Text = "Esfuerzo insumido:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(615, 484);
            this.Controls.Add(this.controlContainer);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeReportButton)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel controlContainer;
        private System.Windows.Forms.PictureBox makeReportButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label totalTimeData;
        private System.Windows.Forms.Label effortSavedData;
        private System.Windows.Forms.Label effortTakenData;
        private System.Windows.Forms.Label baseHoursData;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label baseHourLabel;
        private System.Windows.Forms.Label effortSavedLabel;
        private System.Windows.Forms.Label effortTakenLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label totalPriceData;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceHourData;
        private System.Windows.Forms.Label priceHourLabel;
        private System.Windows.Forms.PictureBox loadTemplate;
        private System.Windows.Forms.PictureBox saveButton;
    }
}

