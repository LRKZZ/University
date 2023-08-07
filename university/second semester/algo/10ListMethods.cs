class Program
{
    static void Main(string[] args)
    {
        List<int> massiv = new List<int>();
        do
        {
            Console.WriteLine("1. Ввод списка");
            Console.WriteLine("2. Очистить список");
            Console.WriteLine("3. Проверить наличие элемента в списке");
            Console.WriteLine("4. Удалить элемент по индексу");
            Console.WriteLine("5. Удалить элемент по названию");
            Console.WriteLine("6. Перевернуть лист");
            Console.WriteLine("7. Вывести список");
            Console.WriteLine("8. Отсортировать список по возрастанию");
            Console.WriteLine("9. Ввести элемент по индексу");
            Console.WriteLine("10. Вывести определенное количество элементов с указанного индекса");

            int choice = Convert.ToInt32(Console.ReadLine());
        
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите количество элементов списка: ");
                    int kolvo = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < kolvo; i++)
                    {
                        massiv.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    massiv.Clear();
                    Console.WriteLine("Операция выполнена");
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Введите название элемента: ");
                    int item = Convert.ToInt32(Console.ReadLine());
                    if (massiv.Contains(item))
                    {
                        Console.WriteLine("Элемент есть в списке");
                    }
                    else
                    {
                        Console.WriteLine("Элемент отсутствует");
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите индекс объекта, который необходимо удалить: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    massiv.RemoveAt(index);
                    Console.WriteLine("Операция выполнена. Новый вид листа: ");
                    for (int i = 0; i < massiv.Count; i++)
                    {
                        Console.WriteLine(massiv[i]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Введите объект, который необходимо удалить (если в списке несколько одинаковых элементов, то удаляется только первый из них): ");
                    int object1 = Convert.ToInt32(Console.ReadLine());
                    if (massiv.Remove(object1) == true)
                    {
                        Console.WriteLine("Операция выполнена. Новый вид листа: ");
                        for (int i = 0; i < massiv.Count; i++)
                        {
                            Console.WriteLine(massiv[i]);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет в списке, попробуйте еще раз.");
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();
                    massiv.Reverse();
                    Console.WriteLine("Операция выполнена. Новый вид листа: ");
                    for (int i = 0; i < massiv.Count; i++)
                    {
                        Console.WriteLine(massiv[i]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Список: ");
                    for (int i = 0; i < massiv.Count; i++)
                    {
                        Console.WriteLine(massiv[i]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Отсортированный список: ");
                    massiv.Sort();
                    for (int i = 0; i < massiv.Count; i++)
                    {
                        Console.WriteLine(massiv[i]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Введите индекс, с которого хотите добавить элемент в лист: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите элемент, который хотите добавить в лист: ");
                    object1 = Convert.ToInt32(Console.ReadLine());
                    massiv.Insert(index, object1);
                    Console.WriteLine("Операция выполнена. Новый вид листа: ");
                    for (int i = 0; i < massiv.Count; i++)
                    {
                        Console.WriteLine(massiv[i]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Введите индекс: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество элементов: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Элементы, удовлетворяющие указанным условиям: ");
                    for (int j = 0; j < count; j++)
                    {
                        Console.WriteLine(massiv.GetRange(index, count)[j]);
                    }
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    break;


            }
        } while (true);
    }
}
