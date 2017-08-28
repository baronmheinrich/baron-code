using ShapeGarden.Interfaces;

namespace ShapeGarden.Abstracts
{

  public abstract class AShape : IShape
  {
    public int Sides { get; set; }

    protected AShape(int s)
    {
      Sides = s;
    }

    public double Volume()
    {
      throw new System.NotImplementedException();
    }

    public double Perimeter()
    {
      throw new System.NotImplementedException();
    }

    public abstract double Surface();
  }

}