using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace TestName
{
    class Tower
    {
        //Health Points of tower
        public int HP;
        //Name of tower
        String name;
        //damage
        public float power;        
        //Rate of attack
        public float attackSpeed;
        //Range
        public float range;
        
        public Vector2 position;
        static ArrayList towers = new ArrayList();

        public Tower(){
            HP = 100;
            name = "Laser";
            power = 2000;
            attackSpeed = 1;
            position.X = 0;
            position.Y = 0;
            range = 1;

        }

        public Tower(String towerName, float towerPower, float towerAttackSpeed){
            name = towerName;
            power = towerPower;
            attackSpeed = towerAttackSpeed;
        }
        public float getPower()
        {
            return power;
        }
        
        
      }
       
}

