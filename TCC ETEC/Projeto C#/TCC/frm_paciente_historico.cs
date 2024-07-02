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
    public partial class frm_paciente_historico : Form
    {
        public frm_paciente_historico()
        {
            InitializeComponent();
            atualizarGridPaciente();
        }

        PacienteDAO pdao = new PacienteDAO();
        ConsultaDAO cdao = new ConsultaDAO();

        private void atualizarGridPaciente()
        {

            dgv_paciente.DataSource = pdao.buscar_tudo();

            dgv_paciente.Columns[0].HeaderText = "ID";
            dgv_paciente.Columns[1].HeaderText = "Nome";
            dgv_paciente.Columns[2].Visible = false;
            dgv_paciente.Columns[3].Visible = false;
            dgv_paciente.Columns[4].HeaderText = "CPF";
            for (int i = 5; i <= 18; i++)
                dgv_paciente.Columns[i].Visible = false;
            dgv_paciente.Columns[19].HeaderText = "Telefone ";
            dgv_paciente.Columns[20].HeaderText = "Celular";
            dgv_paciente.Columns[21].HeaderText = "Email";
        }

        private void GridHistorico()
        {
            dgv_historico.Columns[0].HeaderText = "ID";
            dgv_historico.Columns[1].Visible = false;
            dgv_historico.Columns[2].Visible = false;
            dgv_historico.Columns[3].HeaderText = "Descrição";
            dgv_historico.Columns[4].HeaderText = "Valor";
            dgv_historico.Columns[4].DefaultCellStyle.Format = "c";
            dgv_historico.Columns[5].HeaderText = "Data";
            dgv_historico.Columns[6].HeaderText = "Horário";
            dgv_historico.Columns[6].DefaultCellStyle.Format = "t";
            dgv_historico.Columns[7].HeaderText = "Status";
            dgv_historico.Columns[8].Visible = false;
            dgv_historico.Columns[9].HeaderText = "Nome Psicólogo";
            for (int i = 10; i <= 12; i++)
                dgv_historico.Columns[i].Visible = false;
            dgv_historico.Columns[13].HeaderText = "CPF Psicólogo";
            for (int i = 14; i <= 31; i++)
                dgv_historico.Columns[i].Visible = false;
            dgv_historico.Columns[32].HeaderText = "Nome Paciente";
            dgv_historico.Columns[33].Visible = false;
            dgv_historico.Columns[34].Visible = false;
            dgv_historico.Columns[35].HeaderText = "CPF Paciente";
            for (int i = 36; i <= 52; i++)
                dgv_historico.Columns[i].Visible = false;
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
            if (op_cons_pacientes_nome.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_nome(txt_nome.Text);
            if (op_cons_pacientes_cpf.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_cpf(msk_cpf.Text);
            if (!(dgv_paciente.Rows.Count > 0))
                MessageBox.Show("Nenhum Dado foi Encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_prontuario.Enabled = false;
            dgv_historico.DataSource = DBNull.Value;
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            if (dgv_paciente.Rows.Count > 0)
            {
                int indice = dgv_paciente.CurrentRow.Index;
                int id = Convert.ToInt16(dgv_paciente[0, indice].Value);
                dgv_historico.DataSource = cdao.consultar_historico(id);
                GridHistorico();
                if (dgv_historico.Rows.Count > 0)
                    btn_prontuario.Enabled = true;
                else
                    MessageBox.Show("Nenhum Dado foi Encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Selecione um Paciente.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_prontuario_Click(object sender, EventArgs e)
        {
            int indice = dgv_historico.CurrentRow.Index;
            int id = Convert.ToInt16(dgv_historico[0, indice].Value);
            string data = dgv_historico[5, indice].Value.ToString();
            string hora = dgv_historico[6, indice].Value.ToString();
            string psic = dgv_historico[9, indice].Value.ToString();
            string pac = dgv_historico[32, indice].Value.ToString();
            frm_historico_apontamentos hist = new frm_historico_apontamentos(id, data, hora, psic, pac);
            this.Close();
            hist.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
