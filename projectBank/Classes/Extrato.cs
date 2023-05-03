using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBank.Classes
{
    public class Extrato
    {
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public Extrato(DateTime data, string descricao, double valor)
        {
            Data = data;
            Descricao = descricao;
            Valor = valor;
        }
    }
}
