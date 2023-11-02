using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConversorDeMoedas.Models
{
    public class Moedas
    {
        public double ValorEmMoeda { get; set; }
        public double TaxaDeCambioDolar { get; set; }

        public void CalcularValorConvertido()
        {
            if (TaxaDeCambioDolar == 0)
            {
                Console.WriteLine("A taxa de câmbio do dólar não pode ser zero. Verifique o valor da taxa.");
                return;
            }

            double valorConvertido = ValorEmMoeda / TaxaDeCambioDolar;

            Console.WriteLine($"O valor de {ValorEmMoeda:C} convertido em Dolar é: {valorConvertido.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}

