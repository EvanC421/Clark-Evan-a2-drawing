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
        //Colours:
        Color skyBlue = new Color(135, 206, 250);
        Color windows = new Color(255, 255, 10);
        Color BobsColour = new Color(177, 156, 217);

        //Bob's coordinates
        float xCoordinates = Random.Integer(40, 360);
        float yCoordinates = Random.Integer(40, 360);


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
            float mouseLocationX = Input.GetMouseX();
            float mouseLocationY = Input.GetMouseY();
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

            //draw windows on building 1
            for (int index1 = 0; index1 < 11; index1++)
            {
                int yOffset1 = index1 * 20;
                Draw.FillColor = windows;
                Draw.Square(10, 180 + yOffset1, 10);
                Draw.Square(30, 180 + yOffset1, 10);
                Draw.Square(50, 180 + yOffset1, 10);
                Draw.Square(70, 180 + yOffset1, 10);
                Draw.Square(90, 180 + yOffset1, 10);
            }
            //draw windows on building 2
            for (int index2 = 0; index2 < 11; index2++)
            {
                int yOffset2 = index2 * 30;
                Draw.FillColor = windows;
                Draw.Square(130, 70 + yOffset2, 10);
                Draw.Square(150, 70 + yOffset2, 10);
                Draw.Square(180, 70 + yOffset2, 10);
                Draw.Square(200, 70 + yOffset2, 10);
            }
            //draw windows on building 3
            for (int index3 = 0; index3 < 8; index3++)
            {
                int xOffset3 = index3 * 10;
                Draw.FillColor = windows;
                Draw.Square(220 + xOffset3, 250, 10);
                Draw.Square(220 + xOffset3, 280, 10);
                Draw.Square(220 + xOffset3, 310, 10);
                Draw.Square(220 + xOffset3, 340, 10);
                Draw.Square(220 + xOffset3, 370, 10);
            }
            //draw windows on building 4
            for (int index4 = 0; index4 < 12; index4++)
            {
                int yOffset4 = index4 * 20;
                Draw.FillColor = windows;
                Draw.Square(310, 150 + yOffset4, 10);
                Draw.Square(340, 150 + yOffset4, 10);
                Draw.Square(350, 150 + yOffset4, 10);
                Draw.Square(380, 150 + yOffset4, 10);
            }
            //Bob is drawn for the first time
            //Bob's body
            Draw.FillColor = BobsColour;
            Draw.Circle(xCoordinates, yCoordinates, 40);
            //Bob's eyes
            Draw.FillColor = Color.Black;
            Draw.Circle(xCoordinates - 20, yCoordinates - 10, 7);
            Draw.FillColor = Color.Black;
            Draw.Circle(xCoordinates + 20, yCoordinates - 10, 7);
            //Bob's mouth
            Draw.Rectangle(xCoordinates - 30, yCoordinates + 10, 60, 10);

            //Player puts mouse over Bob
            while (mouseLocationX <= xCoordinates+40 && mouseLocationX >= xCoordinates-40 && mouseLocationY <= yCoordinates+40 && mouseLocationY >= yCoordinates-40)
            {
                xCoordinates = Random.Integer(40, 360);
                yCoordinates = Random.Integer(40, 360);
                Draw.FillColor = BobsColour;
                Draw.Circle(xCoordinates, yCoordinates, 40);
            }
        }
    }
}
