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
        private static char genericName = 'A';
        private float attackSpeed;
        private float minionVelocity;
        private float moveSpeed;
        private int attackDamage;
        private int attackRange;
        private static int minionCounter = 0;
        private int minionHealth;
        private int targetedMinion;
        private static string minionName = "A";
        private Vector2 position;
//Functions & Constructors
        //Default minion stats
        public Minions()
        {
            MinionName = SetGenericMinionName(MinionName);
            AttackDamage = 5;
            AttackRange = 3;
            AttackSpeed = 1;
            MinionHealth = 100;
            MoveSpeed = 2;
            MinionVelocity = 1;
            MinionPosition = Vector2.Zero;
            
        }
        //Custom minion stats
        public Minions(Vector2 Position)
        {
            MinionName = SetGenericMinionName(MinionName);
            attackDamage = 5;
            attackRange = 3;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
            position = Position;
        }
        public Minions(float attack_Speed, float move_Speed, float minion_Velocity, int attack_Damage, int attack_Range, int minion_Health, string name, Vector2 position)
        {
            AttackDamage = attack_Damage;
            AttackRange = attack_Range;
            AttackSpeed = attack_Speed;
            MinionHealth = minion_Health;
            MoveSpeed = move_Speed;
            MinionVelocity = minion_Velocity;
            MinionName = name;
            MinionPosition = position;
        }
        public void Draw(Canvas canvas)
        {

        }
        public void ResetGenericMinionName(string value)
        {
            MinionName = value;
        }
        public string SetGenericMinionName(string currentMinionName)
        {
            if (genericName.ToString() == currentMinionName)
                while (genericName.ToString() == currentMinionName)
                    genericName++;
            if (genericName == '[')
                genericName = 'a';
            if (genericName == '{')
                genericName = 'A';
            MinionName = genericName.ToString();
            genericName++;
            return MinionName;
        }
//Properties
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
        public int MinionCounter
        {
            get { return minionCounter; }
            set
            {
                if (minionCounter == null)
                    minionCounter = 0;
                minionCounter = value;
            }
        }
        public int MinionHealth
        {
            get { return minionHealth; }
            set { minionHealth = value; }
        }
        public int TargetedMinion
        {
            get { return targetedMinion; }
            set
            {
                targetedMinion = value;
            }
        }
        public string MinionName
        {
            get { return minionName; }
            set
            {
                minionName = value;
            }
        }
        public Vector2 MinionPosition
        {
            get { return position; }
            set { position = value; }
        }
    }
}
/*
 * End Log
 * Figure out what stuff belongs in MinionController constructor
 * Consider using bool datatype for TargetedMinion() in TowerController
 * Possibly work on/polish Tower classes. 
*/