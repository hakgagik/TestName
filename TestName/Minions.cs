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
        protected Vector2 position;
//Functions        
        //Default minion stats
        public Minions()
        {
            minionName = GetMinionName.ToString();
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
            minionName = GetMinionName.ToString();
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
//Get functions
        public float GetAttackSpeed
        {
            get { return attackSpeed; }
            set { attackSpeed = value; }
        }
        public float GetMinionVelocity
        {
            get { return minionVelocity; }
            set { minionVelocity = value; }
        }
        public float GetMoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }
        public int GetAttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }
        public int getMinionHealth
        {
            get { return minionHealth; }
            set { minionHealth = value; }
        }
        public string GetMinionName
        {
            get { return minionName; }
            static set
            {
                char i = 'A';
                i++;
                if (i == '[')
                    i = 'a';
                if (i == 'z')
                    i = 'A';
            }
        }
        public Vector2 MinionPosition
        {
            get { return position; }
            set { position = value; }
        }
        void Draw(Canvas canvas)
        {
            
        }
    }
}