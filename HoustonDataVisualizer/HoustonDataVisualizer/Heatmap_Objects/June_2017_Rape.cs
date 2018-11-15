using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2017_Rape
     {
         public static IEnumerable<June_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7613989980568, -95.3754698178285);
              yield return new LatLng(29.7249037878788, -95.3520687272727);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.8074022392637, -95.3207627234906);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.6854243673469, -95.2619330408163);
              yield return new LatLng(29.6647264, -95.2125476);
              yield return new LatLng(29.6834457, -95.3656674);
              yield return new LatLng(29.8496371515152, -95.3198624646465);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6944722314815, -95.388591462963);
              yield return new LatLng(29.6988202, -95.3868178);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.7114463673469, -95.5179400408163);
              yield return new LatLng(29.738651, -95.494111);
              yield return new LatLng(29.74404, -95.36347);
              yield return new LatLng(29.659486755102, -95.5034593061225);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.781687, -95.367524);
              yield return new LatLng(29.9689524, -95.5423929);
              yield return new LatLng(29.7520962726353, -95.6251621325111);
              yield return new LatLng(29.8617283318336, -95.5055170493683);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.8524726326531, -95.5205063265306);
              yield return new LatLng(29.8785572857143, -95.4298756326531);
              yield return new LatLng(29.7901810612245, -95.3412129591837);
              yield return new LatLng(29.842884755102, -95.4030824897959);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.8216981159515, -95.2720647533042);
              yield return new LatLng(29.7728, -95.3123125);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
              yield return new LatLng(29.866607, -95.323695);
          }
     }

     public class June_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
