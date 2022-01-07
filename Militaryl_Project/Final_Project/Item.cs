namespace Final_Project
{
    public class Item : Inventory
    {
        //Potion
        public static int mpPotion = 0;
        public static int hpPotion = 0;
        
        //Sword
        public static int wooddenSword = 0;
        public static int goldenSword = 0;
        public static int ironSword = 0;
        public static int dimonSword = 0;
        public static int titaniumSword = 0;
        
        //Bow
        public static int wooddenBow = 0;
        public static int goldenbow = 0;
        public static int ironbow = 0;
        public static int dimonbow = 0;
        public static int titaniumbow = 0;
        
        //staff
        public static int wooddenMagicWand = 0;
        public static int ironMagicWand = 0;
        public static int goldenMagicWand = 0;
        public static int dimonMagicWand = 0;
        public static int titaniumMagicWand = 0;
        
        //Hat
        public static int magicHat = 0;
        public static int warriorHelmet = 0;
        public static int carriageHat = 0;
        
        //Armor
        public static int magicArmor = 0;
        public static int warriorArmor = 0;
        public static int carriageArmor = 0;
        
        //Ring
        public static int enrageRing = 0;
        public static int sufferRing = 0;
        
        //Necklace
        public static int enrageNecklace = 0;
        public static int sufferNecklace = 0;



        public static bool isFull;
        public static int checkFull;
        public static  void CheckFull(Character character)
        {
            isFull = checkFull >= 5;
            checkFull = mpPotion + hpPotion + wooddenSword + goldenSword + ironSword + dimonSword + titaniumSword + wooddenBow+goldenbow+ironbow+dimonbow+titaniumbow+wooddenMagicWand+ironMagicWand+goldenMagicWand+dimonMagicWand+titaniumMagicWand+magicArmor+magicHat+warriorArmor+warriorHelmet+carriageArmor+carriageHat+enrageNecklace+enrageRing+sufferNecklace+sufferRing;
        }
    }
}