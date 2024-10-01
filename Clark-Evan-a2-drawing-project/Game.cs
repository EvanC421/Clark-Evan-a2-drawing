// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color skyBlue = new Color(135, 206, 250);



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Chase Bob");
            Window.SetSize(400, 400);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(skyBlue);

            //Draw first building
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(0, 160, 120, 240);
            //draw second building
            Draw.Rectangle(120, 60, 100, 340);
            //Draw third builing
            Draw.Rectangle(220, 240, 80,160);
            //Draw fourth building
            Draw.Rectangle(300, 140, 100, 260);
        }
    }
}
