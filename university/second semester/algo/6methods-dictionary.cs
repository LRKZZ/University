class program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> newDictionary= new Dictionary<string, string>();
        do
        {
            Console.WriteLine("1. Заполнить словарь");
            Console.WriteLine("2. Очистить словарь");
            Console.WriteLine("3. Проверить наличие ключа");
            Console.WriteLine("4. Проверить наличие объекта");
            Console.WriteLine("5. Удалить пару по вводу ключа");
            Console.WriteLine("6. Вывести словарь на экран");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите кол-во элементов: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    int schetchik = 1;
                    Console.WriteLine("Введите через Enter ключ, а после значение: ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(schetchik);
                        schetchik++;
                        newDictionary.Add(Console.ReadLine(), Console.ReadLine());
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    newDictionary.Clear();
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Введите ключ, наличие которого вы хотите проверить: ");
                    string key = Console.ReadLine();
                    if (newDictionary.ContainsKey(key) == true)
                    {
                        Console.WriteLine("Ключ содержится");
                    }
                    else
                    {
                        Console.WriteLine("Такого ключа нет");
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите объект, наличие которого вы хотите проверить: ");
                    string value = Console.ReadLine();
                    if (newDictionary.ContainsValue(value) == true)
                    {
                        Console.WriteLine("Объект содержится");
                    }
                    else
                    {
                        Console.WriteLine("Такого объекта нет");
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Введите ключ, пару которого вы хотите удалить: ");
                    key = Console.ReadLine();
                    newDictionary.Remove(key);
                    Console.WriteLine("Операция выполнена. Новый вид словаря: ");
                    foreach(var item in newDictionary)
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    foreach (var item in newDictionary)
                    {
                        Console.WriteLine(item.Key + " " + item.Value);
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }


        } while (true);
    }
}
