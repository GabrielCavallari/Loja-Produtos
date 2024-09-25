using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_de_produtos_eletronicos
{
    public class Smartphone : Produto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }
        public double TamanhoTela { get; set; }

        public Smartphone(string nome, double preco, string descricao, int quantidadeEmEstoque, string marca, string modelo, string sistemaOperacional, double tamanhoTela) : base(nome, preco, descricao, quantidadeEmEstoque)
        {
            Marca = marca;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
            TamanhoTela = tamanhoTela;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando o smartphone... ");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando o smartphone... ");
        }
    }
}
