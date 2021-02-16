using System;
namespace DrawingApplication
{
    public class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }
}
