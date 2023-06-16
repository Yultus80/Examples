int Max(int arg1, int arg2, int arg3)    //сравнения по трем числам
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4
int[] array = { 11, 12, 53, 44, 52, 62, 27, 84, 19 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

/*int max = Max(
    Max(array, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);*/
