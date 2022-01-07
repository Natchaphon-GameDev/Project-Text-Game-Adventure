using System;
namespace Final_Project

{
    public class Mode
    {
        public static int playerRole { get; set; }
        private string _isAccept { get; set; }
        public static string playerName { get; set; }
        static UI ui = new UI();

        public static bool isMultiplayer { get; set; }

        public void Menu()
        {
            ui.MainManu();
            Console.Write("Please Selcet Your Mode : ");
            wrong:
            {
                var startGame = Console.ReadLine();
                switch (startGame)
                {
                    case "s":
                    case "S":
                        Console.Clear();
                        beforeStory();
                        Console.Clear();
                        aftterStory();
                        Console.Clear();
                        break;
                    case "m":
                    case "M":
                        Console.WriteLine("Coming Soon");
                        goto wrong;
                        //isMultiplayer = true         ....Try doing multi but not enough time. 
                    case "q":
                    case "Q":
                        Environment.Exit(0);
                        return;
                    default:
                        Console.Write("The Mode you have been Selected is not correct, Please Select again : ");
                        goto wrong;
                }
            }

        }

        public virtual void beforeStory()
        {

            Console.WriteLine(
                "Please wait for the story...[Do not press any key]"); System.Threading.Thread.Sleep(1500);
            Console.WriteLine(
                "?????  :  Death is something that everyone has to face. All living things will someday be lost, only to accept them."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  That will make you discover the meaning of life."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  But what if I'm going to give you a chance to live some hah?"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  Oh, I forgot to tell you some important things. You just died!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  Hey, don't worry, I will give you a chance."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  But if I had to give you a chance to get back to life for free, Would it be a bit easier hah?"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  I will send you back, but you will have to become a hero to help everyone with no precautions."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "?????  :  I'll send you back, but you'll have to be reborn as a hero and help others until your death."); System.Threading.Thread.Sleep(2000);
            wronganswer:
            {
                Console.WriteLine("?????  :  Will you accept this offer? Yes[Y] or No[N]");
                _isAccept = Console.ReadLine();
                Console.Clear();
                switch (_isAccept)
                {
                    case "Y":
                    case "y":
                    {
                        Console.WriteLine("?????  :  HA! HA! HA! very well!");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("?????  :  Otherwise, I will give you 3 choices for reborn.");
                        System.Threading.Thread.Sleep(1000);
                        chooseRole();
                        break;
                    }
                    case "N":
                    case "n":
                        Console.WriteLine("?????  :  I'm sad to hear that.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("?????  :  So I have to send you to where you should be.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("?????  :  Have a bad trip! Bye!....");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hey!!, Are you listening to me? Hurry and answer me!");
                        goto wronganswer;
                }
            }
        }

        public virtual void aftterStory()
        {
            Console.WriteLine(
                "Please wait for the story...[Do not press any key]");System.Threading.Thread.Sleep(1500);
            Console.WriteLine("?????  :  .....Hey.... hey....."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("?????  :  Hey, wake up!!!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "Villager  :  Are you okay? I saw something falling from the sky. And then I heard a very loud noise, and when I ran over, I saw you lying unconscious."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Villager  :  Who are you?."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You  :  My name is........"); System.Threading.Thread.Sleep(2000);
            Console.Write("*** Please enter your name : ");
            playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You  :  " + playerName); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Villager  :  " + playerName +
                              ", no time to stand and talk, now we need to escape!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You  :  What wrong?"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "Villager  :  You don't know about this? The demons are invading our village."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Villager  :  And now we have to escape!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Demon  :  Ahhhh......Haaaaa!!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Villager  :  That they've come!  Help me!!!!"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "You  :  Don't worry, Hide and don't go out anyway!"); System.Threading.Thread.Sleep(2000);
            Console.ReadKey();
        }

        public static void lastStory()
        {

            Console.Clear();
            Console.WriteLine("Demon  :  ARKKKKKKKKKKKKKKKKKKKKK!!");System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You  :  Okay It's dead! You're safe now."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "Villager  :  Oh god! I thought we were going to die."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                $"Villager  :  {playerName} are you... How do you kill them?"); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "You  :  That is not important, You only know that I am here to help you. "); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "You  :  Whatever, How do we defeat these demons?."); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "Villager  :  That matter, you need to go and defeat their boss. "); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "Villager  :  It's at the Demons castle, far from here 100 units distant. "); System.Threading.Thread.Sleep(2000);
            Console.WriteLine(
                "You  : Okay, I will go there and Kill him with myself. "); System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Villager  :  Hey {playerName} take this!!"); System.Threading.Thread.Sleep(2000);
            switch (playerRole)
            {
                case 1:
                    Console.WriteLine("Villager  :  I give you a Woodden Sword"); System.Threading.Thread.Sleep(2000);
                    Item.wooddenSword += 1;
                    ui.WooddenSword();
                    Console.WriteLine(
                        "*** You receive A Woodden Sword 1 ea ***"); System.Threading.Thread.Sleep(2000);
                    break;
                case 2:
                    Console.WriteLine("Villager  :  I give  you a Woodden Bow"); System.Threading.Thread.Sleep(2000);
                    Item.wooddenBow += 1;
                    ui.WooddenBow();
                    Console.WriteLine("*** You receive A Woodden Bow 1 ea ***"); System.Threading.Thread.Sleep(2000);
                    break;
                case 3:
                    Console.WriteLine("Villager  :  I give  Woodden Magic Wand"); System.Threading.Thread.Sleep(2000);
                    Item.wooddenMagicWand += 1;
                    ui.WooddenMagicWand();
                    Console.WriteLine(
                        "*** You receive A Woodden Magic Wand 1 ea ***"); System.Threading.Thread.Sleep(2000);
                    break;
            }

            Console.WriteLine("You  :  Dont worry I will End this Story! "); System.Threading.Thread.Sleep(2000);
            Console.ReadLine();
        }

        public static void multiplayerChoose()
        {
            Console.Write("Please Enter the Name of Player One : ");
            var namePlayer1 = Console.ReadLine();
            Console.WriteLine($"Please Choose the {namePlayer1} Role");
            chooseRole();
            Console.Clear();
            Console.Write("Please Enter the Name of Player Two : ");
            var namePlayer2 = Console.ReadLine();
            Console.WriteLine($"Please Choose the {namePlayer2} Role ");
            chooseRole();
            Console.Clear();
            Console.Write("Please Enter the Name of Player Three : ");
            var namePlayer3 = Console.ReadLine();
            Console.WriteLine($"Please Choose the {namePlayer3} Role ");
            chooseRole();
        }

        public static void chooseRole()
        {
            LoopRole:
            {
                Console.WriteLine("[1] : Knight : The Guardian with a GreatSword.");
                Console.WriteLine("[2] : Archer : The Maneuver with a Bow. ");
                Console.WriteLine("[3] : Mage   : The Proficient with a Staff.");
                int.TryParse(Console.ReadLine(), out var Role);

                switch (Role)
                {
                    case 1:
                        Console.Clear();
                        ui.Knight();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you choose 'Knight'. Yes[Y] or No[N]");
                        var check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Role.");
                                goto LoopRole;
                            case "Y":
                            case "y":
                                Character.Role = "Knight";
                                playerRole = 1;
                                Console.WriteLine("Your Role is Knight!!");
                                break;
                            default:
                                goto case "n";
                        }

                        break;
                    case 2:
                        Console.Clear();
                        ui.Archer();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you choose 'Archer'. Yes[Y] or No[N]");
                        check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Role.");
                                goto LoopRole;
                            case "Y":
                            case "y":
                                Character.Role = "Archer";
                                playerRole = 2;
                                Console.WriteLine("Your Role is Archer!!");
                                break;
                            default:
                                goto case "n";
                        }

                        break;
                    case 3:
                        Console.Clear();
                        ui.Mage();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you choose 'Mage'. Yes[Y] or No[N]");
                        check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Role.");
                                goto LoopRole;
                            case "Y":
                            case "y":
                                Character.Role = "Mage";
                                playerRole = 3;
                                Console.WriteLine("Your Role is Mage!!");
                                break;
                            default:
                                goto case "n";
                        }

                        break;
                    default:
                        goto LoopRole;
                }
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("?????  :  And This is the Farewell gift from me...");
            System.Threading.Thread.Sleep(1000);
            LoopGift:
            {
                Console.WriteLine("[1] : 2 Healing potions");
                Console.WriteLine("[2] : 2 Mana potions");
                Console.WriteLine("[3] : 1 Healing potion and 1 Mana potion");
                int.TryParse(Console.ReadLine(), out var Gift);

                switch (Gift)
                {
                    case 1:
                        Console.Clear();
                        ui.HealingPotion();
                        Console.WriteLine();
                        ui.HealingPotion();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you choose '2 Healing potions' Yes[Y] or No[N]");
                        var check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Gift.");
                                goto LoopGift;
                            case "Y":
                            case "y":
                                Item.hpPotion += 2;
                                Console.WriteLine("Your Gift is 2 Healing potions!!");
                                return;
                            default:
                                goto case "n";
                        }
                    case 2:
                        Console.Clear();
                        ui.ManaPotion();
                        Console.WriteLine();
                        ui.ManaPotion();
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you choose '2 Mana potions'. Yes[Y] or No[N]");
                        check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Gift.");
                                goto LoopGift;
                            case "Y":
                            case "y":
                                Item.mpPotion += 2;
                                Console.WriteLine("Your Gift is 2 Mana potions!!");
                                return;
                            default:
                                goto case "n";
                        }
                    case 3:
                        Console.Clear();
                        ui.HealingPotion();
                        Console.WriteLine();
                        ui.ManaPotion();
                        Console.WriteLine();
                        Console.WriteLine(
                            "Are you sure you choose '1 Healing potion and 1 Mana potion'. Yes[Y] or No[N]");
                        check = Console.ReadLine();
                        switch (check)
                        {
                            case "N":
                            case "n":
                                Console.Clear();
                                Console.WriteLine("Please Choose your Gift.");
                                goto LoopGift;
                            case "Y":
                            case "y":
                                Item.hpPotion += 1;
                                Item.mpPotion += 1;
                                Console.WriteLine("Your Gift is 1 Healing potion and 1 Mana potion!!");
                                return;
                            default:
                                goto case "n";
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("Please select your gift!!");
                        goto LoopGift;
                }
            }
        }
    }
}
    

