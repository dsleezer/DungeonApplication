using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class EnemyWarehouse
    {

        public static Monster GenerateMonster(Player player)
        {


            Monster flyingcat = new Monster("Flying Cat", 4, 12, 16, 10, 9, 9, 2, 2, 18, 10, 200, "Dexterity", "A housecat with wings.");
            Monster flumph = new Monster("Flumph", 8, 14, 16, 12, 10, 10, 2, 8, 4, 12, 25, "Dexterity", "The childlike whimsy of it hides the intent of it's tentacles.");
            Monster kobold = new Monster("Kobold", 8, 8, 16, 10, 11, 11, 3, 7, 4, 12, 25, "Dexterity", "A small humanoid reptile.");
            Monster magmin = new Monster("Magmin", 6, 8, 10, 12, 12, 12, 12, 2, 12, 4, 14, "Dexterity", "Imp-like with flames for hair.");
            Monster troglodyt = new Monster("Troglodyte", 14, 6, 10, 14, 13, 13, 3, 7, 4, 13, 30, "Strength", "Oozing with slime and covered in scales.");
            Monster modron = new Monster("Modron", 6, 14, 8, 12, 14, 14, 2, 8, 5, 12, 30, "Intelligence", "Mechanical with a clock ticking in the center of it's body.");
            Monster skeleton = new Monster("Skeleton", 10, 6, 14, 16, 15, 15, 3, 7, 4, 13, 30, "Dexterity", "Reanimated bones.");
            Monster hobgoblin = new Monster("Hobgoblin", 12, 10, 12, 12, 18, 18, 2, 9, 3, 18, 40, "Strength", "A large goblin that appears stronger than normal.");
            Monster gnoll = new Monster("Gnoll", 14, 6, 12, 8, 22, 22, 3, 10, 4, 15, 40, "Strength", "A ravenous hyena like creature.");
            Monster dryad = new Monster("Dryad", 10, 14, 12, 10, 22, 22, 5, 13, 6, 11, 40, "Intelligence", "As if it was a part of the forest, this humanoid being has plants growing all over it.");
            Monster willOWisp = new Monster("Will-o-Whisp", 0, 14, 28, 10, 22, 22, 2, 16, 4, 19, 40, "Dexterity", "The soul of a creature that has taken shape as a glowing sphere hanging in the air.");
            Monster bandit = new Monster("Bandit", 11, 10, 12, 12, 24, 24, 2, 7, 3, 12, 40, "Strength", "A person who has fallen down on their luck, or loves the thrill of stealing.");
            Monster zombie = new Monster("Zombie", 14, 4, 6, 16, 26, 26, 2, 7, 3, 8, 50, "Strength", "This person looks dead but it's moving.");
            Monster harpy = new Monster("Harpy", 12, 8, 14, 12, 38, 38, 5, 14, 3, 11, 60, "Dexterity", "Entrancing you with the sound of their voice, this feathered creature looks charming.");
            Monster warewolf = new Monster("Warewolf", 16, 10, 14, 14, 50, 50, 10, 24, 4, 11, 60, "Strength", "A man that has turned into a wolf under the full moon.");
            Monster basilisk = new Monster("Basilisk", 16, 2, 8, 16, 52, 52, 6, 17, 5, 15, 70, "Strength", "A large lizard with scales that seem to be made out of stone.");
            Monster griffon = new Monster("Griffon", 18, 2, 16, 16, 55, 55, 10, 20, 6, 12, 70, "Strength", "A four legged bird with the face of an owl.");
            Monster gibberingMouther = new Monster("Gibbering Mouther", 10, 4, 8, 16, 67, 67, 5, 25, 2, 9, 80, "Strength", "An amoeba covered in eyes and mouths chittering as it moves.");
            Monster troll = new Monster("Troll", 18, 8, 14, 20, 80, 80, 7, 26, 7, 15, 80, "Strength", "Gigantic with green skin and large claws.");
            Monster gelatinousCube = new Monster("Gelatinous Cube", 14, 2, 4, 20, 84, 84, 3, 18, 4, 6, 90, "Strength", "A large transparent cube filled with the remains of adventurers.");
            Monster bulette = new Monster("Boulette", 20, 2, 12, 20, 90, 90, 8, 36, 7, 17, 90, "Strength", "Lives underground and has developed a hard shell.");
            Monster couatl = new Monster("Couatl", 16, 18, 20, 16, 95, 95, 5, 15, 8, 19, 100, "Intelligence", "Seperntlike with feathered wings.");
            Monster treant = new Monster("Treant", 24, 12, 8, 22, 115, 115, 9, 25, 10, 16, 120, "Strength", "This tree seems to have come to life.");
            Monster vampire = new Monster("Vampire", 18, 16, 18, 18, 100, 100, 8, 28, 9, 16, 140, "Strength", "Pale with pointed fangs. It seems to fade into the shadows.");
            Monster hydra = new Monster("Hydra", 20, 2, 12, 20, 140, 140, 12, 30, 8, 15, 180, "Strength", "A three headed serpent with sharp teeth.");
            Monster remorhaz = new Monster("Remorhaz", 24, 4, 14, 22, 160, 16, 13, 35, 11, 17, 200, "Strength", "Hundreds of legs support this massive centipede.");


            List<Monster> level1 = new List<Monster>() { flyingcat, flumph, kobold, magmin, troglodyt, modron, skeleton };
            List<Monster> level3 = new List<Monster>() { flyingcat, flumph, kobold, magmin, troglodyt, modron, skeleton, hobgoblin, gnoll, dryad, willOWisp, bandit, zombie };
            List<Monster> level5 = new List<Monster>() { flyingcat, skeleton, zombie, hobgoblin, gnoll, dryad, willOWisp, bandit, zombie, harpy, warewolf, basilisk, griffon };
            List<Monster> level7 = new List<Monster>() { flyingcat, skeleton, zombie, harpy, warewolf, basilisk, griffon, gibberingMouther, troll, gelatinousCube, bulette };
            List<Monster> level9 = new List<Monster>() { flyingcat, skeleton, zombie, harpy, warewolf, basilisk, griffon, gibberingMouther, troll, gelatinousCube, bulette, couatl, treant };
            List<Monster> level11 = new List<Monster>() { flyingcat, skeleton, zombie, harpy, warewolf, basilisk, griffon, gibberingMouther, troll, gelatinousCube, bulette, couatl, treant, vampire };
            List<Monster> level13 = new List<Monster>() { flyingcat, skeleton, zombie, harpy, warewolf, basilisk, griffon, gibberingMouther, troll, gelatinousCube, bulette, couatl, treant, vampire, hydra, remorhaz };

            Random roll = new Random();

            Monster activeMonster = skeleton;


            if (player.Level >= 13)
            {
                activeMonster = level13[roll.Next(level13.Count)];
            }
            else if (player.Level >= 11)
            {
                activeMonster = level11[roll.Next(level11.Count)];
            }
            else if (player.Level >= 9)
            {
                activeMonster = level9[roll.Next(level9.Count)];
            }
            else if (player.Level >= 7)
            {
                activeMonster = level7[roll.Next(level7.Count)];
            }
            else if (player.Level >= 5)
            {
                activeMonster = level5[roll.Next(level5.Count)];
            }
            else if (player.Level >= 3)
            {
                activeMonster = level3[roll.Next(level3.Count)];
            }
            else
            {
                activeMonster = level1[roll.Next(level1.Count)];
            }


            return activeMonster;
        }

    }
}

