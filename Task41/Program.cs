/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Enter the amount of input numbers: ");
int number = Convert.ToInt32(Console.ReadLine());


int[] EnterNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter number {i} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;

}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length -1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write(" -> ");
}   

int NumbersGreaterThanZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] enterNumbers = EnterNumbers(number);
PrintArray(enterNumbers);
int numbersGreaterThanZero = NumbersGreaterThanZero(enterNumbers);
Console.Write(numbersGreaterThanZero);

