using System;

namespace Lab_Football_League.Models
{
    public class Matches
    {
        private Teams homeTeam;
        private Teams awayTeam;
        private Scores scores;
        private int iD;

        public Matches(int id,Teams homeTeam, Teams awayTeam, Scores scores )
        {
            if (homeTeam.Name == awayTeam.Name)
            {
                throw new ArgumentException("Home and away team must be different");
            }
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Scores = scores;
            this.ID = id;
        }

        public Teams HomeTeam
        {
            get { return this.homeTeam; }
            set { this.homeTeam = value; }
        }

        public Teams AwayTeam
        {
            get { return this.awayTeam; }
            set { this.awayTeam = value; }
        }
        public Scores Scores
        {
            get { return this.scores; }
            set { this.scores = value; }
        }

        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }

        public Teams GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Scores.HomeTeamGoals > this.Scores.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
            
        }

        private bool IsDraw()
        {
            return this.Scores.HomeTeamGoals == this.Scores.AwayTeamGoals;
        }

        public override string ToString()
        {
            return $"{this.HomeTeam} {this.Scores.HomeTeamGoals} : {this.Scores.AwayTeamGoals} {this.AwayTeam}";
        }
    }
}
