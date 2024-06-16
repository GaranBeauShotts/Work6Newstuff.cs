using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWeek6.cs
{
    internal class Player
    {
        public class SoccerPlayer
        {
            // Properties
            public string Name { get; set; }
            public int JerseyNumber { get; set; }
            public int GoalsScored { get; set; }
            public int Assists { get; set; }

            // Constructor
            public SoccerPlayer(string name, int jerseyNumber, int goalsScored, int assists)
            {
                Name = name;
                JerseyNumber = jerseyNumber;
                GoalsScored = goalsScored;
                Assists = assists;
            }
        }

    }
}
