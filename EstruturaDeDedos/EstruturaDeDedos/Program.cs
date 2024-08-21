﻿internal class Program
{

    private static void Main(string[] args)
    {


        void listar(List<string> frutas)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Minha lista de fruta");
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

        //trabalhando com lista ( LIST )
        List<string> frutas = new List<string>();


        //adicionar itens  na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");
        listar(frutas);
        Console.WriteLine("========================================");
        //outra forma de se imprimir na tela 
        Console.WriteLine("comando mais simplificado");
        frutas.ForEach(Console.WriteLine);


        //inserir um elemento no índece especifico
        frutas.Insert(1, "maracuja");
        listar(frutas);


        //alterar um elemento no índice específico
        frutas[4] = "Melancia";
        listar(frutas);

        //remover elementos da lista no índice especifico
        frutas.RemoveAt(3);

        listar(frutas);
        //removendo pelo valor do conteúdo
        frutas.Remove("Morango");
        listar(frutas);


        //apagar todos os elementos 
        frutas.Clear();
        listar(frutas);

        //trabalhando com dicionario
        Dictionary<int, string> carros = new Dictionary<int, string>();
        //adicionando dados a um dicionario
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        //imprimir um dicionario de dados
        Console.WriteLine("dicionario de Carro");
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }


    }
}