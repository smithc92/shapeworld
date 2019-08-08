using System.Collections.Generic;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Domain.Collections
{
  public class ShapeArray
  {
    public void DimensionsArray()
    {
      //1-D
      Shape[] shaped = new Shape[10];
      Shape[] shaped2 = new Shape[]{new Square()};

      //2-D
      Shape[,] shaped3 = new Shape[2,2];
      Shape[,] shaped4 = new Shape[,] 
      {
        {new Square(), new Square()},
        {new Cube(), new Triangle()}
      };

      //3-D
      Shape[,,] shaped5 = new Shape[3,3,3];
      /* Shape[,,] shaped6 = new Shape[,,]
      {
        {{new Square(), new Square(), new Square(), new Square(), new Square()},
        {{new Square(), new Square(), new Square()},
        {{new Square(), new Square(), new Square()},
        {{new Square(), new Square(), new Square()}
      }};*/

      //Read
      System.Console.WriteLine(shaped2[0]);
      System.Console.WriteLine(shaped4[1,0]);
      //System.Console.WriteLine(shaped6[1,0,2]);

      //jagged array, array of arrays
      //by default c# doesn't do this, but can

      //Jagged Array
      Shape[][] shaped7 = new Shape[10][]; //10 arrays of dimension 1
      Shape[][] shaped8 = new Shape[][]
      {
        new Rectangle[10],
        new Circle[]{new Circle(), new Circle()}
      };

      System.Console.WriteLine(shaped8[1][1]);



    }

    public void MyList()
    {
      List<Shape> shaped = new List<Shape>();
      List<Shape> shaped2 = new List<Shape> {new Cube(), new Cube()};

      List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
      List<Shape[][,,]> shaped4 = new List<Shape[][,,]>{(new Shape[5][,,])};
    }

  }
}