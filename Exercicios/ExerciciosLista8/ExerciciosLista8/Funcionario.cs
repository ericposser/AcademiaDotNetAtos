using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista8
{
    abstract class Funcionario
    {
        private string _Nome;
        private string _Departamento;
        private double _Salario;
        private string _DataEntrada;
        private string _RG;
        private bool _Ativo;

        protected Funcionario(string nome, string departamento, double salario, string dataEntrada, string rG, bool ativo)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            DataEntrada = dataEntrada;
            RG = rG;
            Ativo = ativo;
        }

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public double Salario { get => _Salario; set => _Salario = value; }
        public string DataEntrada { get => _DataEntrada; set => _DataEntrada = value; }
        public string RG { get => _RG; set => _RG = value; }
        public bool Ativo { get => _Ativo; set => _Ativo = value; }

        public void Bonifica(double aumento)
        {
            Salario = +aumento;
        }

        public void demite()
        {
            Ativo = false;
        }
        public abstract void Funcao();


        public void MostrarAtividade()
        {
            if (_Ativo)
            {
                Console.WriteLine("Ativo");
            }
            else
            {
                Console.WriteLine("Não esta trabalhando mais");
            }
        }
    }
}
