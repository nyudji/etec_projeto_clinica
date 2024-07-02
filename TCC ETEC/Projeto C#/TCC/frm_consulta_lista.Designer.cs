namespace TCC
{
    partial class frm_consulta_lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta_lista));
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.gpb_filtro = new System.Windows.Forms.GroupBox();
            this.op_pendente = new System.Windows.Forms.RadioButton();
            this.op_finalizado = new System.Windows.Forms.RadioButton();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_ini = new System.Windows.Forms.DateTimePicker();
            this.gpb_periodo = new System.Windows.Forms.GroupBox();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.lbl_fim = new System.Windows.Forms.Label();
            this.lbl_ini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.gpb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb_periodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_lista.BackgroundColor = System.Drawing.Color.White;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Location = new System.Drawing.Point(31, 132);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.ReadOnly = true;
            this.dgv_lista.Size = new System.Drawing.Size(1005, 435);
            this.dgv_lista.TabIndex = 4;
            // 
            // gpb_filtro
            // 
            this.gpb_filtro.Controls.Add(this.op_pendente);
            this.gpb_filtro.Controls.Add(this.op_finalizado);
            this.gpb_filtro.Enabled = false;
            this.gpb_filtro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_filtro.Location = new System.Drawing.Point(368, 49);
            this.gpb_filtro.Name = "gpb_filtro";
            this.gpb_filtro.Size = new System.Drawing.Size(180, 48);
            this.gpb_filtro.TabIndex = 1;
            this.gpb_filtro.TabStop = false;
            this.gpb_filtro.Text = "Status:";
            // 
            // op_pendente
            // 
            this.op_pendente.AutoSize = true;
            this.op_pendente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_pendente.Location = new System.Drawing.Point(12, 18);
            this.op_pendente.Name = "op_pendente";
            this.op_pendente.Size = new System.Drawing.Size(74, 17);
            this.op_pendente.TabIndex = 0;
            this.op_pendente.TabStop = true;
            this.op_pendente.Text = "Pendente";
            this.op_pendente.UseVisualStyleBackColor = true;
            this.op_pendente.CheckedChanged += new System.EventHandler(this.op_pendente_CheckedChanged);
            // 
            // op_finalizado
            // 
            this.op_finalizado.AutoSize = true;
            this.op_finalizado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_finalizado.Location = new System.Drawing.Point(92, 18);
            this.op_finalizado.Name = "op_finalizado";
            this.op_finalizado.Size = new System.Drawing.Size(78, 17);
            this.op_finalizado.TabIndex = 1;
            this.op_finalizado.TabStop = true;
            this.op_finalizado.Text = "Finalizado";
            this.op_finalizado.UseVisualStyleBackColor = true;
            this.op_finalizado.CheckedChanged += new System.EventHandler(this.op_finalizado_CheckedChanged);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.Enabled = false;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(576, 52);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(52, 45);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.White;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_alterar.Location = new System.Drawing.Point(940, 49);
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
            this.pictureBox1.Location = new System.Drawing.Point(1018, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtp_ini
            // 
            this.dtp_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ini.Location = new System.Drawing.Point(36, 17);
            this.dtp_ini.Name = "dtp_ini";
            this.dtp_ini.Size = new System.Drawing.Size(95, 22);
            this.dtp_ini.TabIndex = 0;
            // 
            // gpb_periodo
            // 
            this.gpb_periodo.Controls.Add(this.dtp_fim);
            this.gpb_periodo.Controls.Add(this.lbl_fim);
            this.gpb_periodo.Controls.Add(this.dtp_ini);
            this.gpb_periodo.Controls.Add(this.lbl_ini);
            this.gpb_periodo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_periodo.Location = new System.Drawing.Point(31, 49);
            this.gpb_periodo.Name = "gpb_periodo";
            this.gpb_periodo.Size = new System.Drawing.Size(294, 48);
            this.gpb_periodo.TabIndex = 0;
            this.gpb_periodo.TabStop = false;
            this.gpb_periodo.Text = "Período:";
            // 
            // dtp_fim
            // 
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim.Location = new System.Drawing.Point(180, 17);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(95, 22);
            this.dtp_fim.TabIndex = 1;
            this.dtp_fim.ValueChanged += new System.EventHandler(this.dtp_fim_ValueChanged);
            // 
            // lbl_fim
            // 
            this.lbl_fim.AutoSize = true;
            this.lbl_fim.Location = new System.Drawing.Point(147, 20);
            this.lbl_fim.Name = "lbl_fim";
            this.lbl_fim.Size = new System.Drawing.Size(27, 13);
            this.lbl_fim.TabIndex = 54;
            this.lbl_fim.Text = "Até:";
            // 
            // lbl_ini
            // 
            this.lbl_ini.AutoSize = true;
            this.lbl_ini.Location = new System.Drawing.Point(6, 20);
            this.lbl_ini.Name = "lbl_ini";
            this.lbl_ini.Size = new System.Drawing.Size(24, 13);
            this.lbl_ini.TabIndex = 53;
            this.lbl_ini.Text = "De:";
            // 
            // frm_consulta_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.gpb_periodo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.gpb_filtro);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dgv_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_consulta_lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consulta_lista";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.gpb_filtro.ResumeLayout(false);
            this.gpb_filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb_periodo.ResumeLayout(false);
            this.gpb_periodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.GroupBox gpb_filtro;
        private System.Windows.Forms.RadioButton op_pendente;
        private System.Windows.Forms.RadioButton op_finalizado;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_ini;
        private System.Windows.Forms.GroupBox gpb_periodo;
        private System.Windows.Forms.Label lbl_fim;
        private System.Windows.Forms.Label lbl_ini;
        private System.Windows.Forms.DateTimePicker dtp_fim;
    }
}