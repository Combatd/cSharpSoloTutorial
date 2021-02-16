using System;

namespace DrawingApplication
{
    /*
     You are creating a drawing application and currently have only 1 tool - a pencil. You want to add brush and spray to the drawing toolbar.
    The program you are given declares an IDraw interface with the StartDraw() method, and class Draw, which performs pencil drawing by implementing the IDraw interface. It outputs "Using pencil".
    Complete the given Brush and Spray classes by
    - inheriting them from class Draw
    - implementing the StartDraw() method for each tool, in order to output
    "Using brush" for Brush, or
    "Using spray" for Spray.
     */




    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */


    public interface IDraw
    {
        void StartDraw();
    }
}
