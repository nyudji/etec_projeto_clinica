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
    public partial class frm_cad_pacientes : Form
    {
        public frm_cad_pacientes()
        {
            InitializeComponent();
        }

        private void frm_cad_pacientes_Load(object sender, EventArgs e)
        {
            if(idPac==0)
                msk_cadastro.Text = DateTime.Now.ToString();
        }
        
        PacienteDAO pdao = new PacienteDAO();
        private int idPac;

        public frm_cad_pacientes(int id)
        {
            InitializeComponent();
            DataTable dt_dados = new DataTable();
            dt_dados = pdao.preenche(id);
            txt_nome.Text = dt_dados.Rows[0]["NOME"].ToString();
            txt_sexo.Text = dt_dados.Rows[0]["SEXO"].ToString();
            msk_rg.Text = dt_dados.Rows[0]["RG"].ToString();
            msk_cpf.Text = dt_dados.Rows[0]["CPF"].ToString();
            txt_mae.Text = dt_dados.Rows[0]["MAE"].ToString();
            txt_pai.Text = dt_dados.Rows[0]["PAI"].ToString();
            txt_ec.Text = dt_dados.Rows[0]["EC"].ToString();
            txt_cidade.Text = dt_dados.Rows[0]["CIDADE"].ToString();
            txt_uf.Text = dt_dados.Rows[0]["UF"].ToString();
            txt_cep.Text = dt_dados.Rows[0]["CEP"].ToString();
            txt_rua.Text = dt_dados.Rows[0]["RUA"].ToString();
            txt_complemento.Text = dt_dados.Rows[0]["COMPLEMENTO"].ToString();
            txt_qual.Text = dt_dados.Rows[0]["MEDICACAO"].ToString();
            if (string.IsNullOrEmpty(txt_qual.Text))
                op_medicamento_nao.Checked = true;
            else
                op_medicamento_sim.Checked = true;
            txt_obervacao.Text = dt_dados.Rows[0]["OBSERVACAO"].ToString();
            txt_nascimento.Text = dt_dados.Rows[0]["DTNASC"].ToString();
            msk_cadastro.Text = dt_dados.Rows[0]["DTCAD"].ToString();
            txt_nome_responsavel.Text = dt_dados.Rows[0]["RESPONSAVEL"].ToString();
            txt_responsavel.Text = dt_dados.Rows[0]["TELEFONERES"].ToString();
            txt_telefone.Text = dt_dados.Rows[0]["TELEFONE"].ToString();
            txt_celular.Text = dt_dados.Rows[0]["CELULAR"].ToString();
            txt_email.Text = dt_dados.Rows[0]["EMAIL"].ToString();
            idPac = id;
        }

        private void limpar()
        {
            txt_nome.Clear();
            msk_rg.Clear();
            msk_cpf.Clear();
            txt_pai.Clear();
            txt_mae.Clear();
            txt_nascimento.Clear();
            msk_cadastro.Clear();
            txt_qual.Clear();
            txt_cep.Clear();
            txt_cidade.Clear();
            txt_rua.Clear();
            txt_complemento.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_responsavel.Clear();
            txt_email.Clear();
            txt_obervacao.Clear();
            txt_nome_responsavel.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            this.Close();
        }

        private void op_medicamento_sim_CheckedChanged(object sender, EventArgs e)
        {
            txt_qual.Enabled = true;
            txt_qual.Focus();
        }

        private void op_medicamento_nao_CheckedChanged(object sender, EventArgs e)
        {
            txt_qual.Enabled = false;
            txt_qual.Clear();
        }

        private Paciente getPaciente()
        {
            Paciente pac = new Paciente();

            pac.Nome = txt_nome.Text;
            pac.Rg = msk_rg.Text;
            pac.Sexo = txt_sexo.Text;
            pac.Cpf = msk_cpf.Text;
            pac.Pai = txt_pai.Text;
            pac.Mae = txt_mae.Text;
            pac.Ec = txt_ec.Text;
            pac.Dtnasc = txt_nascimento.Text;
            pac.Medicacao = txt_qual.Text;
            pac.Cep = txt_cep.Text;
            pac.Cidade = txt_cidade.Text;
            pac.Uf = txt_uf.Text;
            pac.Rua = txt_rua.Text;
            pac.Complemento = txt_complemento.Text;
            pac.Telefone = txt_telefone.Text;
            pac.Celular = txt_celular.Text;
            pac.Telefoneres = txt_responsavel.Text;
            pac.Email = txt_email.Text;
            pac.Responsavel = txt_nome_responsavel.Text;
            pac.Observacao = txt_obervacao.Text;

            return pac;


        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente pac = getPaciente();
                pdao.inserir(pac);
                MessageBox.Show("Paciente Cadastrado Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Incluir Paciente: " + erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente pac = getPaciente();
                pdao.alterar(pac, idPac);
                MessageBox.Show("Paciente Alterado Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_cons_pacientes consPac = new frm_cons_pacientes();
                consPac.Show();
                this.Close();


            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Alterar Paciente: " + erro.Message);
            }
        }

        private void msk_cpf_Validated(object sender, EventArgs e)
        {
            if (msk_cpf.MaskCompleted)
            {
                if (!Validacao.Cpf(msk_cpf.Text))
                {
                    MessageBox.Show("Informe um CPF Válido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msk_cpf.Clear();
                    msk_cpf.Focus();
                }
            }
        }

        private void msk_rg_Validated(object sender, EventArgs e)
        {
            if (!(msk_rg.Text.Length < 9))
            {
                if (!Validacao.Rg(msk_rg.Text))
                {
                    MessageBox.Show("Informe um RG Válido !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msk_rg.Clear();
                }
            }
        }

        private void txt_email_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_email.Text))
            {
                if (!Validacao.Email(txt_email.Text))
                {
                    MessageBox.Show("Informe um E-mail Válido !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_email.Clear();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
