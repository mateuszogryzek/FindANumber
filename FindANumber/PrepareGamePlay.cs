using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindANumber
{
    public class PrepareGamePlay
    {
        readonly Random random = new();
        public int Lifes { get; set; }
        public void SetLifes(int lives) => Lifes = lives;
        public void WrongAnswer() => Lifes--;
        public int GetLifes() => Lifes;
        public int ReturnRandomNumber => random.Next(1, 20);
    }
}
