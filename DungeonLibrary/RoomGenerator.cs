using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class RoomGenerator
    {
        /// <summary>
        /// Generates a random location description.
        /// </summary>
        /// <param name="area">Increases the roll of the random room creator.</param>
        public static string RoomCreator(int area)
        {

            Random roomCreateGen = new Random();

            string[] roomList =
            {
                "The fields around you are lush with life. A cool crisp breeze blows past you reminding you of your home.",
                "The open plains are interrupted by rising trees. Inside you could imagine there being all sorts of hidden life.",
                "You are surrounded by trees. You hear the sound of animals ",
                "",
                "",
                "",
                "",
                "",
                "",
                "",

            };
                
            int roomSelect = roomCreateGen.Next(roomList.Length - 1);
            
            string activeRoom = roomList[roomSelect];




            return activeRoom;
        }



    }
}
