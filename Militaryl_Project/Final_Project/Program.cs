using System;

namespace Final_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //attibute
            var mode = new Mode();
            var rnd = new Random();
            var ui = new UI();
            Character enamyRandom = null;

            //run
            mode.Menu();
            if (Mode.isMultiplayer == false)
            {
                Character mainCharacter = null;
                var firstCombat = 0;
                new Inventory();
                new Unit(100);
                Equipment.CheckRole();
                switch (Mode.playerRole)
                {
                    case 1:
                        mainCharacter = new Knight(230, 35, 70, 150, false);
                        break;
                    case 2:
                        mainCharacter = new Archer(200, 30, 80, 200, false);
                        break;
                    case 3:
                        mainCharacter = new Mage(170, 25, 95, 175, false);
                        break;
                }

                while (Unit.isUnitsEnd == false && mainCharacter.isDead == false)
                {
                    Item.CheckFull(mainCharacter);
                    //to random enemy
                    var chooseEnemy = rnd.Next(1, 6);
                    switch (chooseEnemy)
                    {
                        case 1:
                            enamyRandom = new Enemy("Cyclone", 370, 25, 65, 0, false);
                            break;
                        case 2:
                            enamyRandom = new Enemy("Ditch", 220, 15, 75, 0, false);
                            break;
                        case 3:
                            enamyRandom = new Enemy("Mudlark", 320, 35, 60, 0, false);
                            break;
                        case 4:
                            enamyRandom = new Enemy("Venom", 220, 30, 80, 0, false);
                            break;
                        case 5:
                            enamyRandom = new Enemy("Oblique", 170, 25, 90, 0, false);
                            break;
                    }

                    //Making this for battle run once
                    if (firstCombat == 0)
                    {
                        new Combat(mainCharacter, enamyRandom);
                        if (mainCharacter.isDead)
                        {
                            Environment.Exit(0);
                        }

                        firstCombat += 1;
                        Mode.lastStory();
                        Item.CheckFull(mainCharacter);

                    }

                    Console.Clear();
                    ui.MainAction();
                    var playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "w":
                        case "W":
                            Console.Clear();
                            Unit.Walk(mainCharacter);
                            var randomEvent = rnd.Next(1, 5);
                            switch (randomEvent)
                            {
                                case 1:
                                    new Combat(mainCharacter, enamyRandom);
                                    break;
                                case 2:
                                    Console.WriteLine("You found the item!!");
                                    Inventory.RandomItem(mainCharacter);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                case 4:
                                    Console.WriteLine("You can walk safely!!");
                                    Console.ReadKey();
                                    break;
                            }

                            break;
                        case "I":
                        case "i":
                            Console.Clear();
                            Inventory.UseItem(mainCharacter);
                            break;
                        case "C":
                        case "c":
                            Console.Clear();
                            Character.ShowPlayerStatus(mainCharacter);
                            Console.ReadKey();
                            break;
                        case "M":
                        case "m":
                            OpenMenu.IsOpenMenu();
                            break;
                        default:
                            Console.WriteLine("Please select Action!!");
                            break;
                    }

                }

                if (mainCharacter.isDead == false)
                {
                    var boss = new Boss("Leader'Xcelent", 600, 50, 120, 0, false);
                    new Combat(mainCharacter, boss);
                    if (mainCharacter.isDead == false)
                    {
                        Console.WriteLine("DEV  :  Congrats! you just finish ours game Episode one...");
                        Console.WriteLine("DEV  :  But The story not over yet!");
                        Console.WriteLine("DEV  :  Please follow to the next episode at IG : pruek_ns");
                        Console.WriteLine("DEV  :  See yaa!.");
                        Console.ReadKey(); 
                    }
                   
                    // Please Give me A : 1620701795 Natchaphon Sirisangsawang 'u'
                }
            }
            
            //Try doing multi but not enough time.
            
            /*else
            { 
                Character Player1 = null;
                Character Player2 = null;
                Character Player3 = null;
                Mode.multiplayerChoose();
                Equipment.CheckRole(); 
                switch (Mode.playerRole)
                {
                    case 1:
                        Player1 = new Knight(230, 35, 70, 150, false);
                        break;
                    case 2:
                        Player1 = new Archer(200, 30, 80, 200, false);
                        break;
                    case 3:
                        Player1 = new Mage(170, 25, 95, 175, false);
                        break;
                }
               switch (Mode.playerRole)
               {
                   case 1:
                       Player2 = new Knight(230, 35, 70, 150, false);
                       break;
                   case 2:
                       Player2 = new Archer(200, 30, 80, 200, false);
                       break;
                   case 3:
                       Player2 = new Mage(170, 25, 95, 175, false);
                       break;
               }
               switch (Mode.playerRole)
               {
                   case 1:
                       Player3 = new Knight(230, 35, 70, 150, false);
                       break;
                   case 2:
                       Player3 = new Archer(200, 30, 80, 200, false);
                       break;
                   case 3:
                       Player3 = new Mage(170, 25, 95, 175, false);
                       break;
               }

               while (Player1.isDead == false || Player2.isDead == false ||
                      Player3.isDead == false)
               {
                   
                   if (Player1.isDead == false)
                   { 
                       new Inventory();
                       new Unit(100);
                       Item.CheckFull(Player1);
                       //to random enemy
                       var chooseEnemy = rnd.Next(1, 6);
                       switch (chooseEnemy)
                       {
                           case 1:
                               enamyRandom = new Enemy("Cyclone", 300, 25, 65, 0, false);
                               break;
                           case 2:
                               enamyRandom = new Enemy("Ditch", 250, 15, 75, 0, false);
                               break;
                           case 3:
                               enamyRandom = new Enemy("Mudlark", 350, 35, 60, 0, false);
                               break;
                           case 4:
                               enamyRandom = new Enemy("Venom", 250, 30, 80, 0, false);
                               break;
                           case 5:
                               enamyRandom = new Enemy("Oblique", 200, 25, 90, 0, false);
                               break;
                       }
                       Console.Clear();
                       ui.MainAction();
                       var playerAction = Console.ReadLine();
                       switch (playerAction)
                       {
                           case "w":
                           case "W":
                               Console.Clear();
                               Unit.Walk(Player1);
                               var randomEvent = rnd.Next(1, 5);
                               switch (randomEvent)
                               {
                                   case 1:
                                       new Combat(Player1, enamyRandom);
                                       break;
                                   case 2:
                                       Console.WriteLine("You found the item!!");
                                       Inventory.RandomItem(Player1);
                                       Console.ReadKey();
                                       break;
                                   case 3:
                                   case 4:
                                       Console.WriteLine("You can walk safely!!");
                                       Console.ReadKey();
                                       break;
                               }

                               break;
                           case "I":
                           case "i":
                               Console.Clear();
                               Inventory.UseItem(Player1);
                               break;
                           case "C":
                           case "c":
                               Console.Clear();
                               Character.ShowPlayerStatus(Player1);
                               Console.ReadKey();
                               break;
                           case "M":
                           case "m":
                               OpenMenu.IsOpenMenu();
                               break;
                           default:
                               Console.WriteLine("Please select Action!!");
                               break;
                       }
                       if (Unit.isUnitsEnd)
                       {
                           var boss = new Boss("Leader'Xcelent", 600, 100, 150, 0, false);
                           new Combat(Player1, boss);
                           Console.WriteLine("Congrats! you just finish ours game Episode one...");
                           Console.WriteLine("But The story not over yet!");
                           Console.WriteLine("Please follow to the next episode at IG : pruek_ns");
                           Console.WriteLine("See yaa!.");
                           Console.ReadKey();
                       }
                   }
                   
                    if (Player2.isDead == false)
                    { 
                        new Inventory();
                        new Unit(100);
                        Item.CheckFull(Player2);
                        //to random enemy
                        var chooseEnemy = rnd.Next(1, 6);
                        switch (chooseEnemy)
                        {
                            case 1:
                                enamyRandom = new Enemy("Cyclone", 300, 25, 65, 0, false);
                                break;
                            case 2:
                                enamyRandom = new Enemy("Ditch", 250, 15, 75, 0, false);
                                break;
                            case 3:
                                enamyRandom = new Enemy("Mudlark", 350, 35, 60, 0, false);
                                break;
                            case 4:
                                enamyRandom = new Enemy("Venom", 250, 30, 80, 0, false);
                                break;
                            case 5:
                                enamyRandom = new Enemy("Oblique", 200, 25, 90, 0, false);
                                break;
                        }
                        Console.Clear();
                        ui.MainAction();
                        var playerAction = Console.ReadLine();
                        switch (playerAction)
                        {
                            case "w":
                            case "W":
                                Console.Clear();
                                Unit.Walk(Player2);
                                var randomEvent = rnd.Next(1, 5);
                                switch (randomEvent)
                                {
                                    case 1:
                                        new Combat(Player2, enamyRandom);
                                        break;
                                    case 2:
                                        Console.WriteLine("You found the item!!");
                                        Inventory.RandomItem(Player2);
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                    case 4:
                                        Console.WriteLine("You can walk safely!!");
                                        Console.ReadKey();
                                        break;
                                }

                                break;
                            case "I":
                            case "i":
                                Console.Clear();
                                Inventory.UseItem(Player2);
                                break;
                            case "C":
                            case "c":
                                Console.Clear();
                                Character.ShowPlayerStatus(Player2);
                                Console.ReadKey();
                                break;
                            case "M":
                            case "m":
                                OpenMenu.IsOpenMenu();
                                break;
                            default:
                                Console.WriteLine("Please select Action!!");
                                break;
                        }
                        if (Unit.isUnitsEnd)
                        {
                            var boss = new Boss("Leader'Xcelent", 600, 100, 150, 0, false);
                            new Combat(Player2, boss);
                            Console.WriteLine("Congrats! you just finish ours game Episode one...");
                            Console.WriteLine("But The story not over yet!");
                            Console.WriteLine("Please follow to the next episode at IG : pruek_ns");
                            Console.WriteLine("See yaa!.");
                            Console.ReadKey();
                        }
                   

                    }
                    
                    
                    if (Player3.isDead == false)
                    { 
                        new Inventory();
                        new Unit(100);
                        Item.CheckFull(Player3);
                        //to random enemy
                        var chooseEnemy = rnd.Next(1, 6);
                        switch (chooseEnemy)
                        {
                            case 1:
                                enamyRandom = new Enemy("Cyclone", 300, 25, 65, 0, false);
                                break;
                            case 2:
                                enamyRandom = new Enemy("Ditch", 250, 15, 75, 0, false);
                                break;
                            case 3:
                                enamyRandom = new Enemy("Mudlark", 350, 35, 60, 0, false);
                                break;
                            case 4:
                                enamyRandom = new Enemy("Venom", 250, 30, 80, 0, false);
                                break;
                            case 5:
                                enamyRandom = new Enemy("Oblique", 200, 25, 90, 0, false);
                                break;
                        }
                        Console.Clear();
                        ui.MainAction();
                        var playerAction = Console.ReadLine();
                        switch (playerAction)
                        {
                            case "w":
                            case "W":
                                Console.Clear();
                                Unit.Walk(Player3);
                                var randomEvent = rnd.Next(1, 5);
                                switch (randomEvent)
                                {
                                    case 1:
                                        new Combat(Player3, enamyRandom);
                                        break;
                                    case 2:
                                        Console.WriteLine("You found the item!!");
                                        Inventory.RandomItem(Player3);
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                    case 4:
                                        Console.WriteLine("You can walk safely!!");
                                        Console.ReadKey();
                                        break;
                                }

                                break;
                            case "I":
                            case "i":
                                Console.Clear();
                                Inventory.UseItem(Player3);
                                break;
                            case "C":
                            case "c":
                                Console.Clear();
                                Character.ShowPlayerStatus(Player3);
                                Console.ReadKey();
                                break;
                            case "M":
                            case "m":
                                OpenMenu.IsOpenMenu();
                                break;
                            default:
                                Console.WriteLine("Please select Action!!");
                                break;
                        }
                        if (Unit.isUnitsEnd)
                        {
                            var boss = new Boss("Leader'Xcelent", 600, 100, 150, 0, false);
                            new Combat(Player3, boss);
                            Console.WriteLine("Congrats! you just finish ours game Episode one...");
                            Console.WriteLine("But The story not over yet!");
                            Console.WriteLine("Please follow to the next episode at IG : pruek_ns");
                            Console.WriteLine("See yaa!.");
                            Console.ReadKey();
                            // Love u teacher please Give me A : 1620701795 Natchaphon Sirisangsawang 'u'

                        }
                   

                    }
                   
               }
            }*/ 
        } 
    }
}