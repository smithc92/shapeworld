using System;
using ShapeWorld.Domain.Models;

//triangle, circle, sphere, cube
namespace ShapeWorld.Client
{
    internal class Program
    {
      //access regular return name parameters
        private static void Main(string[] args)
        {
            PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Shape someShape = new Rectangle();
          Rectangle someSquare = new Square();
          //Rectangle someRectangle = new Rectangle() as Square;
          //someRectangle someRectangle2 = (Shape) new Rectangle(); <-- Can't do this, shape is abstract
          
          Shape someCube = new Cube();

          someSquare.Length = 10;
          someSquare.Width = 100;

          Console.WriteLine(someShape.Volume());
          //Console.WriteLine(someRectangle.NumberOfEdges);
          Console.WriteLine(someSquare.Volume());
        }
    }
}
