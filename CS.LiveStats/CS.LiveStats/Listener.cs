using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSGSI;

namespace CS.LiveStats
{
    public class Listener
    {
        private GameStateListener _listener;
        private GameState _currentGS;
        private int _health;

        public GameState CurrentGS
        {
            get { return _currentGS; }
        }

        public Listener()
        {
            _listener = new GameStateListener(3000);
            _listener.NewGameState += new NewGameStateHandler(OnNewGameState);

            // If the listener can't start then abort.
            if (_listener.Start() == false)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Listening...");
        }

        private void OnNewGameState(GameState gs)
        {
            // First thing to do is set the current gamestate so other classes can use it.
            _currentGS = gs;

            _health = gs.Player.State.Health;

            Console.WriteLine(_health);
        }

    }
}
