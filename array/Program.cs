int[] array = {2, 5, 100, 3, 8, 3, 7, 4, 100};

int n = array.Length;
int find = 100;               

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                      //для того чтобы не показывала два индекса
    }
    index++;
}