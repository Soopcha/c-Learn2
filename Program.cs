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
            Console.ReadKey(); //ждем пока пользователь что-то введет(1 символ) в терминале 
            //но и без этого работает
            Console.WriteLine("вав");
            Console.Write("sdsd\n\n");
            Console.Write("00000");

/*   комент - contrl + /
если ошибка сборки мб это от того что запустила прогу и дот нет не читает
и сохранять не забывай а то он не читает 
*/
            Console.ReadLine();//читать строку


            //переменные
            int number;
            number = 0;
            int num2 = -10;
            Console.WriteLine(number);

        }
    }
}

