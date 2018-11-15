using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2017_Murder
     {
         public static IEnumerable<November_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.726725969697, -95.3642849595959);
              yield return new LatLng(29.7309439387755, -95.3537383877551);
              yield return new LatLng(29.7291786938776, -95.3497875510204);
              yield return new LatLng(29.6360937910937, -95.3428903775534);
          }
     }

     public class November_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
