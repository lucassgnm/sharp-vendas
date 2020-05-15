using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    class Vendedor
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

        private DateTime _dataadmis;
        public DateTime dataadmis
        {
            get => _dataadmis;
            set => _dataadmis = value;
        }
    }
}
