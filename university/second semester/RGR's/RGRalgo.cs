using System.Xml;

namespace RGRalgo
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> balls = new Dictionary<int, string>();
            balls.Add(1, "white");
            balls.Add(2, "white");
            balls.Add(3, "white");
            balls.Add(4, "clear");
            balls.Add(5, "black");
            balls.Add(6, "black");
            balls.Add(7, "black");
            do
            {
                string check = "";
                foreach(var item in balls)
                {
                    if (item.Value == "white")
                    {
                        check = "занята белым";
                    }
                    if (item.Value == "black")
                    {
                        check = "занята чёрным";
                    }
                    if (item.Value == "clear")
                    {
                        check = "пустая";
                    }
                    Console.WriteLine("Лунка " + item.Key + ": " + check);
                }

                if (balls[1] == "black" && balls[2] == "black" && balls[3] == "black" && balls[4] == "clear" && balls[5] == "white" && balls[6] == "white" && balls[7] == "white")
                {
                    Console.WriteLine("Z Z V Z V Z");
                    break;
                }

                Console.WriteLine("Выберите, из какой лунки будете брать шарик: ");
                int lunka1 = Convert.ToInt32(Console.ReadLine());
                while (balls[lunka1] == "clear")
                {
                    Console.WriteLine("Возьмите другую лунку, в этой лунке нет шарика");
                    lunka1 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Выберите, в какую лунку хотите положить шарик: ");
                int lunka = Convert.ToInt32(Console.ReadLine());
                while (balls[lunka] != "clear")
                {
                    Console.WriteLine("Эта лунка занята, возьмите другую");
                    lunka = Convert.ToInt32(Console.ReadLine());
                }

                string peremena = balls[lunka1];
                balls.Remove(lunka1);
                balls.Remove(lunka);
                balls.Add(lunka, peremena);
                balls.Add(lunka1, "clear");

                Console.Clear();

            } while (true);
        }
    }
}