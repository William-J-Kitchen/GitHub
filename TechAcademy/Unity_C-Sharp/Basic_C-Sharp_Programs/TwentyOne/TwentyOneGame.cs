﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class TwentyOneGame : Game //: <Name> causes this to inherit from the Game class

    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

    }
}
