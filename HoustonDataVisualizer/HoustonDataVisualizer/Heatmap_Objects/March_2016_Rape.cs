using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class March_2016_Rape
     {
         public static IEnumerable<March_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new March_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7602626860715, -95.3472077291463);
              yield return new LatLng(29.7603817642685, -95.3473993706196);
              yield return new LatLng(29.727577, -95.3253825);
              yield return new LatLng(29.72825, -95.3528541020408);
              yield return new LatLng(29.7138472080378, -95.3939628770251);
              yield return new LatLng(29.7182845, -95.2796581);
              yield return new LatLng(29.7047557288236, -95.293260680533);
              yield return new LatLng(29.6197698421053, -95.2296872105263);
              yield return new LatLng(29.5613180816327, -95.1501531836735);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6497531441041, -95.3115956678176);
              yield return new LatLng(29.6630417651007, -95.2638808389262);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.7006327, -95.3736798);
              yield return new LatLng(29.6908470625, -95.3516902708333);
              yield return new LatLng(29.6862514162857, -95.3496833803079);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6659609591837, -95.348611122449);
              yield return new LatLng(29.6634554748143, -95.3222581681538);
              yield return new LatLng(29.6618145102041, -95.334665244898);
              yield return new LatLng(29.673488003084, -95.4885816281357);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.606104, -95.449994);
              yield return new LatLng(29.721231, -95.497919);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7087857058824, -95.4977005294118);
              yield return new LatLng(29.7200126229844, -95.4819969997463);
              yield return new LatLng(29.7200126229844, -95.4819969997463);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6725197373737, -95.5403538080808);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6856641521739, -95.53936);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7327835, -95.5716659);
              yield return new LatLng(29.7141317, -95.5963173);
              yield return new LatLng(29.6939542040816, -95.6074196938776);
              yield return new LatLng(29.6814752040816, -95.6044284897959);
              yield return new LatLng(29.6616143617222, -95.5997850819434);
              yield return new LatLng(29.6610459797665, -95.5904396967706);
              yield return new LatLng(29.758519, -95.3675124);
              yield return new LatLng(29.7520665918367, -95.3686781428571);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7432879474049, -95.3931702380644);
              yield return new LatLng(29.717628755102, -95.5450521836735);
              yield return new LatLng(29.7119174773168, -95.5455428167569);
              yield return new LatLng(29.7168595078565, -95.5559910784906);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.8376779347826, -95.3666047173913);
              yield return new LatLng(29.7855650101592, -95.6895989054828);
              yield return new LatLng(29.7979475973154, -95.5767239597315);
              yield return new LatLng(29.8051338571429, -95.4849743877551);
              yield return new LatLng(29.8118058, -95.5673448434227);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.8790297959184, -95.4180864693878);
              yield return new LatLng(29.7918145129239, -95.3105540617407);
              yield return new LatLng(29.7828783877551, -95.3386771836735);
              yield return new LatLng(29.8110549001347, -95.3469744189325);
              yield return new LatLng(29.8346139899666, -95.3369193143813);
              yield return new LatLng(29.8435112134407, -95.3410650379762);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.85701871875, -95.2648374375);
              yield return new LatLng(29.762978, -95.276078);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
          }
     }

     public class March_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
