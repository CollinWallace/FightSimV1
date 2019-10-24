using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigthSimV1
{
    class Fighter
    {
        private int hp = 100; // Skapar en private int  för hp vilket innebär att den endast kan användas inom denna class.
        public string name; //Skapar en public string för name vilket innebär att den kan användas utanför metoden.
        public int MINdmg = 5; //Int för mininum damage roll
        public int MAXdmg = 15; //int för maximum damage roll

        static Random Genrator = new Random();//Skapar en random generator, static gör den universal, så att alla ändringar som görs här updateras i alla andra instanser a metoden

        public int Attack()
        {
            int Damage = Genrator.Next(MINdmg, MAXdmg); //int damage genererar ett värde mellan MINdmg och MAXdmg.
            return Damage; //Detta returnerar värdet som genereras så att den kan användas utanför.
        }

        public void Hurt(int Damage)
        {
            hp -= Damage; //Här tar man värdet av hp minus värdet som genereras i damage.
        }

        public bool IsAlive() //Detta kollar så att så länge hp är över 0 så är boolen = True, vilket innebär att spelet fortsätter
        {
           return hp > 0;
        }

        public int GetHP() //Denna metod är helt enkelt bara till för att kunna visa vilket värde inten HP har just nu.
        {
            return hp;
        }
        

    }
}
