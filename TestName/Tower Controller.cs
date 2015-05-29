using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace TestName
{
    class Tower_Controller
    {
        
        public double targetInRange(Minions Minion)
        {
            Tower tower = new Tower();
            Minions myMinion = new Minions();
            double distance = Math.Sqrt(tower.position.X - myMinion.position.X) + (tower.position.Y - myMinion.position.Y);
            
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
        
        public void addTower()
        {
            Tower tower = new Tower();
        }

        
        public void destroyTower(Tower tower)

        {
            //Delete selected tower
            
        }
        public Tower_Controller(){

        }
      
        public void update()
        {
        }
        public void draw()
        {
        }
    }
}
