using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01ATOS
{
    public class Pessoa
    {

        public string nome;
        public string telefone;
        public string cidade;
        public string rg;
        public string cpf;


        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cidade = cidade;
            this.rg = rg;
            this.cpf = cpf;
        }

        public Pessoa()
        {
        }

    }
}
