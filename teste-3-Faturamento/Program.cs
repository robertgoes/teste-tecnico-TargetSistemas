using System;
using Newtonsoft.Json;
using teste_3_Faturamento.Models;

/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, 
na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
*/

var conteudoArquivo = File.ReadAllText("dados.json");

//Desserializar o vetor enviado, para uma lista de objetos do tipo Faturamento
List<Faturamento> listaFaturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(conteudoArquivo);


//Declarei uma lista, para armazenar apenas os valores de faturamento
List<decimal> listaDeValores = new List<decimal>();

foreach (var faturamento in listaFaturamentos)
{
    listaDeValores.Add(faturamento.Valor);
}

listaDeValores.RemoveAll(item => item == 0);

listaDeValores.Sort();

var itemFaturamento = CalcularMenorFaturamento(listaFaturamentos);
Console.WriteLine($"Menor faturamento no mês: Dia {itemFaturamento.Dia} - Valor {itemFaturamento.Valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");

itemFaturamento = CalcularMaiorFaturamento(listaFaturamentos);
Console.WriteLine($"Maior faturamento no mês: Dia {itemFaturamento.Dia} - Valor {itemFaturamento.Valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");

var quantidadeDeDiasSuperioresMediaMensal = CalcularDiasSuperioresMediaMensal(listaFaturamentos);
Console.WriteLine($"Quantidade de dias no mês em que o valor do faturamento diário foi superior à média mensal: {quantidadeDeDiasSuperioresMediaMensal}");

int CalcularDiasSuperioresMediaMensal(List<Faturamento> _listaFaturamentos)
{
    int quantidadeDias = 0;
    var mediaFaturamento = listaDeValores.Average();

    _listaFaturamentos.ForEach(delegate (Faturamento item)
    {
        if (item.Valor > mediaFaturamento)
            quantidadeDias++;
    });

    return quantidadeDias;
}

Faturamento CalcularMaiorFaturamento(List<Faturamento> _listaFaturamentos)
{
    Faturamento maiorFaturamento = new Faturamento();
    
    //Localizar na minha lista de faturamento, um objeto com o valor igual ao menor valor da listaDeValores
    foreach (var faturamento in _listaFaturamentos)
    {
        if (faturamento.Valor == listaDeValores.Max())
        {
            maiorFaturamento = faturamento;
        }
    }
    return maiorFaturamento;
}

Faturamento CalcularMenorFaturamento(List<Faturamento> _listaFaturamentos)
{
    Faturamento menorFaturamento = new Faturamento();

    //Localizar na minha lista de faturamento, um objeto com o valor igual ao menor valor da listaDeValores
    foreach (var faturamento in _listaFaturamentos)
    {
        if(faturamento.Valor == listaDeValores[0])
        {
            menorFaturamento = faturamento;
        }
    }
    return menorFaturamento;
}