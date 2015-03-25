using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();
        }

        private void InicializarLista(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Random r = new Random();
            //r.Next(1,100) + (2 * DateTime.Now.Second)
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicao = int.Parse(textBox1.Text);

            Elemento elemento = lista.BuscaEmLocal(posicao);
            Elemento newElemento = new Elemento(lista.Count);

            newElemento.Proximo = elemento.Proximo;
            elemento.Proximo = newElemento;
        }

        private void OrdenarPeloValor_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < lista.Count -1; i++)
            {
                for (int j = i +1 ; j < lista.Count; j++) 
               {
                   Elemento x = lista.BuscaEmLocal(i);                   
                   Elemento y = lista.BuscaEmLocal(j);
                   

                   if (x.Valor > y.Valor)
                   {
                       Elemento temp = x;
                       
                       //x = y;
                       //y = temp;


                       x.Proximo = y.Proximo;
                       x.Anterior = y.Anterior;

                       y.Proximo = temp.Proximo;
                       y.Anterior = temp.Anterior;
                   }
               }
            }
        }
    }
}
