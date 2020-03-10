using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set;}
    public int Width { get; set; }
    public int Weight { get; set; }
    public static List<Parcel> ParcelItems = new List<Parcel>() {};

    public Parcel(int length, int width, int weight)
    {
      Length = length;
      Width = width;
      Weight = weight;
      ParcelItems.Add(this);
    }


  } 
}