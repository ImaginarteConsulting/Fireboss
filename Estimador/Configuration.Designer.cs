namespace Estimador
{
    partial class Configuration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.gridTemplateControls = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effort = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.aboutUs = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.loadTemplate = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.priceHourTextBox = new System.Windows.Forms.TextBox();
            this.priceHourLabel = new System.Windows.Forms.Label();
            this.baseHoursTextBox = new System.Windows.Forms.TextBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.ControlsLabel = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplateControls)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTemplateControls
            // 
            this.gridTemplateControls.AllowUserToResizeColumns = false;
            this.gridTemplateControls.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gridTemplateControls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTemplateControls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTemplateControls.BackgroundColor = System.Drawing.Color.White;
            this.gridTemplateControls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTemplateControls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTemplateControls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridTemplateControls.ColumnHeadersHeight = 27;
            this.gridTemplateControls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Description,
            this.Type,
            this.Pond,
            this.DefaultValue,
            this.Effort,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTemplateControls.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridTemplateControls.EnableHeadersVisualStyles = false;
            this.gridTemplateControls.Location = new System.Drawing.Point(90, 65);
            this.gridTemplateControls.MultiSelect = false;
            this.gridTemplateControls.Name = "gridTemplateControls";
            this.gridTemplateControls.RowHeadersVisible = false;
            this.gridTemplateControls.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridTemplateControls.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gridTemplateControls.RowTemplate.Height = 27;
            this.gridTemplateControls.Size = new System.Drawing.Size(1254, 401);
            this.gridTemplateControls.TabIndex = 0;
            this.gridTemplateControls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTemplateControls_CellContentClick);
            this.gridTemplateControls.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridTemplateControls_CellFormatting);
            this.gridTemplateControls.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTemplateControls_CellValueChanged);
            this.gridTemplateControls.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridTemplateControls_DataError);
            // 
            // Category
            // 
            this.Category.HeaderText = "Categoria";
            this.Category.Items.AddRange(new object[] {
            "0. Análisis",
            "1. Diseño",
            "2. Documentación",
            "3. Desarrollo",
            "4. Test",
            "5. Ajustes",
            "6. Implementación",
            "7. Soporte pos-productivo",
            "99. Otros"});
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            // 
            // Type
            // 
            this.Type.HeaderText = "Tipo de control";
            this.Type.Items.AddRange(new object[] {
            "OptionBool",
            "Number",
            "Percent"});
            this.Type.Name = "Type";
            // 
            // Pond
            // 
            this.Pond.HeaderText = "Ponderado";
            this.Pond.Name = "Pond";
            // 
            // DefaultValue
            // 
            this.DefaultValue.HeaderText = "Valor por defecto";
            this.DefaultValue.Name = "DefaultValue";
            // 
            // Effort
            // 
            this.Effort.HeaderText = "Insume esfuerzo";
            this.Effort.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Effort.Name = "Effort";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.leftTopPanel);
            this.headerPanel.Controls.Add(this.loadTemplate);
            this.headerPanel.Controls.Add(this.messageLabel);
            this.headerPanel.Controls.Add(this.saveButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1299, 43);
            this.headerPanel.TabIndex = 1;
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.Controls.Add(this.aboutUs);
            this.leftTopPanel.Controls.Add(this.closeButton);
            this.leftTopPanel.Location = new System.Drawing.Point(850, 11);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(78, 44);
            this.leftTopPanel.TabIndex = 4;
            // 
            // aboutUs
            // 
            this.aboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutUs.Image = global::Estimador.Properties.Resources.info_32px;
            this.aboutUs.Location = new System.Drawing.Point(3, 1);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(34, 44);
            this.aboutUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutUs.TabIndex = 1;
            this.aboutUs.TabStop = false;
            this.aboutUs.Click += new System.EventHandler(this.aboutUs_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::Estimador.Properties.Resources.close_window_48px;
            this.closeButton.Location = new System.Drawing.Point(41, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 44);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loadTemplate
            // 
            this.loadTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadTemplate.Image = global::Estimador.Properties.Resources.opened_folder_26px;
            this.loadTemplate.Location = new System.Drawing.Point(9, 11);
            this.loadTemplate.Name = "loadTemplate";
            this.loadTemplate.Size = new System.Drawing.Size(30, 21);
            this.loadTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadTemplate.TabIndex = 3;
            this.loadTemplate.TabStop = false;
            this.loadTemplate.Click += new System.EventHandler(this.loadTemplate_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(81, 19);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(35, 13);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "label1";
            this.messageLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Image = global::Estimador.Properties.Resources.save_26px_w;
            this.saveButton.Location = new System.Drawing.Point(45, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(30, 21);
            this.saveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveButton.TabIndex = 1;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.AutoScroll = true;
            this.bodyPanel.Controls.Add(this.priceHourTextBox);
            this.bodyPanel.Controls.Add(this.priceHourLabel);
            this.bodyPanel.Controls.Add(this.baseHoursTextBox);
            this.bodyPanel.Controls.Add(this.baseLabel);
            this.bodyPanel.Controls.Add(this.ControlsLabel);
            this.bodyPanel.Controls.Add(this.gridTemplateControls);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 43);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1299, 469);
            this.bodyPanel.TabIndex = 2;
            // 
            // priceHourTextBox
            // 
            this.priceHourTextBox.Location = new System.Drawing.Point(91, 39);
            this.priceHourTextBox.Name = "priceHourTextBox";
            this.priceHourTextBox.Size = new System.Drawing.Size(62, 20);
            this.priceHourTextBox.TabIndex = 5;
            // 
            // priceHourLabel
            // 
            this.priceHourLabel.AutoSize = true;
            this.priceHourLabel.Location = new System.Drawing.Point(6, 42);
            this.priceHourLabel.Name = "priceHourLabel";
            this.priceHourLabel.Size = new System.Drawing.Size(79, 13);
            this.priceHourLabel.TabIndex = 4;
            this.priceHourLabel.Text = "Precio por hora";
            // 
            // baseHoursTextBox
            // 
            this.baseHoursTextBox.Location = new System.Drawing.Point(91, 9);
            this.baseHoursTextBox.Name = "baseHoursTextBox";
            this.baseHoursTextBox.Size = new System.Drawing.Size(32, 20);
            this.baseHoursTextBox.TabIndex = 3;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(19, 12);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(66, 13);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Base (horas)";
            // 
            // ControlsLabel
            // 
            this.ControlsLabel.AutoSize = true;
            this.ControlsLabel.Location = new System.Drawing.Point(33, 65);
            this.ControlsLabel.Name = "ControlsLabel";
            this.ControlsLabel.Size = new System.Drawing.Size(51, 13);
            this.ControlsLabel.TabIndex = 1;
            this.ControlsLabel.Text = "Controles";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 209;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 512);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Configuration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTemplateControls)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.leftTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTemplateControls;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.TextBox baseHoursTextBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label ControlsLabel;
        private System.Windows.Forms.PictureBox saveButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox priceHourTextBox;
        private System.Windows.Forms.Label priceHourLabel;
        private System.Windows.Forms.PictureBox loadTemplate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pond;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn Effort;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel leftTopPanel;
        private System.Windows.Forms.PictureBox aboutUs;
    }
}