using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2017_Robbery
     {
         public static IEnumerable<September_2017_Robbery_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2017_Robbery_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7394999795918, -95.3773333265306);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.736593, -95.3559805714286);
              yield return new LatLng(29.6370784210526, -95.3620803157895);
              yield return new LatLng(29.8109880408163, -95.5099064693877);
              yield return new LatLng(29.711500030635, -95.3993462895355);
              yield return new LatLng(29.6903483613191, -95.3805342326081);
              yield return new LatLng(29.7182845, -95.2796581);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.796212, -95.519171);
              yield return new LatLng(29.6786733357929, -95.3646774361947);
              yield return new LatLng(29.623515, -95.2377083);
              yield return new LatLng(29.651515, -95.249058755102);
              yield return new LatLng(29.642145269568, -95.2415463606227);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7120796315789, -95.3154526315789);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.656479, -95.298874);
              yield return new LatLng(29.6745395090346, -95.2858233983958);
              yield return new LatLng(29.6591344522613, -95.3135398844221);
              yield return new LatLng(29.6682760769231, -95.2703162564103);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6724393636364, -95.3752411212121);
              yield return new LatLng(29.684131969697, -95.3376834040404);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6834457, -95.3656674);
              yield return new LatLng(29.6622311818182, -95.3610577575758);
              yield return new LatLng(29.6541664646465, -95.3655147373737);
              yield return new LatLng(29.6574162, -95.3973153);
              yield return new LatLng(29.6916588139535, -95.3687409651163);
              yield return new LatLng(29.6591517360798, -95.3654188787805);
              yield return new LatLng(29.68483, -95.3734613265306);
              yield return new LatLng(29.6602321632653, -95.3553014081633);
              yield return new LatLng(29.68483, -95.3734613265306);
              yield return new LatLng(29.6578019411765, -95.3379675294118);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6415986060606, -95.3660074242424);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.8266723095238, -95.3859450238095);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6371751111111, -95.4298019722222);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6660706554887, -95.279443867993);
              yield return new LatLng(29.62806, -95.360877);
              yield return new LatLng(29.6285474823535, -95.3623615436427);
              yield return new LatLng(29.6270878367347, -95.5086300816327);
              yield return new LatLng(29.6301394285714, -95.4668568571429);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.5876519717687, -95.4676744366375);
              yield return new LatLng(29.9322538464207, -95.5454612056597);
              yield return new LatLng(29.6533549544256, -95.4994460616137);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7303149090909, -95.5167858181818);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.6478914897959, -95.2254279591837);
              yield return new LatLng(29.7178322641346, -95.5258367419073);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6891331052632, -95.5745592105263);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6744949916243, -95.5764590769555);
              yield return new LatLng(29.6933681927504, -95.5766965075615);
              yield return new LatLng(29.7523407489211, -95.3604139519699);
              yield return new LatLng(29.746243122449, -95.3732955714286);
              yield return new LatLng(29.7592542857143, -95.3611800408163);
              yield return new LatLng(29.7549141, -95.5837881);
              yield return new LatLng(29.744249195122, -95.3638210243902);
              yield return new LatLng(29.732061298855, -95.3700679396713);
              yield return new LatLng(29.7937534303951, -95.7403200578036);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.6447099473684, -95.3620627894737);
              yield return new LatLng(29.7357165918367, -95.6347353673469);
              yield return new LatLng(29.776024, -95.293102);
              yield return new LatLng(29.8735299090909, -95.3826009393939);
              yield return new LatLng(29.7445817092762, -95.3588814408921);
              yield return new LatLng(29.8034402, -95.3520308);
              yield return new LatLng(29.7932225, -95.3741705);
              yield return new LatLng(29.6255181, -95.2162955);
              yield return new LatLng(29.7762516684669, -95.3814410791936);
              yield return new LatLng(29.791209, -95.3250084736842);
              yield return new LatLng(29.8286277575758, -95.3925822727273);
              yield return new LatLng(29.7417838979592, -95.3788653673469);
              yield return new LatLng(29.8435112134407, -95.3410650379762);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7894086557325, -95.2185629223153);
              yield return new LatLng(29.8098218237182, -95.5024767653921);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8528709183673, -95.5155002040816);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8626607414043, -95.506110510134);
              yield return new LatLng(29.692046, -95.364589);
              yield return new LatLng(29.8550042328767, -95.3917963219178);
              yield return new LatLng(29.859112261745, -95.3706556375839);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8557520816327, -95.4297009387755);
              yield return new LatLng(29.9168403770492, -95.4055372622951);
              yield return new LatLng(29.91946696875, -95.40647971875);
              yield return new LatLng(29.8822478571429, -95.3725589404762);
              yield return new LatLng(29.938146, -95.4037715);
              yield return new LatLng(29.95035, -95.4063125);
              yield return new LatLng(29.8377049149331, -95.3643927667683);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.953144, -95.387201);
              yield return new LatLng(29.7817559387755, -95.3653925714286);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.7710794081633, -95.3497383877551);
              yield return new LatLng(29.7905138979592, -95.3180937346939);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7847494081633, -95.3378774285714);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.839848026391, -95.3428993783418);
              yield return new LatLng(29.8378231646163, -95.3470972688369);
              yield return new LatLng(29.8346038637274, -95.3408903322798);
              yield return new LatLng(29.8388681720438, -95.3428809131663);
              yield return new LatLng(29.8341803877551, -95.3231843469388);
              yield return new LatLng(29.8534582889872, -95.2837460518491);
              yield return new LatLng(29.8203026403685, -95.3182721550531);
              yield return new LatLng(29.8445567580615, -95.2926937667433);
              yield return new LatLng(29.7626756734694, -95.2714162857143);
              yield return new LatLng(29.7765879795918, -95.3102467346939);
              yield return new LatLng(29.7756314317218, -95.2260519287821);
              yield return new LatLng(29.7916678, -95.2691466);
              yield return new LatLng(29.6283932, -95.079053);
              yield return new LatLng(29.7114463673469, -95.5179400408163);
          }
     }

     public class September_2017_Robbery_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
