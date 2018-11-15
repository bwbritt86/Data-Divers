using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2016_Murder
     {
         public static IEnumerable<June_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6631371632653, -95.3702964285714);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6362302424242, -95.3624652727273);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6798912222222, -95.4774146666667);
              yield return new LatLng(29.6071936938776, -95.4281576734694);
              yield return new LatLng(29.583181, -95.4623755);
              yield return new LatLng(29.5921678323009, -95.4736900897833);
              yield return new LatLng(29.7163082380952, -95.4879661904762);
              yield return new LatLng(29.6687234444444, -95.5042262525253);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6751812244898, -95.5879819387755);
              yield return new LatLng(29.770085244898, -95.6000634897959);
              yield return new LatLng(29.82362425, -95.5314646252594);
              yield return new LatLng(29.8748126993988, -95.4355938517034);
              yield return new LatLng(29.8194220808081, -95.3288302424242);
              yield return new LatLng(29.8544907763785, -95.3439813484051);
              yield return new LatLng(29.8227487667553, -95.3050832444147);
          }
     }

     public class June_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
