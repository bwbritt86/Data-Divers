using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class July_2016_Murder
     {
         public static IEnumerable<July_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new July_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.729131, -95.350674);
              yield return new LatLng(29.7292460408163, -95.2978614897959);
              yield return new LatLng(29.6995014285714, -95.2805834693878);
              yield return new LatLng(29.651515, -95.249058755102);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6825177159496, -95.3725253456453);
              yield return new LatLng(29.6757984324324, -95.3415008378378);
              yield return new LatLng(29.6430288367347, -95.4942236530612);
              yield return new LatLng(29.6969082940421, -95.4356165050111);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.7010972417825, -95.4823867898904);
              yield return new LatLng(29.5357912, -95.466331);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.6875338, -95.5745422);
              yield return new LatLng(29.7563300816327, -95.3808778163265);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.8995868181818, -95.4967850909091);
              yield return new LatLng(29.789859344453, -95.3360431218037);
              yield return new LatLng(29.839848026391, -95.3428993783418);
              yield return new LatLng(29.9391132653061, -95.315711);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8221160349579, -95.3173171878809);
              yield return new LatLng(29.80955, -95.282841);
              yield return new LatLng(29.8536385987613, -95.2883264283131);
              yield return new LatLng(29.76119152, -95.2676274);
              yield return new LatLng(29.775889, -95.2191189795918);
          }
     }

     public class July_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
