using ShapeGarden.Abstracts;
using ShapeGarden.Interfaces;

namespace ShapeGarden.Models
{
  public class Rectangle : AShape
  {

      public Rectangle() : base(4)
      {
      }

      //destructor
      ~Rectangle()
      {
        var s = new Square();
      }

    // public Rectangle()
    // {
    //     decimal w;
    //     decimal x;
    //     decimal y;
    //     decimal z;
    // }


    //get return this.number; set this.number = value;
    public override double Surface()
    {
      throw new System.NotImplementedException();
    }
  }

}