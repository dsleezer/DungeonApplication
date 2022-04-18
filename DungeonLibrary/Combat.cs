using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static int DoAttack(Character attacker, Character defender, int textLine)
        {
            if ((attacker.CalcHitChance() >= defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();

                defender.CurrentHealth -= damageDealt;

                textLine = DispWarehouse.TextDisplay(textLine, attacker.CurrentHealth.ToString());

                Console.ForegroundColor = ConsoleColor.Red;
                textLine = DispWarehouse.TextDisplay(textLine, $"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");

                Console.ResetColor();
                
            }
            else
            {
                textLine = DispWarehouse.TextDisplay(textLine, $"{attacker.Name} missed!");
                
            }
            Thread.Sleep(30);
            return textLine;
        }
        public static int DoBattle(Player player, Monster monster, int textLine)
        {
            if (player.CalcInitiative() >= monster.CalcInitiative() || player.EquippedWeapon.WeaponType == WeaponType.Longbow)
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    textLine = DoAttack(player, monster, textLine);
                    textLine = DoAttack(player, monster, textLine);
                    if (monster.CurrentHealth > 0)
                    {
                        textLine = DoAttack(monster, player, textLine);
                    }
                }
                else
                {

                    textLine = DoAttack(player, monster, textLine);
                    if (monster.CurrentHealth > 0)
                    {
                        textLine = DoAttack(monster, player, textLine);
                    }
                }
            }
            else
            {
                if (player.EquippedWeapon.WeaponType == WeaponType.Dagger)
                {
                    textLine = DoAttack(monster, player, textLine);
                    
                    if (monster.CurrentHealth > 0)
                    {
                        textLine = DoAttack(player, monster, textLine);
                        textLine = DoAttack(player, monster, textLine);
                    }
                }
                else
                {

                    textLine = DoAttack(monster, player, textLine);
                    if (player.CurrentHealth > 0)
                    {
                        textLine = DoAttack(player, monster, textLine);
                    }
                }
            }
            return textLine;
        }
    }
}