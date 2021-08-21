using System;

namespace HealthSystem
{
    public abstract class Damageable
    {
        private int health;
        private int maxHealth;

        public Damageable(int initialHealth, int maxHealth) 
        {
            health = initialHealth;
            this.maxHealth = maxHealth;
        }

        public Damageable(int initialHealth) : this(initialHealth, initialHealth) {}

        public int GetHealth() {
            return health;
        }

        public bool IsDead() {
            return health <= 0;
        }

        public void TakeDamage(int amount) 
        {
            health = Math.Max(health-amount, 0);

            OnDamage(amount);

            if (IsDead())
                OnDeath();
        }

        public void Heal(int amount) 
        {
            int oldHealth = health;
            health = Math.Min(health+amount, maxHealth);

            OnHeal(health - oldHealth);
        }

        public void Resurrect() 
        {
            Heal(maxHealth);
        }

        public virtual void OnDamage(int amount) {}
        public virtual void OnHeal(int amount) {}
        public virtual void OnDeath() {}
    }
}
