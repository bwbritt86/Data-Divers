using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2016_Rape
     {
         public static IEnumerable<November_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.7354315714286, -95.2910522653061);
              yield return new LatLng(29.72873025, -95.28876925);
              yield return new LatLng(29.6744544, -95.2647624);
              yield return new LatLng(29.698133025641, -95.2777068461538);
              yield return new LatLng(29.7087141049064, -95.323262169532);
              yield return new LatLng(29.6780286966421, -95.3343517809311);
              yield return new LatLng(29.6123056431738, -95.3609252331474);
              yield return new LatLng(29.6078280476597, -95.3401443388647);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.688497338658, -95.4341842930018);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.6820825862069, -95.4176731724138);
              yield return new LatLng(29.6820825862069, -95.4176731724138);
              yield return new LatLng(29.61072396, -95.40502352);
              yield return new LatLng(29.6231695454545, -95.4372167070707);
              yield return new LatLng(29.70940875, -95.5021972857143);
              yield return new LatLng(29.7151402828283, -95.4888438181818);
              yield return new LatLng(29.71632154, -95.5003057);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6696287927198, -95.5329880194957);
              yield return new LatLng(29.6490793529412, -95.5031055294118);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.726285, -95.4835747083333);
              yield return new LatLng(29.7280926923077, -95.4956195);
              yield return new LatLng(29.6773787236322, -95.557182292604);
              yield return new LatLng(29.687630860417, -95.5656628293238);
              yield return new LatLng(29.6982138918919, -95.5521415405405);
              yield return new LatLng(29.707567, -95.596332);
              yield return new LatLng(29.6763305526316, -95.5969334736842);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7603109183673, -95.362928122449);
              yield return new LatLng(29.7599006666667, -95.3566398181818);
              yield return new LatLng(29.754901969697, -95.3920699393939);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7347590204082, -95.420411);
              yield return new LatLng(29.725472, -95.48764);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7358494899329, -95.4414421677852);
              yield return new LatLng(29.7177317184365, -95.5487337360415);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.6148226, -95.1709873);
              yield return new LatLng(29.828640461613, -95.4930349914339);
              yield return new LatLng(29.8307000909091, -95.4173412727273);
              yield return new LatLng(29.8248573653705, -95.3866981914112);
              yield return new LatLng(29.8160123408638, -95.5107118817304);
              yield return new LatLng(29.8118058, -95.5673448434227);
              yield return new LatLng(29.8124608571429, -95.4995220204082);
              yield return new LatLng(29.8540444827586, -95.3845168344828);
              yield return new LatLng(29.8549891643836, -95.394369609589);
              yield return new LatLng(29.872811, -95.4231093333333);
              yield return new LatLng(29.870927809549, -95.4136713086492);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.9482828616512, -95.3893683847891);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.7841079545455, -95.3135868409091);
              yield return new LatLng(29.7893967750053, -95.3339810560471);
              yield return new LatLng(29.607654, -95.172573);
              yield return new LatLng(29.78569425, -95.33436475);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.8286705306122, -95.3378089387755);
              yield return new LatLng(29.8619575, -95.34303);
              yield return new LatLng(29.8256866938776, -95.2826236326531);
              yield return new LatLng(29.7644404913891, -95.2081494698368);
              yield return new LatLng(29.742163, -95.419937);
              yield return new LatLng(29.770006, -95.350268);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.7860346275211, -95.7896414556677);
              yield return new LatLng(29.6908442, -95.4969338);
          }
     }

     public class November_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
