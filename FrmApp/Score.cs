using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmApp
{
    internal class Score
    {
        public string ID;
        public string name;
        public string classes;
        public int score_OS;
        public int score_PC;
        public int Total { get { return score_OS + score_PC; } }

        public Score()
        {
            ID = string.Empty;
            name = string.Empty;
            classes = string.Empty;
            score_OS = 0;
            score_PC = 0;
        }

        public Score(string iD, string name, string classes)
        {
            ID = iD;
            this.name = name;
            this.classes = classes;
        }

        public Score(string iD, string name, string classes, int score_OS, int score_PC)
        {
            ID = iD;
            this.name = name;
            this.classes = classes;
            this.score_OS = score_OS;
            this.score_PC = score_PC;
        }

    }
}
