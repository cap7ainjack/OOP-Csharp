using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Football_League.Models
{
    public class Scores
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Scores(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals 
        {
            get { return this.homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                this.homeTeamGoals = value;
            }
        }

        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                this.awayTeamGoals = value;
            }
        }
    }
}
