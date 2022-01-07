using System;
using System.Linq.Expressions;

namespace Final_Project
{
    public class Combat
    {
        UI ui = new UI();
        
        Random rnd = new Random();
        private int _skillDamage = 50;
        private int _damagePlayer;
        private int _damageEnemy;
        private string _chooseAttack;
        private string _chooseAction;

        public Combat(Character character, Character enemy)
        {
            Console.WriteLine();
            Console.WriteLine("  ==========================");
            Console.WriteLine("    The Battle Begins!!");
            Console.WriteLine($"    You meet the {Enemy.enemyName}!!");
            Console.WriteLine("  ==========================");
            Console.ReadKey();
            while (enemy.Hp > 0 && character.Hp > 0)
            {
                
                returnToAction:
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=======================");
                    Console.WriteLine("      Your Turn!!");
                    Console.WriteLine("=======================");
                    Console.WriteLine("");
                    Console.WriteLine("Choose your Action");
                    Console.WriteLine("[A] : Fight");
                    Console.WriteLine("[B] : Check Enemy status");
                    Console.WriteLine("[C] : Use Item");
                    Console.WriteLine("[D] : Wait for Action (Skip your turn) ");
                    Console.WriteLine("[E] : Try to escape");
                    _chooseAction = Console.ReadLine();
                    switch (_chooseAction)
                    {
                        case "A":
                        case "a":
                            Console.Clear();
                            Console.WriteLine("[A] : Normal attack");
                            Console.WriteLine("[B] : Skill attack (-30 MP)");
                            Console.WriteLine("[C] : Return to Action");
                            _chooseAttack = Console.ReadLine();
                            switch (_chooseAttack)
                            {
                                case "a":
                                case "A":
                                    _damagePlayer = character.Attack - enemy.Def;
                                    enemy.Hp -= _damagePlayer;
                                    ui.NormalAttack();
                                    Console.WriteLine($"Use...Normal Attack....{_damagePlayer} Damage.");
                                    Console.WriteLine($"Enemy....HP remaining..{enemy.Hp} Point.");
                                    break;
                                case "b":
                                case "B":
                                    if (character.MP <= 29)
                                    {
                                        Console.WriteLine("Your Mana not enough");
                                        Console.ReadLine();
                                        goto returnToAction;
                                    }
                                    _damagePlayer = character.Attack - enemy.Def;
                                    enemy.Hp = enemy.Hp - _damagePlayer - _skillDamage;
                                    character.MP -= 30;
                                    ui.MagicAttack();
                                    Console.WriteLine($"Use...Skill....{_damagePlayer + _skillDamage} Damage.");
                                    Console.WriteLine($"{Character.enemyName}....HP remaining..{enemy.Hp} Point.");
                                    Console.WriteLine($"Your....Mana remaining..{character.MP} Point.");
                                    break;
                                case "c":
                                case "C":
                                    goto returnToAction;
                                default:
                                    Console.WriteLine("Please follow the introduction");
                                    goto returnToAction;
                            }

                            break;
                        case "B":
                        case "b":
                            Console.Clear();
                            Console.WriteLine($" Enemy Name : {Character.enemyName}");
                            Console.WriteLine($"  Status HP : {enemy.Hp}");
                            Console.WriteLine($"        DEF : {enemy.Def}");
                            Console.WriteLine($"        ATK : {enemy.Attack}");
                            Console.ReadKey();
                            goto returnToAction;
                        case "C":
                        case "c":
                            Console.WriteLine("Choose Item");
                            Inventory.UseItem(character);
                            goto returnToAction;
                        case "D":
                        case "d":
                            Console.WriteLine("Wait for Enemy turn.....");
                            break;
                        case "E":
                        case "e":
                            var randomEscape = rnd.Next(3);
                            if (randomEscape == 1)
                            {
                                Console.WriteLine("You escaped from the battle");
                                Console.ReadKey();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("You Inevitable!");
                                break;
                            }
                        default:
                            Console.WriteLine("Please follow the introduction");
                            goto returnToAction;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                if (enemy.Hp > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("=======================");
                    Console.WriteLine("     Enemy Turn!");
                    Console.WriteLine("=======================");
                    Console.WriteLine();
                    Console.WriteLine("Enemy Name : " + Character.enemyName);
                    Console.WriteLine(Character.enemyName + " Attack!!");
                    _damageEnemy = enemy.Attack - character.Def;
                    character.Hp -= _damageEnemy;
                    Console.WriteLine($"Your...take....{_damageEnemy} Damage.");
                    Console.WriteLine($"Your...HP remaining....{character.Hp} Point.");
                }
                else
                {
                    var randomItem = rnd.Next(1,3);
                    if (randomItem == 2)
                    {
                        Inventory.RandomItem(character);
                        Console.ReadLine();
                    }
                    break;
                }
                Console.ReadLine();
            }

            if (character.Hp <= 0)
            {
                Console.Clear();
                Console.WriteLine("?????  :  You just died.. Hm... but I think it must be happen....");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("?????  :  I hope we will meet again..");
                System.Threading.Thread.Sleep(2000);
                character.isDead = true;
            }
        }
    }
}