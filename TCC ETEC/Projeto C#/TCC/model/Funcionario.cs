using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    class Funcionario
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
        private string dtnas;

        public string Dtnas
        {
            get { return dtnas; }
            set { dtnas = value; }
        }
        private DateTime dtcad;

        public DateTime Dtcad
        {
            get { return dtcad; }
            set { dtcad = value; }
        }

        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private string crp;

        public string Crp
        {
            get { return crp; }
            set { crp = value; }
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string hentrada;

        public string Hentrada
        {
            get { return hentrada; }
            set { hentrada = value; }
        }
        private string hsaida;

        public string Hsaida
        {
            get { return hsaida; }
            set { hsaida = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private string complemento;

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string rua;

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public static bool psicologo;
    }
}
