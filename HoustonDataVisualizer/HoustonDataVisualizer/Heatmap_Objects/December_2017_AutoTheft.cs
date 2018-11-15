using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class December_2017_AutoTheft
     {
         public static IEnumerable<December_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new December_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7461960204082, -95.3342226326531);
              yield return new LatLng(29.7291212653061, -95.3256452857143);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7469888163265, -95.3683574081633);
              yield return new LatLng(29.726184, -95.354819);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7035046, -95.8302728);
              yield return new LatLng(29.7101470408163, -95.2935088979592);
              yield return new LatLng(29.7203278314607, -95.3690326516854);
              yield return new LatLng(29.724840030303, -95.3719262121212);
              yield return new LatLng(29.7189453877551, -95.3199644897959);
              yield return new LatLng(29.7196455565167, -95.2961854331002);
              yield return new LatLng(29.7029258571429, -95.278993);
              yield return new LatLng(29.7072337346939, -95.2892);
              yield return new LatLng(29.7895843, -95.1044499);
              yield return new LatLng(29.6874163061224, -95.2376420816327);
              yield return new LatLng(29.6917841741678, -95.2467900878962);
              yield return new LatLng(29.6503041175632, -95.2256736415218);
              yield return new LatLng(29.6417095918367, -95.2376437346939);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.6242045014093, -95.255725425692);
              yield return new LatLng(29.6562624848485, -95.2506577878788);
              yield return new LatLng(29.628996010101, -95.2096993333333);
              yield return new LatLng(29.6445294285714, -95.2312478979592);
              yield return new LatLng(29.6362163939394, -95.2326963939394);
              yield return new LatLng(29.742434, -95.4826295);
              yield return new LatLng(29.7537642244898, -95.294108877551);
              yield return new LatLng(29.6231701, -95.2172689);
              yield return new LatLng(29.61509175, -95.23194275);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6852734693878, -95.2997234081633);
              yield return new LatLng(29.690793, -95.313971);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.8409623, -95.4598133);
              yield return new LatLng(29.751764, -95.3111919534942);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6946692437164, -95.3366104564096);
              yield return new LatLng(29.6933082757156, -95.3342845383837);
              yield return new LatLng(29.8583392651382, -95.2953235196961);
              yield return new LatLng(29.6966612972973, -95.3446132972973);
              yield return new LatLng(29.7760597391304, -95.331611326087);
              yield return new LatLng(29.7152945106383, -95.3551019787234);
              yield return new LatLng(29.6621743673469, -95.3652173673469);
              yield return new LatLng(29.7499233877551, -95.3614805306122);
              yield return new LatLng(29.6621573469388, -95.3670235510204);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6621573469388, -95.3670235510204);
              yield return new LatLng(29.6496710204082, -95.4832098979592);
              yield return new LatLng(29.6819336122449, -95.3998455510204);
              yield return new LatLng(29.6903595, -95.3707509);
              yield return new LatLng(29.6903595, -95.3707509);
              yield return new LatLng(29.6817793718593, -95.5108087839196);
              yield return new LatLng(29.7099746122449, -95.4859701428571);
              yield return new LatLng(29.6798902222222, -95.5282488333333);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7143254725632, -95.5190380110774);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7143254725632, -95.5190380110774);
              yield return new LatLng(29.6261956923077, -95.503518);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.625537125, -95.45833825);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7552639387755, -95.3656179183673);
              yield return new LatLng(29.7398416666667, -95.3849831212121);
              yield return new LatLng(29.7487590408163, -95.3789072857143);
              yield return new LatLng(29.7569980612245, -95.3755557142857);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7403783673469, -95.4463907142857);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7918407045455, -95.5766829090909);
              yield return new LatLng(29.7841590909091, -95.6000317272727);
              yield return new LatLng(29.742196, -95.470733);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7617763265306, -95.3579227346939);
              yield return new LatLng(29.843676, -95.330574);
              yield return new LatLng(29.788085, -95.357819);
              yield return new LatLng(29.8131730904523, -95.3660782713568);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7682594693878, -95.3921184897959);
              yield return new LatLng(29.7703490816327, -95.4120010204082);
              yield return new LatLng(29.7376057755102, -95.3308608571429);
              yield return new LatLng(29.7635812084268, -95.4032550723507);
              yield return new LatLng(29.8052081428571, -95.4181703061224);
              yield return new LatLng(29.6255181, -95.2162955);
              yield return new LatLng(29.6033817327522, -95.221684955126);
              yield return new LatLng(29.7128138496667, -95.3475347047428);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.789868668665, -95.5587988678373);
              yield return new LatLng(29.8132695464168, -95.5508854535832);
              yield return new LatLng(29.6911540557612, -95.5905996469179);
              yield return new LatLng(29.8524726326531, -95.5205063265306);
              yield return new LatLng(29.8164987118644, -95.5263270677966);
              yield return new LatLng(29.8053313268078, -95.5716735208285);
              yield return new LatLng(29.8573801155779, -95.5294352261307);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8609218195639, -95.5497421813586);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.7207987209302, -95.2888529069767);
              yield return new LatLng(29.8357326001564, -95.397966857464);
              yield return new LatLng(29.940021772183, -95.4143655427045);
              yield return new LatLng(29.8868003463861, -95.3480895556285);
              yield return new LatLng(29.607654, -95.172573);
              yield return new LatLng(29.7889044897959, -95.3368656734694);
              yield return new LatLng(29.7892922542268, -95.3456859815441);
              yield return new LatLng(29.8148478944724, -95.3478150904523);
              yield return new LatLng(29.8223516862698, -95.3426383252857);
              yield return new LatLng(29.8238016711409, -95.3400551342282);
              yield return new LatLng(29.772936122449, -95.4126379387755);
              yield return new LatLng(29.8320900255689, -95.3395801953662);
              yield return new LatLng(29.83711, -95.320771);
              yield return new LatLng(29.882164, -95.363855);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.948167, -95.3039320638298);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8342642857143, -95.318138122449);
              yield return new LatLng(29.8606417411513, -95.3073297981679);
              yield return new LatLng(29.8183565454545, -95.2799755454545);
              yield return new LatLng(29.6280201020408, -95.4887678571429);
              yield return new LatLng(29.8555078797819, -95.2676983645332);
              yield return new LatLng(29.8664894225204, -95.290617991691);
              yield return new LatLng(29.8346653469388, -95.3325278571429);
              yield return new LatLng(29.8831395918367, -95.285788);
              yield return new LatLng(29.812805, -95.207784);
              yield return new LatLng(29.812805, -95.207784);
              yield return new LatLng(29.7390125918367, -95.254518877551);
              yield return new LatLng(29.7752207283099, -95.2725327546019);
              yield return new LatLng(29.812805, -95.207784);
              yield return new LatLng(29.7522769387755, -95.2816617959184);
              yield return new LatLng(29.7858983214971, -95.279883361849);
              yield return new LatLng(29.7983789466587, -95.2543473874135);
              yield return new LatLng(29.8409623, -95.4598133);
              yield return new LatLng(29.772155, -95.19863);
              yield return new LatLng(29.8314997010078, -95.2736351778573);
              yield return new LatLng(29.77218, -95.28391);
              yield return new LatLng(29.7836816779661, -95.1855000169491);
          }
     }

     public class December_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
