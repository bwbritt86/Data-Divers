using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2017_Rape
     {
         public static IEnumerable<October_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7566082488663, -95.3397596236087);
              yield return new LatLng(29.734961122449, -95.3220924693878);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.7318382439024, -95.3529433658537);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6724958974359, -95.311505974359);
              yield return new LatLng(29.6662333658613, -95.2694678117348);
              yield return new LatLng(29.6599365600104, -95.3547100917663);
              yield return new LatLng(29.60579, -95.464871);
              yield return new LatLng(29.7162611020408, -95.4921939387755);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.8085585306122, -95.5489736326531);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7447932020202, -95.5762127272727);
              yield return new LatLng(29.689743, -95.3938302323232);
              yield return new LatLng(29.7855947296705, -95.693187162656);
              yield return new LatLng(29.7435053333333, -95.3716278181818);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.8436844148936, -95.3654230957447);
              yield return new LatLng(29.7869300204082, -95.4687429183674);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8565593073136, -95.3652224753166);
              yield return new LatLng(29.8617208064516, -95.4284417096774);
              yield return new LatLng(29.8793089520821, -95.476568061477);
              yield return new LatLng(29.8797973885035, -95.2871819379707);
              yield return new LatLng(29.8314181724138, -95.2915403448276);
              yield return new LatLng(29.8836048571429, -95.2997132040816);
          }
     }

     public class October_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
