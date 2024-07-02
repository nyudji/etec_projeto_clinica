namespace TCC
{
    partial class frm_cons_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cons_funcionarios));
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.gpb_filtro = new System.Windows.Forms.GroupBox();
            this.op_cons_funcionarios_cargo = new System.Windows.Forms.RadioButton();
            this.op_cons_funcionarios_nome = new System.Windows.Forms.RadioButton();
            this.op_cons_funcionarios_cpf = new System.Windows.Forms.RadioButton();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.gpb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            this.dgv_funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_funcionario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Location = new System.Drawing.Point(29, 133);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.Size = new System.Drawing.Size(1003, 414);
            this.dgv_funcionario.TabIndex = 6;
            this.dgv_funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionario_CellContentClick);
            // 
            // msk_cpf
            // 
            this.msk_cpf.Enabled = false;
            this.msk_cpf.Location = new System.Drawing.Point(220, 50);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 22);
            this.msk_cpf.TabIndex = 33;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(220, 23);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(165, 22);
            this.txt_nome.TabIndex = 0;
            // 
            // gpb_filtro
            // 
            this.gpb_filtro.Controls.Add(this.op_cons_funcionarios_cargo);
            this.gpb_filtro.Controls.Add(this.op_cons_funcionarios_nome);
            this.gpb_filtro.Controls.Add(this.op_cons_funcionarios_cpf);
            this.gpb_filtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtro.Location = new System.Drawing.Point(12, 23);
            this.gpb_filtro.Name = "gpb_filtro";
            this.gpb_filtro.Size = new System.Drawing.Size(186, 47);
            this.gpb_filtro.TabIndex = 5;
            this.gpb_filtro.TabStop = false;
            this.gpb_filtro.Text = "Consultar";
            // 
            // op_cons_funcionarios_cargo
            // 
            this.op_cons_funcionarios_cargo.AutoSize = true;
            this.op_cons_funcionarios_cargo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_funcionarios_cargo.Location = new System.Drawing.Point(115, 17);
            this.op_cons_funcionarios_cargo.Name = "op_cons_funcionarios_cargo";
            this.op_cons_funcionarios_cargo.Size = new System.Drawing.Size(56, 17);
            this.op_cons_funcionarios_cargo.TabIndex = 2;
            this.op_cons_funcionarios_cargo.TabStop = true;
            this.op_cons_funcionarios_cargo.Text = "Cargo";
            this.op_cons_funcionarios_cargo.UseVisualStyleBackColor = true;
            this.op_cons_funcionarios_cargo.CheckedChanged += new System.EventHandler(this.op_cons_funcionarios_cargo_CheckedChanged);
            // 
            // op_cons_funcionarios_nome
            // 
            this.op_cons_funcionarios_nome.AutoSize = true;
            this.op_cons_funcionarios_nome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_funcionarios_nome.Location = new System.Drawing.Point(6, 17);
            this.op_cons_funcionarios_nome.Name = "op_cons_funcionarios_nome";
            this.op_cons_funcionarios_nome.Size = new System.Drawing.Size(55, 17);
            this.op_cons_funcionarios_nome.TabIndex = 0;
            this.op_cons_funcionarios_nome.TabStop = true;
            this.op_cons_funcionarios_nome.Text = "Nome";
            this.op_cons_funcionarios_nome.UseVisualStyleBackColor = true;
            this.op_cons_funcionarios_nome.CheckedChanged += new System.EventHandler(this.op_cons_pacientes_nome_CheckedChanged);
            // 
            // op_cons_funcionarios_cpf
            // 
            this.op_cons_funcionarios_cpf.AutoSize = true;
            this.op_cons_funcionarios_cpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_cons_funcionarios_cpf.Location = new System.Drawing.Point(65, 17);
            this.op_cons_funcionarios_cpf.Name = "op_cons_funcionarios_cpf";
            this.op_cons_funcionarios_cpf.Size = new System.Drawing.Size(44, 17);
            this.op_cons_funcionarios_cpf.TabIndex = 1;
            this.op_cons_funcionarios_cpf.TabStop = true;
            this.op_cons_funcionarios_cpf.Text = "CPF";
            this.op_cons_funcionarios_cpf.UseVisualStyleBackColor = true;
            this.op_cons_funcionarios_cpf.CheckedChanged += new System.EventHandler(this.op_cons_pacientes_cpf_CheckedChanged);
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Items.AddRange(new object[] {
            "Secretária",
            "Psicologo"});
            this.cmb_cargo.Location = new System.Drawing.Point(220, 51);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(100, 21);
            this.cmb_cargo.TabIndex = 1;
            this.cmb_cargo.Visible = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(834, 48);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 64);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(333, 48);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.White;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVoltar.Location = new System.Drawing.Point(936, 48);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(96, 64);
            this.BtnVoltar.TabIndex = 4;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1027, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_cons_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_cargo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.gpb_filtro);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cons_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Funcionários";
            this.Load += new System.EventHandler(this.frm_cons_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.gpb_filtro.ResumeLayout(false);
            this.gpb_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox gpb_filtro;
        private System.Windows.Forms.RadioButton op_cons_funcionarios_nome;
        private System.Windows.Forms.RadioButton op_cons_funcionarios_cpf;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.RadioButton op_cons_funcionarios_cargo;
        private System.Windows.Forms.ComboBox cmb_cargo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}