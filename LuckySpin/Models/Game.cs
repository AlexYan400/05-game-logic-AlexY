using System;
using System.Collections.Generic;
using System.Linq;
using LuckySpin.Services;

namespace LuckySpin.Models
{
    /**
    * Game Model holds the game logic and in-memory list of Spins as well as the current Player
    * Notice the use of the GameStatus enum to track the current state of the Game
    * this will help control the game play flow in the Controller and Views
    **/
    public class Game
    {
        //Instance Variables
        private List<Spin> _spins = new List<Spin>(); //NOTE: This is an in-memory list of spins

        //Game Properties
        public Player? Player { get; set; } //The Player playing this Game
        public IEnumerable<Spin> Spins { //Read only - the spins in the game
            get { return _spins; }
        }
        public decimal PlayCost { //Read only - the cost to play a spin
            get { return 0.50m; }
        }
        public GameStatus Status { get; set; } = GameStatus.Idle;
        //TODO: Implement the PlayTurn Method as shown in Figure 1. Be sure to set Game Status appropriately
        //      Run Unit Tests to check
        public void PlayTurn(Spin spin){


        }
        //Game helper methods
        public void Start()
        {
            Reset();
            Status = GameStatus.Spinning;
        }
        public void AddSpin(Spin s)
        {
            _spins.Add(s);
        }
        public void Reset()
        {
            _spins.Clear();
            Status = GameStatus.Idle;
        }
    }

    public enum GameStatus
    {
        Idle,
        Spinning,
        Won,
        GameOver
    }
}