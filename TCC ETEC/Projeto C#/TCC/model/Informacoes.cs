using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    class Informacoes
    {
        private string apontamentos;

        public string Apontamentos
        {
            get { return apontamentos; }
            set { apontamentos = value; }
        }

        private string nome_pac;

        public string Nome_pac
        {
            get { return nome_pac; }
            set { nome_pac = value; }
        }

        private string nome_psi;

        public string Nome_psi
        {
            get { return nome_psi; }
            set { nome_psi = value; }
        }

        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Informacoes(string apont, string pac, string psi, string data, string hora)
        {
            this.apontamentos = apont;
            this.nome_pac = pac;
            this.nome_psi = psi;
            this.data = data;
            this.hora = hora;
        }
    }
}
