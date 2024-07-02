using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.model;

namespace TCC
{
    public partial class Relatorio : Form
    {
        public Relatorio(DataTable dt)
        {
            InitializeComponent(); List<Informacoes> info = new List<Informacoes>();
            info.Add(new Informacoes(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString()));
            InformacoesBindingSource.DataSource = info;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
