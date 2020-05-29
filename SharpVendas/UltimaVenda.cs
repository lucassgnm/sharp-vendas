using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    public class UltimaVenda
    {
        private int _idproduto;
        public int idproduto
        {
            get => _idproduto;
            set => _idproduto = value;
        }

        private String _descricao;
        public String descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        private int _qtde;
        public int qtde
        {
            get => _qtde;
            set => _qtde = value;
        }

        private float _valorun;
        public float valorun
        {
            get => _valorun;
            set => _valorun = value;
        }

        private float _valortotal;
        public float valortotal
        {
            get => _valortotal;
            set => _valortotal = value;
        }
    }
}
