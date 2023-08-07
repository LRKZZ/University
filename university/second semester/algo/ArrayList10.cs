using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList massiv = new ArrayList();
        ArrayList Constmassiv = new ArrayList();
        do
        {
            Console.WriteLine("1. Заполнить лист");
            Console.WriteLine("2. Перевернуть лист");
            Console.WriteLine("3. Вывести определенный интервал элементов из списка");
            Console.WriteLine("4. Удалить элемент по индексу");
            Console.WriteLine("5. Определить индекс введённого объекта");
            Console.WriteLine("6. Ввод элемента с определённого индекса");
            Console.WriteLine("7. Проверить, содержится ли введённый объект в листе");
            Console.WriteLine("8. Очистить лист");
            Console.WriteLine("9. Отсортировать лист по возрастанию");
            Console.WriteLine("10. Вывести лист");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите количество элементов: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        int zz = Convert.ToInt32(Console.ReadLine());
                        massiv.Insert(i, zz);
                        Constmassiv.Insert(i, zz);
                    }
                    Constmassiv = massiv;
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    massiv.Reverse();
                    for (int j = 0; j < massiv.Count; j++)
                    {
                        Console.WriteLine(massiv[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 10:
                    Console.Clear();
                    for (int j = 0; j < massiv.Count; j++)
                    {
                        Console.WriteLine(massiv[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Введите индекс: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов после индекса: ");
                    int kolvo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Элементы, удовлетворяющие указанным условиям: ");
                    for (int j = 0; j < kolvo; j++)
                    {
                        Console.WriteLine(massiv.GetRange(index, kolvo)[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите индекс элемента, который необходимо удалить");
                    index = Convert.ToInt32(Console.ReadLine());
                    massiv.RemoveAt(index);
                    Console.WriteLine("Операция выполнена. Новый вид листа: ");
                    for (int j = 0; j < massiv.Count; j++)
                    {
                        Console.WriteLine(massiv[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Введите, что необходимо найти: ");
                    int object1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Индекс необходимого элемента: ");
                    index = massiv.LastIndexOf(object1);
                    Console.WriteLine(index);

                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Введите индекс, с которого ввести элемент: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число, которое необходимо ввести: ");
                    object1 = Convert.ToInt32(Console.ReadLine());
                    massiv.Insert(index, object1);
                    Console.WriteLine("Операция выполнена. Новый лист: ");
                    for (int j = 0; j < massiv.Count; j++)
                    {
                        Console.WriteLine(massiv[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    for (int j = 0; j < massiv.Count; j++)
                    {
                        Console.WriteLine(massiv[j]);
                    }
                    Console.WriteLine("Введите, что необходимо найти: ");
                    object1 = Convert.ToInt32(Console.ReadLine());
                    if (massiv.Contains(object1))
                    {
                        Console.WriteLine("Элемент содержится");
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет");
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    massiv.Clear();
                    Console.WriteLine("Операция выполнена");
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    massiv.Sort();
                    Console.WriteLine("Операция выполнена");
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (true);
    }
}
