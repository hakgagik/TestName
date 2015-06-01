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
        private static Minions[] basicBaddies = new Minions[] { new Minions() };
//Functions
        public MinionController()
        {
            //Contructor stuff
        }
        public Minions[] MinionData
        {
            get { return basicBaddies; }
        }
        public static void SpawnMinion(Vector2 position)
        {
            int i = 0;
            i = basicBaddies[i].MinionCounter;
            basicBaddies[i] = new Minions(position);
            basicBaddies[i].MinionCounter++;
        }
        public void MinionDeath(Canvas canvas) 
        {
            //Check all minions for zero health
            for (int i = 0; i < basicBaddies.Length; i++)
                if (basicBaddies[i].MinionHealth < 0)
                {
                    //Best guess at undrawing the unit
                    canvas.Resize(0, 0);
                    basicBaddies[i].MinionCounter--;
                    basicBaddies[i].ResetGenericMinionName(basicBaddies[i].MinionName);
                }

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