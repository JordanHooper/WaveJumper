using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public enum GameState
    {
        menuScreen,             //just have the menu enabled
        preGame,                //pre game timer
        running,                //gameplay
        gamePause,              //paused
        gameEnd                 //end - update highscores if necessary
    };
}
