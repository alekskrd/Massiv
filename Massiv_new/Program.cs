void FilllArray(int[] collection)
{
    int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = new Random().Next(1, 10);
            index++;
        }
}

void PrintArray(int[] col)    //void ничего не возврашает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];

FilllArray (array);
PrintArray(array);
    
