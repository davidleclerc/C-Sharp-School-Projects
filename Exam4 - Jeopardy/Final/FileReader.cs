using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final
{
    class FileReader
    {
        
        public static List<GameData> GetGameData()
        {
            //creates list to add the xml objects into
            List<GameData> gameDataList = new List<GameData>();

            //linq xdocument reads all descendants of jeopardy heading
            var xmlList = XDocument.Load("Jeopardy.xml").Descendants().ToList();
            int j = 1;
            //selects the data for each category and saves it to a game data object
            for (int i = 0; i < 5; i++)
            {

                string topic = xmlList[j].Attribute("name").Value;
                string question1 = xmlList[j].Element("first").Value;
                string answer1 = xmlList[j].Element("first").Attribute("answer").Value;
                string question2 = xmlList[j].Element("second").Value;
                string answer2 = xmlList[j].Element("second").Attribute("answer").Value;
                string question3 = xmlList[j].Element("third").Value;
                string answer3 = xmlList[j].Element("third").Attribute("answer").Value;
                string question4 = xmlList[j].Element("fourth").Value;
                string answer4 = xmlList[j].Element("fourth").Attribute("answer").Value;
                string question5 = xmlList[j].Element("fifth").Value;
                string answer5 = xmlList[j].Element("fifth").Attribute("answer").Value;

                GameData newGameData = new GameData(topic, question1, answer1, question2,
             answer2, question3, answer3, question4, answer4,
             question5, answer5);
                gameDataList.Add(newGameData);
                j += 6;


            }
            return gameDataList;
        }
    }
 }

