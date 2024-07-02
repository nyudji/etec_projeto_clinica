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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        FuncionarioDAO fdao = new FuncionarioDAO();
        Funcionario func = new Funcionario();
        

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

     



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtLogin = new DataTable();
                dtLogin = fdao.login(txt_usuario.Text, txt_senha.Text);
                if (txt_usuario.Text == "" || txt_senha.Text == "")
                {
                    MessageBox.Show("Existem Campos Incompletos !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtLogin.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário e/ou Senha Incorretas !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        frm_menu menu = new frm_menu();
                        menu.Show();
                        this.Visible = false;

                    }
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                DataTable dtLogin = new DataTable();
                dtLogin = fdao.login(txt_usuario.Text, txt_senha.Text);
                if (txt_usuario.Text == "" || txt_senha.Text == "")
                {
                    MessageBox.Show("Existem Campos Incompletos !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtLogin.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário e/ou Senha Incorretas !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                            frm_menu menu = new frm_menu();
                            menu.Show();
                            this.Visible = false;
                        }
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

