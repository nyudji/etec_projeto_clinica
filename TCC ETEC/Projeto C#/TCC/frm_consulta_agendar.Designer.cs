namespace TCC
{
    partial class frm_consulta_agendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta_agendar));
            this.dgv_psicologo = new System.Windows.Forms.DataGridView();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.gpb_paciente = new System.Windows.Forms.GroupBox();
            this.op_cons_pacientes_nome = new System.Windows.Forms.RadioButton();
            this.op_cons_pacientes_cpf = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gpb_horario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar_psicologo = new System.Windows.Forms.Button();
            this.msk_cpf_psicologo = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome_psicologo = new System.Windows.Forms.TextBox();
            this.gpb_psicologo = new System.Windows.Forms.GroupBox();
            this.op_cons_psicologo_nome = new System.Windows.Forms.RadioButton();
            this.op_cons_psicologo_cpf = new System.Windows.Forms.RadioButton();
            this.dgv_paciente = new System.Windows.Forms.DataGridView();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.btn_pesquisar_paciente = new System.Windows.Forms.Button();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_psicologo)).BeginInit();
            this.gpb_paciente.SuspendLayout();
            this.gpb_horario.SuspendLayout();
            this.gpb_psicologo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_psicologo
            // 
            this.dgv_psicologo.AllowUserToAddRows = false;
            this.dgv_psicologo.AllowUserToDeleteRows = false;
            this.dgv_psicologo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_psicologo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_psicologo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_psicologo.Location = new System.Drawing.Point(20, 322);
            this.dgv_psicologo.Name = "dgv_psicologo";
            this.dgv_psicologo.ReadOnly = true;
            this.dgv_psicologo.Size = new System.Drawing.Size(481, 207);
            this.dgv_psicologo.TabIndex = 36;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Enabled = false;
            this.msk_cpf.Location = new System.Drawing.Point(166, 53);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 22);
            this.msk_cpf.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(166, 26);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(175, 22);
            this.txt_nome.TabIndex = 1;
            // 
            // gpb_paciente
            // 
            this.gpb_paciente.Controls.Add(this.op_cons_pacientes_nome);
            this.gpb_paciente.Controls.Add(this.op_cons_pacientes_cpf);
            this.gpb_paciente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_paciente.Location = new System.Drawing.Point(16, 26);
            this.gpb_paciente.Name = "gpb_paciente";
            this.gpb_paciente.Size = new System.Drawing.Size(131, 47);
            this.gpb_paciente.TabIndex = 0;
            this.gpb_paciente.TabStop = false;
            this.gpb_paciente.Text = "Paciente";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 73;
            // 
            // gpb_horario
            // 
            this.gpb_horario.Controls.Add(this.label2);
            this.gpb_horario.Controls.Add(this.txt_preco);
            this.gpb_horario.Controls.Add(this.label3);
            this.gpb_horario.Controls.Add(this.dtp_data);
            this.gpb_horario.Controls.Add(this.lbl_horario);
            this.gpb_horario.Controls.Add(this.cmb_horario);
            this.gpb_horario.Controls.Add(this.btn_pesquisar_psicologo);
            this.gpb_horario.Controls.Add(this.msk_cpf_psicologo);
            this.gpb_horario.Controls.Add(this.txt_nome_psicologo);
            this.gpb_horario.Controls.Add(this.gpb_psicologo);
            this.gpb_horario.Controls.Add(this.dgv_psicologo);
            this.gpb_horario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_horario.Location = new System.Drawing.Point(527, 26);
            this.gpb_horario.Name = "gpb_horario";
            this.gpb_horario.Size = new System.Drawing.Size(520, 542);
            this.gpb_horario.TabIndex = 5;
            this.gpb_horario.TabStop = false;
            this.gpb_horario.Text = "Horário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Preço:";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(100, 152);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(97, 22);
            this.txt_preco.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Data:";
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(100, 46);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(97, 22);
            this.dtp_data.TabIndex = 0;
            this.dtp_data.ValueChanged += new System.EventHandler(this.dtp_data_ValueChanged);
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(35, 102);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(49, 13);
            this.lbl_horario.TabIndex = 84;
            this.lbl_horario.Text = "Horário:";
            // 
            // cmb_horario
            // 
            this.cmb_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.cmb_horario.Location = new System.Drawing.Point(100, 99);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(97, 21);
            this.cmb_horario.TabIndex = 1;
            this.cmb_horario.SelectedIndexChanged += new System.EventHandler(this.cmb_horario_SelectedIndexChanged);
            // 
            // btn_pesquisar_psicologo
            // 
            this.btn_pesquisar_psicologo.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar_psicologo.Enabled = false;
            this.btn_pesquisar_psicologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_psicologo.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar_psicologo.Image")));
            this.btn_pesquisar_psicologo.Location = new System.Drawing.Point(311, 261);
            this.btn_pesquisar_psicologo.Name = "btn_pesquisar_psicologo";
            this.btn_pesquisar_psicologo.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar_psicologo.TabIndex = 5;
            this.btn_pesquisar_psicologo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar_psicologo.UseVisualStyleBackColor = false;
            this.btn_pesquisar_psicologo.Click += new System.EventHandler(this.btn_pesquisar_psicologo_Click);
            // 
            // msk_cpf_psicologo
            // 
            this.msk_cpf_psicologo.Enabled = false;
            this.msk_cpf_psicologo.Location = new System.Drawing.Point(188, 262);
            this.msk_cpf_psicologo.Mask = "000,000,000-00";
            this.msk_cpf_psicologo.Name = "msk_cpf_psicologo";
            this.msk_cpf_psicologo.Size = new System.Drawing.Size(100, 22);
            this.msk_cpf_psicologo.TabIndex = 4;
            // 
            // txt_nome_psicologo
            // 
            this.txt_nome_psicologo.Enabled = false;
            this.txt_nome_psicologo.Location = new System.Drawing.Point(188, 235);
            this.txt_nome_psicologo.Name = "txt_nome_psicologo";
            this.txt_nome_psicologo.Size = new System.Drawing.Size(175, 22);
            this.txt_nome_psicologo.TabIndex = 3;
            // 
            // gpb_psicologo
            // 
            this.gpb_psicologo.Controls.Add(this.op_cons_psicologo_nome);
            this.gpb_psicologo.Controls.Add(this.op_cons_psicologo_cpf);
            this.gpb_psicologo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_psicologo.Location = new System.Drawing.Point(38, 225);
            this.gpb_psicologo.Name = "gpb_psicologo";
            this.gpb_psicologo.Size = new System.Drawing.Size(131, 57);
            this.gpb_psicologo.TabIndex = 77;
            this.gpb_psicologo.TabStop = false;
            this.gpb_psicologo.Text = "Psicólogo";
            // 
            // op_cons_psicologo_nome
            // 
            this.op_cons_psicologo_nome.AutoSize = true;
            this.op_cons_psicologo_nome.Enabled = false;
            this.op_cons_psicologo_nome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_psicologo_nome.Location = new System.Drawing.Point(6, 17);
            this.op_cons_psicologo_nome.Name = "op_cons_psicologo_nome";
            this.op_cons_psicologo_nome.Size = new System.Drawing.Size(55, 17);
            this.op_cons_psicologo_nome.TabIndex = 1;
            this.op_cons_psicologo_nome.TabStop = true;
            this.op_cons_psicologo_nome.Text = "Nome";
            this.op_cons_psicologo_nome.UseVisualStyleBackColor = true;
            this.op_cons_psicologo_nome.CheckedChanged += new System.EventHandler(this.op_cons_psicologo_nome_CheckedChanged);
            // 
            // op_cons_psicologo_cpf
            // 
            this.op_cons_psicologo_cpf.AutoSize = true;
            this.op_cons_psicologo_cpf.Enabled = false;
            this.op_cons_psicologo_cpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_psicologo_cpf.Location = new System.Drawing.Point(81, 17);
            this.op_cons_psicologo_cpf.Name = "op_cons_psicologo_cpf";
            this.op_cons_psicologo_cpf.Size = new System.Drawing.Size(44, 17);
            this.op_cons_psicologo_cpf.TabIndex = 2;
            this.op_cons_psicologo_cpf.TabStop = true;
            this.op_cons_psicologo_cpf.Text = "CPF";
            this.op_cons_psicologo_cpf.UseVisualStyleBackColor = true;
            this.op_cons_psicologo_cpf.CheckedChanged += new System.EventHandler(this.op_cons_psicologo_cpf_CheckedChanged);
            // 
            // dgv_paciente
            // 
            this.dgv_paciente.AllowUserToAddRows = false;
            this.dgv_paciente.AllowUserToDeleteRows = false;
            this.dgv_paciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_paciente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paciente.Location = new System.Drawing.Point(16, 106);
            this.dgv_paciente.Name = "dgv_paciente";
            this.dgv_paciente.ReadOnly = true;
            this.dgv_paciente.Size = new System.Drawing.Size(481, 193);
            this.dgv_paciente.TabIndex = 77;
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacao.Location = new System.Drawing.Point(13, 314);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(70, 13);
            this.lbl_observacao.TabIndex = 80;
            this.lbl_observacao.Text = "Observação:";
            // 
            // txt_observacao
            // 
            this.txt_observacao.Location = new System.Drawing.Point(16, 330);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(481, 138);
            this.txt_observacao.TabIndex = 4;
            // 
            // btn_pesquisar_paciente
            // 
            this.btn_pesquisar_paciente.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar_paciente.Image")));
            this.btn_pesquisar_paciente.Location = new System.Drawing.Point(289, 53);
            this.btn_pesquisar_paciente.Name = "btn_pesquisar_paciente";
            this.btn_pesquisar_paciente.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar_paciente.TabIndex = 3;
            this.btn_pesquisar_paciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar_paciente.UseVisualStyleBackColor = false;
            this.btn_pesquisar_paciente.Click += new System.EventHandler(this.btn_pesquisar_paciente_Click);
            // 
            // btn_agendar
            // 
            this.btn_agendar.BackColor = System.Drawing.Color.White;
            this.btn_agendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agendar.Image")));
            this.btn_agendar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_agendar.Location = new System.Drawing.Point(22, 498);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(96, 64);
            this.btn_agendar.TabIndex = 82;
            this.btn_agendar.Text = "Agendar";
            this.btn_agendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agendar.UseVisualStyleBackColor = false;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(301, 498);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(96, 64);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.White;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_limpar.Location = new System.Drawing.Point(160, 498);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(96, 64);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = global::TCC.Properties.Resources.ico_alterar;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(22, 498);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 65);
            this.btn_alterar.TabIndex = 6;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // frm_consulta_agendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pesquisar_paciente);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.dgv_paciente);
            this.Controls.Add(this.lbl_observacao);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.gpb_horario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.gpb_paciente);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_consulta_agendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agendar_consulta";
            this.Load += new System.EventHandler(this.frm_consulta_agendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_psicologo)).EndInit();
            this.gpb_paciente.ResumeLayout(false);
            this.gpb_paciente.PerformLayout();
            this.gpb_horario.ResumeLayout(false);
            this.gpb_horario.PerformLayout();
            this.gpb_psicologo.ResumeLayout(false);
            this.gpb_psicologo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_psicologo;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox gpb_paciente;
        private System.Windows.Forms.RadioButton op_cons_pacientes_nome;
        private System.Windows.Forms.RadioButton op_cons_pacientes_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpb_horario;
        private System.Windows.Forms.MaskedTextBox msk_cpf_psicologo;
        private System.Windows.Forms.DataGridView dgv_paciente;
        private System.Windows.Forms.TextBox txt_nome_psicologo;
        private System.Windows.Forms.GroupBox gpb_psicologo;
        private System.Windows.Forms.RadioButton op_cons_psicologo_nome;
        private System.Windows.Forms.RadioButton op_cons_psicologo_cpf;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_observacao;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Button btn_pesquisar_psicologo;
        private System.Windows.Forms.Button btn_pesquisar_paciente;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_alterar;
        public System.Windows.Forms.Button btn_voltar;
    }
}