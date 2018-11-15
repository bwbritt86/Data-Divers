using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class March_2017_Rape
     {
         public static IEnumerable<March_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new March_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.753574244898, -95.3517533673469);
              yield return new LatLng(29.7368168571429, -95.352886122449);
              yield return new LatLng(29.7171416220999, -95.375713841297);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.7216530612245, -95.3192983673469);
              yield return new LatLng(29.6819180494206, -95.2500726548635);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6171450204082, -95.2239143265306);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.582874943038, -95.2093695063291);
              yield return new LatLng(29.5943397142857, -95.1834482040816);
              yield return new LatLng(29.7149030487805, -95.3187134512195);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6964211632653, -95.3681980204082);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6713034219539, -95.3718964702144);
              yield return new LatLng(29.6618809795918, -95.3429293673469);
              yield return new LatLng(29.6778441363949, -95.3428279373191);
              yield return new LatLng(29.6712712653061, -95.3477157142857);
              yield return new LatLng(29.770793, -95.328129);
              yield return new LatLng(29.6251300221535, -95.3673302169516);
              yield return new LatLng(29.6400136122449, -95.350181);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6790415510204, -95.4854418163265);
              yield return new LatLng(29.6790584166667, -95.4820706666667);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.79535655, -95.4723364145281);
              yield return new LatLng(29.6239195, -95.4293975);
              yield return new LatLng(29.6226503636364, -95.5011078787879);
              yield return new LatLng(29.7108146, -95.4934061);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7201615, -95.483087);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6654564127762, -95.5167636830897);
              yield return new LatLng(29.6463671020408, -95.5030988163265);
              yield return new LatLng(29.7666506, -95.4551646);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7361066112446, -95.4951988245413);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7328652, -95.506082);
              yield return new LatLng(29.7106817878788, -95.5163259393939);
              yield return new LatLng(29.7067990308582, -95.5185425632659);
              yield return new LatLng(29.7167560681828, -95.5109625700638);
              yield return new LatLng(29.7008048783311, -95.5661137032163);
              yield return new LatLng(29.755755, -95.358351);
              yield return new LatLng(29.7645882244898, -95.3625878571429);
              yield return new LatLng(29.7439656326531, -95.3801708163265);
              yield return new LatLng(29.752256, -95.406549);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7258203959353, -95.5454003020324);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7712725454545, -95.5947524545455);
              yield return new LatLng(29.7761783, -95.5991007);
              yield return new LatLng(29.7796620025975, -95.6209187670583);
              yield return new LatLng(29.7315844747475, -95.6523320707071);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.8131316331658, -95.3691038994975);
              yield return new LatLng(29.478761, -95.0503024);
              yield return new LatLng(29.7743795918367, -95.3741537755102);
              yield return new LatLng(29.7946772289157, -95.4163891325301);
              yield return new LatLng(29.8220178478261, -95.4809752173913);
              yield return new LatLng(29.823928, -95.462066);
              yield return new LatLng(29.8402325454545, -95.468639030303);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8286119459459, -95.3942285945946);
              yield return new LatLng(29.79272316, -95.54022348);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7855947296705, -95.693187162656);
              yield return new LatLng(29.8016129591837, -95.4849274897959);
              yield return new LatLng(29.8218831414141, -95.5154092323232);
              yield return new LatLng(29.9579508073025, -95.4187490410603);
              yield return new LatLng(29.9537134088502, -95.4184086546896);
              yield return new LatLng(29.9689524, -95.5423929);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.8463720204082, -95.3718984285714);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8712862763819, -95.4429188442211);
              yield return new LatLng(29.9530113773585, -95.3921516037736);
              yield return new LatLng(29.9535212105263, -95.3933262105263);
              yield return new LatLng(29.8191754713115, -95.3434342418033);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.7881073939394, -95.341178969697);
              yield return new LatLng(29.8002404545455, -95.3246092323232);
              yield return new LatLng(29.8216286530612, -95.3502214693877);
              yield return new LatLng(29.8539362323382, -95.2624842332493);
              yield return new LatLng(29.8778949290866, -95.2937828076901);
              yield return new LatLng(29.770006, -95.350268);
              yield return new LatLng(29.7770732857143, -95.2458466326531);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.785742877551, -95.2227415918367);
              yield return new LatLng(29.7758115714286, -95.2227946666667);
              yield return new LatLng(29.7758115714286, -95.2227946666667);
          }
     }

     public class March_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
