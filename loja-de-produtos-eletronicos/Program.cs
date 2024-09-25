using loja_de_produtos_eletronicos;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criação da loja
        Loja minhaLoja = new Loja("Loja de Eletrônicos");

        // Adicionando produtos à loja
        AdicionarProdutos(minhaLoja);

        // Exibindo produtos disponíveis
        ExibirProdutos(minhaLoja);

        // Ligando e desligando os produtos
        LigarDesligarProdutos(minhaLoja);

        // Exibindo o total dos produtos
        double total = minhaLoja.CalcularTotal();
        Console.WriteLine($"\nTotal de produtos na loja: R$ {total:F2}");

        // Encerramento
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }

    static void AdicionarProdutos(Loja loja)
    {
        // Adicionando alguns produtos com interação do usuário
        loja.AdicionarProduto(new Televisao("TV Samsung", 2500.00, "TV 4K UHD", 10, "Samsung", 55, 3840, TecnologiaTV.OLED));
        loja.AdicionarProduto(new Smartphone("iPhone", 5000.00, "iPhone 13", 5, "Apple", "13", "iOS", 6.1));
        loja.AdicionarProduto(new Computador("PC Gamer", 4500.00, "PC com RTX 3070", 3, "Intel i9", 16, 1000, "RTX 3070"));

        Console.WriteLine("Produtos adicionados com sucesso!");
    }

    static void ExibirProdutos(Loja loja)
    {
        Console.WriteLine("\nProdutos disponíveis na loja:");
        foreach (Produto produto in loja.ListaProdutos)
        {
            produto.ExibirInformacoes();
            Console.WriteLine("--------------------");
        }
    }

    static void LigarDesligarProdutos(Loja loja)
    {
        Console.WriteLine("\nLigando e desligando os produtos...");
        foreach (Produto produto in loja.ListaProdutos)
        {
            if (produto is Televisao tv)
            {
                tv.Ligar();
                tv.Desligar();
            }
            else if (produto is Smartphone smartphone)
            {
                smartphone.Ligar();
                smartphone.Desligar();
            }
            else if (produto is Computador pc)
            {
                pc.Ligar();
                pc.Desligar();
            }
        }
    }
}
