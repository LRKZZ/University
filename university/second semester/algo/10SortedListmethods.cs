public class Program
{
    public static void Main()
    {
        SortedList<string, string> massiv = new SortedList<string, string>();
        Console.Clear();
        do
        {
            Console.WriteLine("1. Заполнить SL");
            Console.WriteLine("2. Очистить словарь");
            Console.WriteLine("3. Проверить, содержится ли указанный ключ в словаре");
            Console.WriteLine("4. Добавить пару в словарь");
            Console.WriteLine("5. Удалить указанный ключ с объектом");
            Console.WriteLine("6. Проверить, содержится ли указанный объект в словаре");
            Console.WriteLine("7. Найти индекс введённого ключа");
            Console.WriteLine("8. Найти индекс введённого значения");
            Console.WriteLine("9. Вывести на экран SL");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите количество пар для ввода: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Введите ключ и значение: ");
                        massiv.Add(Console.ReadLine(), Console.ReadLine());

                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    massiv.Clear();
                    Console.WriteLine("Операция выполнена, словарь пуст");
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Введите ключ, который необходимо проверить: ");
                    if (massiv.ContainsKey(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("Ключ присутствует");
                    }
                    else
                    {
                        Console.WriteLine("Ключ отсутствует");
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите ключ и значение: ");
                    massiv.Add(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Введите ключ, который необходимо удалить");
                    massiv.Remove(Console.ReadLine());
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Введите ключ, который необходимо проверить: ");
                    if (massiv.ContainsValue(Console.ReadLine()) == true)
                    {
                        Console.WriteLine("Объект присутствует");
                    }
                    else
                    {
                        Console.WriteLine("Объект отсутствует");
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Введите ключ: ");
                    int index = massiv.IndexOfKey(Console.ReadLine());
                    Console.WriteLine("Индекс ключа (если -1, значит, такого ключа нет): " + index);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Введите значение: ");
                    index = massiv.IndexOfValue(Console.ReadLine());
                    Console.WriteLine("Индекс значения (если -1, значит, такого значения нет): " + index);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    foreach (var item in massiv)
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (true);
    }
}