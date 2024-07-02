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
    public partial class frm_consulta_lista : Form
    {
        public frm_consulta_lista()
        {
            InitializeComponent();
        }

        ConsultaDAO cdao = new ConsultaDAO();

        private void GridLista()
        {
            dgv_lista.Columns[0].HeaderText = "ID";
            dgv_lista.Columns[1].Visible = false;
            dgv_lista.Columns[2].Visible = false;
            dgv_lista.Columns[3].HeaderText = "Descrição";
            dgv_lista.Columns[4].HeaderText = "Valor";
            dgv_lista.Columns[4].DefaultCellStyle.Format = "c";
            dgv_lista.Columns[5].HeaderText = "Data";
            dgv_lista.Columns[6].HeaderText = "Horário";
            dgv_lista.Columns[6].DefaultCellStyle.Format = "t";
            dgv_lista.Columns[7].HeaderText = "Status";
            dgv_lista.Columns[8].Visible = false;
            dgv_lista.Columns[9].HeaderText = "Nome Psicólogo";
            for (int i = 10; i <= 12; i++)
                dgv_lista.Columns[i].Visible = false;
            dgv_lista.Columns[13].HeaderText = "CPF Psicólogo";
            for (int i = 14; i <= 31; i++)
                dgv_lista.Columns[i].Visible = false;
            dgv_lista.Columns[32].HeaderText = "Nome Paciente";
            dgv_lista.Columns[33].Visible = false;
            dgv_lista.Columns[34].Visible = false;
            dgv_lista.Columns[35].HeaderText = "CPF Paciente";
            for (int i = 36; i <= 52; i++)
                dgv_lista.Columns[i].Visible = false;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_lista.Rows.Count > 0)
            {
                int indice = dgv_lista.CurrentRow.Index;
                int id = Convert.ToInt16(dgv_lista[0, indice].Value);
                frm_consulta_agendar clie = new frm_consulta_agendar(id);
                this.Close();
                clie.btn_alterar.Visible = true;
                clie.btn_voltar.Location = new Point(160, 499);
                clie.Show();
            }
            else
                MessageBox.Show("Selecione uma Consulta.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string dtIni = dtp_ini.Value.ToString("yyyy-MM-dd");
            string dtFim = dtp_fim.Value.ToString("yyyy-MM-dd");
            if (op_pendente.Checked == true)
            {
                dgv_lista.DataSource = cdao.consultar_status(0, dtIni, dtFim);
                GridLista();
                btn_alterar.Enabled = true;
            }
            if (op_finalizado.Checked == true)
            {
                dgv_lista.DataSource = cdao.consultar_status(1, dtIni, dtFim);
                GridLista();
                btn_alterar.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_fim_ValueChanged(object sender, EventArgs e)
        {
            gpb_filtro.Enabled = true;
        }

        private void op_pendente_CheckedChanged(object sender, EventArgs e)
        {
            btn_pesquisar.Enabled = true;
        }

        private void op_finalizado_CheckedChanged(object sender, EventArgs e)
        {
            btn_pesquisar.Enabled = true;
        }
    }
}
