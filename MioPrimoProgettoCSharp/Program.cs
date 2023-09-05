// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ciao utente!");
Console.WriteLine("Come ti chiami?");

var nome = Console.ReadLine();

Console.WriteLine("Benvenuto " + nome + ", piacere di conoscerti!");

int[] numeriEstratti = { 5, 10, 18, 90, 83, 27 };

Console.WriteLine("I numeri della lotteria estratti sono: ");

for(int i = 0; i < numeriEstratti.Length; i++)
{
	Console.Write(numeriEstratti[i]);
	if (numeriEstratti[i] % 2 == 0)
	{
		Console.WriteLine(" - pari");
	}else
	{
		Console.WriteLine(" - dispari");
	}
}

Console.WriteLine("Alla prossima giocata!");
