namespace ConsoleApp12
{


    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();
            do
            {
                Console.WriteLine("1. Добавить элементы");
                Console.WriteLine("2. Очистить");
                Console.WriteLine("3. Удалить элемент");
                Console.WriteLine("4. Вывести на экран");
                Console.WriteLine("5. Проверить, содержится ли элемент");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите, сколько элементов вы хотите добавить: ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            hs.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        hs.Clear();
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите элемент, который хотите удалить: ");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        hs.Remove(delete);
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        foreach (var item in hs)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Введите элемент, который хотите проверить: ");
                        int check = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(hs.Contains(check));
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}