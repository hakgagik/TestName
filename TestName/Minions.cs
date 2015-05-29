using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class Minions
    {
        //attack damage
        int attackDamage;
        //attack speed
        float attackSpeed;
        //health
        int minionHealth;
        //move speed
        float moveSpeed;
        //velocity
        float minionVelocity;
        //Minions
        static ArrayList minions = new ArrayList();
        public Minions()
        {
            attackDamage = 5;
            attackSpeed = 1;
            minionHealth = 100;
            moveSpeed = 2;
            minionVelocity = 1;
        }
        public static void spawnMinion()
        {
            char i = 'A';
            minions.Add(i);
            i++;
            if (i == '[')
                i = 'a';
        }
        public ArrayList sendMinionData()
        {
            return minions;
        }
    }
}
