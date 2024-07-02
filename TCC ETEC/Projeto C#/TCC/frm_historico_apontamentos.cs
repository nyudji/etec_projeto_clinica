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
    public partial class frm_historico_apontamentos : Form
    {
        public frm_historico_apontamentos()
        {
            InitializeComponent();
        }

        AnotacaoDAO adao = new AnotacaoDAO();
        ConsultaDAO cdao = new ConsultaDAO();
        DataTable dt_adiciona = new DataTable();
        int idCons;

        public frm_historico_apontamentos(int id, string data, string hora, string psic, string pac)
        {
            InitializeComponent();
            dt_adiciona.Columns.Add(new DataColumn("Apontamentos", typeof(string)));
            dt_adiciona.Columns.Add(new DataColumn("Nome do Paciente", typeof(string)));
            dt_adiciona.Columns.Add(new DataColumn("Nome do Psicólogo", typeof(string)));
            dt_adiciona.Columns.Add(new DataColumn("Data", typeof(string)));
            dt_adiciona.Columns.Add(new DataColumn("Horário", typeof(string)));

            DataTable dt_dados = new DataTable();
            dt_dados = adao.consulta(id);
            if (dt_dados.Rows.Count > 0)
            {
                txt_apontamentos.Text = dt_dados.Rows[0][2].ToString();
                btn_salvar.Visible = false;
                btn_alterar.Visible = true;
            }
            idCons = id;
            lbl_nome_pac.Text = pac;
            lbl_nome_psic.Text = psic;
            lbl_data.Text = data.Substring(0, 10);
            lbl_hora.Text = hora.Substring(11, 5);

            DataRow linha;
            linha = dt_adiciona.NewRow();
            linha["Apontamentos"] = dt_dados.Rows[0][2].ToString();
            linha["Nome do Paciente"] = pac;
            linha["Nome do Psicólogo"] = psic;
            linha["Data"] = lbl_data.Text;
            linha["Horário"] = lbl_hora.Text;
            dt_adiciona.Rows.Add(linha);
        }

        private Anotacao getAnotacao()
        {
            Anotacao anot = new Anotacao();

            anot.Id_consulta = idCons;
            anot.Apontamento = txt_apontamentos.Text;

            return anot;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Anotacao anot = getAnotacao();
                adao.anotacao(anot);
                cdao.status(idCons);
                MessageBox.Show("Anotação Salva com Sucesso!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Salva a Anotação.\nErro: " + erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Anotacao anot = getAnotacao();
                adao.alterar(anot, idCons);
                MessageBox.Show("Anotação Alterada Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Alterar a Anotação: " + erro.Message);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_paciente_historico pac_hist = new frm_paciente_historico();
            pac_hist.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class Company
        {
            private List<Informacoes> info;
            public Company()
            {
                info = new List<Informacoes>();
            }
            public List<Informacoes> GetInfo()
            {
                return info;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio(dt_adiciona);
            rel.Show();
        }

        private void frm_historico_apontamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
