using ConversorDeMoedas.Models;

Moedas moeda = new();

Console.WriteLine("Informe o valor em R$ que deseja converter ");
moeda.ValorEmMoeda = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a taxa de câmbio atual. ");
moeda.TaxaDeCambioDolar = Convert.ToDouble(Console.ReadLine());

moeda.CalcularValorConvertido();


