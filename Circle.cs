namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
      public Circle() : base(0)
      {
      }

      public virtual double Radius{get;set;}

      public override double Surface()
      {
        return Math.PI * pow(Radius, 2);
      }

      public override double Perimeter()
      {
        return 2*Math.PI*Radius;
      }
      

    }
}