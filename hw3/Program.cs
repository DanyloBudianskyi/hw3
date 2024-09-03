using SevenWonders;
using Japan;
using Ukraine;
using Canada;

//1.Разработайте приложение «7 чудес света», где каждое чудо будет представлено отдельным классом. Создайте дополнительный класс, содержащий точку входа. Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность взаимодействия классов. 
//namespace SevenWondersMain
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            LighthouseOfAlexandria lighthouse = new LighthouseOfAlexandria();
//            ColossusOfRhodes colossus = new ColossusOfRhodes();
//            Console.WriteLine(lighthouse.ToString()); 
//            Console.WriteLine(colossus.ToString());
//        }
//    }
//}


//2.	 Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран. Причём страна бы обозначалась пространством имён, а город — классом в данном пространстве.

namespace Countries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tokyo tokyo = new Tokyo();
            Ottawa ottawa = new Ottawa();
            Kiev kiev = new Kiev();
            int maxPopulation = Math.Max(ottawa.population, Math.Max(tokyo.population, kiev.population));
            if(maxPopulation == tokyo.population)
            {
                Console.WriteLine("The largest population in Tokyo");
            }
            else if (maxPopulation == kiev.population)
            {
                Console.WriteLine("The largest population in Kiev");
            }
            else if (maxPopulation == ottawa.population)
            {
                Console.WriteLine("The largest population in Ottawa");
            }
        }
    }
}
