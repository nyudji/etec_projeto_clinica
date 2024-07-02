using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.DAO;
using TCC.model;

namespace TCC
{
    public partial class frm_consulta_agendar : Form
    {
        PacienteDAO pdao = new PacienteDAO();
        FuncionarioDAO fdao = new FuncionarioDAO();
        ConsultaDAO cdao = new ConsultaDAO();
        DataTable dt_psicologo = new DataTable();
        bool verificar = false;
        int idCons;

        public frm_consulta_agendar()
        {
            InitializeComponent();
            Funcionario.psicologo = true;
            txt_nome.Focus();
        }

        public frm_consulta_agendar(int id)
        {
            InitializeComponent();
            Funcionario.psicologo = true;
            idCons = id;
            DataTable dt_dados = new DataTable();
            dt_dados = cdao.consultar_dados(id);
            txt_observacao.Text = dt_dados.Rows[0]["DESCRICAO"].ToString();
            txt_preco.Text = dt_dados.Rows[0]["VALOR"].ToString();
            dtp_data.Value = Convert.ToDateTime(dt_dados.Rows[0]["DATA"].ToString());
            string hora = dt_dados.Rows[0]["HORARIO"].ToString();
            cmb_horario.SelectedItem = hora.Substring(11, 5);
            int idPsic = Convert.ToInt16(dt_dados.Rows[0]["ID_FUNCIONARIO"].ToString());
            dgv_psicologo.DataSource = fdao.preenche(idPsic);
            int idPac = Convert.ToInt16(dt_dados.Rows[0]["ID_PACIENTE"].ToString());
            dgv_paciente.DataSource = pdao.preenche(idPac);
            gpb_paciente.Enabled = false;
        }

        private void frm_consulta_agendar_Load(object sender, EventArgs e)
        {
            if (idCons == 0)
            {
                atualizarGrid();
                atualizarGridPaciente();
            }
        }

        private void op_cons_psicologo_nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_nome_psicologo.Enabled = true;
            msk_cpf_psicologo.Enabled = false;
            btn_pesquisar_psicologo.Enabled = true;
            msk_cpf_psicologo.Clear();
            txt_nome_psicologo.Clear();
            txt_nome_psicologo.Focus();
        }

        private void op_cons_psicologo_cpf_CheckedChanged(object sender, EventArgs e)
        {
            txt_nome_psicologo.Enabled = false;
            msk_cpf_psicologo.Enabled = true;
            btn_pesquisar_psicologo.Enabled = true;
            msk_cpf_psicologo.Focus();
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


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (btn_alterar.Visible == false)
                this.Close();
            else
            {
                frm_consulta_lista cons = new frm_consulta_lista();
                cons.Show();
                this.Close();
            }
        }


        private void atualizarGrid()
        {

            dgv_psicologo.DataSource = fdao.buscar_tudo();

            dgv_psicologo.Columns[0].HeaderText = "ID";
            dgv_psicologo.Columns[1].HeaderText = "Nome";
            for (int i = 2; i <= 4; i++)
                dgv_psicologo.Columns[i].Visible = false;
            dgv_psicologo.Columns[5].HeaderText = "CPF";
            for (int i = 6; i <= 14; i++)
                dgv_psicologo.Columns[i].Visible = false;
            dgv_psicologo.Columns[15].HeaderText = "Telefone";
            dgv_psicologo.Columns[16].HeaderText = "Celular";
            dgv_psicologo.Columns[17].HeaderText = "Email";
            for (int i = 18; i <= 22; i++)
                dgv_psicologo.Columns[i].Visible = false;
        }
        private void atualizarGridPaciente()
        {

            dgv_paciente.DataSource = pdao.buscar_tudo();

            dgv_paciente.Columns[0].HeaderText = "ID";
            dgv_paciente.Columns[1].HeaderText = "Nome";
            dgv_paciente.Columns[2].Visible = false;
            dgv_paciente.Columns[3].Visible = false;
            dgv_paciente.Columns[4].HeaderText = "CPF";
            for (int i = 5; i <=18 ; i++)
                dgv_paciente.Columns[i].Visible = false;
            dgv_paciente.Columns[19].HeaderText = "Telefone ";
            dgv_paciente.Columns[20].HeaderText = "Celular";
            dgv_paciente.Columns[21].HeaderText = "Email";
        }

        private void limpar()
        {
            txt_nome.Clear();
            msk_cpf.Clear();
            txt_observacao.Clear();
            cmb_horario.SelectedIndex = -1;
            txt_preco.Clear();
            txt_nome_psicologo.Clear();
            msk_cpf_psicologo.Clear();
            op_cons_pacientes_nome.Checked = true;
            op_cons_psicologo_nome.Checked = false;
            op_cons_psicologo_cpf.Checked = false;
            op_cons_psicologo_cpf.Enabled = false;
            op_cons_psicologo_nome.Enabled = false;
            btn_pesquisar_psicologo.Enabled = false;
            txt_nome.Focus();
            atualizarGrid();
            atualizarGridPaciente();
            verificar = false;
        }

        private Consulta getConsulta()
        {
            Consulta con = new Consulta();

            int indicepac = dgv_paciente.CurrentRow.Index;
            con.Id_paciente = Convert.ToInt16(dgv_paciente[0, indicepac].Value);
            int indicepsic = dgv_psicologo.CurrentRow.Index;
            con.Id_psicologo = Convert.ToInt16(dgv_psicologo[0, indicepsic].Value);
            con.Descricao = txt_observacao.Text;
            con.Valor = Convert.ToDouble(txt_preco.Text);
            con.Data = Convert.ToDateTime(dtp_data.Value.ToShortDateString());
            con.Horario = Convert.ToDateTime(cmb_horario.Text);

            return con;
        }

        private void btn_pesquisar_paciente_Click(object sender, EventArgs e)
        {
            if (op_cons_pacientes_cpf.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_cpf(msk_cpf.Text);
            if (op_cons_pacientes_nome.Checked == true)
                dgv_paciente.DataSource = pdao.buscar_nome(txt_nome.Text);
        }

        private void btn_pesquisar_psicologo_Click(object sender, EventArgs e)
        {
            DataTable dt_cons = dt_psicologo.Clone();

            if (op_cons_psicologo_nome.Checked == true)
            {
                foreach (DataRow row in dt_psicologo.Select("NOME LIKE '%" + txt_nome_psicologo.Text + "%'"))
                {
                    dt_cons.ImportRow(row);
                }

                dgv_psicologo.DataSource = dt_cons;
            }

            if (op_cons_psicologo_cpf.Checked == true)
            {
                foreach (DataRow row in dt_psicologo.Select("CPF = '" + msk_cpf_psicologo.Text + "'"))
                {
                    dt_cons.ImportRow(row);
                }

                dgv_psicologo.DataSource = dt_cons;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta con = getConsulta();
                cdao.agendar(con);
                MessageBox.Show("Agendamento Realizado com Sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Realizar o Agendamento: " + erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta con = getConsulta();
                cdao.alterar(con, idCons);
                MessageBox.Show("Agendamento Alterado Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_consulta_lista cons = new frm_consulta_lista();
                cons.Show();
                this.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Alterar os Dados: " + erro.Message);
            }
        }

        private void dtp_data_ValueChanged(object sender, EventArgs e)
        {
            reseta();
            if (verificar == true)
                consultar_horario();
        }

        private void cmb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            reseta();
            verificar = true;
            op_cons_psicologo_nome.Enabled = true;
            op_cons_psicologo_cpf.Enabled = true;
            consultar_horario();
        }

        private void reseta()
        {
            op_cons_psicologo_nome.Checked = false;
            op_cons_psicologo_cpf.Checked = false;
            txt_nome_psicologo.Enabled = false;
            msk_cpf_psicologo.Enabled = false;
            msk_cpf_psicologo.Clear();
            txt_nome_psicologo.Clear();
        }

        private void consultar_horario()
        {
            string horario = cmb_horario.Text;
            string data = dtp_data.Value.ToString("yyyy-MM-dd");
            DataTable dt_cons = new DataTable();
            dt_cons = cdao.consultar_psicologo(data);
            dt_psicologo = fdao.buscar_tudo();

            for (int i = 0; i < dt_cons.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dt_cons.Rows[i]["ID_FUNCIONARIO"].ToString());
                string time = dt_cons.Rows[i]["HORARIO"].ToString();
                string hora = time.Substring(11, 5);

                if (horario == hora)
                {
                    for (int x = 0; x < dt_psicologo.Rows.Count; x++)
                    {
                        if (id == Convert.ToInt32(dt_psicologo.Rows[x]["ID"].ToString()))
                        {
                            dt_psicologo.Rows.RemoveAt(x);
                            x = dt_psicologo.Rows.Count;
                        }
                    }
                }
            }

            dgv_psicologo.DataSource = dt_psicologo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
