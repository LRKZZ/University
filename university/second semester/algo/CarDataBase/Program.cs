using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace cars
{
    class Program
    {
        static public void Main(string[] args)
        {
            Owner owner = new Owner();
            Car car = new Car();
            var list = new List<Owner>();
            var list1owner = new List<string>();
            var listmarks = new List<string>();
            var listyoc = new List<int>();
            var listcolor = new List<string>();
            

            do
            {
                
                Console.Clear();
                Console.WriteLine("1. Ввод");
                Console.WriteLine("2. Выборка машин с одним владельцем");
                Console.WriteLine("3. Выборка машин моложе заданного года");
                Console.WriteLine("4. Выборка машин с заданной маркой");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Сколько будет введено машин? ");
                        int countcars = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < countcars; i++)
                        {
                            Console.WriteLine("Введите марку машины: ");
                            car.mark = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска: ");
                            car.year_of_create = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите цвет машины: ");
                            car.color = Console.ReadLine();
                            Console.WriteLine("Введите количество владельцев: ");
                            int owners = Convert.ToInt32(Console.ReadLine());
                            listmarks.Add(car.mark);
                            listyoc.Add(car.year_of_create);
                            listcolor.Add(car.color);

                            if (owners == 1)
                            {
                                list1owner.Add(car.mark);
                            }
                            for (int j = 0; j < owners; j++)
                            {
                                Console.WriteLine("Введите ФИО, год покупки и год продажи через Enter");
                                list.Add(new Owner
                                {
                                    first_last_name = Console.ReadLine(),
                                    year_of_buy = Convert.ToInt32(Console.ReadLine()),
                                    year_of_sell = Convert.ToInt32(Console.ReadLine())

                                });
                            }

                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить.");
                        Console.ReadKey();
                        break;




                    case 2:
                        Console.Clear();
                        foreach (var item in list1owner)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите год, машины младше которого необходимо найти: ");
                        int yearcheck = Convert.ToInt32(Console.ReadLine());
                        int leng = listyoc.Count();
                        for (int i = 0; i < leng; i++)
                        {
                            if (listyoc[i] < yearcheck)
                            {
                                Console.WriteLine(listmarks[i]);
                            }
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите марку: ");
                        string checkmark = Convert.ToString(Console.ReadLine());
                        leng = listmarks.Count();
                        for (int i = 0; i < leng; i++)
                        {
                            if (checkmark == listmarks[i])
                            {
                                Console.WriteLine("Марка: " + listmarks[i]);
                                Console.WriteLine("Цвет: " + listcolor[i]);
                                Console.WriteLine("Год выпуска: " + listyoc[i]);

                            }
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить.");
                        Console.ReadKey();
                        break;



                }
            } while (true);
            



        }
    }

}
