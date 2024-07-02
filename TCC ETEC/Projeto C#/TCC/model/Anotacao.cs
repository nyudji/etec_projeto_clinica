using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    class Anotacao
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_consulta;

        public int Id_consulta
        {
            get { return id_consulta; }
            set { id_consulta = value; }
        }

        private string apontamento;

        public string Apontamento
        {
            get { return apontamento; }
            set { apontamento = value; }
        }
    }
}
