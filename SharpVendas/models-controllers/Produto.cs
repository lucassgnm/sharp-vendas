using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    class Produto
    {
        private int _id;
        public int id
        {
            get => _id;
            set => _id = value;
        }

        private String _descricao;
        public String descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        private float _valor;
        public float valor
        {
            get => _valor;
            set => _valor = value;
        }

        private int _qtde;
        public int qtde
        {
            get => _qtde;
            set => _qtde = value;
        }
    }
}
