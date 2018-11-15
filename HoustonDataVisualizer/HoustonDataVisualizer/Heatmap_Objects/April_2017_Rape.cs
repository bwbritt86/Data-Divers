using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class April_2017_Rape
     {
         public static IEnumerable<April_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new April_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7401870408163, -95.3446287755102);
              yield return new LatLng(29.7341428571429, -95.3469380408163);
              yield return new LatLng(29.7127695, -95.4868239);
              yield return new LatLng(29.710271979798, -95.2842763333333);
              yield return new LatLng(29.7255624489796, -95.2798205918367);
              yield return new LatLng(29.6925800014518, -95.2456303395928);
              yield return new LatLng(29.6819180494206, -95.2500726548635);
              yield return new LatLng(29.6469658243243, -95.235043027027);
              yield return new LatLng(29.6311308163265, -95.2470917959184);
              yield return new LatLng(29.7208343, -95.2119019);
              yield return new LatLng(29.6810356122449, -95.2800828571429);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6719111934312, -95.3082498561374);
              yield return new LatLng(29.69728859375, -95.334682);
              yield return new LatLng(29.6476951515152, -95.3693626262626);
              yield return new LatLng(29.652734, -95.352984);
              yield return new LatLng(29.6631371632653, -95.3702964285714);
              yield return new LatLng(29.6732912040816, -95.3584646326531);
              yield return new LatLng(29.6659609591837, -95.348611122449);
              yield return new LatLng(29.6631371632653, -95.3702964285714);
              yield return new LatLng(29.6827943919687, -95.3322137036491);
              yield return new LatLng(29.628195941875, -95.3655937471263);
              yield return new LatLng(29.6794774081633, -95.479232755102);
              yield return new LatLng(29.7037033882285, -95.3809492149503);
              yield return new LatLng(29.689743, -95.3938302323232);
              yield return new LatLng(29.611800132337, -95.4497360813895);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.7012641282959, -95.5074302285693);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6395925357143, -95.50304725);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.6398775153154, -95.4952952282314);
              yield return new LatLng(29.668476, -95.50441151);
              yield return new LatLng(29.743323442953, -95.4641478187919);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.7342657, -95.4898185);
              yield return new LatLng(29.7666506, -95.4551646);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7114463673469, -95.5179400408163);
              yield return new LatLng(29.7327835, -95.5716659);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7037772575758, -95.5898191363636);
              yield return new LatLng(29.6659370272103, -95.5818741213125);
              yield return new LatLng(29.7581051020408, -95.36773);
              yield return new LatLng(29.7478610612245, -95.3863975510204);
              yield return new LatLng(29.748870244898, -95.3928032653061);
              yield return new LatLng(29.7300747688563, -95.4614405307345);
              yield return new LatLng(29.7090398008955, -95.5553019988087);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.746313, -95.61436);
              yield return new LatLng(29.7315844747475, -95.6523320707071);
              yield return new LatLng(29.771096, -95.4110694489796);
              yield return new LatLng(29.677502, -95.353798);
              yield return new LatLng(29.8140111428571, -95.4574147619048);
              yield return new LatLng(29.8389243623188, -95.4775157028986);
              yield return new LatLng(29.81850544, -95.45949316);
              yield return new LatLng(29.8226899387755, -95.3705960204082);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7909320769231, -95.5473729102564);
              yield return new LatLng(29.8014901020408, -95.5699578979592);
              yield return new LatLng(29.8024211428571, -95.4789734897959);
              yield return new LatLng(29.8528709183673, -95.5155002040816);
              yield return new LatLng(29.8675903576584, -95.3978816936079);
              yield return new LatLng(29.8675903576584, -95.3978816936079);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.946196621034, -95.4351549684004);
              yield return new LatLng(29.947744032382, -95.4303875687136);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8540607803516, -95.2906498108119);
              yield return new LatLng(29.7787483673469, -95.2983608367347);
              yield return new LatLng(29.7758115714286, -95.2227946666667);
              yield return new LatLng(29.697891, -95.419713);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.725472, -95.48764);
          }
     }

     public class April_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
