using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindANumber
{
    public class GamePlay
    {
        public int Score { get; set; }

        public int SetScore(int score) => Score += score;
        public int GetScore => Score;
        
    }
}
