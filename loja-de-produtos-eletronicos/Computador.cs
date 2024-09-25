using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace loja_de_produtos_eletronicos
{
    public class Computador : Produto
    {
        public string Processador { get; set; }
        public int MemoriaRam { get; set; }
        public int Armazenamento { get; set; }
        public string PlacaDeVideo { get; set; }

        public Computador(string nome, double preco, string descricao, int quantidadeEmEstoque, string processador, int memoriaRam, int armazenamento, string placadeVideo) : base(nome, preco, descricao, quantidadeEmEstoque)
        {
            Processador = processador;
            MemoriaRam = memoriaRam;
            Armazenamento = armazenamento;
            PlacaDeVideo = placadeVideo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando o computador ... ");
        }

        public void Desligar()
        { 
            Console.WriteLine("Desligando o computador ... ");
        }

        public void AumentarMemoria(int quantidade)
        {
            MemoriaRam += quantidade;
            Console.WriteLine($"Memória RAM aumentada para {MemoriaRam} MB.");
        }

        public void AumentarArmazenamento(int quantidade)
        {
            Armazenamento += quantidade;
            Console.WriteLine($"HD aumentado para {Armazenamento} GB");
        }
    }
    
    
}
