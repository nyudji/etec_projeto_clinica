namespace TCC
{
    partial class frm_historico_apontamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_historico_apontamentos));
            this.lbl_nome_pac = new System.Windows.Forms.Label();
            this.lbl_pac = new System.Windows.Forms.Label();
            this.lbl_nome_psic = new System.Windows.Forms.Label();
            this.lbl_psic = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.txt_apontamentos = new System.Windows.Forms.TextBox();
            this.lbl_apontamentos = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome_pac
            // 
            this.lbl_nome_pac.AutoSize = true;
            this.lbl_nome_pac.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_pac.Location = new System.Drawing.Point(96, 44);
            this.lbl_nome_pac.Name = "lbl_nome_pac";
            this.lbl_nome_pac.Size = new System.Drawing.Size(104, 13);
            this.lbl_nome_pac.TabIndex = 3;
            this.lbl_nome_pac.Text = "nome_do_paciente";
            // 
            // lbl_pac
            // 
            this.lbl_pac.AutoSize = true;
            this.lbl_pac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pac.Location = new System.Drawing.Point(32, 44);
            this.lbl_pac.Name = "lbl_pac";
            this.lbl_pac.Size = new System.Drawing.Size(57, 14);
            this.lbl_pac.TabIndex = 2;
            this.lbl_pac.Text = "Paciente:";
            // 
            // lbl_nome_psic
            // 
            this.lbl_nome_psic.AutoSize = true;
            this.lbl_nome_psic.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_psic.Location = new System.Drawing.Point(103, 82);
            this.lbl_nome_psic.Name = "lbl_nome_psic";
            this.lbl_nome_psic.Size = new System.Drawing.Size(111, 13);
            this.lbl_nome_psic.TabIndex = 5;
            this.lbl_nome_psic.Text = "nome_do_psicólogo";
            // 
            // lbl_psic
            // 
            this.lbl_psic.AutoSize = true;
            this.lbl_psic.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psic.Location = new System.Drawing.Point(32, 82);
            this.lbl_psic.Name = "lbl_psic";
            this.lbl_psic.Size = new System.Drawing.Size(64, 14);
            this.lbl_psic.TabIndex = 4;
            this.lbl_psic.Text = "Psicólogo:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(387, 82);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(34, 13);
            this.lbl_hora.TabIndex = 7;
            this.lbl_hora.Text = "00:00";
            // 
            // lbl_hr
            // 
            this.lbl_hr.AutoSize = true;
            this.lbl_hr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hr.Location = new System.Drawing.Point(339, 82);
            this.lbl_hr.Name = "lbl_hr";
            this.lbl_hr.Size = new System.Drawing.Size(35, 14);
            this.lbl_hr.TabIndex = 6;
            this.lbl_hr.Text = "Hora:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(387, 44);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(55, 13);
            this.lbl_data.TabIndex = 9;
            this.lbl_data.Text = "__/__/____";
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dt.Location = new System.Drawing.Point(339, 44);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(33, 14);
            this.lbl_dt.TabIndex = 8;
            this.lbl_dt.Text = "Data:";
            // 
            // txt_apontamentos
            // 
            this.txt_apontamentos.Location = new System.Drawing.Point(35, 203);
            this.txt_apontamentos.Multiline = true;
            this.txt_apontamentos.Name = "txt_apontamentos";
            this.txt_apontamentos.Size = new System.Drawing.Size(993, 357);
            this.txt_apontamentos.TabIndex = 0;
            // 
            // lbl_apontamentos
            // 
            this.lbl_apontamentos.AutoSize = true;
            this.lbl_apontamentos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apontamentos.Location = new System.Drawing.Point(32, 170);
            this.lbl_apontamentos.Name = "lbl_apontamentos";
            this.lbl_apontamentos.Size = new System.Drawing.Size(92, 14);
            this.lbl_apontamentos.TabIndex = 83;
            this.lbl_apontamentos.Text = "Apontamentos:";
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = global::TCC.Properties.Resources.ico_alterar;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(830, 119);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 64);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(932, 119);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(96, 64);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salvar.Location = new System.Drawing.Point(830, 119);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(96, 64);
            this.btn_salvar.TabIndex = 85;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.White;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_imprimir.Location = new System.Drawing.Point(728, 119);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(96, 64);
            this.btn_imprimir.TabIndex = 1;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // frm_historico_apontamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.lbl_apontamentos);
            this.Controls.Add(this.txt_apontamentos);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_hr);
            this.Controls.Add(this.lbl_nome_psic);
            this.Controls.Add(this.lbl_psic);
            this.Controls.Add(this.lbl_nome_pac);
            this.Controls.Add(this.lbl_pac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_historico_apontamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_historico_apontamentos";
            this.Load += new System.EventHandler(this.frm_historico_apontamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_pac;
        private System.Windows.Forms.Label lbl_pac;
        private System.Windows.Forms.Label lbl_nome_psic;
        private System.Windows.Forms.Label lbl_psic;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_hr;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.TextBox txt_apontamentos;
        private System.Windows.Forms.Label lbl_apontamentos;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_alterar;
    }
}