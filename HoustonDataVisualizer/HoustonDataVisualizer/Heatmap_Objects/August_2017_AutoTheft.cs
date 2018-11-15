using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2017_AutoTheft
     {
         public static IEnumerable<August_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7251350124675, -95.3288496905872);
              yield return new LatLng(29.7414162981589, -95.3150587111105);
              yield return new LatLng(29.747039, -95.3354531632653);
              yield return new LatLng(29.7415135675676, -95.3500906756757);
              yield return new LatLng(29.7448923061224, -95.3776778571429);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7276557755102, -95.3652327346939);
              yield return new LatLng(29.724517877551, -95.3563275102041);
              yield return new LatLng(29.7197113333333, -95.3726137575757);
              yield return new LatLng(29.9784935, -95.1529555);
              yield return new LatLng(29.7022014186559, -95.3703776181183);
              yield return new LatLng(29.7061992244898, -95.3596976938775);
              yield return new LatLng(29.7166701020408, -95.3609819387755);
              yield return new LatLng(29.6763898788832, -95.3335234356999);
              yield return new LatLng(29.6546263636364, -95.4830865151515);
              yield return new LatLng(29.7025094693878, -95.3771860612245);
              yield return new LatLng(29.7113799660244, -95.3812929443364);
              yield return new LatLng(29.7206040956722, -95.4107991577328);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.722022321608, -95.5302816130653);
              yield return new LatLng(29.7354313265306, -95.2944452244898);
              yield return new LatLng(29.7341759795918, -95.290358244898);
              yield return new LatLng(29.7070385918367, -95.2955968979592);
              yield return new LatLng(29.7062762040816, -95.2955814897959);
              yield return new LatLng(29.7141943061224, -95.2692347755102);
              yield return new LatLng(29.7051266060606, -95.2826948787879);
              yield return new LatLng(29.8280281000231, -95.3509671751889);
              yield return new LatLng(29.6917841741678, -95.2467900878962);
              yield return new LatLng(29.6874919697442, -95.2428653725928);
              yield return new LatLng(29.6562624848485, -95.2506577878788);
              yield return new LatLng(29.6702100393013, -95.2585653973799);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6463065405405, -95.2278743243243);
              yield return new LatLng(29.6362163939394, -95.2326963939394);
              yield return new LatLng(29.6364423636364, -95.2246606363636);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6209803673469, -95.2544454489796);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6476974594595, -95.2365011081081);
              yield return new LatLng(29.626054420814, -95.341887021378);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6452038047729, -95.2340408829827);
              yield return new LatLng(29.589606, -95.230184);
              yield return new LatLng(29.680326, -95.310786375);
              yield return new LatLng(29.6130022538321, -95.2395696308266);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.703339, -95.2943786);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.4511444430426, -95.3298654089021);
              yield return new LatLng(29.7030866712329, -95.3035541917808);
              yield return new LatLng(29.6860370268456, -95.3111818053691);
              yield return new LatLng(29.6846214081633, -95.3059982244898);
              yield return new LatLng(29.6680390204082, -95.2431587346939);
              yield return new LatLng(29.7589382, -95.3676974);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.6947067586207, -95.2997747586207);
              yield return new LatLng(29.6638516841014, -95.2795763966032);
              yield return new LatLng(29.668043010101, -95.3123679494949);
              yield return new LatLng(29.6842492040816, -95.2972239183674);
              yield return new LatLng(29.7099931414141, -95.2816207575758);
              yield return new LatLng(29.6144218686869, -95.2722534343434);
              yield return new LatLng(29.6495524161074, -95.3735542684564);
              yield return new LatLng(29.6376123953488, -95.3249486976744);
              yield return new LatLng(29.68592586828, -95.3251317553554);
              yield return new LatLng(29.6687870909091, -95.3452918585859);
              yield return new LatLng(29.6493449653395, -95.3348737826109);
              yield return new LatLng(29.7610149, -95.3488909);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6857211136364, -95.4335125227273);
              yield return new LatLng(29.6819336122449, -95.3998455510204);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.6744678977273, -95.4145503522727);
              yield return new LatLng(29.6582164056799, -95.5072113191829);
              yield return new LatLng(29.620360450586, -95.4788165797729);
              yield return new LatLng(29.6195256915498, -95.4788781404795);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7229639640895, -95.4845697726588);
              yield return new LatLng(29.7043790133148, -95.496063037073);
              yield return new LatLng(29.7453432233951, -95.345511834436);
              yield return new LatLng(29.684479637397, -95.5311754814442);
              yield return new LatLng(29.7274341818182, -95.4813061515152);
              yield return new LatLng(29.6855740555556, -95.5258947592593);
              yield return new LatLng(29.6749964924623, -95.5389765829146);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.668476, -95.50441151);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7816678970588, -95.4680571029412);
              yield return new LatLng(29.7387761136364, -95.4823915681818);
              yield return new LatLng(29.7274341818182, -95.4813061515152);
              yield return new LatLng(29.7274652040816, -95.5216586938775);
              yield return new LatLng(29.5790229, -95.1035979);
              yield return new LatLng(29.7280816767533, -95.5154248914525);
              yield return new LatLng(29.6890277380276, -95.287769278435);
              yield return new LatLng(29.8598872614035, -95.4516846236639);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7058631428571, -95.6097677142857);
              yield return new LatLng(29.788717, -95.552065);
              yield return new LatLng(29.6748051428571, -95.5566506122449);
              yield return new LatLng(29.7499233877551, -95.3614805306122);
              yield return new LatLng(29.7800134081633, -95.348187);
              yield return new LatLng(29.7568484693878, -95.3674576734694);
              yield return new LatLng(29.7556405335767, -95.4853178377723);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.7346925510204, -95.5374812040816);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.7432879474049, -95.3931702380644);
              yield return new LatLng(29.73479, -95.576054);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7761783, -95.5991007);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.8522801836735, -95.3151279591837);
              yield return new LatLng(29.8012219183673, -95.3563733469388);
              yield return new LatLng(29.7985572857143, -95.3756048979592);
              yield return new LatLng(29.8096097096774, -95.375213516129);
              yield return new LatLng(29.7724832653061, -95.4023384489796);
              yield return new LatLng(29.7581051020408, -95.36773);
              yield return new LatLng(29.6122673485201, -95.3522765305522);
              yield return new LatLng(29.822311, -95.4667637142857);
              yield return new LatLng(29.8098278918919, -95.4879655135135);
              yield return new LatLng(29.835495877551, -95.4898069183673);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.8308652857143, -95.4093252244898);
              yield return new LatLng(29.7513175306122, -95.3692710612245);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.6267096, -95.2484497);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7907507990814, -95.5422952076978);
              yield return new LatLng(29.8080338036776, -95.4766095676832);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8092989393939, -95.472276969697);
              yield return new LatLng(29.8074873378741, -95.5066375956085);
              yield return new LatLng(29.7884798458959, -95.5218711836751);
              yield return new LatLng(29.8352183061224, -95.5298063061225);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7924054161285, -95.5140127430645);
              yield return new LatLng(29.8473892575454, -95.3773687167239);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8709740909091, -95.368927969697);
              yield return new LatLng(29.8463460845017, -95.3950966540811);
              yield return new LatLng(29.8528046, -95.4056834);
              yield return new LatLng(29.8614693316583, -95.473508758794);
              yield return new LatLng(29.8506800606061, -95.4876472424242);
              yield return new LatLng(29.8857125844491, -95.4741389295365);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.938146, -95.4037715);
              yield return new LatLng(29.9420257272727, -95.3889880909091);
              yield return new LatLng(29.8330738787879, -95.3473738484848);
              yield return new LatLng(29.8316002653061, -95.4570496122449);
              yield return new LatLng(29.7965693078233, -95.3130881391471);
              yield return new LatLng(29.7895520315789, -95.3333523052631);
              yield return new LatLng(29.78939584375, -95.3352028125);
              yield return new LatLng(29.8502716120471, -95.3440534448517);
              yield return new LatLng(29.8481785714286, -95.3467538163265);
              yield return new LatLng(29.8417472200009, -95.3427369850956);
              yield return new LatLng(29.8651689986338, -95.3240353866377);
              yield return new LatLng(29.8544018571429, -95.3283241632653);
              yield return new LatLng(29.9413056578947, -95.3157684736842);
              yield return new LatLng(29.8245177429536, -95.3207064262251);
              yield return new LatLng(29.8649354949495, -95.3150765858586);
              yield return new LatLng(29.8459804, -95.2782982);
              yield return new LatLng(29.8347733877551, -95.2856431020408);
              yield return new LatLng(29.8547023870968, -95.2730910967742);
              yield return new LatLng(29.8538983080264, -95.2676972040355);
              yield return new LatLng(29.8557689090909, -95.288688);
              yield return new LatLng(29.8797026074766, -95.309978364486);
              yield return new LatLng(29.765996, -95.2779920612245);
              yield return new LatLng(29.7581341515152, -95.2763194848485);
              yield return new LatLng(29.7828611515152, -95.2995868181818);
              yield return new LatLng(29.784351030303, -95.3037977474747);
              yield return new LatLng(29.7843297755102, -95.2941178367347);
              yield return new LatLng(29.7571213877551, -95.2828689387755);
              yield return new LatLng(29.7642099411765, -95.2041306470588);
              yield return new LatLng(29.7623101111111, -95.2159379259259);
              yield return new LatLng(29.8249322929293, -95.3407561616162);
          }
     }

     public class August_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
