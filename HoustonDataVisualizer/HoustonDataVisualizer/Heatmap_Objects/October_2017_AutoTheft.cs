using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2017_AutoTheft
     {
         public static IEnumerable<October_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7461988445571, -95.3280573212348);
              yield return new LatLng(29.7478929591837, -95.3415907755102);
              yield return new LatLng(29.743467755102, -95.3278873469388);
              yield return new LatLng(29.7332379949749, -95.3165275376884);
              yield return new LatLng(29.729131, -95.350674);
              yield return new LatLng(29.7320606530612, -95.3617697142857);
              yield return new LatLng(29.73125415625, -95.3533458125);
              yield return new LatLng(29.7555825918367, -95.3671954693878);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7174026666667, -95.2965565);
              yield return new LatLng(29.7196085121951, -95.31734);
              yield return new LatLng(29.706499755102, -95.2891675306122);
              yield return new LatLng(29.717304100223, -95.2917721837321);
              yield return new LatLng(29.7163509795918, -95.2781851836735);
              yield return new LatLng(29.7142236938776, -95.2781044693878);
              yield return new LatLng(29.68589209375, -95.23436790625);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.5879507424568, -95.2234936825326);
              yield return new LatLng(29.7205841111111, -95.3181725925926);
              yield return new LatLng(29.5885948889801, -95.2022543570863);
              yield return new LatLng(29.606512426779, -95.2281037972712);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.650220304104, -95.211783556583);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6502806363636, -95.2341675757576);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.387034, -95.0658482753036);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.7068631673268, -95.3063684489232);
              yield return new LatLng(29.606369618612, -95.2237638375124);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6423395, -95.2931415);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6769200769231, -95.3527505384615);
              yield return new LatLng(29.7674712352941, -95.2105218823529);
              yield return new LatLng(29.6939250943392, -95.3369002473396);
              yield return new LatLng(29.6786733357929, -95.3646774361947);
              yield return new LatLng(29.6720414545455, -95.3691622727273);
              yield return new LatLng(29.6834457, -95.3656674);
              yield return new LatLng(29.6694784, -95.3525890909091);
              yield return new LatLng(29.6517268453252, -95.3670417893236);
              yield return new LatLng(29.6746072244898, -95.4497395918367);
              yield return new LatLng(29.0776822040816, -98.0772448571429);
              yield return new LatLng(29.68337465, -95.4293347261367);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.60381, -95.452288397025);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6122791111111, -95.3558686666667);
              yield return new LatLng(29.8678703333333, -95.3946182121212);
              yield return new LatLng(29.719444, -95.370594);
              yield return new LatLng(29.7593176734694, -95.3520116122449);
              yield return new LatLng(29.7033018787879, -95.3663922121212);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.70923328574, -95.5111435959926);
              yield return new LatLng(29.7247031836735, -95.4060136938776);
              yield return new LatLng(29.7196455565167, -95.2961854331002);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7287507634291, -95.4776645381295);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.87862345, -95.4664839537588);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.6953950808081, -95.5516297676768);
              yield return new LatLng(29.7280413673469, -95.518170877551);
              yield return new LatLng(29.7272044081633, -95.5181580408163);
              yield return new LatLng(29.709130775433, -95.5109674926786);
              yield return new LatLng(29.7015580036095, -95.5838071186492);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.8860490227273, -95.6597979886364);
              yield return new LatLng(29.6675099538276, -95.5872639303925);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.9568563, -95.2646183);
              yield return new LatLng(29.7524277346939, -95.3928973877551);
              yield return new LatLng(29.7462506122449, -95.3911609795918);
              yield return new LatLng(29.8316264, -95.7543887);
              yield return new LatLng(29.749894, -95.3742256938775);
              yield return new LatLng(29.7161077058824, -95.4721112941176);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7164506357301, -95.5496666960183);
              yield return new LatLng(29.7090398008955, -95.5553019988087);
              yield return new LatLng(29.732695, -95.5752564897959);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7692075, -95.546784337133);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7736826341464, -95.6222969024391);
              yield return new LatLng(29.9374919, -95.6496229);
              yield return new LatLng(29.780342, -95.612715);
              yield return new LatLng(29.8074317065117, -95.5699719808315);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.7769243469388, -95.3725195306123);
              yield return new LatLng(29.7475330211268, -95.3760967816901);
              yield return new LatLng(29.7779970408163, -95.3498019183673);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7706415, -95.4158425);
              yield return new LatLng(29.7771509591837, -95.3653108367347);
              yield return new LatLng(29.8083985503356, -95.3798012348993);
              yield return new LatLng(29.6246811824736, -95.4327416405476);
              yield return new LatLng(29.7886281632653, -95.3311613877551);
              yield return new LatLng(29.806662, -95.464791);
              yield return new LatLng(29.817079764908, -95.4750750462904);
              yield return new LatLng(29.8266901592955, -95.4309077445006);
              yield return new LatLng(29.8383553469388, -95.3813865918367);
              yield return new LatLng(29.8569679591837, -95.3547032040816);
              yield return new LatLng(29.8335636174497, -95.3693489060403);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.877212, -95.355218);
              yield return new LatLng(29.833964969697, -95.3462092323232);
              yield return new LatLng(29.789868668665, -95.5587988678373);
              yield return new LatLng(29.6786338484848, -95.5068061212121);
              yield return new LatLng(29.8023387142857, -95.5243395510204);
              yield return new LatLng(29.789868668665, -95.5587988678373);
              yield return new LatLng(29.79272316, -95.54022348);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7993883618476, -95.4634311450288);
              yield return new LatLng(29.7483157346939, -95.3767435918367);
              yield return new LatLng(29.847443, -95.506253);
              yield return new LatLng(29.8573318484849, -95.5313286060606);
              yield return new LatLng(29.7208343, -95.2119019);
              yield return new LatLng(29.9496847596783, -95.546969696259);
              yield return new LatLng(29.8536633533685, -95.4017011709818);
              yield return new LatLng(29.849807452381, -95.3846406428571);
              yield return new LatLng(29.836273030303, -95.2790993939394);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.9329496, -95.5075622);
              yield return new LatLng(29.9512075503356, -95.4215994899329);
              yield return new LatLng(29.7891534375, -95.3170208125);
              yield return new LatLng(29.8198044096237, -95.4913230068879);
              yield return new LatLng(29.8169360606061, -95.3310001515151);
              yield return new LatLng(29.8032393691275, -95.3374924362416);
              yield return new LatLng(29.7850240757576, -95.2286523636364);
              yield return new LatLng(29.8399904081633, -95.3371029183673);
              yield return new LatLng(29.8238114026846, -95.3391470805369);
              yield return new LatLng(29.8308027346939, -95.3318891836735);
              yield return new LatLng(29.8787976940615, -95.3603422391343);
              yield return new LatLng(29.8370948145692, -95.3435283113577);
              yield return new LatLng(29.9956803, -95.2974405);
              yield return new LatLng(29.8282806958626, -95.303876939708);
              yield return new LatLng(29.8314997010078, -95.2736351778573);
              yield return new LatLng(29.820022, -95.292341);
              yield return new LatLng(29.8367677692308, -95.2916573461539);
              yield return new LatLng(29.841569, -95.246706);
              yield return new LatLng(29.7721399791667, -95.2145984375);
              yield return new LatLng(29.8551955663916, -95.2808363424313);
              yield return new LatLng(29.8551955663916, -95.2808363424313);
              yield return new LatLng(29.8741251818182, -95.2626808888889);
              yield return new LatLng(29.8741251818182, -95.2626808888889);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.7640162, -95.2679387674853);
              yield return new LatLng(29.764491, -95.273595);
              yield return new LatLng(29.8098788819198, -95.2636448560903);
              yield return new LatLng(29.7758687520698, -95.22836109391);
              yield return new LatLng(29.7938942121212, -95.2528162424242);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7069207575758, -95.5686741111111);
              yield return new LatLng(29.7809066538462, -95.1841863076923);
              yield return new LatLng(29.775889, -95.2191189795918);
              yield return new LatLng(29.747012, -95.307224);
              yield return new LatLng(29.8501330408163, -95.5547483469388);
          }
     }

     public class October_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
