using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System.Drawing;
using System.Collections;

namespace TestName
{
    class Tower_Controller
    {
        
        static Tower[] towers;
        Minions myMinion = new Minions();
        public double targetInRange(Minions Minion)
        {
            double distance = 0;
            for (int i = 0; i < towers.Length; i++)
                distance = Math.Sqrt(
                    (towers[0].position.X - myMinion.position.X) * 
                    (towers[0].position.X - myMinion.position.X) +
                    (towers[0].position.Y - myMinion.position.Y) * 
                    (towers[0].position.Y - myMinion.position.Y));
            return distance;
        }
        public float CalculateDamage(Minions Minion, Tower tower)
        {
            Tower myTower = new Tower();
            Minions myMinion = new Minions();
            float damage = 0;
            //damage selected enemy
            if (targetInRange(Minion) < 1)
            {
                damage = myMinion.getMinionHealth() - myTower.power;
            }
            return damage;
        }
        public static void addTower()
        {
            char i = 'A';
            towers[i] = new Tower();
            i++;
        }
        public void damageTower(Tower tower)

        {
            //Delete selected tower
            
        }
        public Tower_Controller(){

        }
        public void update()
        {
        }
        public void draw(Canvas canvas)
        {
            for (int i = 0; i<towers.Length; i++){
            canvas.DrawSqaure(towers[i].position.X, towers[i].position.Y, 0.1F, Color.Blue);
            }
        }
    }
}
