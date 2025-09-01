// Crie um programa que peça preços de produtos até que o usuário digite 0.
// Ao final, mostre o valor acumulado da compra.
bool escolha = true;

do
{
    Console.WriteLine("Enter the price of a product. If there are multiple products, separate each price with a space.");
    Console.WriteLine("To exit, enter 0 after the prices, or at the beginning if you do not wish to continue.");
    Console.Write("---> ");
    string[] productPrice = Console.ReadLine().Split(' ');
    double totalValue = 0.0;
    int productCounter = 0;

    for (int i = 0; i < productPrice.Length; i++)
    {
        totalValue += Convert.ToDouble(productPrice[i]);

        if (productPrice[i] == "0")
        {
            escolha = false;
        }
        else
        {
            productCounter++;
        }
    }

    if (totalValue > 0.0)
    {   
        double average = totalValue / productPrice.Length;
        Console.WriteLine($"\nThe total value is ${totalValue:F2}, with an average of ${average:F2} per product, based on {productCounter} product(s) registered.\n");
    }
    else
    {
        Console.WriteLine("\nYou chose to exit without entering any values.");
        Console.ReadKey();
    }
} while (escolha);