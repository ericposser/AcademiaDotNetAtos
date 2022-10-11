using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista7
{
    internal class Pedido
    {
        private Itens item;
        private Cliente cliente;
        private double valor;

        public Pedido(Itens item, Cliente cliente)
        {
            this.item = item;
            this.cliente = cliente;
        }

        public void setValor()
        {
            valor = (item.Quantidade * item.Produto.Preco);
        }
        public double getValor()
        {
            return valor;
        }
    }
}
