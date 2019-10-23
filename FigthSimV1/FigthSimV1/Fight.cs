using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigthSimV1
{
    class Fighter
    {
        private int hp = 100;
        public string name;
        public int MINdmg = 5;
        public int MAXdmg = 15;

        static Random Genrator = new Random();//statc gör den univrsal

        public int Attack()
        {
            int Damage = Genrator.Next(MINdmg, MAXdmg);
            return Damage;
        }

        public void Hurt(int Damage)
        {
            hp -= Damage;
        }

        public bool IsAlive()
        {
           return hp > 0;
        }

        public int GetHP()
        {
            return hp;
        }
        

    }
}
