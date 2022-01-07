using System;
namespace Final_Project
{
    public class Inventory
    {
        public enum item
        {
            HealingPotion,
            ManaPotion,
            Wooden_Sword,
            Iron_Sword,
            Golden_Sword,
            Dimon_Sword,
            TitaniumSword,
            Woodden_Bow,
            Iron_Bow,
            Golden_Bow,
            Dimon_Bow,
            Titanium_Bow,
            Woodden_Magic_Wand,
            Iron_Magic_Wand,
            Golden_Magic_Wand,
            Dimon_Magic_Wand,
            Titanium_Magic_Wand,
            Magic_Hat,
            Warrior_Helmet,
            Carriage_Hat,
            Magic_Armor,
            Warrior_Armor,
            Carriage_Armor,
            Enrage_Ring,
            Suffer_Ring,
            Enrage_Necklace,
            Suffer_Necklace,
            
        }
        
        // Sword Constructor
        private static Sword _wSword = new Sword(0, 0, 10, 25);
        private static Sword _iSword = new Sword(0, 0, 25, 45);
        private static Sword _gSword = new Sword(0, 0, 40, 45);
        private static Sword _dSword = new Sword(0, 0, 55, 55);
        private static Sword _tSword = new Sword(0, 0, 60, 70);
              
         // Bow Constructor
        private static Bow _wBow = new Bow(0, 0, 15, 25);
        private static Bow _iBow = new Bow(0, 0, 30, 45);
        private static Bow _gBow = new Bow(0, 0, 45, 45);
        private static Bow _dBow = new Bow(0, 0, 60, 55);
        private static Bow _tBow = new Bow(0, 0, 70, 65);
             
        // MagicWand Constructor
        private static MagicWand _wMagicWand = new MagicWand(0, 0, 20, 25);
        private static MagicWand _iMagicWand = new MagicWand(0, 0, 35, 45);
        private static MagicWand _gMagicWand = new MagicWand(0, 0, 45, 55);
        private static MagicWand _dMagicWand = new MagicWand(0, 0, 55, 65);
        private static MagicWand _tMagicWand = new MagicWand(0, 0, 75, 75);
             
        // Hat Constructor
        private static Hat _mHat = new Hat(40, 5, 0, 60);
        private static Hat _wHat = new Hat(140, 10, 0, 25);
        private static Hat _cHat = new Hat(90, 7, 0, 35);
             
        // Armor Constructor
        private static Armor _mArmor = new Armor(90, 5, 0, 30);
        private static Armor _wArmor = new Armor(180, 10, 0, 15);
        private static Armor _cArmor = new Armor(140, 7, 0, 20);
             
        // Ring Constructor
        private static Accessory _eRing = new Accessory(25, 0, 50, 30);
        private static Accessory _sRing = new Accessory(50, 0, 25, 30);
 
        // Necklace Constructor
        private static Accessory _eNecklace = new Accessory(50, 0, 60, 45);
        private static Accessory _sNecklace = new Accessory(75, 0, 25, 45);

        static UI ui = new UI();
        
        public static string itemUse { get; private set; }
        public static string itemDrop { get; private set; }
        private static Random rnd = new Random();
        private static Type type = typeof(item);
        private static Array values = type.GetEnumValues();

        public static void RandomItem(Character character)
        {
            Item.CheckFull(character);
            var index = rnd.Next(values.Length);
            var value = (item) values.GetValue(index);
            Console.WriteLine($"You Found {value}!!");
            Console.WriteLine();
            switch (value)
            {
                case item.HealingPotion when Item.isFull:
                    ui.HealingPotion();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.HealingPotion:
                    ui.HealingPotion();
                    Item.hpPotion += 1;
                    break;
                case item.ManaPotion when Item.isFull:
                    Console.WriteLine("Your Inventory is Full!");
                    ui.ManaPotion();
                    Console.WriteLine();
                    break;
                case item.ManaPotion:
                    ui.ManaPotion();
                    Item.mpPotion += 1;
                    break;
                case item.Wooden_Sword when Item.isFull:
                    ui.WooddenSword();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Wooden_Sword:
                    ui.WooddenSword();
                    Item.wooddenSword += 1;
                    break;
                case item.Iron_Sword when Item.isFull:
                    ui.IronSword();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Iron_Sword:
                    ui.IronSword();
                    Item.ironSword += 1;
                    break;
                case item.Golden_Sword when Item.isFull:
                    ui.GoldSword();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Golden_Sword:
                    ui.GoldSword();
                    Item.goldenSword += 1;
                    break;
                case item.Dimon_Sword when Item.isFull:
                    ui.DimonSword();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Dimon_Sword:
                    ui.DimonSword();
                    Item.dimonSword += 1;
                    break;
                case item.TitaniumSword when Item.isFull:
                    ui.TitaniumSword();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.TitaniumSword:
                    ui.TitaniumSword();
                    Item.titaniumSword += 1;
                    break;
                case item.Woodden_Bow when Item.isFull:
                    ui.WooddenBow();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Woodden_Bow:
                    ui.WooddenBow();
                    Item.wooddenBow += 1;
                    break;
                case item.Golden_Bow when Item.isFull:
                    ui.GoldBow();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Golden_Bow:
                    ui.GoldBow();
                    Item.goldenbow += 1;
                    break;
                case item.Iron_Bow when Item.isFull:
                    ui.IronBow();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Iron_Bow:
                    ui.IronBow();
                    Item.ironbow += 1;
                    break;
                case item.Dimon_Bow when Item.isFull:
                    ui.DimonBow();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Dimon_Bow:
                    ui.DimonBow();
                    Item.dimonbow += 1;
                    break;
                case item.Titanium_Bow when Item.isFull:
                    ui.TitaniumBow();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Titanium_Bow:
                    ui.TitaniumBow();
                    Item.titaniumbow += 1;
                    break;
                case item.Woodden_Magic_Wand when Item.isFull:
                    ui.WooddenMagicWand();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Woodden_Magic_Wand:
                    ui.WooddenMagicWand();
                    Item.wooddenMagicWand += 1;
                    break;
                case item.Iron_Magic_Wand when Item.isFull:
                    ui.IronMagicWand();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Iron_Magic_Wand:
                    ui.IronMagicWand();
                    Item.ironMagicWand += 1;
                    break;
                case item.Golden_Magic_Wand when Item.isFull:
                    ui.GoldMagicWand();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Golden_Magic_Wand:
                    ui.GoldMagicWand();
                    Item.goldenMagicWand += 1;
                    break;
                case item.Dimon_Magic_Wand when Item.isFull:
                    ui.DimonMagicWand();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Dimon_Magic_Wand:
                    ui.DimonMagicWand();
                    Item.dimonMagicWand += 1;
                    break;
                case item.Titanium_Magic_Wand when Item.isFull:
                    ui.TitaniumMagicWand();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Titanium_Magic_Wand:
                    ui.TitaniumMagicWand();
                    Item.titaniumMagicWand += 1;
                    break;
                case item.Magic_Hat when Item.isFull:
                    ui.MaigcHat();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Magic_Hat:
                    ui.MaigcHat();
                    Item.magicHat += 1;
                    break;
                case item.Warrior_Helmet when Item.isFull:
                    ui.WarriorHelmet();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Warrior_Helmet:
                    ui.WarriorArmor();
                    Item.warriorArmor += 1;
                    break;
                case item.Carriage_Hat when Item.isFull:
                    ui.CarriageHat();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Carriage_Hat:
                    ui.CarriageHat();
                    Item.carriageHat += 1;
                    break;
                case item.Magic_Armor when Item.isFull:
                    ui.MagicArmor();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Magic_Armor:
                    ui.MagicArmor();
                    Item.magicArmor += 1;
                    break;
                case item.Warrior_Armor when Item.isFull:
                    ui.WarriorArmor();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Warrior_Armor:
                    ui.WarriorArmor();
                    Item.warriorArmor += 1;
                    break;
                case item.Carriage_Armor when Item.isFull:
                    ui.CarriageArmor();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Carriage_Armor:
                    ui.CarriageArmor();
                    Item.carriageArmor += 1;
                    break;
                case item.Suffer_Ring when Item.isFull:
                    ui.SufferRing();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Suffer_Ring:
                    ui.SufferRing();
                    Item.sufferRing += 1;
                    break;
                case item.Enrage_Ring when Item.isFull:
                    ui.EnrageRing();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Enrage_Ring:
                    ui.EnrageRing();
                    Item.enrageRing += 1;
                    break;
                case item.Suffer_Necklace when Item.isFull:
                    ui.SufferNecklace();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Suffer_Necklace:
                    ui.SufferNecklace();
                    Item.sufferNecklace += 1;
                    break;
                case item.Enrage_Necklace when Item.isFull:
                    ui.EnrageNecklace();
                    Console.WriteLine();
                    Console.WriteLine("Your Inventory is Full!");
                    break;
                case item.Enrage_Necklace:
                    ui.EnrageNecklace();
                    Item.enrageNecklace += 1;
                    break;
            }



        }

        public static void ShowInventory(Character character)
        {
            Item.CheckFull(character);
            if (Item.hpPotion >= 1 && Item.hpPotion <= 5)
            {
                for (var i = 0; i < Item.hpPotion; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[H] Healing Potion");
                    Console.WriteLine("*** +HP 100 Points ***");
                    ui.HealingPotion();
                }
            }

            if (Item.mpPotion >= 1 && Item.mpPotion <= 5)
            {
                for (var i = 0; i < Item.mpPotion; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[M] Mana Potion");
                    Console.WriteLine("*** +MP 50 Points ***");
                    ui.ManaPotion();
                }
            }

            if (Item.wooddenSword >= 1 && Item.wooddenSword <= 5)
            {
                for (var i = 0; i < Item.wooddenSword; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[WS] Woodden Sword");
                    Equipment.ShowStatus(_wSword);
                    ui.WooddenSword();
                }
            }

            if (Item.ironSword >= 1 && Item.ironSword <= 5)
            {
                for (var i = 0; i < Item.ironSword; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[IS] Iron Sword");
                    Equipment.ShowStatus(_iSword);
                    ui.IronSword();
                }
            }

            if (Item.goldenSword >= 1 && Item.goldenSword <= 5)
            {
                for (var i = 0; i < Item.goldenSword; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[GS] Golden Sword");
                    Equipment.ShowStatus(_gSword);
                    ui.GoldSword();
                }
            }

            if (Item.dimonSword >= 1 && Item.dimonSword <= 5)
            {
                for (var i = 0; i < Item.dimonSword; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[DS] Dimon Sword");
                    Equipment.ShowStatus(_dSword);
                    ui.DimonSword();
                }
            }

            if (Item.titaniumSword >= 1 && Item.titaniumSword <= 5)
            {
                for (var i = 0; i < Item.titaniumSword; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[TS] Titanium Sword");
                    Equipment.ShowStatus(_tSword);
                    ui.TitaniumSword();
                }
            }
            if (Item.wooddenBow >= 1 && Item.wooddenBow <= 5)
            {
                for (var i = 0; i < Item.wooddenBow; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[WB] Woodden Bow");
                    Equipment.ShowStatus(_wBow);
                    ui.WooddenBow();
                }
            }
            if (Item.ironbow >= 1 && Item.ironbow <= 5)
            {
                for (var i = 0; i < Item.ironbow; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[IB] Iron Bow");
                    Equipment.ShowStatus(_iBow);
                    ui.IronBow();
                }
            }
            if (Item.goldenbow >= 1 && Item.goldenbow <= 5)
            {
                for (var i = 0; i < Item.goldenbow; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[GB] Golden Bow");
                    Equipment.ShowStatus(_gBow);
                    ui.GoldBow();
                }
            }
            if (Item.dimonbow >= 1 && Item.dimonbow <= 5)
            {
                for (var i = 0; i < Item.dimonbow; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[DB] Dimon Bow");
                    Equipment.ShowStatus(_dBow);
                    ui.DimonBow();
                }
            }
            if (Item.titaniumbow >= 1 && Item.titaniumbow <= 5)
            {
                for (var i = 0; i < Item.titaniumbow; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[TB] Titanium Bow");
                    Equipment.ShowStatus(_tBow);
                    ui.TitaniumBow();
                }
            }
            if (Item.wooddenMagicWand >= 1 && Item.wooddenMagicWand <= 5)
            {
                for (var i = 0; i < Item.wooddenMagicWand; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[WM] Woodden Magic Wand");
                    Equipment.ShowStatus(_wMagicWand);
                    ui.WooddenMagicWand();
                }
            }
            if (Item.ironMagicWand >= 1 && Item.ironMagicWand <= 5)
            {
                for (var i = 0; i < Item.ironMagicWand; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[IM] Iron Magic Wand");
                    Equipment.ShowStatus(_iMagicWand);
                    ui.IronMagicWand();
                }
            }
            if (Item.goldenMagicWand >= 1 && Item.goldenMagicWand <= 5)
            {
                for (var i = 0; i < Item.goldenMagicWand; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[GM] Golden Magic Wand");
                    Equipment.ShowStatus(_gMagicWand);
                    ui.GoldMagicWand();
                }
            }
            if (Item.dimonMagicWand >= 1 && Item.dimonMagicWand <= 5)
            {
                for (var i = 0; i < Item.dimonMagicWand; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[DM] Dimon Magic Wand");
                    Equipment.ShowStatus(_dMagicWand);
                    ui.DimonMagicWand();
                }
            }
            if (Item.titaniumMagicWand >= 1 && Item.titaniumMagicWand <= 5)
            {
                for (var i = 0; i < Item.titaniumMagicWand; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[TM] Titanium Magic Wand");
                    Equipment.ShowStatus(_tMagicWand);
                    ui.TitaniumMagicWand();
                }
            }
            if (Item.magicHat >= 1 && Item.magicHat <= 5)
            {
                for (var i = 0; i < Item.magicHat; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[MH] Magic Hat");
                    Equipment.ShowStatus(_mHat);
                    ui.MaigcHat();
                }
            }
            if (Item.warriorHelmet >= 1 && Item.warriorHelmet <= 5)
            {
                for (var i = 0; i < Item.warriorHelmet; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[WH] Warrior Helmet");
                    Equipment.ShowStatus(_wHat);
                    ui.WarriorHelmet();
                }
            }
            if (Item.carriageHat >= 1 && Item.carriageHat <= 5)
            {
                for (var i = 0; i < Item.carriageHat; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[CH] Carriage Hat");
                    Equipment.ShowStatus(_cHat);
                    ui.CarriageHat();
                }
            }
            if (Item.magicArmor >= 1 && Item.magicArmor <= 5)
            {
                for (var i = 0; i < Item.magicArmor; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[MA] Magic Armor");
                    Equipment.ShowStatus(_mArmor);
                    ui.MagicArmor();
                }
            }
            if (Item.warriorArmor >= 1 && Item.warriorArmor <= 5)
            {
                for (var i = 0; i < Item.warriorArmor; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[WA] Warrior Armor");
                    Equipment.ShowStatus(_wArmor);
                    ui.WarriorArmor();
                }
            }
            if (Item.carriageArmor >= 1 && Item.carriageArmor <= 5)
            {
                for (var i = 0; i < Item.carriageArmor; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[CA] Carriage Armor");
                    Equipment.ShowStatus(_cArmor);
                    ui.CarriageArmor();
                }
            }
            if (Item.enrageRing >= 1 && Item.enrageRing <= 5)
            {
                for (var i = 0; i < Item.enrageRing; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[ER] Enrage Ring");
                    Equipment.ShowStatus(_eRing);
                    ui.EnrageRing();
                }
            }
            if (Item.sufferRing >= 1 && Item.sufferRing <= 5)
            {
                for (var i = 0; i < Item.sufferRing; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[SR] Suffer Ring");
                    Equipment.ShowStatus(_sRing);
                    ui.SufferRing();
                }
            }
            if (Item.enrageNecklace >= 1 && Item.enrageNecklace <= 5)
            {
                for (var i = 0; i < Item.enrageNecklace; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[EN] Enrage Necklace");
                    Equipment.ShowStatus(_eNecklace);
                    ui.EnrageNecklace();
                }
            }
            if (Item.sufferNecklace >= 1 && Item.sufferNecklace <= 5)
            {
                for (var i = 0; i < Item.sufferNecklace; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("[SN] Suffer Necklace");
                    Equipment.ShowStatus(_sNecklace);
                    ui.SufferNecklace();
                }
            }
            Console.WriteLine();
            Console.WriteLine("if you want to use Item Press [I] to Switch Mode");
            Console.WriteLine("if you want to drop Item Press [D] to Switch Mode");
            Console.WriteLine("if you want to exit the inventory Press [Q] to Quit");
        }
        public static void UseItem(Character character)
        {
            multiUse:
            {
                Item.CheckFull(character);
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("     Mode Use Item");
                Console.WriteLine("=======================");
                ShowInventory(character);
                itemUse = Console.ReadLine();
                switch (itemUse)
                {
                    case "q":
                    case "Q":
                        return;
                    case "D":
                    case "d":
                        DropItem(character);
                        break;
                    case "I":
                    case "i":
                        UseItem(character);
                        break;
                    case "h":
                    case "H":
                        if (Item.hpPotion > 0)
                        {
                            Item.hpPotion -= 1;
                            character.Hp += 100;
                            Console.WriteLine("...Using Healing Potion...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Healing Potion...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "m":
                    case "M":
                        if (Item.mpPotion > 0)
                        {
                            Item.mpPotion -= 1;
                            character.MP += 50;
                            Console.WriteLine("...Using Mana Potion...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Mana Potion...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ws":
                    case "WS":
                        if (Item.wooddenSword > 0)
                        {
                            if (Equipment.knightRole)
                            {
                                Item.wooddenSword -= 1;
                                _wSword.AddStatus(character);
                                Console.WriteLine("...Using Woodden Sword...");
                                Equipment.wepponEquip = 1;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "is":
                    case "IS":
                        if (Item.ironSword > 0)
                        {
                            if (Equipment.knightRole)
                            {
                                Item.ironSword -= 1;
                                _iSword.AddStatus(character);
                                Console.WriteLine("...Using Iron Sword...");
                                Equipment.wepponEquip = 2;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gs":
                    case "GS":
                        if (Item.goldenSword > 0)
                        {
                            if (Equipment.knightRole)
                            {
                                Item.goldenSword -= 1;
                                _gSword.AddStatus(character);
                                Console.WriteLine("...Using Golden Sword...");
                                Equipment.wepponEquip = 3;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ds":
                    case "DS":
                        if (Item.dimonSword > 0)
                        {
                            if (Equipment.knightRole)
                            {
                                Item.dimonSword -= 1;
                                _dSword.AddStatus(character);
                                Console.WriteLine("...Using Dimon Sword...");
                                Equipment.wepponEquip = 4;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimom Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ts":
                    case "TS":
                        if (Item.titaniumSword > 0)
                        {
                            if (Equipment.knightRole)
                            {
                                Item.titaniumSword -= 1;
                                _tSword.AddStatus(character);
                                Console.WriteLine("...Using Titanium Sword...");
                                Equipment.wepponEquip = 5;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wb":
                    case "WB":
                        if (Item.wooddenBow > 0)
                        {
                            if (Equipment.archerRole)
                            {
                                Item.wooddenBow -= 1;
                                _wBow.AddStatus(character);
                                Console.WriteLine("...Using WooddenBow Bow...");
                                Equipment.wepponEquip = 6;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden Bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ib":
                    case "IB":
                        if (Item.ironbow > 0)
                        {
                            if (Equipment.archerRole)
                            {
                                Item.ironbow -= 1;
                                _iBow.AddStatus(character);
                                Console.WriteLine("...Using Iron Bow...");
                                Equipment.wepponEquip = 7;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron Bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gb":
                    case "GB":
                        if (Item.goldenbow > 0)
                        {
                            if (Equipment.archerRole)
                            {
                                Item.goldenbow -= 1;
                                _gBow.AddStatus(character);
                                Console.WriteLine("...Using Golden Bow...");
                                Equipment.wepponEquip = 8;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden Bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "db":
                    case "DB":
                        if (Item.dimonbow > 0)
                        {
                            if (Equipment.archerRole)
                            {
                                Item.dimonbow -= 1;
                                _dBow.AddStatus(character);
                                Console.WriteLine("...Using Dimon Bow...");
                                Equipment.wepponEquip = 9;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimon Bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "tb":
                    case "TB":
                        if (Item.titaniumbow > 0)
                        {
                            if (Equipment.archerRole)
                            {
                                Item.titaniumbow -= 1;
                                _tBow.AddStatus(character);
                                Console.WriteLine("...Using Titanium Bow...");
                                Equipment.wepponEquip = 10;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium Bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wm":
                    case "WM":
                        if (Item.wooddenMagicWand > 0)
                        {
                            if (Equipment.mageRole)
                            {
                                Item.wooddenMagicWand -= 1;
                                _wMagicWand.AddStatus(character);
                                Console.WriteLine("...Using Woodden Magic Wand...");
                                Equipment.wepponEquip = 11;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "im":
                    case "IM":
                        if (Item.ironMagicWand > 0)
                        {
                            if (Equipment.mageRole)
                            {
                                Item.ironMagicWand -= 1;
                                _iMagicWand.AddStatus(character);
                                Console.WriteLine("...Using Iron Magic Wand...");
                                Equipment.wepponEquip = 12;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gm":
                    case "GM":
                        if (Item.goldenMagicWand > 0)
                        {
                            if (Equipment.mageRole)
                            {
                                Item.goldenMagicWand -= 1;
                                _gMagicWand.AddStatus(character);
                                Console.WriteLine("...Using Golden Magic Wand...");
                                Equipment.wepponEquip = 13;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "dm":
                    case "DM":
                        if (Item.dimonMagicWand > 0)
                        {
                            if (Equipment.mageRole)
                            {
                                Item.dimonMagicWand -= 1;
                                _dMagicWand.AddStatus(character);
                                Console.WriteLine("...Using Dimon Magic Wand...");
                                Equipment.wepponEquip = 14;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimon Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "tm":
                    case "TM":
                        if (Item.titaniumMagicWand > 0)
                        {
                            if (Equipment.mageRole)
                            {
                                Item.titaniumMagicWand -= 1;
                                _tMagicWand.AddStatus(character);
                                Console.WriteLine("...Using Titanium Magic Wand...");
                                Equipment.wepponEquip = 15;
                                System.Threading.Thread.Sleep(1000);
                                goto multiUse;
                            }
                            else
                            {
                                Console.WriteLine("Your Role can't be worn");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "mh":
                    case "MH":
                        if (Item.magicHat > 0)
                        {
                            Item.magicHat -= 1;
                            _mHat.AddStatus(character);
                            Console.WriteLine("...Using Magic Hat...");
                            Equipment.HatEquip = 1;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Magic Hat...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wh":
                    case "WH":
                        if (Item.warriorHelmet > 0)
                        {
                            Item.warriorHelmet -= 1;
                            _wHat.AddStatus(character);
                            Console.WriteLine("...Using Warrior Helmet...");
                            Equipment.HatEquip = 2;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Warrior Helmet...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ch":
                    case "CH":
                        if (Item.carriageHat > 0)
                        {
                            Item.carriageHat -= 1;
                            _cHat.AddStatus(character);
                            Console.WriteLine("...Using Carriage Hat...");
                            Equipment.HatEquip = 3;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Carriage Hat...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ma":
                    case "MA":
                        if (Item.magicArmor > 0)
                        {
                            Item.magicArmor -= 1;
                            _mArmor.AddStatus(character);
                            Console.WriteLine("...Using Magic Armor...");
                            Equipment.ArmorEquip = 1;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Magic Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wa":
                    case "WA":
                        if (Item.warriorArmor > 0)
                        {
                            Item.warriorArmor -= 1;
                            _wArmor.AddStatus(character);
                            Console.WriteLine("...Using Warrior Armor...");
                            Equipment.ArmorEquip = 2;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Warrior Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ca":
                    case "CA":
                        if (Item.carriageArmor > 0)
                        {
                            Item.carriageArmor -= 1;
                            _cArmor.AddStatus(character);
                            Console.WriteLine("...Using Carriage Armor...");
                            Equipment.ArmorEquip = 3;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Carriage Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "er":
                    case "ER":
                        if (Item.enrageRing > 0)
                        {
                            Item.enrageRing -= 1;
                            _eRing.AddStatus(character);
                            Console.WriteLine("...Using Enrage Ring...");
                            Equipment.AccessoryEquip = 1;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Enrage Ring...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "sr":
                    case "SR":
                        if (Item.sufferRing > 0)
                        {
                            Item.sufferRing -= 1;
                            _sRing.AddStatus(character);
                            Console.WriteLine("...Using Suffer Ring...");
                            Equipment.AccessoryEquip = 2;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Suffer Ring...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "en":
                    case "EN":
                        if (Item.enrageNecklace > 0)
                        {
                            Item.enrageNecklace -= 1;
                            _eNecklace.AddStatus(character);
                            Console.WriteLine("...Using Enrage Necklace...");
                            Equipment.AccessoryEquip = 3;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Enrage Necklace...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "sn":
                    case "SN":
                        if (Item.sufferNecklace > 0)
                        {
                            Item.sufferNecklace -= 1;
                            _sNecklace.AddStatus(character);
                            Console.WriteLine("...Using suffer Necklace...");
                            Equipment.AccessoryEquip = 4;
                            System.Threading.Thread.Sleep(1000);
                            goto multiUse;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have suffer Necklace...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    default:
                        Console.WriteLine("You Don't Follow the Introduction, The System will get back to Main action!");
                        return;
                }
            }
        }

        public static void DropItem(Character character)
        {
            multiDrop: //to Drop for multtply and can check list of dropped item
            {
                Item.CheckFull(character);
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("    Mode Drop Item");
                Console.WriteLine("=======================");
                ShowInventory(character);
                itemDrop = Console.ReadLine();
                switch (itemDrop)
                {
                    case "q":
                    case "Q":
                        return;
                    case "D":
                    case "d":
                        DropItem(character);
                        break;
                    case "I":
                    case "i":
                        UseItem(character);
                        break;
                    case "h":
                    case "H":
                        if (Item.hpPotion > 0)
                        {
                            Item.hpPotion -= 1;
                            Console.WriteLine("...Healing Potion was dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Healing Potion...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "m":
                    case "M":
                        if (Item.mpPotion > 0)
                        {
                            Item.mpPotion -= 1;
                            Console.WriteLine("...Mana Potion has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Mana Potion...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ws":
                    case "WS":
                        if (Item.wooddenSword > 0)
                        {
                            Item.wooddenSword -= 1;
                            Console.WriteLine("...Woodden Sword has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "is":
                    case "IS":
                        if (Item.ironSword > 0)
                        {
                            Item.ironSword -= 1;
                            Console.WriteLine("...Iron Sword has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gs":
                    case "GS":
                        if (Item.goldenSword > 0)
                        {
                            Item.goldenSword -= 1;
                            Console.WriteLine("...Golden Sword has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ds":
                    case "DS":
                        if (Item.dimonSword > 0)
                        {
                            Item.dimonSword -= 1;
                            Console.WriteLine("...Dimon Sword has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimom Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ts":
                    case "TS":
                        if (Item.titaniumSword > 0)
                        {
                            Item.titaniumSword -= 1;
                            Console.WriteLine("...Titanium Sword has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium Sword...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wb":
                    case "WB":
                        if (Item.wooddenBow > 0)
                        {
                            Item.wooddenBow -= 1;
                            Console.WriteLine("...Woodden Bow has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ib":
                    case "IB":
                        if (Item.ironbow > 0)
                        {
                            Item.ironbow -= 1;
                            Console.WriteLine("...Iron Bow has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gb":
                    case "GB":
                        if (Item.goldenbow > 0)
                        {
                            Item.goldenbow -= 1;
                            Console.WriteLine("...Golden Bow has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "db":
                    case "DB":
                        if (Item.dimonbow > 0)
                        {
                            Item.dimonbow -= 1;
                            Console.WriteLine("...Dimon Bow has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimon bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "tb":
                    case "TB":
                        if (Item.titaniumbow > 0)
                        {
                            Item.titaniumbow -= 1;
                            Console.WriteLine("...Titanium Bow has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium bow...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wm":
                    case "WM":
                        if (Item.wooddenMagicWand > 0)
                        {
                            Item.wooddenMagicWand -= 1;
                            Console.WriteLine("...Woodden Magic Wand has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Woodden Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "im":
                    case "IM":
                        if (Item.ironMagicWand > 0)
                        {
                            Item.ironMagicWand -= 1;
                            Console.WriteLine("...Iron Magic Wand has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Iron Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "gm":
                    case "GM":
                        if (Item.goldenMagicWand > 0)
                        {
                            Item.goldenMagicWand -= 1;
                            Console.WriteLine("...Golden Magic Wand has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Golden Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "dm":
                    case "DM":
                        if (Item.dimonMagicWand > 0)
                        {
                            Item.dimonMagicWand -= 1;
                            Console.WriteLine("...Dimon Magic Wand has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Dimon Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "tm":
                    case "TM":
                        if (Item.titaniumMagicWand > 0)
                        {
                            Item.titaniumMagicWand -= 1;
                            Console.WriteLine("...Titanium Magic Wand has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Titanium Magic Wand...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "mh":
                    case "MH":
                        if (Item.magicHat > 0)
                        {
                            Item.magicHat -= 1;
                            Console.WriteLine("...Magic Hat has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Magic Hat...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wh":
                    case "WH":
                        if (Item.warriorHelmet > 0)
                        {
                            Item.warriorHelmet -= 1;
                            Console.WriteLine("...Warrior Helmet has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Warrior Helmet...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ch":
                    case "CH":
                        if (Item.carriageHat > 0)
                        {
                            Item.carriageHat -= 1;
                            Console.WriteLine("...Carriage Hat has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Carriage Hat...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ma":
                    case "MA":
                        if (Item.magicArmor > 0)
                        {
                            Item.magicArmor -= 1;
                            Console.WriteLine("...Magic Armor has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Magic Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "wa":
                    case "WA":
                        if (Item.warriorArmor > 0)
                        {
                            Item.warriorArmor -= 1;
                            Console.WriteLine("...Warrior Armor has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Warrior Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "ca":
                    case "CA":
                        if (Item.carriageArmor > 0)
                        {
                            Item.carriageArmor -= 1;
                            Console.WriteLine("...Carriage Armor has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Carriage Armor...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "er":
                    case "ER":
                        if (Item.enrageRing > 0)
                        {
                            Item.enrageRing -= 1;
                            Console.WriteLine("...Enrage Ring has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Enrage Ring...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "sr":
                    case "SR":
                        if (Item.sufferRing > 0)
                        {
                            Item.sufferRing -= 1;
                            Console.WriteLine("...Suffer Ring has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Suffer Ring...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "en":
                    case "EN":
                        if (Item.enrageNecklace > 0)
                        {
                            Item.enrageNecklace -= 1;
                            Console.WriteLine("...Enrage Necklace has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Enrage Necklace...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    case "sn":
                    case "SN":
                        if (Item.sufferNecklace > 0)
                        {
                            Item.sufferNecklace -= 1;
                            Console.WriteLine("...Suffer Necklace has dropped...");
                            System.Threading.Thread.Sleep(1000);
                            goto multiDrop;
                        }
                        else
                        {
                            Console.WriteLine("...You don't have Suffer Necklace...");
                            System.Threading.Thread.Sleep(1000);
                        }

                        break;
                    default:
                        Console.WriteLine("You Don't Follow the Introduction, The System will get back to Main action!");
                        return;
                }
            }

        }
    }
}