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
        public int TargetedMinion()
        {
            int minionElement = 0;
            //Figure out how to specify a certain minion
            minionElement = myMinion.TargetedMinion;
            return minionElement;
        }
        public double TargetInRange(Minions Minion)
        {
            double distance = 0;
            for (int i = 0; i < towers.Length; i++)
                distance = Math.Sqrt(
                    (towers[0].position.X - Minion.MinionPosition.X) *
                    (towers[0].position.X - Minion.MinionPosition.X) +
                    (towers[0].position.Y - Minion.MinionPosition.Y) *
                    (towers[0].position.Y - Minion.MinionPosition.Y));
            return distance;
        }
        public float CalculateDamage(Minions[] Minion)
        {
            Tower myTower = new Tower();
            int remainingHealth = 0;
            //damage selected enemy
            if (TargetInRange(Minion[TargetedMinion()]) < 1)
            {
                remainingHealth = Minion[TargetedMinion()].MinionHealth - myTower.power;
                Minion[TargetedMinion()].MinionHealth = remainingHealth;
            }
            return remainingHealth;
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
