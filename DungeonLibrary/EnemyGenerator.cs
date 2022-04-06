namespace DungeonLibrary
{
    public class EnemyGenerator
    {
        /// <summary>
        /// This generates a new random enemy with randomized stats based on the enemy.
        /// </summary>
        /// <param name="level">Adds difficulty to enemies based on player level.</param>
        /// <param name="area">Adds difficulty to enemies based on the area.</param>
        public static string EnemySelector(int level, int area)
        {
            Random enemySelectGen = new Random();

            int enemySelect = enemySelectGen.Next(100);
            
            string[] enemyList =
            {
                "Bandit",
                "Goblin",
                "Gnoll",
                "Zombie",
                "Giant Rat",
                "Wyrm",
                //TODO create more enemies
            };
            int[] enemyStats =
            {
                0,//health
                0,//str
                0,//int
                0,//dex
                0,//defense
                0,//mdefense
                0,//attack priority

            };

            string activeEnemy = enemyList[enemySelect + level + area];
            //TODO create base stat blocks for enemies
            if (activeEnemy == "Bandit")//bandit stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }
            else if (activeEnemy == "Goblin")//goblin stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }
            else if (activeEnemy == "Gnoll")//gnoll stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }
            else if (activeEnemy == "Zombie")//zombie stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }
            else if (activeEnemy == "Giant Rat")//giant rat stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }
            else if (activeEnemy == "Wyrm")//wyrm stat gen
            {
                enemyStats[0] = enemySelectGen.Next();//health
                enemyStats[1] = enemySelectGen.Next();//str
                enemyStats[2] = enemySelectGen.Next();//int
                enemyStats[3] = enemySelectGen.Next();//dex
                enemyStats[4] = enemySelectGen.Next();//defense
                enemyStats[5] = enemySelectGen.Next();//mdefense
                enemyStats[6] = enemySelectGen.Next();//attack priority
            }








            
            return activeEnemy;
        }






    }
}