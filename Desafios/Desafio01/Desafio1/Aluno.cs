using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Aluno : Pessoa
    {
        public string matricula;
        public string codigo;
        public string nomeCurso;
        public Aluno()
        {
        }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf) : base(nome, telefone, cidade, rg, cpf)
        {

            this.nome = nome;
            this.telefone = telefone;
            this.cidade = cidade;
            this.rg = rg;
            this.cpf = cpf;
        }
    }
}
