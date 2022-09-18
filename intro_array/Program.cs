int Max(int arg1, int arg2, int arg3)   //методы(функции)
{
    int result = arg1;                  //если будет ошибка
    if(arg2 > result) result = arg2;    //то ее править нужно
    if(arg3 > result) result = arg3;    //в ондом месте, а не 
    return result;                      // по всему коду
}
     //индекс  0  1  2  3  4  5  6  7  8
int[] array = {2, 5, 7, 3, 8, 3, 7, 4, 100};


int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);