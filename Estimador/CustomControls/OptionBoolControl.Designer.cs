namespace Estimador.CustomControls
{
    partial class OptionBoolControl
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
            this.optionLabel = new System.Windows.Forms.Label();
            this.estimatedWeightLabel = new System.Windows.Forms.Label();
            this.checkFalse = new System.Windows.Forms.PictureBox();
            this.checkTrue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.optionLabel.Location = new System.Drawing.Point(11, 8);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(66, 13);
            this.optionLabel.TabIndex = 1;
            this.optionLabel.Text = "{description}";
            // 
            // estimatedWeightLabel
            // 
            this.estimatedWeightLabel.AutoSize = true;
            this.estimatedWeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estimatedWeightLabel.Location = new System.Drawing.Point(175, 8);
            this.estimatedWeightLabel.Name = "estimatedWeightLabel";
            this.estimatedWeightLabel.Size = new System.Drawing.Size(29, 13);
            this.estimatedWeightLabel.TabIndex = 3;
            this.estimatedWeightLabel.Text = "{ew}";
            // 
            // checkFalse
            // 
            this.checkFalse.Image = global::Estimador.Properties.Resources.delete_sign_48px;
            this.checkFalse.Location = new System.Drawing.Point(114, 37);
            this.checkFalse.Name = "checkFalse";
            this.checkFalse.Size = new System.Drawing.Size(64, 64);
            this.checkFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.checkFalse.TabIndex = 5;
            this.checkFalse.TabStop = false;
            this.checkFalse.Click += new System.EventHandler(this.checkFalse_Click);
            this.checkFalse.MouseEnter += new System.EventHandler(this.checkFalse_MouseEnter);
            this.checkFalse.MouseLeave += new System.EventHandler(this.checkFalse_MouseLeave);
            // 
            // checkTrue
            // 
            this.checkTrue.Image = global::Estimador.Properties.Resources.checkmark_48px;
            this.checkTrue.Location = new System.Drawing.Point(35, 37);
            this.checkTrue.Name = "checkTrue";
            this.checkTrue.Size = new System.Drawing.Size(64, 64);
            this.checkTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.checkTrue.TabIndex = 4;
            this.checkTrue.TabStop = false;
            this.checkTrue.Click += new System.EventHandler(this.checkTrue_Click);
            this.checkTrue.MouseEnter += new System.EventHandler(this.checkTrue_MouseEnter);
            this.checkTrue.MouseLeave += new System.EventHandler(this.checkTrue_MouseLeave);
            // 
            // OptionBoolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkFalse);
            this.Controls.Add(this.checkTrue);
            this.Controls.Add(this.estimatedWeightLabel);
            this.Controls.Add(this.optionLabel);
            this.Name = "OptionBoolControl";
            this.Size = new System.Drawing.Size(220, 117);
            this.Load += new System.EventHandler(this.OptionBoolControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label estimatedWeightLabel;
        private System.Windows.Forms.PictureBox checkTrue;
        private System.Windows.Forms.PictureBox checkFalse;
    }
}
