using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade02
{
    public interface IPessoa
    {
        string Nome { get; set; }
        int Idade { get; set; }
        void Falar();
    }
}