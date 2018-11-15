using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class March_2017_Murder
     {
         public static IEnumerable<March_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new March_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7037625424248, -95.2826574764096);
              yield return new LatLng(29.6323970411211, -95.3404577884705);
              yield return new LatLng(29.612259466971, -95.3502424340882);
              yield return new LatLng(29.6988202, -95.3868178);
              yield return new LatLng(29.7613182, -95.4654908);
              yield return new LatLng(29.7019272, -95.6163408);
              yield return new LatLng(29.754107755102, -95.3563747959184);
              yield return new LatLng(29.7668882040816, -95.6255951428571);
              yield return new LatLng(29.7773664285714, -95.3975359183674);
              yield return new LatLng(29.83130044082, -95.4118866092741);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.7729318125, -95.32320925);
              yield return new LatLng(29.7843022653061, -95.2957093469388);
          }
     }

     public class March_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
