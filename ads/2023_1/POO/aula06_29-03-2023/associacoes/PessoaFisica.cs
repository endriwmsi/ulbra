using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class PessoaFisica : Pessoa {
        public PessoaFisica(int id, string nome, City city, string cpf) : base(id, nome, city) 
        {
            this.CPF = cpf;
        }

        public string CPF { get; set; }
    }
}