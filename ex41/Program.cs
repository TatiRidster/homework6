// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int PositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}
Console.Write("Введите числа через запятую: ");
int[] array = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray(); //Данный способ ввода массива с лекции про то, как писать код
Console.WriteLine(PositiveNumbers(array));
