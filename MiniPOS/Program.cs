// Versão simples: Programa que solicita ao usuário os preços de três produtos e exibe o valor total da compra e o preço médio por item.

Console.WriteLine("Informe o preço dos produtos separados por espaço.");
string[] productPrice = Console.ReadLine().Split(' ');
double sum = 0.0;

for(int i = 0;i< productPrice.Length; i++)
{
    sum += Convert.ToDouble(productPrice[i]);
}

double average = sum / productPrice.Length;

Console.WriteLine($"O valor total é: R$ {sum:F2}, assim, o preço médio por item é R$ {average:F2}");