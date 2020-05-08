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

        private int _valorun;
        public int valorun
        {
            get => _valorun;
            set => _valorun = value;
        }

        private int _valortotal;
        public int valortotal
        {
            get => _valortotal;
            set => _valortotal = value;
        }
    }
}
