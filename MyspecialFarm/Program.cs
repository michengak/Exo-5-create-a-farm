using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyspecialFarm
{
    

    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Hello dear visitor, welome to my special farm\n, " +
                             "Here we have many animals, hope you enjoy your moment");
                             
            Console.Write("To discover our farm, please press enter...." );
          
            Console.ReadLine();




   
                // Instantiate the Urban Farm animals
                Goat Zink = new Goat();
                Pig Shetar = new Pig ();
                Donkey Mauric = new Donkey();
                Camel Ibraka = new Camel();

            //The program begins

                Zink.CanEat();
                Zink.DoProduce();
                Zink.CanEat();
                Zink.CanTalk();
                
                Console.ReadLine();
                Console.Clear();

                Shetar.CanEat();
                Shetar.DoProduce();
                Shetar.CanEat();
                Shetar.CanTalk();

                Console.ReadLine();
                Console.Clear();


                Mauric.CanEat();
                Mauric.DoProduce();
                Mauric.CanEat();
                Mauric.CanTalk();

                Console.ReadLine();
                Console.Clear();


                Ibraka.CanEat();
                Ibraka.DoProduce();
                Ibraka.CanEat();
                Ibraka.CanTalk();

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("We hope you enjoy your tour in our farm!\n" +
                                   "Thank you for coming!");
                Console.ReadLine();
            




        }
    }
}
