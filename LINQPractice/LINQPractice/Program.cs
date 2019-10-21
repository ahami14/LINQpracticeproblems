using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
             //PROBLEM ONE
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var myLinqQuery = from name in words
                          where name.Contains("th")
                          select name;
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }  
            Console.ReadLine();



            //PROBLEM TWO
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            List<string> distinct = names.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();


            //PROBLEM THREE
            List<string> classGrades = new List<string>()
            {
               "80,100,92,89,65",
               "93,81,78,84,69",
               "73,88,83,99,64",
               "98,100,66,74,55"
            };
            //classGrades = classGrades.Select(g => g.in)
            var intClassGrades1 = classGrades[0].Split(',').Select(g => double.Parse(g)).ToList();
            intClassGrades1.Remove(intClassGrades1.Min());
            double average1 = intClassGrades1.Average();

            var intClassGrades2 = classGrades[1].Split(',').Select(g => double.Parse(g)).ToList();
            intClassGrades2.Remove(intClassGrades2.Min());
            double average2 = intClassGrades2.Average();

            var intClassGrades3 = classGrades[2].Split(',').Select(g => double.Parse(g)).ToList();
            intClassGrades3.Remove(intClassGrades3.Min());
            double average3 = intClassGrades3.Average();

            var intClassGrades4 = classGrades[3].Split(',').Select(g => double.Parse(g)).ToList();
            intClassGrades4.Remove(intClassGrades4.Min());
            double average4 = intClassGrades4.Average();

            double totalAverage = (average1 + average2 + average3 + average4) / 4;

            Console.WriteLine(totalAverage);
            Console.ReadLine();


            //PROBLEM FOUR
            List<string> mikeName = new List<string>();
            mikeName.Add("T");
            mikeName.Add("e");
            mikeName.Add("r");
            mikeName.Add("r");
            mikeName.Add("i");
            mikeName.Add("l");
            mikeName.Add("l");
            var a = from b in mikeName
                    group b by b into c
                    orderby c.Key
                    select c;
            foreach (var nameNum in a)
            {
                Console.WriteLine("Letter " +nameNum.Key + " appears " +nameNum.Count() + " times");
                Console.ReadLine();
            }
        }
    }  
}
