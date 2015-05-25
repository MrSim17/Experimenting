using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultidimensionalArray();
            //LiftedOperators();
            Polymorphism();
        }

        public static void Polymorphism()
        {
            var person = new Person();
            var nathan = new Nathan();

            Console.WriteLine(person.SayName());
            Console.WriteLine(nathan.SayName());

            List<Person> people = new List<Person> { person, nathan };

            foreach (Person p in people)
            {
                Console.WriteLine(p.SayName());
            }

            Console.WriteLine(nathan.SayName());
            Console.WriteLine(((Person)nathan).SayName());

            Console.ReadLine();

            var one = new ClassLibrary1.Class1();
        }

        public static void MultidimensionalArray()
        {
            // https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx
            // Two Dimensions - requires fixed lengths
            int[,] twoDim = new int[2,2];

            twoDim[0, 0] = 0;
            twoDim[0,1] = 1;
            twoDim[1, 0] = 2;

            twoDim = new int[,] { {0,1}, {2,3} }; // can omit the size if it is decidable during init

            // more than just 3 dimensions
            int[,,,] fourDim = new int[2, 2, 2, 2];
            int[,,,,] fiveDim = new int[2, 2, 2, 2, 2];
            int[,,,,] sixDim = new int[2, 2, 2, 2, 2];

            // LOL 100 dimensions throws a runtime exception
            //int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] oneHundredDim = new int[2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2];

            // Jagged Arrays - does not require fixed lengths in one dimension
            // https://msdn.microsoft.com/en-us/library/2s05feca.aspx
            int[][] jagged = new int[2][]; // second array requires no size
            jagged = new int[1][] { new int[1] };

        }

        public static void LiftedOperators()
        {
            // http://blogs.msdn.com/b/ericlippert/archive/2007/06/27/what-exactly-does-lifted-mean.aspx
            // http://blogs.msdn.com/b/abhinaba/archive/2005/12/14/503533.aspx
            // Adding this to check how it decompiles
            int? x = 1;
            int? y = 1;
            int? z = x + y;

            if(z == null)
            {
                Console.WriteLine("value is null");
            }

            // Interesting decompiles to
            /*

    		int? num = new int?(1);
			int? num2 = new int?(1);
			int? num3 = num;
			int? num4 = num2;
			if (!(num3.HasValue & num4.HasValue))
			{
				int? arg_47_0 = null; // did not expect adding a null to equate to null
			}
			else
			{
				new int?(num3.GetValueOrDefault() + num4.GetValueOrDefault());
			}

            */

            // adding the if statement optimizes to
            /*

            int? num = new int?(1);
			int? num2 = new int?(1);
			bool flag = !(num + num2).HasValue; // Definitely did not expect this
			if (flag)
			{
				Console.WriteLine("value is null");
			}

            */
        }
    }
}
