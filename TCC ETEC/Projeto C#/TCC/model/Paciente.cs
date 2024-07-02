using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    class Paciente
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string pai;

        public string Pai
        {
            get { return pai; }
            set { pai = value; }
        }
        private string mae;

        public string Mae
        {
            get { return mae; }
            set { mae = value; }
        }
        private string ec;

        public string Ec
        {
            get { return ec; }
            set { ec = value; }
        }
        private string dtnasc;

        public string Dtnasc
        {
            get { return dtnasc; }
            set { dtnasc = value; }
        }
        private DateTime dtcad;

        public DateTime Dtcad
        {
            get { return dtcad; }
            set { dtcad = value; }
        }

        private string medicacao;

        public string Medicacao
        {
            get { return medicacao; }
            set { medicacao = value; }
        }
        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        private string rua;

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string telefoneres;

        public string Telefoneres
        {
            get { return telefoneres; }
            set { telefoneres = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
        private string responsavel;

        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }
        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
