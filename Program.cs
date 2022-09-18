// See https://aka.ms/new-console-template for more information

//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...].

int[] numbers = { 1, 5, 7, 9, 11, 13, 17, 19, 23, 29 };

void StampaArray(int[] array, char openP ='[', char closedP =']')
{
	Console.Write(openP);

	int i;

	for (i = 0; i < array.Length - 1; i++)
	{
		Console.Write(array[i]);
        Console.Write(", ");
    }

    Console.Write(array[i]);
    Console.Write(closedP);
}

StampaArray(numbers);