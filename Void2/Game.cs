// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Security.Cryptography;

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
        float starRadius = 200;
        string[] Stars = new string[8];
       
        


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

            //This red circle will appear behind the big black circle, once the mouse click, is inputted 
            Draw.FillColor = Color.Red;

            Draw.LineColor = Color.Clear;
            Draw.Circle(Window.Size / 2, 50);
           //Attempting to do my own arrow 
            Vector2[] starDirections = []; 
            {
                Vector2 r = Random.Direction();
            }

            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                // If it is, make shape colors clear and background black
                Draw.FillColor = Color.Clear;
                
                //Trying to draw a star particle
                Draw.Circle(Window.Size / starRadius, 20);
               
                //Background goes black once mouse is clicked
                Window.ClearBackground(Color.Black);

            }
            else
            {
                
                // If not, make shape colors black
                Draw.FillColor = Color.Black;
            }
            //Adding in the black circle
            Draw.Circle(Window.Size / 2, 100);

            
            Draw.Circle(Window.Size / 2, 50);
//This is the small black circle that is seen once we click the left mouse
            Draw.FillColor = Color.Black;
            Draw.Circle(Window.Size / 2, 10);
            
            //Attempting my for loop
            for (int i = 0; i > starDirections.Length; i++)
            {
                Vector2 starDirection = starDirections[i];
                DrawStar(starDirection);
            }
        }

        private void DrawStar(Vector2 starDirections)
        {
            /*Adding the private void was the only way the DrawStar stopped being an error
             * But I'm kind of confused because the private void is mentioned after the DrawStar up above, is initially mentioned
             * So how is it still being read*/
        }
    }
}



