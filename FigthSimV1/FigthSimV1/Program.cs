using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigthSimV1
{
    class Program
    {
        static void Main(string[] args)
        {
           Fighter A = new Fighter();
           Fighter B = new Fighter();
            int turn = 1;

            Console.WriteLine("WRITE A NAME FOR FIGHTER A:");
            A.name = Console.ReadLine();
            Console.WriteLine("Fighter A is:" +A.name);
            //Console.ReadLine();

            Console.WriteLine("WRITE A NAME FOR FIGHTER b:");
            B.name = Console.ReadLine();
            Console.WriteLine("Fighter B is:" + B.name);
            Console.ReadLine();

            while(A.IsAlive() && B.IsAlive())
            {
                Console.WriteLine("TURN: "+turn);
                A.Hurt(B.Attack());
                Console.WriteLine(A.name + " has "+A.GetHP()+"HP left");

                B.Hurt(A.Attack());
                Console.WriteLine(B.name + " has " + B.GetHP() + "HP left");
                Console.ReadLine();

                turn++;
            }

            if(A.IsAlive()==false || B.IsAlive() ==true )
            {
                Console.WriteLine("Fighter: " + B.name + " has won!");
                Console.ReadLine();
            }
            if (B.IsAlive() == false || A.IsAlive() == true)
            {
                Console.WriteLine("Fighter: " + A.name + " has won!");
                Console.ReadLine();
            }

        }
    }
}
