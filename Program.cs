// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*  dotnet --version 
    dotnet new consle - новый проект с шаблоном консл
    clear - читска консоли
    dotnet run - зпауск
*/

using System;
using System.Reflection.Metadata; //юзаем библиотеку систем, ну типо уже гже-то прописано это
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace project
{ //типо папка с файлами 

    class Program
    {

        static void Main()
        { //главная функция мейн

            Console.WriteLine("Хехее юзаем библиотеку и выводим");
            //Console.ReadKey(); //ждем пока пользователь что-то введет(1 символ) в терминале 
            //это чтобы кансоль не вырубалась но и без этого работает
            Console.WriteLine("вав");
            Console.Write("sdsd\n\n");
            Console.Write("00000");

            /*   комент - contrl + /
            если ошибка сборки мб это от того что запустила прогу и дот нет не читает
            и сохранять не забывай а то он не читает 
            */
            Console.ReadLine();//читать строку


            //переменные
            //целые
            int number;
            number = 0;
            int num2 = -10;
            Console.WriteLine("Переменная - " + number);

            uint num3 = 10; //положительные числа только тут храняться
            byte num4 = 25; // от - 255 до 255  меньше оперативки жрет
            short num5 = -32000; //-32 тыщи до +32 с чем -то
            long num6 = 1000000000;//больше инта огромен в 2 раза больше инта

            // с точкой
            float numF = -10000.34f; // до точки и после  несколько миллионов
            double numD = 5.2323234f;
            double numD2 = 5.2323234d; // лучше d ставить   и добл больше флоут



            //строки
            string word = " привет";
            char symbol = 'd'; // хранит 1 символ


            //булиановская
            bool isHappy = true;




            //так тоже можно писать
            int num_1 = 0, num_2 = 0;
            num_1 = Convert.ToInt32(Console.ReadLine()); //из стринга в инт
            //тк ReadLine всегда читает тип стринг

            Console.WriteLine(" 1 " + num_1 + " 2 " + num_2);



            float user_input;
            // user_input = Convert.ToDouble(Console.ReadLine());
            user_input = float.Parse(Console.ReadLine());   //в коде точка в консоле точка на выводе что-то запятая

            Console.WriteLine("переменная " + user_input);


            //мат действия
            user_input = user_input + 10f;  //single - это флоут но и без f можно
            user_input = user_input - 10f;
            user_input = user_input / 10f;
            user_input = user_input % 10f;

            user_input += 5f;
            user_input *= 5f;
            user_input /= 5f;
            user_input -= 5f;

            user_input++; //плюс 1
            user_input--;



            //cw и энтер
            System.Console.WriteLine(Math.PI);  //систем по сути и выше прописывался, но и без этого работает конечно
            //к константе пи обращаемся

            System.Console.WriteLine(Math.Abs(-20));  // корень
            System.Console.WriteLine(Math.Ceiling(4.11)); // округление к большему
            System.Console.WriteLine(Math.Floor(4.11)); // округление к меньшему
            System.Console.WriteLine(Math.Round(4.11)); // округление по нормальному

            System.Console.WriteLine(Math.Min(5, 0));
            System.Console.WriteLine(Math.Max(5, 0));

            System.Console.WriteLine(Math.Pow(5, 2)); // степень 



            System.Console.WriteLine("хехех привет {0}   и  {1}", num_2, user_input);





            //Условные переменные

            int a = 5;
            if (a == 5)
            {
                System.Console.WriteLine("Number is 5 ");
            }
            if (a != 5)
            {
                System.Console.WriteLine("Number is not 5 ");
            }


            string word2 = "hello";
            if (word2 == "hello")
            {
                System.Console.WriteLine("хай ");
            }

            if (isHappy)
            {// тоже самое что и isHappy == true
                System.Console.WriteLine("хай счасть");
            }

            if (!isHappy)
            { // тоже самое что и isHappy == false
                System.Console.WriteLine("  не хай  не счастье");
            }
            else
            {
                System.Console.WriteLine("хай 2  счастье");
            }


            if (a > 7)
            {
                System.Console.WriteLine("  больше 7 ");
            }
            else if (a < 3)    //else if может быть сколько угодно
            {
                if (a == 2)
                {
                    System.Console.WriteLine(" меньше 3 ");
                }
            }
            else
            {
                System.Console.WriteLine("другое");
            }

            if (a > 8) System.Console.WriteLine("a>8"); //можно скобки пропускать если 1 стр кода

            if (a == 8 && isHappy)
            {//и
                System.Console.WriteLine("и");
            }

            if (a == 8 || isHappy)
            {//или
                System.Console.WriteLine("или");
            }



            short user_input2 = Convert.ToInt16(Console.ReadLine());

            switch (user_input2)
            { //в case нет фигурных {}
                case 5:
                    System.Console.WriteLine("Number is 5");
                    break;
                case 15:
                    System.Console.WriteLine("Number is 15");
                    break;
                case 25:
                    System.Console.WriteLine("Number is 25");
                    break;
                default:
                    Console.WriteLine("number is unrecognized");
                    break;

            }





            //циклы
            for (byte i2 = 0; i2 <= 10; i2++)
            {
                System.Console.WriteLine("Element : {0}", i2);
            }

            for (byte j = 200; j > 10; j /= 2)
                System.Console.WriteLine("Element : {0}", j); // можно и без скобок так же если 1 строчка


            byte i = 0;
            while (i < 10)
            {
                System.Console.WriteLine("El {0}", 1);
                i--;
            }

            // isHappy = true;
            // while (isHappy){
            //     string end = Console.ReadLine();
            //     if (end == "end"){
            //         isHappy = false;
            //     }
            // }

            //ОТЛИЧИЕ

            //сто процентов 1 раз выполнится и потом только условие проверит
            i = 11;
            do
            {
                System.Console.WriteLine("do while check");
            } while (i < 10);


            for (i = 0; i <= 10; i++)
            {
                if (i > 5)
                    break;
                if (i % 2 == 0)
                    continue;   //пропускает 1 круг цикла
                System.Console.WriteLine("Element : {0}", i);
            }


            //массивы
            byte[] nums = new byte[5];//выделяем память - new   от 0 до 4
            nums[0] = 4;
            nums[1] = 204;
            nums[2] = 34;
            nums[3] = 54;
            nums[4] = 240;

            System.Console.WriteLine("El :" + nums[0]);

            string[] strings = new string[] { "Jon", "bob", "Alex" };
            strings[1] = "Hehhhh no bob";

            for (byte k = 0; k < nums.Length; k++)
                System.Console.WriteLine("El  " + nums[k]);

            short[] numbers = new short[10];
            Random random = new Random();
            for (byte k = 0; k < numbers.Length; k++)
            {
                numbers[k] = Convert.ToInt16(random.Next(-15, 15));
                System.Console.WriteLine("El  " + numbers[k]);
            }


            //вложенные массивы
            char[,] symbols = new char[2, 3];
            symbols[0, 0] = 'H';
            System.Console.WriteLine(symbols[0, 0]);

            int[,] nums2 = {
                {2, 3, 5},
                {2, 343, 5},
                {3, 3, 5},

            };

            nums2[1, 2] = 56;


            //for - each 
            foreach (short el in numbers)
            { //берем переменную того же типа что и наш массивий
              //переменная будет содержать значение каждого элемента нашего масиива
                System.Console.WriteLine("Ellll  " + el);

            }

            foreach (short el in nums2)
            {  // двумерные массивы тоже славно перебирает
                System.Console.Write(" Ell222  " + el);

            }
            System.Console.WriteLine(" ");

            //ДИНАМИЧЕСКИЕ МАССИВЫ
            List<int> numList = new List<int>(){
                4, 5, 6
            };

            numList.Add(40);
            numList.Add(40);
            numList.Add(43);
            numList.Add(45);

            foreach (int el in numList)
            {
                System.Console.Write(" List " + el);
            }
            System.Console.WriteLine();

            numList.Remove(100); //удалить по значению не индексу
            numList.Sort();
            numList.Reverse();
            //clear copyTo - клонирование и тд

            foreach (int el in numList)
            {
                System.Console.Write(" List " + el);
            }




            //функциии  main - тоже функция
            //методы - функции в классе
            // те в C# по сути нет функций, а только методы но можно по фану и называть это функцией

            Print();
            Print();
            Print2("хаайй");
            Sum(3, 4);
            int res2 = Sum2(5, 4);
            Print2(res2.ToString());



            System.Console.WriteLine();
            System.Console.WriteLine();
            //cстринг - массив символов char
            string word4 = "heello";
            System.Console.WriteLine(word4[3]);
            System.Console.WriteLine(word4.Length);
            System.Console.WriteLine(String.Concat(word4, "!!"));
            System.Console.WriteLine(String.Compare(word4, "Hello")); // 0 - обе стр равны, -1 если нет


            System.Console.WriteLine();
            string people = "sd,sd,sd,sd,sd";
            string[] names = people.Split(new char[] { ',' });
            foreach (string el in names)
                System.Console.Write(el);

            people = String.Join(" ", names);
            System.Console.WriteLine(people);


            people = "          пробель";
            people = people.Trim();//убирает пробели
            System.Console.WriteLine(people);
            //обрезать строку
            System.Console.WriteLine(people.Substring(2));//удалены первые два эл
            System.Console.WriteLine(people.Substring(0, people.Length - 1));//только ласт символ минус


            //файлиии IO imput out strim
            //вообще файлы мы должны открывать и закрывать но тк мы юзаем using то как би забили


            //создали изолированное место
            System.Console.WriteLine("Введите текст ");
            string text = Console.ReadLine();
            using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                //чтобы записать текст нужно перевести в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(array, 0, array.Length); //без отсупа

            }

            using (FileStream stream1 = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length); //начинаем читать без пропусков с 0 до конца строки

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                System.Console.WriteLine(textFromFile);
            }



            //обработчик исключений
            try
            {
                System.Console.WriteLine("введите  число ");
                int num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не тот формат");
            } finally { //код сработает в любом случае
                //например чтобы закрыть файл
            }

            //есть ещё DivideByZereoException и тд ошибки
            //catch можно сколько угодно писать
        }

        public static void Print()
        { // заголовки с большой
            System.Console.WriteLine("Hiii function");
        }

        public static void Print2(string word)
        {
            System.Console.WriteLine(word);
        }
        public static void Sum(int x, int y)
        {
            int res = x + y;
            Print2("res  " + res);
        }
        public static int Sum2(int x, int y)
        {
            return x + y;
        }




    }
}

