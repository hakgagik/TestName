﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestName
{
    class Tower
    {
        //Name of tower
        String name;

        //damage
        float power;
        
        //Rate of attack
        float attackSpeed;

        static ArrayList towers = new ArrayList();

        public TowerA(){
            name = "Laser";
            power = 2000;
            attackSpeed = 1;

        }
        public static void addTower(){
            char i = 'A';
            towers.addTower();
            i++;
        }


    }
       
    }
}
