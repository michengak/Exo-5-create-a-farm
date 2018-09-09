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

           

            Console.WriteLine("Hello dear visitor, welcome to my special farm\n, " +
                             "Here we have many animals, hope you enjoy your moment");
                             
            Console.Write("To discover our farm, please press enter...." );
          
            Console.ReadLine();
            Console.Clear();
            

            
   
                // Instantiate the Urban Farm animals
                Goat Zink = new Goat();
                Pig Shetar = new Pig ();
                Donkey Mauric = new Donkey();
                Camel Ibraka = new Camel();

            //The program begins 
            // requierements 3 and 4( four classes, one method and four classes, four methods)

                Zink.CanWalk();
                Zink.DoProduce();
                Zink.CanEat();
                Zink.CanTalk();
                
                Console.ReadLine();
                Console.Clear();

                Shetar.CanTalk();
                Shetar.DoProduce();
                Shetar.CanEat();
                Shetar.CanWalk();

                Console.ReadLine();
                Console.Clear();


                Mauric.CanTalk();
                Mauric.DoProduce();
                Mauric.CanEat();
                Mauric.CanWalk();

                Console.ReadLine();
                Console.Clear();


                Ibraka.CanWalk();
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
