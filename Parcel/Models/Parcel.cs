using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelObject
  {
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Volume { get; set; }
    public int VolumeCost { get; set; }
    public int WeightCost { get; set; }
    public int Price { get; set; }

    // public ParcelObject(int weight, int height, int width, int length)
    // {
    //   Weight = weight;
    //   Height = height; 
    //   Width = width;
    //   Length = length;
    //   VolumeCost = 0;
    //   WeightCost = 0;
    //   Volume = 0;
    //   Price = 0;
    // }
    public void GetVolume()
    {
      Volume = Length * Width * Height;
    }
    public void VolumePrice()
    {
      if (Volume > 1000 && Volume < 20000000 )
      {
        VolumeCost = 40000;
      }
      if (Volume < 1000 && Volume > 500)
      {
        VolumeCost = 10000;
      }
      if (Volume < 500)
      {
        VolumeCost = 1;
      }
    }
    public void WeightPrice()
    {
      if (Weight > 23000)
      {
        WeightCost = 47999;
      }
      if (Weight < 23000 && Weight > 1000)
      {
        WeightCost = 12000;
      }
      if (Weight < 1000)
      {
        WeightCost = 3;
      }
    }
    public void TotalPrice()
    {
      Price = VolumeCost + WeightCost;
    }
  }
}