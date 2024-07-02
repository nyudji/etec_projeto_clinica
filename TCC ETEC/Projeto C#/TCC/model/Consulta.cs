using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.model
{
    class Consulta
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int id_psicologo;

        public int Id_psicologo
        {
            get { return id_psicologo; }
            set { id_psicologo = value; }
        }
        private int id_paciente;

        public int Id_paciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
        }
        //private int id_anotacao;

        //public int Id_anotacao
        //{
        //    get { return id_anotacao; }
        //    set { id_anotacao = value; }
        //}
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private DateTime horario;

        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public enum status
        {
            Pendente,
            Finalizado
        }
    }
}
