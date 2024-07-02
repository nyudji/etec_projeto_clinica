namespace TCC
{
    partial class Splash
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
            this.pgb_splah = new System.Windows.Forms.ProgressBar();
            this.tm_splah = new System.Windows.Forms.Timer(this.components);
            this.pct_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_splah
            // 
            this.pgb_splah.ForeColor = System.Drawing.Color.Red;
            this.pgb_splah.Location = new System.Drawing.Point(12, 226);
            this.pgb_splah.Name = "pgb_splah";
            this.pgb_splah.Size = new System.Drawing.Size(427, 42);
            this.pgb_splah.TabIndex = 1;
            this.pgb_splah.Click += new System.EventHandler(this.pgb_splah_Click);
            // 
            // tm_splah
            // 
            this.tm_splah.Enabled = true;
            this.tm_splah.Tick += new System.EventHandler(this.tm_splah_Tick);
            // 
            // pct_image
            // 
            this.pct_image.Image = global::TCC.Properties.Resources.Question;
            this.pct_image.Location = new System.Drawing.Point(2, 3);
            this.pct_image.Name = "pct_image";
            this.pct_image.Size = new System.Drawing.Size(448, 216);
            this.pct_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_image.TabIndex = 0;
            this.pct_image.TabStop = false;
            this.pct_image.Click += new System.EventHandler(this.pct_image_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(451, 280);
            this.Controls.Add(this.pgb_splah);
            this.Controls.Add(this.pct_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pct_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_image;
        private System.Windows.Forms.ProgressBar pgb_splah;
        private System.Windows.Forms.Timer tm_splah;
    }
}