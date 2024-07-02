using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LINKAR TELAS
            frm_cad_pacientes clie = new frm_cad_pacientes();
            clie.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LINKAR TELAS
            frm_cad_funcionarios clie = new frm_cad_funcionarios();
            clie.Show();
        }

        private void tsmi_cons_clie_Click(object sender, EventArgs e)
        {
            frm_cons_pacientes clie = new frm_cons_pacientes();
            clie.Show();
        } 

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsmi_cons_funcionario_Click(object sender, EventArgs e)
        {
            frm_cons_funcionarios clie = new frm_cons_funcionarios();
            clie.Show();
        }

        private void psicólogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void psicólogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // LINKAR TELAS
            frm_consulta_agendar clie = new frm_consulta_agendar();
            clie.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cons_pacientes clie = new frm_cons_pacientes();
            clie.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_cons_funcionarios clie = new frm_cons_funcionarios();
            clie.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_paciente_historico pac_hist = new frm_paciente_historico();
            pac_hist.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_cons_pacientes clie = new frm_cons_pacientes();
            //clie.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            frm_cons_pacientes cpp = new frm_cons_pacientes();
            cpp.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_cons_funcionarios clie = new frm_cons_funcionarios();
            clie.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_consulta_lista clie = new frm_consulta_lista();
            clie.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
