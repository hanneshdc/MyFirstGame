using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace MyFirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow myGameWindow = new MyGameWindow();
            myGameWindow.Run(60);
        }
    }
}
