using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class July_2017_Murder
     {
         public static IEnumerable<July_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new July_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7300966352384, -95.365334058868);
              yield return new LatLng(29.607654, -95.172573);
              yield return new LatLng(29.8387009146933, -95.289900340831);
              yield return new LatLng(29.6712712653061, -95.3477157142857);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7560844489796, -95.3830006530612);
          }
     }

     public class July_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
