using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            if ((attacker.CalcHitChance() >= defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.CurrentHealth -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }
            Thread.Sleep(30);
        }
        public static void DoBattle(Player player, Monster monster)
        {
            if (player.CalcInitiative() >= monster.CalcInitiative() || player.EquippedWeapon.WeaponType == WeaponType.Longbow)
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    DoAttack(player, monster);
                    DoAttack(player, monster);
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(monster, player);
                    }
                }
                else
                {

                    DoAttack(player, monster);
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(monster, player);
                    }
                }
            }
            else
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    DoAttack(monster, player);
                    
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(player, monster);
                        DoAttack(player, monster);
                    }
                }
                else
                {

                    DoAttack(monster, player);
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(player, monster);
                    }
                }
            }
        }
    }
}