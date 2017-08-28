using System.Collections.Generic;

namespace ShapeGarden.Models
{

  public class ShapeCollection
  {
    public void ArrayGroup()
    {
      //1D array
      int[] arr1 = {1,2,3};
      int[] arr2 = new int[]{4,5,6};
      int[] arr3 = new int[3];
      
      //adding and taking away from an array
      arr1[0] = 10;
      arr1[0] = null;

      //Multidemensional array
      int[,] arr4 = {{1,2}, {3,4}};
      int[,] arr5 = new int[,]{{1,2}, {3,4}};
      int[,] arr6 = new int[2,2];

      // Jagged
      // Each array has to be defined internally
      int[][] arr7 = { new int[]{1,2}, new int[]{3} };
    }

    public void ListGroup()
    {

      List<int> li1 = new List<int> {1,2,3};
      List<int> li2 = new List<int> ();

      li1.Add(3);
      li1[2] = 10;
    }

    public void DictonaryGroup()
    {
      Dictionary<string,string> d1 = new Dictionary<string, string>{{"name", "fred"}};
      Dictionary<string,string> d2 = new Dictionary<string, string>();

      //this will override
      d1["last"] = "belotte";
      //will throw an error if last already exists, if it doesn't exist it will create it
      d1.Add("title", "troublemaker");
    }

    //generics allow any other class to manipulate other types that are not theirs
    //
  }

}