void FillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random ().Next (1,10);
        index ++;
    }
}

void PrintArray (int [] col)
{
    int count = col.Length;
    int pisition = 0;
    while (pisition < count)
    {
        Console.WriteLine (col [pisition]);
        pisition ++;
    }
}
int IndexOf (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pisition = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            pisition = index;
            break;
        }
        index ++;
    }
    return pisition;
}

int [] array = new int [10];


FillArray (array);
PrintArray (array);
Console.WriteLine ();
int pos = IndexOf (array, 84);
Console.WriteLine (pos);
