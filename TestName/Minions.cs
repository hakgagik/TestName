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
        protected int attackDamage;
        protected float attackSpeed;
        protected int minionHealth;
        protected float moveSpeed;
        protected float minionVelocity;
        protected string minionName;
        public Vector2 position;
//Functions        
        //Default minion stats
        public Minions()
        {
            minionName = setMinionName().ToString();
            attackDamage = 5;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
            position.X = 0;
            position.Y = 0;
        }
        //Custom minion stats
        public Minions(Vector2 Position)
        {
            minionName = setMinionName().ToString();
            attackDamage = 5;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
            position = Position;
        }
        public Minions(string name, int atkDamage, float atkSpeed, int minHealth, float mvSpeed, float minVelocity, int xPosition, int yPosition)
        {
            minionName = name;
            attackDamage = atkDamage;
            attackSpeed = atkSpeed;
            minionHealth = minHealth;
            moveSpeed = mvSpeed;
            minionVelocity = minVelocity;
            position.X = xPosition;
            position.Y = yPosition;
        }
        //Spawn generic named minion
        public static char setMinionName()
        {
            char i = 'A';
            i++;
            if (i == '[')
                i = 'a';
            if (i == 'z')
                i = 'A';
            return i;
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
//Get functions
        public float getAttackSpeed()
        {
            return attackSpeed;
        }
        public float getMinionVelocity()
        {
            return minionVelocity;
        }
        public float getMoveSpeed()
        {
            return moveSpeed;
        }
        public int getAttackDamage()
        {
            return attackDamage;
        }
        public int getMinionHealth()
        {
            return minionHealth;
        }
        public string getMinionName()
        {
            return minionName;
        }
        void Draw()
        {

        }
    }
}