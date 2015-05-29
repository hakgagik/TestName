using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class MinionController
    {
        protected static Minions[] basicBaddies;
        public Vector2 moveTo
        {
            set
            {
                Vector2 position = value;
            }
        }
        public Minions[] getMinionData()
        {
            return basicBaddies;
        }
        public static void spawnMinion(Vector2 position)
        {
            int i = 0;
            basicBaddies[i] = new Minions(position);
            i++;
        }
        public void takeDamage() 
        {

        }
        public MinionController()
        {
            //stuff
        }
        void Update() 
        {

        }
        void Draw() 
        {

        }
    }
}
