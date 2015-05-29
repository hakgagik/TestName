using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class MinionController
    {
        protected static Minions[] basicBaddies;
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
        public void Update() 
        {

        }
        public void Draw(Canvas canvas) 
        {
            for (int i = 0; i < basicBaddies.Length; i++)
                canvas.DrawCircle(basicBaddies[i].MinionPosition.X, basicBaddies[i].MinionPosition.Y, .05f, Color.Green);
        }
    }
}
