using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_de_produtos_eletronicos
{
    public class Loja
    {
        public string NomeLoja { get; set; }
        public List<Produto> ListaProdutos { get; set; }

        public Loja(string nomeLoja)
        {
            NomeLoja = nomeLoja;
            ListaProdutos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            try
            {
                ListaProdutos.Add(produto);
                Console.WriteLine($"Produto {produto.Nome} adicionado com sucesso");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao adicionar o produto: {ex.Message}");
            }
        }

        public void RemoverProduto(Produto prduto)
        {
            ListaProdutos.Remove(prduto);
        }
           
        public void ProdutosDisponiveis()
        {
            Console.WriteLine("Produtos Disponíveis na loja: \n");
            foreach (Produto produto in ListaProdutos)
            {
                produto.ExibirInformacoes();
            }
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach(Produto produto in ListaProdutos)
            {
                total += produto.Preco;
            }
            return total;
        }
    }
}
