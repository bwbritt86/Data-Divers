using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class May_2017_Rape
     {
         public static IEnumerable<May_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new May_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7418031632653, -95.3123541632653);
              yield return new LatLng(29.75392075, -95.349489625);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.6399484054054, -95.4261114864865);
              yield return new LatLng(29.6750496530612, -95.3695186938776);
              yield return new LatLng(29.7357244489796, -95.2874945918367);
              yield return new LatLng(29.924223, -95.382502);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.679342877551, -95.5559142857143);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.8592895691507, -95.2877610058607);
              yield return new LatLng(29.6724684411581, -95.5773314418661);
              yield return new LatLng(29.7523407489211, -95.3604139519699);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.982078, -95.564517);
              yield return new LatLng(29.7342176494759, -95.5434038457369);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.5972770040948, -95.4846793139348);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7953774693878, -95.5589194081633);
              yield return new LatLng(29.823928, -95.462066);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8490444563836, -95.3035331530787);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.7837704081633, -95.3146785918367);
              yield return new LatLng(29.7837704081633, -95.3146785918367);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.7870241919192, -95.3315778686869);
              yield return new LatLng(29.8280281000231, -95.3509671751889);
              yield return new LatLng(29.8218205, -95.2844685);
              yield return new LatLng(29.7395890805369, -95.387684409396);
              yield return new LatLng(29.8797428777778, -95.3032953777778);
          }
     }

     public class May_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
