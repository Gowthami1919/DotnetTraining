using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegates encapsulate the method
namespace Delegates
{
    class Program
    {
        static void Main(string[] args)

        {
            Program pro = new Program();
            int x = pro.delegate1(2, 4, 5);//calling function delegate
            Console.WriteLine(x);
           
            pro.circumferenceAction(2);//calling Action delegate
            arithemetic arith = new arithemetic(pro.Adding);//assigning method to a delegate
            arith = arith + pro.Subtracting;
            arith.Invoke(100, 243);
            //printing yield
            foreach(var item in pro.EvenNumber(3))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

        }
        //Function delegates
        Func<int, int, int, int> delegate1 = (x, y, z) => { return 2 * x * y * z; };

        //Action delegate
        Action<long> circumferenceAction = x => Console.Write(2 * 3.14 * x);

        //Multicaste delegate
        public delegate void arithemetic(int x, int y);//declaring delegate

        public void Adding(int x, int y)
        {
            Console.WriteLine("Add:{0}", x + y);
        }

        public void Subtracting(int x, int y)
        {
            Console.WriteLine("Substraction:{0}", x - y);
        }

        //Yield 
        public IEnumerable<int> EvenNumber(int x)
        {
            for(int i = 0; i < x; i++)
            {
                 int number = 2 * i;
                yield return number;

            }

        }


    }
    






    
}
