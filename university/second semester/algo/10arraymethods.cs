using System.CodeDom.Compiler;
using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] massiv = new int[n];
        Console.Clear();
        do
        {
        Console.WriteLine("1. Заполнить одномерный массив");
        Console.WriteLine("2. Очистить определённые элементы массива");
        Console.WriteLine("3. Вывести массив на экран");
        Console.WriteLine("4. Найти введённый элемент");
        Console.WriteLine("5. Перевернуть массив");
        Console.WriteLine("6. Перевернуть указанный интервал массива");
        Console.WriteLine("7. Увеличить количество элементов массива");
        Console.WriteLine("8. Отсортировать массив по возрастанию");
        Console.WriteLine("9. Изменить указанный элемент по индексу");
        int choice = Convert.ToInt32(Console.ReadLine());

        
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Заполните массив. Количество элементов массива: " + n);
                    for (int i = 0; i < n; i++)
                    {
                        massiv[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Введите индекс, с которого нужно удалить");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов, которые необходимо удалить");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Array.Clear(massiv, index, length);
                    Console.WriteLine("Операция выполнена. Новый массив: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ваш массив: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите объект, который необходимо найти: ");
                    int object1 = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Индекс введённого элемента (если -1, значит, такого элемента нет): " + Array.IndexOf(massiv, object1));
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Array.Reverse(massiv);
                    Console.WriteLine("Операция выполнена. Новый вид массива: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Введите индекс, с которого нужно перевернуть массив: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов: ");
                    object1 = Convert.ToInt32(Console.ReadLine());
                    Array.Reverse(massiv, index, object1);
                    Console.WriteLine("Операция выполнена. Новый вид массива: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Введите новое количество элементов массива: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Array.Resize<int>(ref massiv, n);
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    Array.Sort(massiv);
                    Console.WriteLine("Операция выполнена. Новый вид массива: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Введите индекс элемента, который нужно заменить: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите элемент, который нужно вставить: ");
                    object1 = Convert.ToInt32(Console.ReadLine());
                    massiv.SetValue(object1, index);
                    Console.WriteLine("Операция выполнена. Новый вид массива: ");
                    Print(massiv);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;







            }

        } while (true);

    }
    public static void Print(int[] massiv)
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine(massiv[i]);
        }
    }
}
