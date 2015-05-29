using OpenTK;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class Minions
    {
//Variables
        int attackDamage;
        float attackSpeed;
        int minionHealth;
        float moveSpeed;
        float minionVelocity;
        public Vector2 position;
        //Minion list
        static ArrayList minions = new ArrayList();
//Functions        
        //Default minion stats
        public Minions()
        {
            attackDamage = 5;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
        }
        //Custom minion stats
        public Minions(int atkDamage, float atkSpeed, int minHealth, float mvSpeed, float minVelocity)
        {
            attackDamage = atkDamage;
            attackSpeed = atkSpeed;
            minionHealth = minHealth;
            moveSpeed = mvSpeed;
            minionVelocity = minVelocity;
        }
        //Spawn generic named minion
        public static void spawnMinion()
        {
            char i = 'A';
            minions.Add(i);
            i++;
            if (i == '[')
                i = 'a';
            if (i == 'z')
                i = 'A';
        }
        public ArrayList sendMinionData()
        {
            return minions;
        }
        public Vector2 MiniontPosition
        {
            get { return position; }
        }
        public Vector2 setMinionPosition
        {
            set
            {
                position = value;
            }
        }
        void Draw()
        {

        }
    }
}
