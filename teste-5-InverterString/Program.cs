using System;

Console.WriteLine("Informe uma palavra que deseja inverter:");
string palavra = Console.ReadLine();

//Stack ou pilha, é uma estrutura de dados do tipo LIFO(Last In, First Out)
Stack<char> pilhaPalavra = new Stack<char>(palavra);

//Conseguimos passar o conteúdo de uma pilha para um array
var palavraInvertida = pilhaPalavra.ToArray();

string palavraNova = new String(palavraInvertida);

Console.WriteLine(palavraNova);