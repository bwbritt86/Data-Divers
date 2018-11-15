using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2016_Murder
     {
         public static IEnumerable<May_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7338759795918, -95.3603180612245);
              yield return new LatLng(29.7335177142857, -95.3656742040816);
              yield return new LatLng(29.6476196046512, -95.2214794418605);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6659609591837, -95.348611122449);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6452468286075, -95.4964896886431);
              yield return new LatLng(29.6188137755422, -95.4728467991055);
              yield return new LatLng(29.7201615, -95.483087);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.7328357857233, -95.4959019983648);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7007325833333, -95.55219675);
              yield return new LatLng(29.6864043469388, -95.5651479183674);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7091863131313, -95.5453897878788);
              yield return new LatLng(29.7725265454545, -95.5747280909091);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7936089, -95.5214399);
              yield return new LatLng(29.7985828139535, -95.4849515581395);
              yield return new LatLng(29.8615970251256, -95.3696124422111);
              yield return new LatLng(29.8764027549045, -95.4270668213767);
              yield return new LatLng(29.7774369183673, -95.3323104081633);
              yield return new LatLng(29.8161442, -95.2625062);
          }
     }

     public class May_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
