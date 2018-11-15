using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2017_Murder
     {
         public static IEnumerable<September_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.8173946767677, -95.3259306666667);
              yield return new LatLng(29.6454811010101, -95.3777347676768);
              yield return new LatLng(29.6696675954439, -95.5340951804133);
              yield return new LatLng(29.7106817878788, -95.5163259393939);
              yield return new LatLng(29.6890094159936, -95.5953464490992);
          }
     }

     public class September_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
