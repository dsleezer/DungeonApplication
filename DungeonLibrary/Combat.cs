using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender, TextTracker textLine)
        {
            if ((attacker.CalcHitChance() >= defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.CurrentHealth -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                DispWarehouse.TextDisplay(textLine, $"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");

                Console.ResetColor();
                
            }
            else
            {
                DispWarehouse.TextDisplay(textLine, $"{attacker.Name} missed!");
                
            }
            Thread.Sleep(30);
        }
        public static void DoBattle(Player player, Monster monster, TextTracker textLine)
        {
            if (player.CalcInitiative() >= monster.CalcInitiative() || player.EquippedWeapon.WeaponType == WeaponType.Longbow)
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    DoAttack(player, monster, textLine);
                    DoAttack(player, monster, textLine);
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(monster, player, textLine);
                    }
                }
                else
                {

                    DoAttack(player, monster, textLine);
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(monster, player, textLine);
                    }
                }
            }
            else
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    DoAttack(monster, player, textLine);
                    
                    if (monster.CurrentHealth > 0)
                    {
                        DoAttack(player, monster, textLine);
                        DoAttack(player, monster, textLine);
                    }
                }
                else
                {

                    DoAttack(monster, player, textLine);
                    if (player.CurrentHealth > 0)
                    {
                        DoAttack(player, monster, textLine);
                    }
                }
            }           
        }
    }
}