using System;

namespace HealthSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy maBoi = new Enemy(100);

            maBoi.TakeDamage(50);
            maBoi.Heal(10);
            maBoi.TakeDamage(9000);
            maBoi.TakeDamage(50);
            maBoi.TakeDamage(50);
        }
    }

    class Enemy : Damageable
    {
        public Enemy(int initialHealth) : base(initialHealth) {}

        public override void OnDamage(int amount)
        {
            Console.WriteLine("Taken damage! " + amount);
        }

        public override void OnDeath()
        {
            Console.WriteLine("Dided");
        }

        public override void OnHeal(int amount)
        {
            Console.WriteLine("Healed for " + amount);
        }
    }
}
