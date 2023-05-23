using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Danny";
            CurrentPlayer.CharacterClass = "Wizard";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 10000;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.Location_Row = 0;
            CurrentLocation.Location_Column = 0;
            CurrentLocation.Description = "Your Current Residence";
        }
    }
}
