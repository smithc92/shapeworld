namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
        //fields 
        //private int numberOfEdges;    //backing field (since private, only members of class)

        //properties
        public virtual double Perimeter()
        {
          return 0;
        }
        public int NumberOfEdges{get;}
        public Shape(int edges)
        {
          NumberOfEdges = edges;
        }
      public abstract double Surface();
      public double Volume()
      {
        return 0;
      }
     
      
    }
}