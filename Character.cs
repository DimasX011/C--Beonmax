using System;
using System.Collections.Generic;
using System.Text;

namespace D__OOP
{
    public class Character
    {
        public static int speed = 10;
        public int Health {
            //доступ на чтение
            get;
            //доступ на запись
            private set; } = 100;
        public void Hit (int damage)
        {
            if (damage > Health)
                damage = Health;



            Health -= damage;
        }

        public int  PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
