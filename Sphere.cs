namespace ShapeWorld.Domain.Models
{
    public class Sphere : Circle
    {
      public new double Volume()
      {
        return Surface() * (4/3) * Radius;
      }
    }
}