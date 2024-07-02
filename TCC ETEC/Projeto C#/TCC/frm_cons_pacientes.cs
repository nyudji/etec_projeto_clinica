using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.DAO;

namespace TCC
{
    public partial class frm_cons_pacientes : Form
    {
        public frm_cons_pacientes()
        {
            InitializeComponent();
        }

        PacienteDAO pdao = new PacienteDAO();        

        private void frm_cons_pacientes_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {

            dgv_paciente.DataSource = pdao.buscar_tudo();

            dgv_paciente.Columns[0].HeaderText = "ID";
            dgv_paciente.Columns[1].HeaderText = "Nome";
            dgv_paciente.Columns[2].HeaderText = "Sexo";
            dgv_paciente.Columns[3].HeaderText = "RG";
            dgv_paciente.Columns[4].HeaderText = "CPF";
            dgv_paciente.Columns[5].HeaderText = "Mãe";
            dgv_paciente.Columns[6].HeaderText = "Pai";
            dgv_paciente.Columns[7].HeaderText = "EC";
            dgv_paciente.Columns[8].HeaderText = "Cidade";
            dgv_paciente.Columns[9].HeaderText = "UF";
            dgv_paciente.Columns[10].HeaderText = "CEP";
            dgv_paciente.Columns[11].HeaderText = "Endereço";
            dgv_paciente.Columns[12].HeaderText = "Complemento";
            dgv_paciente.Columns[13].HeaderText = "Medicação";
            dgv_paciente.Columns[14].HeaderText = "Data Nascimento";
            dgv_paciente.Columns[15].HeaderText = "Data Cadastro";
            dgv_paciente.Columns[15].DefaultCellStyle.Format = "d";
            dgv_paciente.Columns[16].HeaderText = "Observação";
            dgv_paciente.Columns[17].HeaderText = "Responsável";
            dgv_paciente.Columns[18].HeaderText = "TelefoneResponsável";
            dgv_paciente.Columns[19].HeaderText = "Telefone ";
            dgv_paciente.Columns[20].HeaderText = "Celular";
            dgv_paciente.Columns[21].HeaderText = "Email";
         
         
        }

        private void op_cons_pacientes_nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            msk_cpf.Enabled = false;
            msk_cpf.Clear();
            txt_nome.Clear();
            txt_nome.Focus();
        }

       
        private void op_cons_pacientes_cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_nome.Enabled = false;
            msk_cpf.Enabled = true;
            msk_cpf.Focus();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (op_cons_pacientes_cpf.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_cpf(msk_cpf.Text); 
            if (op_cons_pacientes_nome.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_nome(txt_nome.Text);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_paciente.Rows.Count > 0)
            {
                int indice = dgv_paciente.CurrentRow.Index;
                int id = Convert.ToInt16(dgv_paciente[0, indice].Value);
                frm_cad_pacientes pac = new frm_cad_pacientes(id);
                pac.btn_excluir.Visible = true;
                pac.btn_alterar.Visible = true;
                pac.Text = "Alterar Paciente";
                pac.Show();
                this.Close();
            }
            else
                MessageBox.Show("Selecione um Paciente.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
