namespace ShapeWorld.Domain.Models
{
    public class RectanglularPrism : Rectangle
    {
      public virtual double Height{get; set;}
     
      public new double Volume()
      {
        //return 1234;
        return Surface() * Height;
      }
    }
}