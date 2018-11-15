using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class April_2017_Murder
     {
         public static IEnumerable<April_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new April_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7321579591837, -95.3577049795918);
              yield return new LatLng(29.7320696923077, -95.3565831282051);
              yield return new LatLng(29.7035782, -95.2807134);
              yield return new LatLng(29.6935841053542, -95.3590650558638);
              yield return new LatLng(29.6326872071708, -95.4960132108338);
              yield return new LatLng(29.6879648888889, -95.5097585555556);
              yield return new LatLng(29.6395925357143, -95.50304725);
              yield return new LatLng(29.6789146538462, -95.5526367307692);
              yield return new LatLng(29.7740009387755, -95.3570969591837);
              yield return new LatLng(29.7845091065692, -95.3507688520902);
              yield return new LatLng(29.957373, -95.4232634897959);
              yield return new LatLng(29.7848576896552, -95.2276817931034);
          }
     }

     public class April_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
