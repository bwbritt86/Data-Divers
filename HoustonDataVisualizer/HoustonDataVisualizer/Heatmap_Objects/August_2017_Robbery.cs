using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class August_2017_Robbery
     {
         public static IEnumerable<August_2017_Robbery_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new August_2017_Robbery_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7603817642685, -95.3473993706196);
              yield return new LatLng(29.7456093877551, -95.3434041428571);
              yield return new LatLng(29.7414461632653, -95.3765609591837);
              yield return new LatLng(29.7339355, -95.3844615);
              yield return new LatLng(29.7380297755102, -95.3754478367347);
              yield return new LatLng(29.737052125, -95.379277375);
              yield return new LatLng(29.798190562061, -95.5240907582418);
              yield return new LatLng(29.7320606530612, -95.3617697142857);
              yield return new LatLng(29.8487225, -95.2570121111111);
              yield return new LatLng(29.7936089, -95.5214399);
              yield return new LatLng(29.6878690606061, -95.3671535454545);
              yield return new LatLng(29.7369551388889, -95.3533366944444);
              yield return new LatLng(29.6581039818494, -95.5238098604321);
              yield return new LatLng(29.7035046, -95.8302728);
              yield return new LatLng(29.7595104489796, -95.3597120204082);
              yield return new LatLng(29.7281782857143, -95.3768136734694);
              yield return new LatLng(29.6766816756757, -95.3444246216216);
              yield return new LatLng(29.6987606901449, -95.4032341484183);
              yield return new LatLng(29.7163373061224, -95.2795267755102);
              yield return new LatLng(29.706525, -95.2876466666667);
              yield return new LatLng(29.713719, -95.280794);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6446278108108, -95.2257046351351);
              yield return new LatLng(29.6247271643851, -95.2439637653133);
              yield return new LatLng(29.642145269568, -95.2415463606227);
              yield return new LatLng(29.5487374100719, -95.0982678633093);
              yield return new LatLng(29.7061995, -95.308924);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6896948979592, -95.301835877551);
              yield return new LatLng(29.6852887886399, -95.3063597318395);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6502316, -95.4046619);
              yield return new LatLng(29.6701223, -95.2595343);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6571494949495, -95.3011188787879);
              yield return new LatLng(29.674962, -95.2699238);
              yield return new LatLng(29.6675169387755, -95.2630821428571);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6531129959122, -95.3124418501013);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6640143928618, -95.3129797359531);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6910895117127, -95.3410199619874);
              yield return new LatLng(29.6784107777778, -95.3558421111111);
              yield return new LatLng(29.6750420036213, -95.3703373500948);
              yield return new LatLng(29.6680828367347, -95.3651716734694);
              yield return new LatLng(29.6694784, -95.3525890909091);
              yield return new LatLng(29.6784107777778, -95.3558421111111);
              yield return new LatLng(29.6616278291716, -95.351473924759);
              yield return new LatLng(29.6731489795918, -95.3609632244898);
              yield return new LatLng(29.68483, -95.3734613265306);
              yield return new LatLng(29.6377567272727, -95.235211);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6766582501775, -95.3391463835095);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6940000607085, -95.5350305721951);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7157092515634, -95.5702647309268);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7982256030151, -95.3188485929648);
              yield return new LatLng(29.6216384081633, -95.4000908163265);
              yield return new LatLng(29.612341757785, -95.371099949237);
              yield return new LatLng(29.6121163030303, -95.313731969697);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6042559381688, -95.4759133182399);
              yield return new LatLng(29.6445363894019, -95.5443342988108);
              yield return new LatLng(29.6362621034188, -95.4235728896785);
              yield return new LatLng(29.5891661486486, -95.4652113918919);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.583181, -95.4623755);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7133852541773, -95.4929901752125);
              yield return new LatLng(29.70940875, -95.5021972857143);
              yield return new LatLng(29.680082356883, -95.5272901847001);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.9540780028839, -95.546591187082);
              yield return new LatLng(29.6654119387755, -95.5203619387755);
              yield return new LatLng(29.6353463030303, -95.358485030303);
              yield return new LatLng(29.7816678970588, -95.4680571029412);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.70923328574, -95.5111435959926);
              yield return new LatLng(29.7805992040816, -95.4779164285714);
              yield return new LatLng(29.8351504897959, -95.3750666326531);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.736943122449, -95.5140935918367);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.736943122449, -95.5140935918367);
              yield return new LatLng(29.7130063103448, -95.5111565862069);
              yield return new LatLng(29.7361066112446, -95.4951988245413);
              yield return new LatLng(29.7258857583342, -95.5204836443799);
              yield return new LatLng(29.6748763265306, -95.5555579387755);
              yield return new LatLng(29.687630860417, -95.5656628293238);
              yield return new LatLng(29.6977325162862, -95.6144962137379);
              yield return new LatLng(29.6763305526316, -95.5969334736842);
              yield return new LatLng(29.6746762778025, -95.5800129567929);
              yield return new LatLng(29.9181481632653, -95.3998293469388);
              yield return new LatLng(29.7459747755102, -95.3501988571429);
              yield return new LatLng(29.7349230204082, -95.3868055306122);
              yield return new LatLng(29.7369865959596, -95.4320428181818);
              yield return new LatLng(29.7361166, -95.4246415);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.726211755102, -95.6523824285714);
              yield return new LatLng(29.7447932020202, -95.5762127272727);
              yield return new LatLng(29.7274341818182, -95.4813061515152);
              yield return new LatLng(29.7392560804769, -95.5760997711227);
              yield return new LatLng(29.7255314, -95.7075702);
              yield return new LatLng(29.7725265454545, -95.5747280909091);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.79539, -95.21756);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.665674, -95.5128685);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8500148367347, -95.4889734081633);
              yield return new LatLng(29.8110120784678, -95.3287458704983);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.843606405817, -95.388264881347);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8322785972453, -95.3760542918727);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8671937, -95.5377551);
              yield return new LatLng(29.7884798458959, -95.5218711836751);
              yield return new LatLng(29.8018584584743, -95.5287791965575);
              yield return new LatLng(29.7907228919314, -95.5622292744778);
              yield return new LatLng(29.785324605, -95.467904);
              yield return new LatLng(29.8077027294411, -95.4851967992959);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.854484510101, -95.5401167525253);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8559505863656, -95.532212523585);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8733529795918, -95.3989443469388);
              yield return new LatLng(29.7607508367347, -95.3562094897959);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8550703020105, -95.4522823244098);
              yield return new LatLng(29.8457143682549, -95.3730964639952);
              yield return new LatLng(29.8995868181818, -95.4967850909091);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8744492820513, -95.4447747051282);
              yield return new LatLng(29.9328935714286, -95.3954665102041);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.91946696875, -95.40647971875);
              yield return new LatLng(29.9590155770382, -95.4235065229033);
              yield return new LatLng(29.950750755102, -95.3924097346939);
              yield return new LatLng(29.94829, -95.429797);
              yield return new LatLng(29.9473950606061, -95.4165926969697);
              yield return new LatLng(29.785594, -95.313477);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.7881281428571, -95.3252985510204);
              yield return new LatLng(29.7814872653061, -95.3318828979592);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.839848026391, -95.3428993783418);
              yield return new LatLng(29.8469203265306, -95.349000877551);
              yield return new LatLng(29.8488248297479, -95.3427845473333);
              yield return new LatLng(29.8426815625, -95.3429393958333);
              yield return new LatLng(29.8778949290866, -95.2937828076901);
              yield return new LatLng(29.8553302689653, -95.3312720093287);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8322874081633, -95.3244298367347);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8654767959184, -95.3050593265306);
              yield return new LatLng(29.8222537919463, -95.3294720134228);
              yield return new LatLng(29.8314402828283, -95.2990486666667);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.841745651137, -95.2536268353975);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.99693, -95.587699);
              yield return new LatLng(29.7514750117554, -95.2841426513229);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.6387268055556, -95.4225715555556);
              yield return new LatLng(29.7681398571429, -95.2132294285714);
          }
     }

     public class August_2017_Robbery_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
