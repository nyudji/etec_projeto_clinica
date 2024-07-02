namespace TCC
{
    partial class frm_paciente_historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_paciente_historico));
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.gpb_filtro = new System.Windows.Forms.GroupBox();
            this.op_cons_pacientes_nome = new System.Windows.Forms.RadioButton();
            this.op_cons_pacientes_cpf = new System.Windows.Forms.RadioButton();
            this.dgv_paciente = new System.Windows.Forms.DataGridView();
            this.dgv_historico = new System.Windows.Forms.DataGridView();
            this.btn_prontuario = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_cpf
            // 
            this.msk_cpf.Enabled = false;
            this.msk_cpf.Location = new System.Drawing.Point(178, 68);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 20);
            this.msk_cpf.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(178, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(158, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // gpb_filtro
            // 
            this.gpb_filtro.Controls.Add(this.op_cons_pacientes_nome);
            this.gpb_filtro.Controls.Add(this.op_cons_pacientes_cpf);
            this.gpb_filtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtro.Location = new System.Drawing.Point(28, 41);
            this.gpb_filtro.Name = "gpb_filtro";
            this.gpb_filtro.Size = new System.Drawing.Size(131, 47);
            this.gpb_filtro.TabIndex = 0;
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
            // dgv_paciente
            // 
            this.dgv_paciente.AllowUserToAddRows = false;
            this.dgv_paciente.AllowUserToDeleteRows = false;
            this.dgv_paciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_paciente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paciente.Location = new System.Drawing.Point(28, 136);
            this.dgv_paciente.Name = "dgv_paciente";
            this.dgv_paciente.ReadOnly = true;
            this.dgv_paciente.Size = new System.Drawing.Size(464, 414);
            this.dgv_paciente.TabIndex = 4;
            // 
            // dgv_historico
            // 
            this.dgv_historico.AllowUserToAddRows = false;
            this.dgv_historico.AllowUserToDeleteRows = false;
            this.dgv_historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_historico.BackgroundColor = System.Drawing.Color.White;
            this.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico.Location = new System.Drawing.Point(571, 136);
            this.dgv_historico.Name = "dgv_historico";
            this.dgv_historico.ReadOnly = true;
            this.dgv_historico.Size = new System.Drawing.Size(464, 414);
            this.dgv_historico.TabIndex = 6;
            // 
            // btn_prontuario
            // 
            this.btn_prontuario.BackColor = System.Drawing.Color.White;
            this.btn_prontuario.Enabled = false;
            this.btn_prontuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prontuario.Image = global::TCC.Properties.Resources.START;
            this.btn_prontuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_prontuario.Location = new System.Drawing.Point(939, 58);
            this.btn_prontuario.Name = "btn_prontuario";
            this.btn_prontuario.Size = new System.Drawing.Size(96, 64);
            this.btn_prontuario.TabIndex = 7;
            this.btn_prontuario.Text = "Prontuário";
            this.btn_prontuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_prontuario.UseVisualStyleBackColor = false;
            this.btn_prontuario.Click += new System.EventHandler(this.btn_prontuario_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.BackColor = System.Drawing.Color.White;
            this.btn_historico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historico.Image = global::TCC.Properties.Resources._7670_32x32;
            this.btn_historico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_historico.Location = new System.Drawing.Point(825, 58);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(96, 64);
            this.btn_historico.TabIndex = 5;
            this.btn_historico.Text = "Histórico";
            this.btn_historico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_historico.UseVisualStyleBackColor = false;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(284, 65);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_paciente_historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_prontuario);
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.dgv_historico);
            this.Controls.Add(this.dgv_paciente);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.gpb_filtro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_paciente_historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_paciente_historico";
            this.gpb_filtro.ResumeLayout(false);
            this.gpb_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox gpb_filtro;
        private System.Windows.Forms.RadioButton op_cons_pacientes_nome;
        private System.Windows.Forms.RadioButton op_cons_pacientes_cpf;
        private System.Windows.Forms.DataGridView dgv_paciente;
        private System.Windows.Forms.DataGridView dgv_historico;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button btn_prontuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}