using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2017_Rape
     {
         public static IEnumerable<August_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7331621836735, -95.364142877551);
              yield return new LatLng(29.711722969697, -95.2878343030303);
              yield return new LatLng(29.603018, -95.250206);
              yield return new LatLng(29.5894216969697, -95.2239293030303);
              yield return new LatLng(29.5667045483871, -95.1145992580645);
              yield return new LatLng(29.7006327, -95.3736798);
              yield return new LatLng(29.682599, -95.373226);
              yield return new LatLng(29.673488003084, -95.4885816281357);
              yield return new LatLng(29.7959111395349, -95.3373506976744);
              yield return new LatLng(29.68611490759, -95.3505691890695);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.7584508163265, -95.3542289387755);
              yield return new LatLng(29.8316264, -95.7543887);
              yield return new LatLng(29.7258203959353, -95.5454003020324);
              yield return new LatLng(29.7354313265306, -95.2944452244898);
              yield return new LatLng(29.785324605, -95.467904);
              yield return new LatLng(29.7201750617185, -95.373671835899);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8469203265306, -95.349000877551);
              yield return new LatLng(29.8619575, -95.34303);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
          }
     }

     public class August_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
