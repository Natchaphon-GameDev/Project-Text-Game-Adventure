using System;

namespace Final_Project
{
    public class Equipment : Item
    {
        //check old Item Equip
        public static int wepponEquip { get; set; }
        public static int HatEquip { get; set; }
        public static int ArmorEquip { get; set; }
        public static int AccessoryEquip { get; set; }
        
        public static bool knightRole { get; set; }
        public static bool archerRole { get; set; }
        public static bool mageRole { get; set; }
        private int addHp { get;  }
        private int addDef { get;  }
        private int addAttack { get; }
        private int addMP { get;  }


        public Equipment(int addhp, int adddef, int addattack, int addmp)
        {
            addHp = addhp;
            addDef = adddef;
            addAttack = addattack;
            addMP = addmp;
        }

        public static void ShowStatus(Equipment weppon)
        {
            Console.WriteLine($"*** Status : HP +{weppon.addHp}, MP +{weppon.addMP}, DEF +{weppon.addDef}, ATK +{weppon.addAttack} ***");
        }

        public virtual void AddStatus(Character character)
        {
            character.Hp += addHp;
            character.Def += addDef;
            character.Attack += addAttack;
            character.MP += addMP;
        }

        public static void CheckRole()
        {
            switch (Mode.playerRole)
            {
                case 1:
                    knightRole = true;
                    break;
                case 2:
                    archerRole = true;
                    break;
                case 3:
                    mageRole = true;
                    break;
                default:
                    knightRole = false;
                    archerRole = false;
                    mageRole = false;
                    break;
            }
        }
    }


    public class Sword : Equipment
    {
        public Sword(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            //When You Equip any item your old status item will disappear and you will get your item back
            switch (wepponEquip)
            {
                case 1:
                    character.Attack -= 10;
                    character.MP -= 25;
                    wooddenSword += 1;
                    break;
                case 2:
                    character.Attack -= 25;
                    character.MP -= 45;
                    ironSword += 1;
                    break;
                case 3:
                    character.Attack -= 40;
                    character.MP -= 45;
                    goldenSword += 1;
                    break;
                case 4:
                    character.Attack -= 55;
                    character.MP -= 55;
                    dimonSword += 1;
                    break;
                case 5:
                    character.Attack -= 60;
                    character.MP -= 70;
                    titaniumSword += 1;
                    break;
            }
        }
    }

    public class Bow : Equipment
    {
        public Bow(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            switch (wepponEquip)
            {
                case 6:
                    character.Attack -= 15;
                    character.MP -= 25;
                    wooddenBow += 1;
                    break;
                case 7:
                    character.Attack -= 30;
                    character.MP -= 45;
                    ironbow += 1;
                    break;
                case 8:
                    character.Attack -= 45;
                    character.MP -= 45;
                    goldenbow += 1;
                    break;
                case 9:
                    character.Attack -= 60;
                    character.MP -= 55;
                    dimonbow += 1;
                    break;
                case 10:
                    character.Attack -= 70;
                    character.MP -= 65;
                    titaniumbow += 1;
                    break;
            }
        }
    }

    public class MagicWand : Equipment
    {
        public MagicWand(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            switch (wepponEquip)
            {
                case 11:
                    character.Attack -= 20;
                    character.MP -= 25;
                    wooddenMagicWand += 1;
                    break;
                case 12:
                    character.Attack -= 35;
                    character.MP -= 45;
                    ironMagicWand += 1;
                    break;
                case 13:
                    character.Attack -= 45;
                    character.MP -= 55;
                    goldenMagicWand += 1;
                    break;
                case 14:
                    character.Attack -= 55;
                    character.MP -= 65;
                    dimonMagicWand += 1;
                    break;
                case 15:
                    character.Attack -= 75;
                    character.MP -= 75;
                    titaniumMagicWand += 1;
                    break;
            }
        }
    }
    public class Hat : Equipment
    {
        public Hat(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            switch (HatEquip)
            {
                case 1:
                    character.Hp -= 40;
                    character.Def -= 5;
                    character.MP -= 60;
                    magicHat += 1;
                    break;
                case 2:
                    character.Hp -= 140;
                    character.Def -= 10;
                    character.MP -= 25;
                    warriorHelmet += 1;
                    break;
                case 3:
                    character.Hp -= 80;
                    character.Def -= 7;
                    character.MP -= 35;
                    carriageHat += 1;
                    break;
            }
        }
    }
    public class Armor : Equipment
    {
        public Armor(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            switch (ArmorEquip)
            {
                case 1:
                    character.Hp -= 90;
                    character.Def -= 5;
                    character.MP -= 30;
                    magicArmor += 1;
                    break;
                case 2:
                    character.Hp -= 180;
                    character.Def -= 10;
                    character.MP -= 15;
                    warriorArmor += 1;
                    break;
                case 3:
                    character.Hp -= 140;
                    character.Def -= 7;
                    character.MP -= 20;
                    carriageArmor += 1;
                    break;
            }
        }
    }
    public class Accessory  : Equipment
    {
        public Accessory(int addhp, int adddef, int addattack, int addmp) : base(addhp, adddef, addattack, addmp)
        {

        }

        public override void AddStatus(Character character)
        {
            base.AddStatus(character);
            switch (AccessoryEquip)
            {
                case 1:
                    character.Hp -= 25;
                    character.Attack -= 50;
                    character.MP -= 30;
                    enrageRing += 1;
                    break;
                case 2:
                    character.Hp -= 50;
                    character.Attack -= 25;
                    character.MP -= 30;
                    sufferRing += 1;
                    break;
                case 3:
                    character.Hp -= 50;
                    character.Attack -= 60;
                    character.MP -= 45;
                    enrageNecklace += 1;
                    break;
                case 4:
                    character.Hp -= 75;
                    character.Attack -= 25;
                    character.MP -= 45;
                    sufferNecklace += 1;
                    break;
            }
        }
    }
}

    
