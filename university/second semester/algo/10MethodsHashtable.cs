using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable massiv = new Hashtable();
        do
        {
            Console.WriteLine("1. Заполнить словарь");
            Console.WriteLine("2. Очистить словарь");
            Console.WriteLine("3. Проверить, содержится ли указанный ключ в словаре");
            Console.WriteLine("4. Добавить пару в словарь");
            Console.WriteLine("5. Удалить указанный ключ с объектом");
            Console.WriteLine("6. Проверить, содержится ли указанный объект в словаре");
            Console.WriteLine("7. Вывести все ключи");
            Console.WriteLine("8. Вывести все значения");
            Console.WriteLine("9. Вывести на экран словарь");
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
                    ICollection C = massiv.Keys;
                    string output = "";
                    foreach(var str in C)
                    {
                        output += Convert.ToString(str) + '\n';
                    }
                    Console.WriteLine(output);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    ICollection D = massiv.Values;
                    string output1 = "";
                    foreach (var str in D)
                    {
                        output1 += Convert.ToString(str) + '\n';
                    }
                    Console.WriteLine(output1);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    ICollection A = massiv.Keys;
                    string a = "";
                    foreach (var str in A)
                    {
                        a += str + ":" + massiv[str] + "\n";
                    }
                    Console.WriteLine(a);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (true);
    }
}
