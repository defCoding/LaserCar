namespace Laser
{
    partial class frmLaser
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
            this.components = new System.ComponentModel.Container();
            this.srlPort = new System.IO.Ports.SerialPort(this.components);
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srlPort
            // 
            this.srlPort.PortName = "COM4";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoordinates.Location = new System.Drawing.Point(8, 8);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(60, 19);
            this.lblCoordinates.TabIndex = 0;
            this.lblCoordinates.Text = "X:   Y:   ";
            // 
            // frmLaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.lblCoordinates);
            this.Name = "frmLaser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laser Control";
            this.Load += new System.EventHandler(this.frmLaser_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLaser_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLaser_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort srlPort;
        private System.Windows.Forms.Label lblCoordinates;
    }
}

