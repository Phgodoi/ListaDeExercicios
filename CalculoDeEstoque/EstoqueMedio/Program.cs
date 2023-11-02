using EstoqueMedio.Models;

List<EstoqueProdutos> ListaProdutos = new();

bool exibirMenu = true;

double somaProd = 0;

while (exibirMenu)
{
    Console.WriteLine("\n Selecione uma opçao: ");
    Console.WriteLine("1 - Cadastrar produdo");
    Console.WriteLine("2 - Ver itens cadastrados");
    Console.WriteLine("3 - Somar");
    Console.WriteLine("4 - Encerrar \n");


    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Informe o nome de um produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Informe o valor do produto: ");

            double valorProduto;

            if (double.TryParse(Console.ReadLine(), out valorProduto))
            {
                ListaProdutos.Add(new EstoqueProdutos { Produto = nomeProduto, Valor = valorProduto });
            }
            else
            {
                Console.WriteLine("\nValor inválido. O pdoduto não foi adicionado!");
            }
        break;
            case "2":
            if (ListaProdutos.Any())
            {
                Console.WriteLine("\nOs produtos na lista são: ");
                foreach (var item in ListaProdutos)
                {
                   

                    Console.WriteLine($"{item.Produto} - {item.Valor:C}");
                }
            }

            break;

        case "3":   
            foreach (var item in ListaProdutos)
            {
                somaProd += item.Valor;
                
            }
            Console.WriteLine($"\nSua lista possui {ListaProdutos.Count} produtos e a soma total é: {somaProd:C}. ");
        break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. verifique!");
        break;
    }
}


double valorMedio = somaProd / ListaProdutos.Count;

Console.WriteLine($"\nO valor total da sua lista é : {somaProd:C}, e o valor médio é: {valorMedio:C}");