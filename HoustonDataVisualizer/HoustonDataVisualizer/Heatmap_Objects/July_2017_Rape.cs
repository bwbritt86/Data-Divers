using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class July_2017_Rape
     {
         public static IEnumerable<July_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new July_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.6980747027027, -95.5521374864865);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.6977407926421, -95.2453408762542);
              yield return new LatLng(29.6871376530612, -95.2917853673469);
              yield return new LatLng(29.6110698243243, -95.2223115315315);
              yield return new LatLng(29.6943156363636, -95.3664827272727);
              yield return new LatLng(29.661513, -95.325104);
              yield return new LatLng(29.6175551456844, -95.4267761131037);
              yield return new LatLng(29.6005404387447, -95.4956267930963);
              yield return new LatLng(29.7051570134228, -95.4845335503356);
              yield return new LatLng(29.707378755102, -95.4733342857143);
              yield return new LatLng(29.698765, -95.310152);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7457422, -95.6247263);
              yield return new LatLng(29.7011715558864, -95.6160731593889);
              yield return new LatLng(29.67414, -95.545926);
              yield return new LatLng(29.7603296938776, -95.3518406530612);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.8282966116139, -95.4579969045052);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.9049892525699, -95.3377848535749);
              yield return new LatLng(29.8459233620257, -95.2704536253136);
              yield return new LatLng(29.7766403374321, -95.1759637100181);
              yield return new LatLng(29.7950661834201, -95.2424583087721);
          }
     }

     public class July_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
