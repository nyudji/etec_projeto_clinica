namespace TCC
{
    partial class frm_cad_funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_funcionarios));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_filtro = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_confsenha = new System.Windows.Forms.TextBox();
            this.LblConfSenha = new System.Windows.Forms.Label();
            this.txt_crp = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_crp = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.cmb_cargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_entrada = new System.Windows.Forms.MaskedTextBox();
            this.txt_saida = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msk_dt_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.ComboBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_obervacao = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_filtro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(356, 22);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // txt_dt_nascimento
            // 
            this.txt_dt_nascimento.Location = new System.Drawing.Point(155, 211);
            this.txt_dt_nascimento.Mask = "00/00/0000";
            this.txt_dt_nascimento.Name = "txt_dt_nascimento";
            this.txt_dt_nascimento.Size = new System.Drawing.Size(77, 22);
            this.txt_dt_nascimento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data de Nascimento:";
            // 
            // gpb_filtro
            // 
            this.gpb_filtro.Controls.Add(this.txt_email);
            this.gpb_filtro.Controls.Add(this.txt_telefone);
            this.gpb_filtro.Controls.Add(this.txt_celular);
            this.gpb_filtro.Controls.Add(this.label9);
            this.gpb_filtro.Controls.Add(this.label8);
            this.gpb_filtro.Controls.Add(this.label7);
            this.gpb_filtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtro.Location = new System.Drawing.Point(20, 279);
            this.gpb_filtro.Name = "gpb_filtro";
            this.gpb_filtro.Size = new System.Drawing.Size(347, 146);
            this.gpb_filtro.TabIndex = 1;
            this.gpb_filtro.TabStop = false;
            this.gpb_filtro.Text = "Contato";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(50, 96);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 22);
            this.txt_email.TabIndex = 2;
            this.txt_email.Validated += new System.EventHandler(this.txt_email_Validated);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(69, 23);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 22);
            this.txt_telefone.TabIndex = 0;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(69, 63);
            this.txt_celular.Mask = "(00) 00000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(100, 22);
            this.txt_celular.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_confsenha);
            this.groupBox2.Controls.Add(this.LblConfSenha);
            this.groupBox2.Controls.Add(this.txt_crp);
            this.groupBox2.Controls.Add(this.txt_senha);
            this.groupBox2.Controls.Add(this.lbl_crp);
            this.groupBox2.Controls.Add(this.LblSenha);
            this.groupBox2.Controls.Add(this.txt_usuario);
            this.groupBox2.Controls.Add(this.LblUsuario);
            this.groupBox2.Controls.Add(this.lbl_cargo);
            this.groupBox2.Controls.Add(this.cmb_cargo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(596, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 196);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_confsenha
            // 
            this.txt_confsenha.Location = new System.Drawing.Point(114, 106);
            this.txt_confsenha.Name = "txt_confsenha";
            this.txt_confsenha.PasswordChar = '*';
            this.txt_confsenha.Size = new System.Drawing.Size(247, 22);
            this.txt_confsenha.TabIndex = 2;
            // 
            // LblConfSenha
            // 
            this.LblConfSenha.AutoSize = true;
            this.LblConfSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfSenha.Location = new System.Drawing.Point(6, 109);
            this.LblConfSenha.Name = "LblConfSenha";
            this.LblConfSenha.Size = new System.Drawing.Size(102, 13);
            this.LblConfSenha.TabIndex = 55;
            this.LblConfSenha.Text = "Confirmar Senha : ";
            // 
            // txt_crp
            // 
            this.txt_crp.Location = new System.Drawing.Point(164, 151);
            this.txt_crp.Name = "txt_crp";
            this.txt_crp.Size = new System.Drawing.Size(197, 22);
            this.txt_crp.TabIndex = 4;
            this.txt_crp.Visible = false;
            this.txt_crp.TextChanged += new System.EventHandler(this.txt_crp_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(114, 60);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(247, 22);
            this.txt_senha.TabIndex = 1;
            // 
            // lbl_crp
            // 
            this.lbl_crp.AutoSize = true;
            this.lbl_crp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crp.Location = new System.Drawing.Point(128, 158);
            this.lbl_crp.Name = "lbl_crp";
            this.lbl_crp.Size = new System.Drawing.Size(30, 13);
            this.lbl_crp.TabIndex = 81;
            this.lbl_crp.Text = "CRP:";
            this.lbl_crp.Visible = false;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(63, 69);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(42, 13);
            this.LblSenha.TabIndex = 53;
            this.LblSenha.Text = "Senha:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(114, 21);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(247, 22);
            this.txt_usuario.TabIndex = 0;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(55, 30);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 13);
            this.LblUsuario.TabIndex = 53;
            this.LblUsuario.Text = "Usuário:";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(2, 154);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(41, 13);
            this.lbl_cargo.TabIndex = 54;
            this.lbl_cargo.Text = "Cargo:";
            this.lbl_cargo.Click += new System.EventHandler(this.salario_Click);
            // 
            // cmb_cargo
            // 
            this.cmb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cargo.FormattingEnabled = true;
            this.cmb_cargo.Items.AddRange(new object[] {
            "Secretária",
            "Psicologo"});
            this.cmb_cargo.Location = new System.Drawing.Point(46, 154);
            this.cmb_cargo.Name = "cmb_cargo";
            this.cmb_cargo.Size = new System.Drawing.Size(76, 21);
            this.cmb_cargo.TabIndex = 3;
            this.cmb_cargo.SelectedIndexChanged += new System.EventHandler(this.cmb_cargo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Saída:";
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(58, 19);
            this.txt_entrada.Mask = "00:00";
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(77, 22);
            this.txt_entrada.TabIndex = 0;
            // 
            // txt_saida
            // 
            this.txt_saida.Location = new System.Drawing.Point(58, 60);
            this.txt_saida.Mask = "00:00";
            this.txt_saida.Name = "txt_saida";
            this.txt_saida.Size = new System.Drawing.Size(77, 22);
            this.txt_saida.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_saida);
            this.groupBox1.Controls.Add(this.txt_entrada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horário";
            // 
            // msk_dt_cadastro
            // 
            this.msk_dt_cadastro.Enabled = false;
            this.msk_dt_cadastro.Location = new System.Drawing.Point(382, 169);
            this.msk_dt_cadastro.Mask = "00/00/0000";
            this.msk_dt_cadastro.Name = "msk_dt_cadastro";
            this.msk_dt_cadastro.Size = new System.Drawing.Size(85, 22);
            this.msk_dt_cadastro.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Data de Cadastro:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "RG:";
            // 
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(79, 95);
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(97, 22);
            this.msk_rg.TabIndex = 3;
            this.msk_rg.Validated += new System.EventHandler(this.msk_rg_Validated);
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(79, 127);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(97, 22);
            this.msk_cpf.TabIndex = 4;
            this.msk_cpf.Validated += new System.EventHandler(this.msk_cpf_Validated);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "CPF:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cep);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_complemento);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_rua);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_uf);
            this.groupBox3.Controls.Add(this.txt_cidade);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(596, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(56, 31);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(77, 22);
            this.txt_cep.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 68;
            this.label21.Text = "Complemento:";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(87, 130);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(282, 22);
            this.txt_complemento.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Rua:";
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(56, 98);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(313, 22);
            this.txt_rua.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cidade:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(257, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "UF:";
            // 
            // txt_uf
            // 
            this.txt_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_uf.FormattingEnabled = true;
            this.txt_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txt_uf.Location = new System.Drawing.Point(287, 32);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(46, 21);
            this.txt_uf.TabIndex = 1;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(55, 66);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(313, 22);
            this.txt_cidade.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 66;
            this.label19.Text = "CEP:";
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(79, 167);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(169, 22);
            this.txt_salario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Salário:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_sexo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_nome);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.msk_dt_cadastro);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.msk_rg);
            this.groupBox4.Controls.Add(this.txt_salario);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.msk_cpf);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_dt_nascimento);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(549, 259);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 118;
            this.label11.Text = "Sexo:";
            // 
            // txt_sexo
            // 
            this.txt_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sexo.FormattingEnabled = true;
            this.txt_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.txt_sexo.Location = new System.Drawing.Point(79, 61);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(97, 21);
            this.txt_sexo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Observação:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_obervacao
            // 
            this.txt_obervacao.Location = new System.Drawing.Point(123, 455);
            this.txt_obervacao.Multiline = true;
            this.txt_obervacao.Name = "txt_obervacao";
            this.txt_obervacao.Size = new System.Drawing.Size(332, 108);
            this.txt_obervacao.TabIndex = 3;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = global::TCC.Properties.Resources.ico_alterar;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(725, 513);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 65);
            this.btn_alterar.TabIndex = 5;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.White;
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_excluir.Location = new System.Drawing.Point(827, 513);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(96, 64);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(929, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 64);
            this.button3.TabIndex = 7;
            this.button3.Text = "Voltar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.White;
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_limpar.Location = new System.Drawing.Point(827, 513);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(96, 64);
            this.btn_limpar.TabIndex = 48;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.BackColor = System.Drawing.Color.White;
            this.btn_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_incluir.Location = new System.Drawing.Point(725, 513);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(96, 64);
            this.btn_incluir.TabIndex = 47;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.XXXXXX;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_cad_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_obervacao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.gpb_filtro);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cad_funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionários";
            this.Load += new System.EventHandler(this.Cadastrar_Funcionarios_Load);
            this.gpb_filtro.ResumeLayout(false);
            this.gpb_filtro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_dt_nascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpb_filtro;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_entrada;
        private System.Windows.Forms.MaskedTextBox txt_saida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.MaskedTextBox msk_dt_cadastro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_crp;
        private System.Windows.Forms.Label lbl_crp;
        private System.Windows.Forms.ComboBox cmb_cargo;
        public System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.Button btn_excluir;
        public System.Windows.Forms.Button btn_alterar;
        public System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_confsenha;
        private System.Windows.Forms.Label LblConfSenha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox txt_uf;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txt_sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_obervacao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}