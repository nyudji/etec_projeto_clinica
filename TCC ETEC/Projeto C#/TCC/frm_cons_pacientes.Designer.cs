namespace TCC
{
    partial class frm_cons_pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cons_pacientes));
            this.gpb_filtro = new System.Windows.Forms.GroupBox();
            this.op_cons_pacientes_nome = new System.Windows.Forms.RadioButton();
            this.op_cons_pacientes_cpf = new System.Windows.Forms.RadioButton();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.dgv_paciente = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_filtro
            // 
            this.gpb_filtro.Controls.Add(this.op_cons_pacientes_nome);
            this.gpb_filtro.Controls.Add(this.op_cons_pacientes_cpf);
            this.gpb_filtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtro.Location = new System.Drawing.Point(12, 21);
            this.gpb_filtro.Name = "gpb_filtro";
            this.gpb_filtro.Size = new System.Drawing.Size(131, 47);
            this.gpb_filtro.TabIndex = 5;
            this.gpb_filtro.TabStop = false;
            this.gpb_filtro.Text = "Consultar";
            // 
            // op_cons_pacientes_nome
            // 
            this.op_cons_pacientes_nome.AutoSize = true;
            this.op_cons_pacientes_nome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_pacientes_nome.Location = new System.Drawing.Point(6, 17);
            this.op_cons_pacientes_nome.Name = "op_cons_pacientes_nome";
            this.op_cons_pacientes_nome.Size = new System.Drawing.Size(55, 17);
            this.op_cons_pacientes_nome.TabIndex = 0;
            this.op_cons_pacientes_nome.TabStop = true;
            this.op_cons_pacientes_nome.Text = "Nome";
            this.op_cons_pacientes_nome.UseVisualStyleBackColor = true;
            this.op_cons_pacientes_nome.CheckedChanged += new System.EventHandler(this.op_cons_pacientes_nome_CheckedChanged);
            // 
            // op_cons_pacientes_cpf
            // 
            this.op_cons_pacientes_cpf.AutoSize = true;
            this.op_cons_pacientes_cpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_pacientes_cpf.Location = new System.Drawing.Point(65, 17);
            this.op_cons_pacientes_cpf.Name = "op_cons_pacientes_cpf";
            this.op_cons_pacientes_cpf.Size = new System.Drawing.Size(44, 17);
            this.op_cons_pacientes_cpf.TabIndex = 1;
            this.op_cons_pacientes_cpf.TabStop = true;
            this.op_cons_pacientes_cpf.Text = "CPF";
            this.op_cons_pacientes_cpf.UseVisualStyleBackColor = true;
            this.op_cons_pacientes_cpf.CheckedChanged += new System.EventHandler(this.op_cons_pacientes_cpf_CheckedChanged);
            // 
            // msk_cpf
            // 
            this.msk_cpf.Enabled = false;
            this.msk_cpf.Location = new System.Drawing.Point(162, 48);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 20);
            this.msk_cpf.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(162, 21);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(158, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // dgv_paciente
            // 
            this.dgv_paciente.AllowUserToAddRows = false;
            this.dgv_paciente.AllowUserToDeleteRows = false;
            this.dgv_paciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_paciente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paciente.Location = new System.Drawing.Point(30, 132);
            this.dgv_paciente.Name = "dgv_paciente";
            this.dgv_paciente.ReadOnly = true;
            this.dgv_paciente.Size = new System.Drawing.Size(1007, 414);
            this.dgv_paciente.TabIndex = 6;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(268, 45);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(940, 48);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(96, 64);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(828, 48);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 64);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_cons_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dgv_paciente);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.gpb_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cons_pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pacientes";
            this.Load += new System.EventHandler(this.frm_cons_pacientes_Load);
            this.gpb_filtro.ResumeLayout(false);
            this.gpb_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_filtro;
        private System.Windows.Forms.RadioButton op_cons_pacientes_nome;
        private System.Windows.Forms.RadioButton op_cons_pacientes_cpf;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DataGridView dgv_paciente;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}