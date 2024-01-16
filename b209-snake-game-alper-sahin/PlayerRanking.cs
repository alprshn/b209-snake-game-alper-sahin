using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace b209_snake_game_alper_sahin
{
    public class PlayerRanking
    {
        public int Ranking { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public PlayerRanking(int ranking, string name, int score)
        {
            Ranking = ranking;
            Name = name;
            Score = score;
        }
    }

    
}
