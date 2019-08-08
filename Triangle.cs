namespace ShapeWorld.Domain.Models
{
    public class Triangle : Shape
    {
      public Triangle() : base(3)
      {
      }

      public virtual double Base{get;set;}
      public virtual double Height{get;set;}

      public override double Surface()
      {
        return (1/2) * Base * Height;
      }

    }
}