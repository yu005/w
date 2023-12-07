using System;

namespace _1207
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bananaHero = new Player("BananaHero", 20, 500);
            Monster potatoDemon = new Monster("PotatoDemon", 10, 200);
            while (bananaHero.GetHP() != 0 && potatoDemon.GetHP() != 0)
            {
                bananaHero.GetHurt(potatoDemon.GetATK());
                potatoDemon.GetHurt(bananaHero.GetATK());
                potatoDemon.GetHurt(bananaHero.Fireball());
            }
        }
    }
    class Player
    {
        private string NAME;
        private int ATK;
        private int HP;
        public Player(string NAME, int ATK, int HP)
        {
            this.NAME = NAME;
            this.ATK = ATK;
            this.HP = HP;
        }
        public int GetATK()
        {
            return ATK;
        }
        public int GetHP()
        {
            return HP;
        }
        public int Fireball()
        {
            return ATK * 3;
        }
        public void GetHurt(int monsterATK)
        {
            HP -= monsterATK;
            if(HP<=0)
            {
                HP = 0;
                IsDead();
            }
            else
            {
                ShowHP();
            }
        }
        private void ShowHP()
        {
            Console.WriteLine($"Player {NAME} HP:{HP}");
        }
        private void IsDead()
        {
            Console.WriteLine($"Player {NAME} is dead");
        }

    }
    class Monster
    {
        private string NAME;
        private int ATK;
        private int HP;
        public Monster(string NAME, int ATK, int HP)
        {
            this.NAME = NAME;
            this.ATK = ATK;
            this.HP = HP;
        }
        public int GetATK()
        {
            return ATK;
        }
        public int GetHP()
        {
            return HP;
        }

        public void GetHurt(int playerATK)
        {
            HP -= playerATK;
            if (HP <= 0)
            {
                HP = 0;
                IsDead();
            }
            else
            {
                ShowHP();
            }
        }
        private void ShowHP()
        {
            Console.WriteLine($"Monster {NAME} HP:{HP}");
        }
        private void IsDead()
        {
            Console.WriteLine($"{NAME} is dead");
        }
    }
}
