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
           Fighter A = new Fighter(); //Med detta så kallar jag in metoden Fighter in i Main för spelaren A
           Fighter B = new Fighter(); //Skapar spelaren B med metoden fighter.
           int turn = 1; //Skapar ett start värde för turn

            Console.WriteLine("WRITE A NAME FOR FIGHTER A:");
            A.name = Console.ReadLine(); // Med detta så lägger jag till stringen "name" till "A" och säger att det är lika med console.readline så att användaren kan lägga in sitt egna input och det inputet lagras i "A".
            Console.WriteLine("Fighter A is:" +A.name); //Skriver ut namnet på A som användaren skrivit in.
            

            Console.WriteLine("WRITE A NAME FOR FIGHTER b:");
            B.name = Console.ReadLine(); //Det som nu skrivs in i readline lagras istället i stringen jag kopplat till B
            Console.WriteLine("Fighter B is:" + B.name);
            Console.ReadLine();

            while(A.IsAlive() && B.IsAlive()) //Så länge A.IsAlive och B.IsAlive är true (Alltså att hp är över 0) så fortsätter denna loop.
            {
                Console.WriteLine("TURN: "+turn); //Visar int turn
                A.Hurt(B.Attack()); // Detta gör så att spelaren B får en slumpmässig "B.Attack" som sedan med hjälp av A.Hurt subtraherar "B.Attack" med Spelaren As HP.
                Console.WriteLine(A.name + " has "+A.GetHP()+"HP left"); //GetHP returnerar då det värde som inten HP har kvar och visar den i konsollen.

                B.Hurt(A.Attack()); //Samma som ovan fast med spelaren A
                Console.WriteLine(B.name + " has " + B.GetHP() + "HP left");
                Console.ReadLine();

                turn++; //Varje gång loopen körs adderas inten med 1
            }

            if(A.IsAlive()==false || B.IsAlive() ==true ) //Så länge A.IsAlive är false (Död) och B.IsAlive är true (lever) så vinner spelaren B, då det innebär att spelaren A har ett HP (int) som är under/lika med 0.
            {
                Console.WriteLine("Fighter: " + B.name + " has won!");
                Console.ReadLine();
            }
            if (B.IsAlive() == false || A.IsAlive() == true) //Samma som ovan fast tvärtom.
            {
                Console.WriteLine("Fighter: " + A.name + " has won!");
                Console.ReadLine();
            }

        }
    }
}
