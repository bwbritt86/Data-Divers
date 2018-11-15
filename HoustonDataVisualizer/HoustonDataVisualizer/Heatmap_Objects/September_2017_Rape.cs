using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2017_Rape
     {
         public static IEnumerable<September_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.6362163939394, -95.2326963939394);
              yield return new LatLng(29.6998534528302, -95.3040841509434);
              yield return new LatLng(29.6144678989899, -95.2678498080808);
              yield return new LatLng(29.6943156363636, -95.3664827272727);
              yield return new LatLng(29.6322769943548, -95.3423819982169);
              yield return new LatLng(29.6829012727273, -95.4852554545455);
              yield return new LatLng(29.7274341818182, -95.4813061515152);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6831235656566, -95.5117016363636);
              yield return new LatLng(29.8777571212468, -95.2984159654792);
              yield return new LatLng(29.6654564127762, -95.5167636830897);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.679273, -95.5528135);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.8503403307754, -95.607220770633);
              yield return new LatLng(29.8362243466289, -95.3900988549315);
              yield return new LatLng(29.7635834006181, -95.4787056697866);
              yield return new LatLng(29.6653068926174, -95.5888028724832);
              yield return new LatLng(29.8570641946309, -95.4186079060403);
              yield return new LatLng(29.8452082, -95.3774922);
          }
     }

     public class September_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
