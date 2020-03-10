using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set;}
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Width { get; set;}
    public int Cost {get; set;}
    public static List<Parcel> ParcelItems = new List<Parcel>() {};

    public Parcel(int length, int width, int weight, int height)
    {
      Length = length;
      Width = width;
      Weight = weight;
      Height = height;
      ParcelItems.Add(this);
    }
    public int GetVolume()
    {
      int volume = Width * Length * Height;
      return volume;
    }

    public int GetCost()
    {
      int cost = (Volume + Weight) * .05;
      return cost;
    }

    public static List<Parcel> ShowParcel()
    {
      ParcelItems.Clear();
    }
  } 
}