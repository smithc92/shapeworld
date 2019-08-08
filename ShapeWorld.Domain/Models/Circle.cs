namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
      public const double PI = 3.14159265358979;
      public Circle() : base(0)
      {
      }

      public virtual double Radius{get;set;}

      public override double Surface()
      {
        return PI * Radius * Radius;
      }

      public override double Perimeter()
      {
        return 2*PI*Radius;
      }
      

    }
}