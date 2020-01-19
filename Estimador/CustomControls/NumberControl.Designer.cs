namespace Estimador.CustomControls
{
    partial class NumberControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberLabel = new System.Windows.Forms.Label();
            this.estimatedWeightLabel = new System.Windows.Forms.Label();
            this.numberSelectedLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.PictureBox();
            this.subtractButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractButton)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.numberLabel.Location = new System.Drawing.Point(11, 8);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(66, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "{description}";
            // 
            // estimatedWeightLabel
            // 
            this.estimatedWeightLabel.AutoSize = true;
            this.estimatedWeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estimatedWeightLabel.Location = new System.Drawing.Point(172, 8);
            this.estimatedWeightLabel.Name = "estimatedWeightLabel";
            this.estimatedWeightLabel.Size = new System.Drawing.Size(29, 13);
            this.estimatedWeightLabel.TabIndex = 4;
            this.estimatedWeightLabel.Text = "{ew}";
            // 
            // numberSelectedLabel
            // 
            this.numberSelectedLabel.AutoSize = true;
            this.numberSelectedLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSelectedLabel.ForeColor = System.Drawing.Color.Gray;
            this.numberSelectedLabel.Location = new System.Drawing.Point(86, 49);
            this.numberSelectedLabel.Name = "numberSelectedLabel";
            this.numberSelectedLabel.Size = new System.Drawing.Size(45, 33);
            this.numberSelectedLabel.TabIndex = 5;
            this.numberSelectedLabel.Text = "99";
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::Estimador.Properties.Resources.add_24px;
            this.addButton.Location = new System.Drawing.Point(137, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 64);
            this.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractButton.Image = global::Estimador.Properties.Resources.minus_32px;
            this.subtractButton.Location = new System.Drawing.Point(13, 36);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(64, 64);
            this.subtractButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.subtractButton.TabIndex = 6;
            this.subtractButton.TabStop = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // NumberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.numberSelectedLabel);
            this.Controls.Add(this.estimatedWeightLabel);
            this.Controls.Add(this.numberLabel);
            this.Name = "NumberControl";
            this.Size = new System.Drawing.Size(214, 112);
            this.Load += new System.EventHandler(this.NumberControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label estimatedWeightLabel;
        private System.Windows.Forms.Label numberSelectedLabel;
        private System.Windows.Forms.PictureBox subtractButton;
        private System.Windows.Forms.PictureBox addButton;
    }
}
