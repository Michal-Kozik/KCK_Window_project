﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCK_Window_project
{
    public class Turret
    {
        //pola
        private int level;
        private int ammo;
        private int dmg;

        private int posX;
        private int posY;

        //konstruktor
        public Turret(Hero hero)
        {
            level = 1;
            ammo = 3;
            dmg = 50;

            posY = 10;
            posX = hero.GetX();
        }

        //gettery
        public int GetX()
        {
            return posX;
        }
        public int GetY()
        {
            return posY;
        }
        public int GetDmg()
        {
            return dmg;
        }
        public int GetAmmo()
        {
            return ammo;
        }
        public int GetLevel()
        {
            return level;
        }
        //do wywalenia
        public char GetLevelChar()
        {
            switch (level)
            {
                case 1:
                    return '1';
                case 2:
                    return '2';
                default:
                    return '3';
            }
        }
        public int GetUpgradeCost()
        {
            switch (level)
            {
                case 1:
                    return 75;
                case 2:
                    return 125;
                default:
                    return 175;
            }
        }
        public static int GetBuildCost()
        {
            return 75;
        }

        //metody
        public void Upgrade()
        {
            level += 1;
            switch (level)
            {
                case 2:
                    ammo = 5;
                    dmg = 75;
                    return;
                default:
                    ammo = 8;
                    dmg = 100;
                    return;
            }
        }

        public void Shot()
        {
            ammo -= 1;
        }
    }
}
