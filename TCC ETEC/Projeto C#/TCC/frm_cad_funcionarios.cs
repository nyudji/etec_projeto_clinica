using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.DAO;
using TCC.model;

namespace TCC
{
    public partial class frm_cad_funcionarios : Form
    {
        public frm_cad_funcionarios()
        {
            InitializeComponent();
        }

        private void Cadastrar_Funcionarios_Load(object sender, EventArgs e)
        {
            if(idFunc==0)
                msk_dt_cadastro.Text = DateTime.Now.ToString();
        }

        
        FuncionarioDAO fdao = new FuncionarioDAO();
        private int idFunc;

          public frm_cad_funcionarios(int id)
        {
            InitializeComponent();
            DataTable dt_dados = new DataTable();
            dt_dados = fdao.preenche(id);
            txt_nome.Text = dt_dados.Rows[0]["NOME"].ToString();
            txt_sexo.Text = dt_dados.Rows[0]["SEXO"].ToString();
            txt_salario.Text = dt_dados.Rows[0]["SALARIO"].ToString();
            msk_rg.Text = dt_dados.Rows[0]["RG"].ToString();
            msk_cpf.Text = dt_dados.Rows[0]["CPF"].ToString();
            txt_cep.Text = dt_dados.Rows[0]["CEP"].ToString();
            txt_rua.Text = dt_dados.Rows[0]["RUA"].ToString();
            txt_complemento.Text = dt_dados.Rows[0]["COMPLEMENTO"].ToString();
            txt_cidade.Text = dt_dados.Rows[0]["CIDADE"].ToString();
            txt_uf.Text = dt_dados.Rows[0]["UF"].ToString();
            txt_dt_nascimento.Text = dt_dados.Rows[0]["DTNASC"].ToString();
            msk_dt_cadastro.Text = dt_dados.Rows[0]["DTCAD"].ToString();
            cmb_cargo.Text = dt_dados.Rows[0]["CARGO"].ToString();
            txt_crp.Text = dt_dados.Rows[0]["CRP"].ToString();
            txt_telefone.Text = dt_dados.Rows[0]["TELEFONE"].ToString();
            txt_celular.Text = dt_dados.Rows[0]["CELULAR"].ToString();
            txt_email.Text = dt_dados.Rows[0]["EMAIL"].ToString();
            txt_usuario.Text = dt_dados.Rows[0]["USUARIO"].ToString();
            txt_senha.Text = dt_dados.Rows[0]["SENHA"].ToString();
            txt_entrada.Text = dt_dados.Rows[0]["HENTRADA"].ToString();
            txt_saida.Text = dt_dados.Rows[0]["HSAIDA"].ToString();
            txt_obervacao.Text = dt_dados.Rows[0]["OBSERVACAO"].ToString();
            idFunc = id;
        }

        private void limpar()
        {
            txt_nome.Clear();
            txt_salario.Clear();
            msk_rg.Clear();
            msk_cpf.Clear();
            txt_cep.Clear();
            txt_rua.Clear();
            txt_complemento.Clear();
            txt_cidade.Clear();
            txt_dt_nascimento.Clear();
            msk_dt_cadastro.Clear();
            txt_crp.Clear();
            txt_telefone.Clear();
            txt_celular.Clear();
            txt_email.Clear();
            txt_usuario.Clear();
            txt_senha.Clear();
            txt_entrada.Clear();
            txt_saida.Clear();
            txt_confsenha.Clear();
            txt_obervacao.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            limpar();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                frm_menu menu = new frm_menu();
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void salario_Click(object sender, EventArgs e)
        {

        }

        private void txt_crp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cargo.SelectedIndex == 1)
            {
                txt_crp.Visible = true;
                lbl_crp.Visible = true;
            }
            else
            {
                txt_crp.Visible = false;
                lbl_crp.Visible = false;
            }

        }
        private Funcionario getFuncionario()
        {
            Funcionario func = new Funcionario();

            func.Nome = txt_nome.Text;
            func.Sexo = txt_sexo.Text;
            func.Salario = Convert.ToDouble(txt_salario.Text);
            func.Rg = msk_rg.Text;
            func.Cpf = msk_cpf.Text;
            func.Cep = txt_cep.Text;
            func.Rua = txt_rua.Text;
            func.Complemento = txt_complemento.Text;
            func.Cidade = txt_cidade.Text;
            func.Uf = txt_uf.Text;
            func.Dtnas = txt_dt_nascimento.Text;
            func.Cargo = cmb_cargo.Text;
            func.Crp = txt_crp.Text;
            func.Telefone = txt_telefone.Text;
            func.Celular = txt_celular.Text;
            func.Email = txt_email.Text;
            func.Usuario = txt_usuario.Text;
            func.Senha = txt_senha.Text;
            func.Hentrada = txt_entrada.Text;
            func.Hsaida = txt_saida.Text;
            func.Observacao = txt_obervacao.Text;
            return func;


        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_confsenha.Text == txt_senha.Text)
            {
                try
                {
                    Funcionario func = getFuncionario();
                    fdao.inserir(func);
                    MessageBox.Show("Funcionário Cadastrado Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro ao Incluir Funcionario: " + erro.Message);
                }
            }
            else MessageBox.Show("Confirmação de senha incorreta ");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                model.Funcionario func = getFuncionario();
                fdao.excluir(func);
                MessageBox.Show("Excluido com sucesso");
                this.Close();
                frm_cons_funcionarios fun = new frm_cons_funcionarios();
                fun.Show();
               
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Excluir Funcionario " + erro.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario func = getFuncionario();
                fdao.alterar(func, idFunc);
                MessageBox.Show("Funcionário Alterado Com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_cons_funcionarios fun = new frm_cons_funcionarios();
                fun.Show();
                this.Close();


            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao Alterar Funcionário: " + erro.Message);
            }
        }

        private void op_cons_pacientes_nome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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