using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class November_2017_AutoTheft
     {
         public static IEnumerable<November_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new November_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.743467755102, -95.3278873469388);
              yield return new LatLng(29.7433831020408, -95.3190971428571);
              yield return new LatLng(29.738005755102, -95.3321694285714);
              yield return new LatLng(29.7370225, -95.3218771666667);
              yield return new LatLng(29.7478095510204, -95.3715315918367);
              yield return new LatLng(29.7429395714286, -95.378462755102);
              yield return new LatLng(29.6008531879195, -95.3999511610738);
              yield return new LatLng(29.7035046, -95.8302728);
              yield return new LatLng(29.7260572323232, -95.3723814141414);
              yield return new LatLng(29.6814395792853, -95.4190562093379);
              yield return new LatLng(29.7074816, -95.4022553);
              yield return new LatLng(29.7263279851165, -95.4116388074922);
              yield return new LatLng(29.7086104255812, -95.4157381404842);
              yield return new LatLng(29.716788, -95.2888560408163);
              yield return new LatLng(29.6983923469388, -95.2792571632653);
              yield return new LatLng(29.7462827373737, -95.4407625353535);
              yield return new LatLng(29.686013, -95.244434);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.7546285, -95.3987092);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7499769387755, -95.3652375918367);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6011274243625, -95.1133951726257);
              yield return new LatLng(29.6922865881817, -95.2954468730946);
              yield return new LatLng(29.6939002272727, -95.3058785227273);
              yield return new LatLng(29.7776608888889, -95.3305609191919);
              yield return new LatLng(29.6622504285714, -95.2864227142857);
              yield return new LatLng(29.6807995102041, -95.2814581428571);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7263497346939, -95.518130755102);
              yield return new LatLng(29.6439573265306, -95.3048798367347);
              yield return new LatLng(29.6439573265306, -95.3048798367347);
              yield return new LatLng(29.6944084081633, -95.3471575510204);
              yield return new LatLng(29.6634609387755, -95.3644475918367);
              yield return new LatLng(29.6713013636364, -95.3760738888889);
              yield return new LatLng(29.6488747575194, -95.3356732779594);
              yield return new LatLng(29.7352277142857, -95.3516091428571);
              yield return new LatLng(29.6699685137533, -95.3603879358459);
              yield return new LatLng(29.6669465, -95.364369);
              yield return new LatLng(29.6374750306699, -95.3765905780835);
              yield return new LatLng(29.675715, -95.365896);
              yield return new LatLng(29.6747273773662, -95.3208773533866);
              yield return new LatLng(29.6825654487988, -95.3422277712632);
              yield return new LatLng(29.6988202, -95.3868178);
              yield return new LatLng(29.6068968176614, -95.4357717763954);
              yield return new LatLng(29.6376664646465, -95.457926);
              yield return new LatLng(29.6216633333333, -95.4327083333333);
              yield return new LatLng(29.5823093061225, -95.4633231632653);
              yield return new LatLng(29.599374, -95.475123);
              yield return new LatLng(29.7603296938776, -95.3518406530612);
              yield return new LatLng(29.7156996, -95.5087845);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7073465978228, -95.4773326769183);
              yield return new LatLng(29.7133852541773, -95.4929901752125);
              yield return new LatLng(29.6896861292191, -95.5210234691429);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6798902222222, -95.5282488333333);
              yield return new LatLng(29.7163082380952, -95.4879661904762);
              yield return new LatLng(29.6721646734694, -95.3556961428571);
              yield return new LatLng(29.6535655454545, -95.538006030303);
              yield return new LatLng(29.6646318163265, -95.2226539795918);
              yield return new LatLng(29.6687234444444, -95.5042262525253);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.7805992040816, -95.4779164285714);
              yield return new LatLng(29.7816678970588, -95.4680571029412);
              yield return new LatLng(29.7533068231215, -95.4708912189245);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.755690119403, -95.4975524029851);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7642099411765, -95.2041306470588);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7215935234899, -95.5250228389262);
              yield return new LatLng(29.7131282, -95.6200806);
              yield return new LatLng(29.7143254725632, -95.5190380110774);
              yield return new LatLng(29.7177427, -95.5158072);
              yield return new LatLng(29.6856641521739, -95.53936);
              yield return new LatLng(29.7006942438443, -95.5416878005452);
              yield return new LatLng(29.8378059838932, -95.643807002301);
              yield return new LatLng(29.794336, -95.3851379);
              yield return new LatLng(29.6713341314175, -95.3942767969156);
              yield return new LatLng(29.6741079444444, -95.5700514444444);
              yield return new LatLng(29.6748051428571, -95.5566506122449);
              yield return new LatLng(29.6790584166667, -95.4820706666667);
              yield return new LatLng(29.7797677142857, -95.4169954693878);
              yield return new LatLng(29.7528803877551, -95.3726258979592);
              yield return new LatLng(29.7487190816327, -95.3900448163265);
              yield return new LatLng(29.7458828132925, -95.3871554182845);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.746603672678, -95.3901114230498);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7299320039905, -95.5758689081626);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.734824564072, -95.6506046357249);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.6381302155622, -95.3369753616075);
              yield return new LatLng(29.80760825, -95.37401575);
              yield return new LatLng(29.8527259, -95.5243864);
              yield return new LatLng(29.7954895918367, -95.4420654489796);
              yield return new LatLng(29.8577493110463, -95.4064703028969);
              yield return new LatLng(29.7968604693878, -95.2355770306122);
              yield return new LatLng(29.783367, -95.445288);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.8214014, -95.48766392);
              yield return new LatLng(29.8027115151515, -95.3649016969697);
              yield return new LatLng(29.7274944915254, -95.5072977950693);
              yield return new LatLng(29.8398895, -95.402726);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8156139759391, -95.3690954072696);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.808609841837, -95.4829877502103);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.847443, -95.506253);
              yield return new LatLng(29.935295, -95.4617409739531);
              yield return new LatLng(29.8565719798658, -95.363433590604);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.873726, -95.427103);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.747012, -95.307224);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.95519, -95.352171);
              yield return new LatLng(29.857871, -95.3455363333333);
              yield return new LatLng(29.8544907763785, -95.3439813484051);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.784174244898, -95.3286574693877);
              yield return new LatLng(29.8659310267819, -95.2996848752511);
              yield return new LatLng(29.8502471728095, -95.3100222926468);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8260753469388, -95.2966174897959);
              yield return new LatLng(29.811104, -95.282573);
              yield return new LatLng(29.8547023870968, -95.2730910967742);
              yield return new LatLng(29.8555368130874, -95.2692070875896);
              yield return new LatLng(29.7575467631579, -95.2563076842105);
              yield return new LatLng(29.8132184438861, -95.240464);
              yield return new LatLng(29.7852764692168, -95.2622064683434);
              yield return new LatLng(29.6283932, -95.079053);
          }
     }

     public class November_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
