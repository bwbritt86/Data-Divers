using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class April_2016_Rape
     {
         public static IEnumerable<April_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new April_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7305256734694, -95.3675261632653);
              yield return new LatLng(29.7039737587384, -95.3667680426302);
              yield return new LatLng(29.720443828083, -95.3931279754312);
              yield return new LatLng(29.6947797803991, -95.3835887082411);
              yield return new LatLng(29.7252865, -95.3868255);
              yield return new LatLng(29.727919483871, -95.2903611935484);
              yield return new LatLng(29.6400372, -95.2443648);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5877504242424, -95.2257416363636);
              yield return new LatLng(29.619390122449, -95.193772122449);
              yield return new LatLng(29.5610352692308, -95.129765);
              yield return new LatLng(29.6675159049789, -95.3160304082645);
              yield return new LatLng(29.6920064285714, -95.3683206938775);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6738090204082, -95.3703041632653);
              yield return new LatLng(29.6207874, -95.3046589);
              yield return new LatLng(29.6235330408163, -95.3639363061225);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.677712, -95.463628);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6288434693878, -95.3644300612245);
              yield return new LatLng(29.6030839, -95.4671501);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7010972417825, -95.4823867898904);
              yield return new LatLng(29.7200735, -95.490992);
              yield return new LatLng(29.7087857058824, -95.4977005294118);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6631406447368, -95.50366325);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.69661875, -95.5959391428571);
              yield return new LatLng(29.6755675517241, -95.5932105172414);
              yield return new LatLng(29.6824600606061, -95.6057404848485);
              yield return new LatLng(29.7542107142857, -95.3829745306122);
              yield return new LatLng(29.7328670125864, -95.5458306290917);
              yield return new LatLng(29.73168523361, -95.6364232322608);
              yield return new LatLng(29.7385736611389, -95.638779907628);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.4803517, -95.0572715);
              yield return new LatLng(29.957193, -95.4185865);
              yield return new LatLng(29.8389258115942, -95.4756425144927);
              yield return new LatLng(29.8321339891089, -95.4899770118835);
              yield return new LatLng(29.837180899182, -95.411814969904);
              yield return new LatLng(29.843615621567, -95.3805616500902);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.948814, -95.546726);
              yield return new LatLng(29.8462380234928, -95.3689792819734);
              yield return new LatLng(29.8557520816327, -95.4297009387755);
              yield return new LatLng(29.858643, -95.4497385);
              yield return new LatLng(29.9595747229091, -95.4320487974526);
              yield return new LatLng(29.7800353877551, -95.345887);
              yield return new LatLng(29.7784199591837, -95.3169954489796);
              yield return new LatLng(29.7813317959184, -95.3359093877551);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.7968873809524, -95.3291304761905);
              yield return new LatLng(29.8139335804637, -95.3169237832408);
              yield return new LatLng(29.839848026391, -95.3428993783418);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.9665355932531, -95.2955838009585);
              yield return new LatLng(29.9499005, -95.4122458);
              yield return new LatLng(29.8580115883501, -95.3150758327805);
              yield return new LatLng(29.8490444563836, -95.3035331530787);
              yield return new LatLng(29.8365153020134, -95.3051849731544);
              yield return new LatLng(29.8365153020134, -95.3051849731544);
              yield return new LatLng(29.7536749795918, -95.2828043673469);
              yield return new LatLng(29.7737072222222, -95.2163234222222);
              yield return new LatLng(29.770006, -95.350268);
          }
     }

     public class April_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
