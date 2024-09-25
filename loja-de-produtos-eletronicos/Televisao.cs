using loja_de_produtos_eletronicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace loja_de_produtos_eletronicos
{
    public enum TecnologiaTV
    {
        LED,
        OLED,
        QLED,
        Plasma
    }
    public class Televisao : Produto
    {
        public string Marca { get; set; }
        public double TamanhoTela { get; set; }
        public double Resolucao { get; set; }
        public TecnologiaTV Tecnologia { get; set; }


        public Televisao(string nome, double preco, string descricao, int quantidadeEmEstoque, string marca, double tamanhoTela, double resolucao,TecnologiaTV tecnologia) : base(nome, preco, descricao, quantidadeEmEstoque)
        {
            Marca = marca;
            TamanhoTela = tamanhoTela;
            Resolucao = resolucao;
            Tecnologia = tecnologia;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando a TV... ");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando a TV... ");
        }
    }
}
