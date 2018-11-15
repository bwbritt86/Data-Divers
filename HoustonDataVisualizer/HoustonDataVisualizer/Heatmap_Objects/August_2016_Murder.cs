using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2016_Murder
     {
         public static IEnumerable<August_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7309439387755, -95.3537383877551);
              yield return new LatLng(29.7033018787879, -95.3663922121212);
              yield return new LatLng(29.6207874, -95.3046589);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.7162611020408, -95.4921939387755);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.73168523361, -95.6364232322608);
              yield return new LatLng(29.780933, -95.329664);
              yield return new LatLng(29.838667877551, -95.3890506122449);
              yield return new LatLng(29.8241359795918, -95.522740244898);
              yield return new LatLng(29.9469814980719, -95.4050693774446);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.8555323636364, -95.3303825454545);
              yield return new LatLng(29.8348965353716, -95.3251433881923);
              yield return new LatLng(29.8394945555556, -95.262322969697);
              yield return new LatLng(29.768018, -95.2163005);
          }
     }

     public class August_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
