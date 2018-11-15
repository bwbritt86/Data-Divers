using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class January_2017_Murder
     {
         public static IEnumerable<January_2017_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new January_2017_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.5873681726716, -95.4518598882582);
              yield return new LatLng(29.7064560204082, -95.484556877551);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6789146538462, -95.5526367307692);
              yield return new LatLng(29.692069122449, -95.5517520816327);
              yield return new LatLng(29.7180435714286, -95.541226);
              yield return new LatLng(29.8675903576584, -95.3978816936079);
              yield return new LatLng(29.8614693316583, -95.473508758794);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.8075831791045, -95.3157364328358);
              yield return new LatLng(29.8414482357095, -95.251867576782);
              yield return new LatLng(29.7378787142857, -95.3557579795918);
              yield return new LatLng(29.6932067565645, -95.3371896214654);
              yield return new LatLng(29.6903414897959, -95.3531256122449);
              yield return new LatLng(29.697062974359, -95.3576732051282);
              yield return new LatLng(29.6362140808081, -95.3611970909091);
          }
     }

     public class January_2017_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
