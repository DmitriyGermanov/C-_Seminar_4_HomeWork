/*
 * Дан массив и число. Найдите три числа в массиве сумма 
    которых равна искомому числу. Подсказка: если взять 
    первое число в массиве, можно ли найти в оставшейся его
    части два числа равных по сумме первому.
*/

using HomeWork;

internal class Program
{
    private static void Main(string[] args)
    {
        FindSummOfNum findNumm = new();
        int[] array = { 1, 2, 5, 7, 3, 4, 2 };
        int num = 11;
        var result = findNumm.FindNumbers(array, num);
        if (result != null)
            Console.WriteLine($"Позиция элементов в массиве: {result.ToString()}");
        else
            Console.WriteLine("Комбинация чисел не найдена");
    }
}