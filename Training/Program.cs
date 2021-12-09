using System.Collections.Generic;
using System.Linq;

namespace Training
{
    class Program
    {

        static bool isluwi(int x)
        {
            System.Console.WriteLine("movedi aq");
            return x < 5;
        }


        

        static void Main(string[] args)
        {
            var humans = Database.Humans;
            var gionames = humans.Where(human => human.FirstName == "გიორგი");



            var ratinames = humans.Where(IsRati);

            bool IsRati(Human humanrati) => humanrati.FirstName == "რატია";



            var range = Enumerable.Range(1, 10).ToList();

            var lessthanfive = range.Where(isluwi);

         }

         bool IsGiorgi(Human human) => human.FirstName == "გიორგი";

         






    }
}