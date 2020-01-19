namespace Estimador.CustomControls
{
    partial class PercentControl
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
            this.percentLabel = new System.Windows.Forms.Label();
            this.percentTrack = new System.Windows.Forms.TrackBar();
            this.estimatedWeightLabel = new System.Windows.Forms.Label();
            this.percentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.percentTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.percentLabel.Location = new System.Drawing.Point(11, 8);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(66, 13);
            this.percentLabel.TabIndex = 0;
            this.percentLabel.Text = "{description}";
            // 
            // percentTrack
            // 
            this.percentTrack.Location = new System.Drawing.Point(14, 33);
            this.percentTrack.Maximum = 500;
            this.percentTrack.Name = "percentTrack";
            this.percentTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.percentTrack.Size = new System.Drawing.Size(45, 150);
            this.percentTrack.TabIndex = 1;
            this.percentTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.percentTrack.ValueChanged += new System.EventHandler(this.percentTrack_ValueChanged);
            // 
            // estimatedWeightLabel
            // 
            this.estimatedWeightLabel.AutoSize = true;
            this.estimatedWeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estimatedWeightLabel.Location = new System.Drawing.Point(186, 8);
            this.estimatedWeightLabel.Name = "estimatedWeightLabel";
            this.estimatedWeightLabel.Size = new System.Drawing.Size(29, 13);
            this.estimatedWeightLabel.TabIndex = 4;
            this.estimatedWeightLabel.Text = "{ew}";
            // 
            // percentImage
            // 
            this.percentImage.Location = new System.Drawing.Point(65, 33);
            this.percentImage.Name = "percentImage";
            this.percentImage.Size = new System.Drawing.Size(150, 150);
            this.percentImage.TabIndex = 5;
            this.percentImage.TabStop = false;
            // 
            // PercentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.percentImage);
            this.Controls.Add(this.estimatedWeightLabel);
            this.Controls.Add(this.percentTrack);
            this.Controls.Add(this.percentLabel);
            this.Name = "PercentControl";
            this.Size = new System.Drawing.Size(231, 196);
            this.Load += new System.EventHandler(this.PercentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TrackBar percentTrack;
        private System.Windows.Forms.Label estimatedWeightLabel;
        private System.Windows.Forms.PictureBox percentImage;
    }
}
