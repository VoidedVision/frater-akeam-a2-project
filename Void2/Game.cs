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
        // Place your variables here:


        float[] voidRadius = {
            50f,

        };
        Vector2[] voidPosition = {
            new(150, 100)};


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Void");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Clear;
            Draw.Circle(Window.Size / 2, 50);

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                // If it is, make shape colors clear and background black
                Draw.FillColor = Color.Clear;
                Window.ClearBackground(Color.Black);
            }
            else
            {
                // If not, make shape colors black
                Draw.FillColor = Color.Black;
            }
            Draw.Circle(Window.Size / 2, 100);

            Draw.Circle(Window.Size / 2, 50);

            Draw.FillColor = Color.Black;
            Draw.Circle(Window.Size / 2, 10);
        }
    }
}

//I'm gonna lose my mind :D




//THERE IS NOTHING OVER HERE :D

