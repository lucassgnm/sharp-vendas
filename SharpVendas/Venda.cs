using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    public class Venda
    {
        private int _id;
        public int id
        {
            get => _id;
            set => _id = value;
        }

        private int _idcliente;
        public int idcliente
        {
            get => _idcliente;
            set => _idcliente = value;
        }

        private int _idvendedor;
        public int idvendedor
        {
            get => _idvendedor;
            set => _idvendedor = value;
        }

        private DateTime _datavenda;
        public DateTime datavenda
        {
            get => _datavenda;
            set => _datavenda = value;
        }

        private double _total;
        public double total
        {
            get => _total;
            set => _total = value;
        }
    }
}
