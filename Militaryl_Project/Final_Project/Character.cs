using System;

namespace Final_Project
{
    public class Character
    {
        public static string Role  {get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }
        public int Attack { get; set; }
        public int MP { get; set; }
        public bool isDead { get; set; }

        public static string enemyName { get; set; }

        public Character(int hp, int def , int attack , int mp, bool isdead)
        {
            Hp = hp;
            Def = def;
            Attack = attack;
            MP = mp;
            isDead = isdead;
        }

        public static void ShowPlayerStatus(Character character)
        {
            Console.WriteLine($"Role : {Role}");
            Console.WriteLine($"Character : {Mode.playerName}");
            Console.WriteLine($"Status : HP  {character.Hp}");
            Console.WriteLine($"         DEF {character.Def}");
            Console.WriteLine($"         MP  {character.MP}");
            Console.WriteLine($"         Atk {character.Attack}");
        }
    }

    public class Knight : Character
    {
        public Knight(int hp, int def, int attack, int mp, bool isdead) : base(hp, def, attack, mp, isdead)
        {
            
        }
        
        
        public  void  ShowPlayerStatus(Character character)
        {
            Character.ShowPlayerStatus(character);
        }
        
    }
    
    public class Archer : Character
    {
        public Archer(int hp, int def, int attack, int mp, bool isdead) : base(hp, def, attack, mp, isdead)
        {
           
        }
        
        public  void  ShowPlayerStatus(Character character)
        {
            Character.ShowPlayerStatus(character);
        }
        
        
    }
    
    public class Mage : Character
    {
        public Mage(int hp, int def, int attack, int mp, bool isdead) : base(hp, def, attack, mp, isdead)
        {
           
        }
        
        public  void  ShowPlayerStatus(Character character)
        {
            Character.ShowPlayerStatus(character);
        }
    }

    public class Enemy : Character
    {
        public Enemy(string name,int hp, int def, int attack, int mp, bool isdead) : base(hp, def, attack, mp, isdead)
        {
            enemyName = name;
        }
    }
    
    public class Boss : Character
    {
        Random rnd = new Random();
        public Boss(string name,int hp, int def, int attack, int mp, bool isdead) : base(hp, def, attack, mp, isdead)
        {
            enemyName = name;
            var attackType = rnd.Next(1,4);
            // random boss
            if (attackType == 2)
            {
                Attack += 50;
                Console.WriteLine("Special Even(Boss +ATK 50)");
            }
        }
    }
    
}