using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSGSI;
using CSGSI.Nodes;

namespace CS.LiveStats
{
    class Program
    {
        static private Listener _listener;

        static GameStateListener gsl;

        static void Main(string[] args)
        {
            _listener = new Listener();
        }
    }
}
