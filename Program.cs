// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*  dotnet --version 
    dotnet new consle - новый проект с шаблоном консл
    clear - читска консоли
    dotnet run - зпауск
*/

using System; //юзаем библиотеку систем, ну типо уже гже-то прописано это

namespace project { //типо папка с файлами 

    class Program {
        
        static void Main(){ //главная функция мейн

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

            user_input ++; //плюс 1
            user_input --;



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
            


            System.Console.WriteLine("хехех привет {0}   и  {1}",num_2,user_input);





            //Условные переменные

            int a = 5;
            if(a ==5) {
                System.Console.WriteLine("Number is 5 ");
            }
            if(a !=5) {
                System.Console.WriteLine("Number is not 5 ");
            }


            string word2 = "hello";
            if(word2 == "hello") {
                System.Console.WriteLine("хай ");
            }

            if(isHappy){// тоже самое что и isHappy == true
                System.Console.WriteLine("хай счасть");
            }

            if(!isHappy){ // тоже самое что и isHappy == false
                System.Console.WriteLine("  не хай  не счастье");
            } else
            {
                 System.Console.WriteLine("хай 2  счастье");
            }


            if(a > 7 ){ 
                System.Console.WriteLine("  больше 7 ");
            } else if ( a  < 3)    //else if может быть сколько угодно
            {
                 System.Console.WriteLine(" меньше 3 ");
            } else{
                System.Console.WriteLine("другое");
            }
        }
    }
}

