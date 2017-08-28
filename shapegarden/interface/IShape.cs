namespace ShapeGarden.Interfaces
{
    
public interface IShape
{
  int Sides {get; set;} //Property as opposed to Getters and Setters
  double Perimeter();
  double Surface();

}
    
}