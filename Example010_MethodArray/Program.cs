int[] array = { 14, 12, 31, 45, 18, 15, 16, 17, 18 };

int n = array.Length;  //показать какой номер в массиве у определенного числа
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;  //остановит выполнение программы
    }
    index++;

}
