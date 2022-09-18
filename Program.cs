// See https://aka.ms/new-console-template for more information

//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...].

int[] numbers = { 1, 5, 7, 9, 11, 13, 17, 19, 23, 29 };

void StampaArray(int[] array, char openP = '[', char closedP = ']')
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

//restituisca il quadrato del numero passato come parametro.

Console.WriteLine("Digita un numero");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quadrato(int numero)
{
    return (numero * numero);
}

int powerNumber = Quadrato(userNumber);
Console.WriteLine($"La potenza del numero scelto è: {powerNumber}");

//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!

int[] arrayNumbers = { 6, 12, 25, 34, 69 };

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = (int[])array.Clone();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] *= newArray[i];
    }

    return newArray;
}

void StampaArray(int[] array, char openP = '[', char closedP = ']')
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


int[] result = ElevaArrayAlQuadrato(arrayNumbers);

StampaArray(arrayNumbers);
StampaArray(result);

//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int[] groupNumber = { 4, 7, 9, 15, 20, 33 };

int sommaElementiArray(int[] array)
{
    int total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        total += array[i];
    }

    return total;
}

int totalNumber = sommaElementiArray(groupNumber);

Console.WriteLine(totalNumber);

Task 2
//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...].

int[] groupNumber = { 2, 6, 7, 5, 3, 9 };

void StampaArray(int[] array, char openP = '[', char closedP = ']')
{
    Console.Write(openP);

    int i;

    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }

    Console.Write(array[i]);
    Console.WriteLine(closedP);
}

Console.WriteLine("L'array stampato è il seguente:");
StampaArray(groupNumber);

//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = (int[])array.Clone();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] *= newArray[i];
    }

    return newArray;
}

int[] result = ElevaArrayAlQuadrato(groupNumber);

Console.WriteLine("La potenza di ogni singolo numero dentro l'array è:");
StampaArray(result);

Console.WriteLine("Ristampiamo l'array per verificare che non sia mutato:");
StampaArray(groupNumber);

//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        total += array[i];
    }

    return total;
}

int totalNumber = sommaElementiArray(groupNumber);

Console.WriteLine("La somma di tutti i numeri presenti dentro l'array è:");
Console.WriteLine(totalNumber);

int sommaPowerArray(int[] array)
{
    int total = 0;

    for (int i = 0; i < array.Length; i++)
    {
        total += array[i];
    }

    return total;
}

int totalPowerNumber = sommaPowerArray(result);

Console.WriteLine("La somma di tutti i numeri presenti dentro l'array, elevati al quadrato, è:");
Console.WriteLine(totalPowerNumber);