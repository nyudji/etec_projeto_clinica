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
using TCC.model;

namespace TCC
{
    public partial class frm_cons_funcionarios : Form
    {
        public frm_cons_funcionarios()
        {
            InitializeComponent();
            Funcionario.psicologo = false;
        }

        private void op_cons_pacientes_nome_CheckedChanged(object sender, EventArgs e)
        {
            cmb_cargo.Visible = false;
            txt_nome.Enabled = true;
            msk_cpf.Enabled = false;
            msk_cpf.Clear();
            txt_nome.Clear();
            txt_nome.Focus();
        }

        private void op_cons_pacientes_cpf_CheckedChanged(object sender, EventArgs e)
        {
            cmb_cargo.Visible = false;
            msk_cpf.Visible = true;
            txt_nome.Enabled = false;
            msk_cpf.Enabled = true;
            msk_cpf.Clear();
            msk_cpf.Focus();
        }

        private void op_cons_funcionarios_cargo_CheckedChanged(object sender, EventArgs e)
        {
            cmb_cargo.SelectedIndex = -1;
            txt_nome.Enabled = false;
            cmb_cargo.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                frm_menu menu = new frm_menu();
                this.Close();
            }
        }
        FuncionarioDAO fdao = new FuncionarioDAO();

        private void atualizarGrid()
        {

            dgv_funcionario.DataSource = fdao.buscar_tudo();

            dgv_funcionario.Columns[0].HeaderText = "ID";
            dgv_funcionario.Columns[1].HeaderText = "Nome";
            dgv_funcionario.Columns[2].HeaderText = "Sexo";
            dgv_funcionario.Columns[3].HeaderText = "Salario";
            dgv_funcionario.Columns[3].DefaultCellStyle.Format = "c";
            dgv_funcionario.Columns[4].HeaderText = "RG";
            dgv_funcionario.Columns[5].HeaderText = "CPF";
            dgv_funcionario.Columns[6].HeaderText = "CEP";
            dgv_funcionario.Columns[7].HeaderText = "Endereço";
            dgv_funcionario.Columns[8].HeaderText = "Complemento";
            dgv_funcionario.Columns[9].HeaderText = "Cidade";
            dgv_funcionario.Columns[10].HeaderText = "UF";
            dgv_funcionario.Columns[11].HeaderText = "Data Nascimento";
            dgv_funcionario.Columns[12].HeaderText = "Data Cadastro";
            dgv_funcionario.Columns[12].DefaultCellStyle.Format = "d";
            dgv_funcionario.Columns[13].HeaderText = "Cargo";
            dgv_funcionario.Columns[14].HeaderText = "CRP";
            dgv_funcionario.Columns[15].HeaderText = "Telefone";
            dgv_funcionario.Columns[16].HeaderText = "Celular";
            dgv_funcionario.Columns[17].HeaderText = "Email";
            dgv_funcionario.Columns[18].HeaderText = "Usuário";
            dgv_funcionario.Columns[19].HeaderText = "Senha ";
            dgv_funcionario.Columns[20].HeaderText = "Hora de Entrada";
            dgv_funcionario.Columns[21].HeaderText = "Hora de Saida";
            dgv_funcionario.Columns[22].HeaderText = "Observações";
        }

        private void frm_cons_funcionarios_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (op_cons_funcionarios_cpf.Checked == true)
                dgv_funcionario.DataSource = fdao.buscar_cpf(msk_cpf.Text); 
            if (op_cons_funcionarios_nome.Checked == true)
                dgv_funcionario.DataSource = fdao.buscar_nome(txt_nome.Text);
            if (op_cons_funcionarios_cargo.Checked == true)
                dgv_funcionario.DataSource = fdao.buscar_cargo(cmb_cargo.Text);
            if (dgv_funcionario.Rows.Count > 0)
                btn_alterar.Enabled = true;
            else
                MessageBox.Show("Nenhum Dado foi Encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_funcionario.Rows.Count > 0)
            {
                int indice = dgv_funcionario.CurrentRow.Index;
                int id = Convert.ToInt16(dgv_funcionario[0, indice].Value);
                frm_cad_funcionarios fun = new frm_cad_funcionarios(id);
                // fun.btn_incluir.Visible = false;
                // fun.btn_limpar.Visible = false;
                fun.btn_excluir.Visible = true;
                fun.btn_alterar.Visible = true;
                fun.Text = "Alterar Funcionário";
                fun.Show();
                this.Close();
            }
            else
                MessageBox.Show("Selecione um Funcionário.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
