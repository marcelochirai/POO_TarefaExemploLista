using System;
using System.Collections.Generic;

//Exercício para fixação de conceito e elementos de uma lista
namespace POO_TarefaExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista de Strings
            List<string> list = new List<string>();

            //Uso do Add - Adição de elementos sequencialmente
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Wellington");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("André");

            //Uso do Insert - Adição de elementos na posição indicada
            list.Insert(2, "Lucas");

            //Faz a busca dos elementos na lista e os exibe
            Console.WriteLine("Lista após a inserção do nome Lucas na Posição 2:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Uso do Count - Exibe a quantidade de elementos na lista
            Console.WriteLine("Quantidade de elementos na Lista: " + list.Count);

            //Uso do Find - Busca elementos conforme parâmetros / predicados
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);

            //Uso do FindLast - Busca o último elemento conforme parâmetros / predicados
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("O último elemento que começa com a letra A: " + s2);

            //Uso do FindIndex - Busca por índice / primeira posição do elemento conforme parâmetros / predicados
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de A: " + pos1);

            //Uso do FindLastIndex - Busca pelo índice / posição do último elemento com predicado informado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição de A: " + pos2);

            //Criação de uma segunda lista com os elementos encontrados
            //Uso do FindAll - Busca por elementos com quantidade de elementos informado
            List<string> list2 = list.FindAll(x => x.Length == 5);

            //Divisão de caracteres
            Console.WriteLine("------------------------------");

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Uso do Remove - Remoção do elemento especificado
            list.Remove("Eliney");

            //Divisão de caracteres
            Console.WriteLine("===============================");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Uso do RemoveAll - Remoção de todos os elementos especificados
            list.RemoveAll(x => x[0] == 'W');

            //Divisão de caracteres
            Console.WriteLine("+++++++++++++++++++++++++++++++");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Uso do RemoveAtt - Remoção do elemento conforme sua posição
            list.RemoveAt(3);

            //Divisão de caracteres
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Uso do RemoveRange - Remoção de elementos a partir de uma posição até outra
            list.RemoveRange(1, 2);

            //Divisão de caracteres
            Console.WriteLine("________________________________");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
