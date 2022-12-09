/*
1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);

Ao final do processamento, qual será o valor da variável SOMA?
*/

using System;

int indice = 13;
int soma = 0;
int k = 0;

while (k < indice)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine($"Valor final variável soma: {soma}");

/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma 
dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na 
linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne 
uma mensagem avisando se o número informado pertence ou não a sequência.
*/

Console.WriteLine("\r\n");
Console.WriteLine("Qual número você deseja consultar na sequência de Fibonacci:");

int numeroUsuario = int.Parse(Console.ReadLine());

int indiceUltimoElemento = 1;
int indicePenultimoElemento = 0;

var sequencia = new List<int> {1, 1};

while (sequencia.Count < numeroUsuario)
{
    int proximoElemento = sequencia[indicePenultimoElemento] + sequencia[indiceUltimoElemento];

    sequencia.Add(proximoElemento);

    indicePenultimoElemento++;
    indiceUltimoElemento++;
}

bool temNaSequencia = false;

foreach (var item in sequencia)
{
    Console.WriteLine(item);
    if(numeroUsuario == item)
    {
        temNaSequencia = true;
        break;
    }
}

if(temNaSequencia == true)
{
    Console.WriteLine($"O número {numeroUsuario} está na sequência de Fibonacci");
}
else
{
    Console.WriteLine($"O número {numeroUsuario} não está na sequência");
}