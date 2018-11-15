using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class July_2017_AutoTheft
     {
         public static IEnumerable<July_2017_AutoTheft_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new July_2017_AutoTheft_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7358458582553, -95.4666498658);
              yield return new LatLng(29.7343449130747, -95.3755905897861);
              yield return new LatLng(29.7488553265306, -95.3725191632653);
              yield return new LatLng(29.7435257346939, -95.3780000816326);
              yield return new LatLng(29.7380613877551, -95.366342755102);
              yield return new LatLng(29.7333902653061, -95.3677461020408);
              yield return new LatLng(29.7243048, -95.3486344);
              yield return new LatLng(29.7180874932419, -95.3730679123509);
              yield return new LatLng(29.7245494897959, -95.3792102040816);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.6746751632653, -95.2624533673469);
              yield return new LatLng(29.6916445030528, -95.2367785245875);
              yield return new LatLng(29.6349088571429, -95.2487861428571);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6520589183673, -95.264156755102);
              yield return new LatLng(29.6232206470588, -95.2180190588235);
              yield return new LatLng(29.6269583409091, -95.2159773863636);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.7319417959184, -95.3246496938775);
              yield return new LatLng(29.68691, -95.3185795454546);
              yield return new LatLng(29.6370784210526, -95.3620803157895);
              yield return new LatLng(29.6576269439236, -95.3069578429318);
              yield return new LatLng(29.6756091910146, -95.2863126520881);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.634259, -95.286418);
              yield return new LatLng(29.7573604693878, -95.3683246734694);
              yield return new LatLng(29.6622605918367, -95.3571569591837);
              yield return new LatLng(29.667988, -95.373827);
              yield return new LatLng(29.6702426, -95.3556421);
              yield return new LatLng(29.7758115714286, -95.2227946666667);
              yield return new LatLng(29.6606446641429, -95.3671246184374);
              yield return new LatLng(29.6634603673469, -95.3500013673469);
              yield return new LatLng(29.6626108795514, -95.3306567107321);
              yield return new LatLng(29.6810320937242, -95.3517205127332);
              yield return new LatLng(29.6833766832915, -95.3426975356295);
              yield return new LatLng(29.6801797567568, -95.3432884324324);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6790584166667, -95.4820706666667);
              yield return new LatLng(29.6790584166667, -95.4820706666667);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.6828104594595, -95.3925970135135);
              yield return new LatLng(29.6971745, -95.3731438333333);
              yield return new LatLng(29.6819336122449, -95.3998455510204);
              yield return new LatLng(29.7274341818182, -95.4813061515152);
              yield return new LatLng(29.617424, -95.40382);
              yield return new LatLng(29.6156675918367, -95.4697796938776);
              yield return new LatLng(29.6118106969697, -95.4843855454545);
              yield return new LatLng(29.6237567755102, -95.4789053061225);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.9420257272727, -95.3889880909091);
              yield return new LatLng(29.7163082380952, -95.4879661904762);
              yield return new LatLng(29.8917950766412, -95.4327260757849);
              yield return new LatLng(29.7175419305556, -95.4888747361111);
              yield return new LatLng(29.6725197373737, -95.5403538080808);
              yield return new LatLng(29.6450726867691, -95.5469283012307);
              yield return new LatLng(29.7968604693878, -95.2355770306122);
              yield return new LatLng(29.8382707, -95.7520297);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7719515510204, -95.3104019795918);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7328882, -95.491904);
              yield return new LatLng(29.6923406472026, -95.4170401995359);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7232076174497, -95.5250261946309);
              yield return new LatLng(29.7098125, -95.5170895);
              yield return new LatLng(29.7266311631206, -95.5250666595745);
              yield return new LatLng(29.7114463673469, -95.5179400408163);
              yield return new LatLng(29.6974773658537, -95.5219123902439);
              yield return new LatLng(29.7176375454545, -95.537347);
              yield return new LatLng(29.6479577272727, -95.5116389393939);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6982321553597, -95.5729823408308);
              yield return new LatLng(29.6877034285714, -95.575391);
              yield return new LatLng(29.667201, -95.5638987586207);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7582555306122, -95.362487122449);
              yield return new LatLng(29.7567659591837, -95.3644359591837);
              yield return new LatLng(29.7402116326531, -95.3853560408163);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7457377959184, -95.3516614081633);
              yield return new LatLng(29.71558, -95.548201);
              yield return new LatLng(29.7381336428571, -95.5313872142857);
              yield return new LatLng(29.7208343, -95.2119019);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.665428, -95.519019);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7854586415142, -95.6624858096279);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7841590909091, -95.6000317272727);
              yield return new LatLng(29.782336, -95.6298665);
              yield return new LatLng(29.7232157692308, -95.6121290769231);
              yield return new LatLng(29.716209, -95.6149275454545);
              yield return new LatLng(29.7457422, -95.6247263);
              yield return new LatLng(29.8449187919463, -95.3167462416107);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.8400175, -95.3773445);
              yield return new LatLng(29.8026877878788, -95.366747949495);
              yield return new LatLng(29.9993196, -95.6289973);
              yield return new LatLng(29.794112877551, -95.3546439591837);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.7653709387755, -95.374985244898);
              yield return new LatLng(29.7762430816327, -95.407896);
              yield return new LatLng(29.868371244898, -95.4328225102041);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.7783393265306, -95.4147265510204);
              yield return new LatLng(29.8076083870968, -95.3132695806452);
              yield return new LatLng(29.4850596, -95.0481542);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.840638580339, -95.5504606753156);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.6871336969697, -95.5430221212121);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.8383553469388, -95.3813865918367);
              yield return new LatLng(29.8580170606061, -95.343215);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.8153932244898, -95.5272462040816);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7986792385327, -95.5699358536958);
              yield return new LatLng(29.7863827196443, -95.4732089905947);
              yield return new LatLng(29.8051338571429, -95.4849743877551);
              yield return new LatLng(29.8264423636364, -95.5247934848485);
              yield return new LatLng(29.8209932034771, -95.514510250484);
              yield return new LatLng(29.8612859692, -95.5374147549915);
              yield return new LatLng(29.8573318484849, -95.5313286060606);
              yield return new LatLng(29.8463720204082, -95.3718984285714);
              yield return new LatLng(29.7419144657865, -95.4965609558634);
              yield return new LatLng(29.8409623, -95.4598133);
              yield return new LatLng(29.877748, -95.43755);
              yield return new LatLng(29.8770765102041, -95.4387863673469);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.767676205068, -95.2897043697599);
              yield return new LatLng(29.8787194820093, -95.3481872356093);
              yield return new LatLng(29.8518243786019, -95.3538156015304);
              yield return new LatLng(29.7656562040816, -95.3357339183674);
              yield return new LatLng(29.8513406291764, -95.4204776547374);
              yield return new LatLng(29.783583, -95.345975);
              yield return new LatLng(29.7765879795918, -95.3102467346939);
              yield return new LatLng(29.8180784545455, -95.3310080909091);
              yield return new LatLng(29.7833674693878, -95.3310934081633);
              yield return new LatLng(29.7823773673469, -95.3310814081633);
              yield return new LatLng(29.8059583673469, -95.3233080408163);
              yield return new LatLng(29.8074022392637, -95.3207627234906);
              yield return new LatLng(29.83711, -95.320771);
              yield return new LatLng(29.8496276521739, -95.3570514565217);
              yield return new LatLng(29.8423676904762, -95.349121547619);
              yield return new LatLng(29.8390471062026, -95.3527431424971);
              yield return new LatLng(29.8469203265306, -95.349000877551);
              yield return new LatLng(29.8544159387755, -95.3529788367347);
              yield return new LatLng(29.8375868163265, -95.3291461428571);
              yield return new LatLng(29.8375868163265, -95.3291461428571);
              yield return new LatLng(29.9413056578947, -95.3157684736842);
              yield return new LatLng(29.6803370136986, -95.3180860547945);
              yield return new LatLng(29.736593, -95.3559805714286);
              yield return new LatLng(29.8424145297334, -95.2814971621864);
              yield return new LatLng(29.8517499141338, -95.2676608560978);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.7665604643761, -95.2713646055255);
              yield return new LatLng(29.8650850172259, -95.288858367143);
              yield return new LatLng(29.7774249183673, -95.3041654489796);
              yield return new LatLng(29.852718122449, -95.2837285714286);
              yield return new LatLng(29.7514884285714, -95.2827745510204);
              yield return new LatLng(29.7807827575758, -95.3005430909091);
              yield return new LatLng(29.7872312804577, -95.1842132304969);
              yield return new LatLng(29.8032393691275, -95.3374924362416);
              yield return new LatLng(29.7688115, -95.2132302);
              yield return new LatLng(29.7737379795918, -95.2062206734694);
              yield return new LatLng(29.7674712352941, -95.2105218823529);
              yield return new LatLng(29.7721399791667, -95.2145984375);
          }
     }

     public class July_2017_AutoTheft_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
