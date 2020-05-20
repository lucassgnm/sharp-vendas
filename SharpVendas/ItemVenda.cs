using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas
{
    class ItemVenda
    {
        private int _id;
        public int id
        {
            get => _id;
            set => _id = value;
        }

        private int _idvenda;
        public int idvenda
        {
            get => _idvenda;
            set => _idvenda = value;
        }

        private int _idproduto;
        public int idproduto
        {
            get => _idproduto;
            set => _idproduto = value;
        }

        private int _qtde;
        public int qtde
        {
            get => _qtde;
            set => _qtde = value;
        }

        private double _valorun;
        public double valorun
        {
            get => _valorun;
            set => _valorun = value;
        }

        private double _valortotal;
        public double valortotal
        {
            get => _valortotal;
            set => _valortotal = value;
        }
    }
}
