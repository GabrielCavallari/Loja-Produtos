using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_de_produtos_eletronicos
{
    public class Produto
    {
        
        private double preco; // Este campo privado armazena o preço

        private int quantidadeEmEstoque;

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public double Preco // Esta é a propriedade pública que controla o acesso ao campo privado 'preco'
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                    preco = value;
                else
                    throw new ArgumentException("O preço não pode ser menor que zero");
            }
        }

        public int QuantidadeEmEstoque
        {
            get { return quantidadeEmEstoque; }
            set
            {
                if (value >= 0)
                    quantidadeEmEstoque = value;
                else
                    throw new ArgumentException("A quantidade em estoque não pode ser negativa");
            }
        }

        /* A repetição dos nomes no construtor é uma prática comum em C# e em outras linguagens de programação orientadas a objetos.
         * Ela garante que os objetos sejam inicializados corretamente e evita ambiguidades. */

        public Produto(string nome, double preco, string descricao, int quantidadeEmEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco; // Validação será chamada aqui
            QuantidadeEmEstoque = quantidadeEmEstoque; // Validação será chamada aqui
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}");
        }
    }
}
