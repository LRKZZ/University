class Program
{
    static public void Main(string[] args)
    {
        Stack<string> my_stack = new Stack<string>();
        do
        {
            Console.WriteLine("1. Заполнить stack ");
            Console.WriteLine("2. Вывести stack на экран");
            Console.WriteLine("3. Очистить stack");
            Console.WriteLine("4. Вывести первый элемент на экран");
            Console.WriteLine("5. Проверить наличие введённого элемента");
            Console.WriteLine("6. Удалить первый элемент");
            Console.WriteLine("7. Вставить объект как верхний элемент стека Stack.");
            Console.WriteLine("8. Перевернуть Stack");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите, сколько значений вы хотите ввести в stack: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        my_stack.Push(Console.ReadLine());
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    foreach (var item in my_stack)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    my_stack.Clear();
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    string first = my_stack.Peek();
                    Console.WriteLine(first);
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Введите элемент, который хотите проверить: ");
                    string check = Console.ReadLine();
                    Console.WriteLine(my_stack.Contains(check));
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    my_stack.Pop();
                    Console.WriteLine("Операция выполнена. Новый вид stack'а: ");
                    foreach (var item in my_stack)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Введите элемент: ");
                    string add = Console.ReadLine();
                    my_stack.Push(add);
                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    my_stack.Reverse();
                    Console.WriteLine("Операция выполнена. Новый вид stack'а: ");
                    foreach (var item in my_stack)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (true);
    }
}
