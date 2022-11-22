using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFramework.DataModels
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }

        //public List<Email> pessoaEmails { get; set; }

        public virtual ICollection<Email> pessoaEmails { get; set; }

    }
}
