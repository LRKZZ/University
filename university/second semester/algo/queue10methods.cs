class Program
{
    
    public static void Main(string[] args)
    {
        Queue<string> massiv = new Queue<string>();
        Queue<string> massiv1 = new Queue<string>();

        do
        {
            Console.WriteLine("1. Заполнить очередь");
            Console.WriteLine("2. Очистить очередь");
            Console.WriteLine("3. Вывести очередь на экран");
            Console.WriteLine("4. Проверить, есть ли введённый элемент в очереди");
            Console.WriteLine("5. Вывести первый элемент из очереди на экран");
            Console.WriteLine("6. Ввести элемент в конец очереди");
            Console.WriteLine("7. Удалить первый элемент очереди");
            Console.WriteLine("8. Заполнить ещё одну очередь");







            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите количество объектов, которые вы хотите ввести: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Введите объект");
                        massiv.Enqueue(Console.ReadLine());
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    massiv.Clear();
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ваша очередь: ");
                    foreach (var v in massiv)
                    {
                        Console.WriteLine(v);
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите объект, который вы хотите проверить на наличие: ");
                    if (massiv.Contains(Console.ReadLine())) {
                        Console.WriteLine("Данный объект присутствует в очереди");
                    }
                    else
                    {
                        Console.WriteLine("Данный объект отсутствует в очереди");
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    string check = massiv.Peek();
                    Console.WriteLine("Первый элемент очереди: ");
                    Console.WriteLine(check);
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Введите объект, который вы хотите добавить в очередь: ");
                    massiv.Enqueue(Console.ReadLine());
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    massiv.Dequeue();
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Введите количество объектов, которые вы хотите ввести: ");
                    count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Введите объект");
                        massiv1.Enqueue(Console.ReadLine());
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;







            }
        } while (true);
    }
}