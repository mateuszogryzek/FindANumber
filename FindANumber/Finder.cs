using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindANumber
{
    public class Finder
    {
        public int InputNumber { get; set; }
        public int RandomNumber { get; set; }
        public string GuessNumber() => (RandomNumber == InputNumber) ? "correct" : (RandomNumber > InputNumber) ? "bigger" : "lesser";  
    }
}
