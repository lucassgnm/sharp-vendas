using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas
{
    public class Cliente
    {
        private int _id;
        public int id
        {
            get => _id;
            set => _id = value;
        }

        private String _nome;
        public String nome
        {
            get => _nome;
            set => _nome = value;
        }

        private String _cpf;
        public String cpf
        {
            get => _cpf;
            set => _cpf = value;
        }

        private String _rg;
        public String rg
        {
            get => _rg;
            set => _rg = value;
        }

        private DateTime _datanasc;
        public DateTime datanasc
        {
            get => _datanasc;
            set => _datanasc = value;
        }
    }
}
