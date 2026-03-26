using Loja.Entities;
using System;
using System.Globalization;
using Loja.Entities.Enum;
using System.Text.RegularExpressions;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Nome: ");
            string nome = FormatarNome(Console.ReadLine());
            Console.Clear();

            Console.Write($"Email: ");
            string email = ValidarEmail(Console.ReadLine());
            Console.Clear();

            Console.Write($"Data de Nascimento (DD/MM/YYYY): ");
            string entradaNascimento = Console.ReadLine();
            DateTime nascimento = ValidarData(entradaNascimento);
            Console.Clear();
            Cliente cliente = new Cliente(nome, email, nascimento);

            MostrarStatus();
            Console.Write($"Status: ");


            OrderStatus orderStatus = EnumFormata(Console.ReadLine());
            Console.Clear();
            Console.Write($"Quantos itens para a ordem? ");
            string entradaItens = Console.ReadLine();
            int itens = EhNumero(entradaItens);
            Console.Clear();
            Pedido pede = new Pedido(DateTime.Now, orderStatus, cliente);
            for (int i = 1; i <= itens; i++)
            {
                Console.WriteLine($"Entre com o {i}º item:");
                Console.Write($"Nome do produto: ");
                string nomeProduto = FormatarNome(Console.ReadLine());
                Console.Write($"Preço do produto: ");
                entradaItens = Console.ReadLine();
                double preco = EhPreco(entradaItens);
                Console.Write($"Quantidade: ");
                string entradaQuantidade = Console.ReadLine();
                int quantidade = EhNumero(entradaQuantidade);
                Produto product = new Produto(nomeProduto, preco);
                ItemPedido pedido = new ItemPedido(quantidade, preco, product);
                pede.AddItem(pedido);


            }
            Console.Clear();
            Console.WriteLine($"{pede}");
        }

        static int EhNumero(string entrada)
        {
            int numero;
            while (!int.TryParse(entrada, out numero) || numero < 1)
            {
                if (entrada.Any(char.IsLetter))
                {
                    Console.Write($"Entrada incorreta! Você não pode digitar letras. Por favor, digite um número válido: ");
                    entrada = Console.ReadLine();
                }
                else
                {
                    Console.Write($"Número incorreto! Você não pode digitar 0, um número abaixo de 0 ou caracteres especiais. Por favor, digite um número válido: ");
                    entrada = Console.ReadLine();

                }

            }
            return numero;
        }

        static double EhPreco(string entrada)
        {
            double numero;
            while (!double.TryParse(entrada, out numero) || numero < 1)
            {
                Console.Clear();
                if (entrada.Any(char.IsLetter))
                {
                    Console.Write($"Entrada incorreta! Você não pode digitar letras. Por favor, digite um número válido: ");
                    entrada = Console.ReadLine();
                }
                else
                {
                    Console.Write($"Número incorreto! Você não pode digitar 0, um número abaixo de 0 ou caracteres especiais. Por favor, digite um número válido: ");
                    entrada = Console.ReadLine();

                }

            }
            return numero;
        }

        static string FormatarNome(string nome)
        {

            while (string.IsNullOrEmpty(nome) || !nome.Any(char.IsLetter) || nome.Length < 3)
            {
                Console.Clear();
                Console.Write($"Nome incorreto! \"{nome}\" não é um nome válido, por favor, digite o nome corretamente: ");
                nome = Console.ReadLine();
                
            }
            nome = nome.ToLower();

            nome = char.ToUpper(nome[0]) + nome.Substring(1);
            return nome;
        }

        static string ValidarEmail(string email)
        {
            
            string padrao = @"^[^@\s]+@[^@\s]+.+[^@\s]+$";
            while (email.Length < 6 || !Regex.IsMatch(email, padrao) || !email.Contains("com"))
            {
                Console.Clear();
                Console.Write($"Email inválido! Por favor, digite novamente: ");
                email = Console.ReadLine();
                
            }
            return email;
        }

        static DateTime ValidarData(string data)
        {
            DateTime dt;
            while (!DateTime.TryParse(data, out dt))
            {
                Console.Clear();
                Console.Write("Formato de data incorreto! Por favor digite a data de nascimento corretamente (DD/MM/YYYY): ");
                data = Console.ReadLine();
            }
            return dt;
        }

        static OrderStatus EnumFormata(string entrada)
        {
            OrderStatus status;
            while (!Enum.TryParse<OrderStatus>(entrada, true, out status) || !Enum.IsDefined<OrderStatus>(status))
            {
                Console.Write("Status incorreto! Por favor, digite corretamente: ");
                entrada = Console.ReadLine();
            }
            return status;
        }

        static void MostrarStatus()
        {
            Console.Clear();
            
            Console.WriteLine($"Escolha o status atual do pedido: ");
            foreach (OrderStatus values in Enum.GetValues<OrderStatus>())
            {
                Console.WriteLine($"{(int)values} - {values}");
            }
            Console.WriteLine();
           
        }

    }
}