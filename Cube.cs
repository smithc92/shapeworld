namespace ShapeWorld.Domain.Models
{
    public class Cube : Square
    {
      public new double Volume()
      {
        return Surface() * Width;
      }
    }
}