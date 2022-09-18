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


int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;       //если элемента появится значение -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FilllArray (array);
array[4] = 4;               //принудительно добвили 4
array[6] = 4;               //чтобы посмореть как работает break

PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
System.Console.WriteLine(pos);
    
