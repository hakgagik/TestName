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
        //
        protected float attackSpeed;
        protected float minionVelocity;
        protected float moveSpeed;
        protected int attackDamage;
        protected int attackRange;
        protected int minionHealth;
        protected string minionName;
        protected Vector2 position;
//Functions        
        //Default minion stats
        public Minions()
        {
            minionName = MinionName.ToString();
            attackDamage = 5;
            attackRange = 3;
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
            minionName = MinionName.ToString();
            attackDamage = 5;
            attackRange = 3;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
            position = Position;
        }
        public Minions(string name, int atkDamage, int atkRange, float atkSpeed, int minHealth, float mvSpeed, float minVelocity, int xPosition, int yPosition)
        {
            minionName = name;
            attackDamage = atkDamage;
            attackRange = atkRange;
            attackSpeed = atkSpeed;
            minionHealth = minHealth;
            moveSpeed = mvSpeed;
            minionVelocity = minVelocity;
            position.X = xPosition;
            position.Y = yPosition;
        }        
//Get functions
        public float AttackSpeed
        {
            get { return attackSpeed; }
            set { attackSpeed = value; }
        }
        public float MinionVelocity
        {
            get { return minionVelocity; }
            set { minionVelocity = value; }
        }
        public float MoveSpeed
        {
            get { return moveSpeed; }
            set { moveSpeed = value; }
        }
        public int AttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int MinionHealth
        {
            get { return minionHealth; }
            set { minionHealth = value; }
        }
        public string MinionName
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