using Tortiki;

namespace Tortiki
{
    public class Programm
    {


        public static Pirog checkMenu(int pose, Pirog pirojoke)
        {
            Dictionary<string, int> l1 = new Dictionary<string, int> { { "Элипсоидный", 11111111 }, { "Прабола", 22222222 }, { "Гипербола", 3333333 } };
            Dictionary<string, int> l2 = new Dictionary<string, int> { { "3000 см", 3000 }, { "-11111 см", 7621 }, { "30 см", 9028 } };
            Dictionary<string, int> l3 = new Dictionary<string, int> { { "Клубника", 500 }, { "Шоколад", 400 }, { "Ваниль", 450 } };
            Dictionary<string, int> l4 = new Dictionary<string, int> { { "Розовая", 500 }, { "Чёрная", 500 }, { "Жёлтая", 500 } };
            Dictionary<string, int> l5 = new Dictionary<string, int> { { "Звёздочки", 100 }, { "Квадратики", 100 } };
            switch (pose)
            {
                case 2:
                    Console.Clear();
                    pirojoke = spawnForm(pirojoke, l1, pose);

                    break;
                case 3:
                    Console.Clear();
                    pirojoke = spawnForm(pirojoke, l2, pose);
                    break;
                case 4:
                    Console.Clear();
                    pirojoke = spawnForm(pirojoke, l3, pose);
                    break;
                case 5:
                    pirojoke = colichestvo(pirojoke);
                    break;
                case 6:
                    Console.Clear();
                    pirojoke = spawnForm(pirojoke, l4, pose);
                    break;
                case 7:
                    Console.Clear();
                    pirojoke = spawnForm(pirojoke, l5, pose);
                    break;
                case 8:
                    pirojoke = printCheck(pirojoke);
                    break;

            }
            return pirojoke;
        }

        public static Pirog spawnForm(Pirog pirojoke, Dictionary<string, int> form, int myPose)
        {
            int pose = 2;
            int lastPose = form.Count() + 1;
            int rasn = lastPose - pose;
            var keys = form.Keys;
            Dictionary<int, Dictionary<string, int>> price = new Dictionary<int, Dictionary<string, int>>();
            int count = 2;



            foreach (string zn in keys)
            {

                price.Add(count, new Dictionary<string, int> { { zn, form[zn] } });
                count++;
            }



            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += rasn;
                    }
                    else
                    {
                        pose--;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {

                    if (pose >= lastPose)
                    {
                        pose -= rasn;
                    }
                    else
                    {
                        pose++;
                    }

                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    var f1 = price[pose];
                    string key1 = "";
                    foreach (var i in f1.Keys)
                    {
                        key1 = i;
                    }

                    switch (myPose)
                    {
                        case 2:
                            if (pirojoke.form != "")
                            {

                                pirojoke.price -= form[pirojoke.form];
                                pirojoke.price += f1[key1];
                                pirojoke.form = key1;
                            }
                            else if (pirojoke.form == "")
                            {
                                pirojoke.price += f1[key1];
                                pirojoke.form = key1;
                            }
                            break;
                        case 3:
                            if (pirojoke.size != "")
                            {

                                pirojoke.price -= form[pirojoke.size];
                                pirojoke.price += f1[key1];
                                pirojoke.size = key1;
                            }
                            else
                            {
                                pirojoke.price += f1[key1];
                                pirojoke.size = key1;
                            }
                            break;
                        case 4:
                            if (pirojoke.taste != "")
                            {

                                pirojoke.price -= form[pirojoke.taste];
                                pirojoke.price += f1[key1];
                                pirojoke.taste = key1;
                            }
                            else
                            {
                                pirojoke.price += f1[key1];
                                pirojoke.taste = key1;
                            }
                            break;
                        case 6:
                            if (pirojoke.glaze != "")
                            {

                                pirojoke.price -= form[pirojoke.glaze];
                                pirojoke.price += f1[key1];
                                pirojoke.glaze = key1;
                            }
                            else
                            {
                                pirojoke.price += f1[key1];
                                pirojoke.glaze = key1;
                            }
                            break;
                        case 7:
                            if (pirojoke.decor != "")
                            {
                                pirojoke.price -= form[pirojoke.decor];
                                pirojoke.price += f1[key1];
                                pirojoke.decor = key1;
                            }
                            else
                            {
                                pirojoke.price += f1[key1];
                                pirojoke.decor = key1;
                            }
                            break;

                    }

                    break;
                }

                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.Clear();
                switch (myPose)
                {
                    case 2:
                        Console.WriteLine("Выберите форму");
                        break;
                    case 3:
                        Console.WriteLine("Выберите размер");
                        break;
                    case 4:
                        Console.WriteLine("Выберите вкус");
                        break;
                    case 6:
                        Console.WriteLine("Выберите глазурь");
                        break;
                    case 7:
                        Console.WriteLine("Выберите декор");
                        break;

                }
                Console.WriteLine("___________________________");
                foreach (var znach in form)
                {
                    Console.WriteLine($"   {znach.Key} - {znach.Value} хзеков");
                }
                Console.SetCursorPosition(0, pose);
                Console.Write("->");
            }
            return pirojoke;
        }


        static void Main(string[] argrs)
        {
            int pose = 2;
            Pirog pirog = new Pirog();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow)
                {

                    if (pose >= 8)
                    {
                        pose -= 6;
                    }
                    else
                    {
                        pose++;
                    }

                }

                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += 6;
                    }
                    else
                    {
                        pose--;
                    }

                }

                if (key.Key == ConsoleKey.Enter)
                {
                    pirog = checkMenu(pose, pirog);

                }
                Console.Clear();
                Menu(pose, pirog);
                Console.SetCursorPosition(0, pose);
                Console.Write("->");
            }
        }

        public static void Menu(int pose, Pirog priceCake)
        {
            Console.WriteLine("Welcome to pirojki");
            Console.WriteLine();
            Console.WriteLine("   Форма");
            Console.WriteLine("   Размер");
            Console.WriteLine("   Вкус");
            Console.WriteLine("   Количество");
            Console.WriteLine("   Глазурь");
            Console.WriteLine("   Декор");
            Console.WriteLine("   Конец заказа");
            Console.WriteLine();
            Console.WriteLine($"Заказ: {priceCake.glaze} {priceCake.decor} {priceCake.taste}\t {priceCake.price} {priceCake.size} {priceCake.form} {priceCake.count}");
            Console.WriteLine("Цена: " + priceCake.price + "бачей");
        }

        private static Pirog colichestvo(Pirog ck)
        {
            if (ck.price == 0)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Вы ещё не выбрали ни одного элемента, нажмите Esc, что бы выйти в меню");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                }
                return ck;
            }

            Console.Clear();
            Console.WriteLine("Введите количество тортов:");
            int colT = Convert.ToInt32(Console.ReadLine());
            ck.count = colT;



            return ck;
        }

        private static Pirog printCheck(Pirog ck)
        {
            if (ck.price == 0)
            {
                Console.WriteLine("Вы ещё не выбрали ни одного пункта меню");
                return ck;
            }
            Console.Clear();
            string check = $"Заказ от: {DateTime.Now} \n Заказ: {ck.size} {ck.form} {ck.count} {ck.glaze} {ck.decor} {ck.taste} \n Цена: {ck.price * ck.count}";
            Console.WriteLine("Введите название файл:");
            string puti = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string put1 = Directory.GetCurrentDirectory().Substring(0, 36);

            string sav = Console.ReadLine();



            File.WriteAllText($"{puti}/{sav}", check);

            File.AppendAllText($"{put1}/allCheck.txt", $"\n ...................");
            File.AppendAllText($"{put1}/allCheck.txt", $"\n {check}");

            ck.price = 0;
            ck.form = "";
            ck.count = 1;
            ck.glaze = "";
            ck.size = "";
            ck.decor = "";
            ck.taste = "";
            return ck;
        }
    }
}