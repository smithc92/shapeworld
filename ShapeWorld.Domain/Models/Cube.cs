using ShapeWorld.Domain.Interfaces;
namespace ShapeWorld.Domain.Models
{
    public class Cube : Square , IThreeD
    {
    public double Height { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    /* public new double Volume()
{
return Surface() * Width;
}*/
    public override double Surface()
      {
        return 0;
      }

    }
}