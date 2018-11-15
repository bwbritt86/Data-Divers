using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2016_Murder
     {
         public static IEnumerable<October_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7335596666667, -95.349399);
              yield return new LatLng(29.7296489615385, -95.3504091923077);
              yield return new LatLng(29.700029244898, -95.2752738979592);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6908142424242, -95.3676044545455);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.593473119917, -95.4791093104483);
              yield return new LatLng(29.7029691304348, -95.5036854347826);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.8299976464646, -95.3385687171717);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.7647012051282, -95.2131688717949);
              yield return new LatLng(29.7599257, -95.3624897);
          }
     }

     public class October_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
