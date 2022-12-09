using System;
using teste_4_Percentual.Models;

/*
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada 
estado teve dentro do valor total mensal da distribuidora.
*/

Estado sp = new Estado("SP", 67836.43);
Estado rj = new Estado("RJ", 36678.66);
Estado mg = new Estado("MG", 29229.88);
Estado es = new Estado("ES", 27165.48);
Estado outros = new Estado("OUTROS", 19849.53);

List<Estado> estados = new List<Estado>();

estados.Add(sp);
estados.Add(rj);
estados.Add(mg);
estados.Add(es);
estados.Add(outros);

double valorTotalMensal = 0;
//Foreach para calcular o valor total mensal
estados.ForEach(delegate (Estado item)
{
    valorTotalMensal += item.Valor;
});

Console.WriteLine("SP - " + CalcularPercentualTotalMensal(sp, valorTotalMensal).ToString("N2") + "%");
Console.WriteLine("RJ - " + CalcularPercentualTotalMensal(rj, valorTotalMensal).ToString("N2") + "%");
Console.WriteLine("MG - " + CalcularPercentualTotalMensal(mg, valorTotalMensal).ToString("N2") + "%");
Console.WriteLine("ES - " + CalcularPercentualTotalMensal(es, valorTotalMensal).ToString("N2") + "%");
Console.WriteLine("OUTROS - " + CalcularPercentualTotalMensal(outros, valorTotalMensal).ToString("N2") + "%");

double CalcularPercentualTotalMensal(Estado _estado, double _valorTotalMensal)
{
    var estado = _estado;
    var totalMensal = _valorTotalMensal;

    return (estado.Valor / totalMensal) * 100;
}