using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class June_2017_Burglary
     {
         public static IEnumerable<June_2017_Burglary_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new June_2017_Burglary_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7484595102041, -95.3387891428571);
              yield return new LatLng(29.7451006734694, -95.3597402040816);
              yield return new LatLng(29.7449975306122, -95.3514955306122);
              yield return new LatLng(29.7420066734694, -95.3659979183673);
              yield return new LatLng(29.742485, -95.35374);
              yield return new LatLng(29.7380613877551, -95.366342755102);
              yield return new LatLng(29.7287752828283, -95.3677054747475);
              yield return new LatLng(29.7309523265306, -95.3676885714286);
              yield return new LatLng(29.7314430469799, -95.3706316711409);
              yield return new LatLng(29.6500989, -95.3778987);
              yield return new LatLng(29.7253968979592, -95.3544286938776);
              yield return new LatLng(29.729059125, -95.3697128522727);
              yield return new LatLng(29.742485, -95.35374);
              yield return new LatLng(29.7272247345793, -95.3496696165857);
              yield return new LatLng(29.7271184949495, -95.3664794949495);
              yield return new LatLng(29.7296879387755, -95.3631155306122);
              yield return new LatLng(29.7156792352941, -95.3563826470588);
              yield return new LatLng(29.7018694189632, -95.3731829365338);
              yield return new LatLng(29.7194471313131, -95.3675727979798);
              yield return new LatLng(29.7239905486204, -95.3689535867699);
              yield return new LatLng(29.713059, -95.369181);
              yield return new LatLng(29.7047360544471, -95.3669144659543);
              yield return new LatLng(29.7319213636364, -95.3755086969697);
              yield return new LatLng(29.7066872, -95.399023);
              yield return new LatLng(29.710062, -95.380508);
              yield return new LatLng(29.7024397777778, -95.3946868888889);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.8314308, -95.5026231333333);
              yield return new LatLng(29.714984122449, -95.4157675102041);
              yield return new LatLng(29.7165850612245, -95.4157916938776);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7182845, -95.2796581);
              yield return new LatLng(29.7190422476997, -95.3117646618077);
              yield return new LatLng(29.7212708930005, -95.2915814134707);
              yield return new LatLng(29.7266263195938, -95.2986901179156);
              yield return new LatLng(29.7418598, -95.3225592);
              yield return new LatLng(29.7675817264161, -95.2941455190912);
              yield return new LatLng(29.7202475478054, -95.301818719328);
              yield return new LatLng(29.717304100223, -95.2917721837321);
              yield return new LatLng(29.7219249141923, -95.3078609667696);
              yield return new LatLng(29.7030908809524, -95.281140452381);
              yield return new LatLng(29.7122798571429, -95.2611835306122);
              yield return new LatLng(29.7122798571429, -95.2611835306122);
              yield return new LatLng(29.7097760408163, -95.2882873265306);
              yield return new LatLng(29.723349, -95.2797457959184);
              yield return new LatLng(29.7255975102041, -95.2784677959184);
              yield return new LatLng(29.6502316, -95.4046619);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6882961428571, -95.2774424693878);
              yield return new LatLng(29.6866672088656, -95.2773919641227);
              yield return new LatLng(29.686013, -95.244434);
              yield return new LatLng(29.7055671111111, -95.2436566464646);
              yield return new LatLng(29.6897934615385, -95.2357523846154);
              yield return new LatLng(29.6702100393013, -95.2585653973799);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.6604217574548, -95.2722794861273);
              yield return new LatLng(29.6218581447368, -95.2468697631579);
              yield return new LatLng(29.6373421481217, -95.2449441352823);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.6452038047729, -95.2340408829827);
              yield return new LatLng(29.6236340526316, -95.2478770263158);
              yield return new LatLng(29.6444861632653, -95.2452819795918);
              yield return new LatLng(29.5952269753086, -95.2256842716049);
              yield return new LatLng(29.6110588, -95.2421748);
              yield return new LatLng(29.5932055252525, -95.2176243636364);
              yield return new LatLng(29.5972455102041, -95.1851461020408);
              yield return new LatLng(29.6866541, -95.2567664);
              yield return new LatLng(29.5699775918367, -95.1498295918367);
              yield return new LatLng(29.7175785, -95.3204215);
              yield return new LatLng(29.6946507769747, -95.2913373586306);
              yield return new LatLng(29.6922409259259, -95.3180879259259);
              yield return new LatLng(29.7043626071429, -95.3060708214286);
              yield return new LatLng(29.7140626122449, -95.3175034897959);
              yield return new LatLng(29.7323219, -95.3427822);
              yield return new LatLng(29.7042713872221, -95.3094662839115);
              yield return new LatLng(29.6984276022255, -95.3087687044637);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7173966747857, -95.3199929775165);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.658387, -95.27222);
              yield return new LatLng(29.6696132, -95.2613148);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.6610989, -95.2888579);
              yield return new LatLng(29.639011244898, -95.2658171632653);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.7004598, -95.3446259833333);
              yield return new LatLng(29.6862514162857, -95.3496833803079);
              yield return new LatLng(29.6992525714286, -95.3581812040816);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.6954340408163, -95.3703650408163);
              yield return new LatLng(29.703804411187, -95.3450547588008);
              yield return new LatLng(29.7018378472222, -95.3490594444444);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.6858828383838, -95.3628660808081);
              yield return new LatLng(29.6825177159496, -95.3725253456453);
              yield return new LatLng(29.70627, -95.3735);
              yield return new LatLng(29.6318054657606, -95.4236609893494);
              yield return new LatLng(29.6825177159496, -95.3725253456453);
              yield return new LatLng(29.6622704624776, -95.3503722593857);
              yield return new LatLng(29.6564575, -95.355375);
              yield return new LatLng(29.732016626045, -95.398164670526);
              yield return new LatLng(29.653594, -95.352813);
              yield return new LatLng(29.667988, -95.373827);
              yield return new LatLng(29.646222, -95.3792035454545);
              yield return new LatLng(29.651732, -95.3656409795918);
              yield return new LatLng(29.6821800366297, -95.3699932817132);
              yield return new LatLng(29.6536141012036, -95.3515741634501);
              yield return new LatLng(29.655725979798, -95.3745118383838);
              yield return new LatLng(29.670365, -95.355654);
              yield return new LatLng(29.6700154296356, -95.3580492482017);
              yield return new LatLng(29.652734, -95.352984);
              yield return new LatLng(29.6493449653395, -95.3348737826109);
              yield return new LatLng(29.6649473877551, -95.3269333673469);
              yield return new LatLng(29.6730393, -95.4212877);
              yield return new LatLng(29.679367, -95.322258);
              yield return new LatLng(29.6382993862806, -95.3550403057744);
              yield return new LatLng(29.770793, -95.328129);
              yield return new LatLng(29.6341401428571, -95.3576200408163);
              yield return new LatLng(29.702756, -95.348271);
              yield return new LatLng(29.6376221, -95.32638196);
              yield return new LatLng(29.6312567932539, -95.3446572481406);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6880633576519, -95.4780223695667);
              yield return new LatLng(29.6399149801816, -95.4914686964655);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.611452, -95.496184);
              yield return new LatLng(29.6721225469098, -95.4381848153393);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.7052196326531, -95.4136400816326);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.6801895102041, -95.4388176326531);
              yield return new LatLng(29.7469888163265, -95.3683574081633);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6657225959596, -95.3261327676768);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.6820825862069, -95.4176731724138);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.753442, -95.366406);
              yield return new LatLng(29.62806, -95.360877);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.6122515854219, -95.3482083376241);
              yield return new LatLng(29.6134068, -95.4454089);
              yield return new LatLng(29.6978051428571, -95.3587423265306);
              yield return new LatLng(29.931653, -95.4300092);
              yield return new LatLng(29.6229455985351, -95.4951968628117);
              yield return new LatLng(29.6397593939394, -95.457976);
              yield return new LatLng(29.7126937591895, -95.3533794542303);
              yield return new LatLng(29.6026955441208, -95.5037424199973);
              yield return new LatLng(29.58824436, -95.463996);
              yield return new LatLng(29.6724684411581, -95.5773314418661);
              yield return new LatLng(29.7146804358974, -95.4704093589744);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7193825652174, -95.4888976521739);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7162611020408, -95.4921939387755);
              yield return new LatLng(29.7051147272727, -95.4782792121212);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7164442346939, -95.4754324591837);
              yield return new LatLng(29.7193825652174, -95.4888976521739);
              yield return new LatLng(29.7224968846154, -95.4807776923077);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.670979, -95.505553);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.6687234444444, -95.5042262525253);
              yield return new LatLng(29.6591975714286, -95.4980113736264);
              yield return new LatLng(29.9540780028839, -95.546591187082);
              yield return new LatLng(29.7612433265306, -95.4645268571429);
              yield return new LatLng(29.743971959596, -95.4669190606061);
              yield return new LatLng(29.7376292857143, -95.4666810612245);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7459391836735, -95.4847406326531);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7287304242424, -95.4813175151515);
              yield return new LatLng(29.7328357857233, -95.4959019983648);
              yield return new LatLng(29.7262135557527, -95.4884144539289);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7253601428571, -95.5010022857143);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7151457, -95.4975269);
              yield return new LatLng(29.7166998, -95.5578608);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7244523731343, -95.5349207761194);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7063262340488, -95.5220324226094);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8637920697469, -95.5423905729574);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7947604192679, -95.3287936720748);
              yield return new LatLng(29.6823845, -95.5744802727273);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.68664509375, -95.5590162604167);
              yield return new LatLng(29.6823845, -95.5744802727273);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7074625, -95.5515795);
              yield return new LatLng(29.6953981836735, -95.5750575714286);
              yield return new LatLng(29.703431, -95.614995);
              yield return new LatLng(29.7034852857143, -95.5990405714286);
              yield return new LatLng(29.7043179351933, -95.6147347610929);
              yield return new LatLng(29.7043179351933, -95.6147347610929);
              yield return new LatLng(29.6882625520056, -95.6070511532767);
              yield return new LatLng(29.703431, -95.614995);
              yield return new LatLng(29.6745942083662, -95.5785471378117);
              yield return new LatLng(29.6632698163265, -95.6186399183674);
              yield return new LatLng(29.6724684411581, -95.5773314418661);
              yield return new LatLng(29.6745942083662, -95.5785471378117);
              yield return new LatLng(29.7116650805369, -95.5157990402684);
              yield return new LatLng(29.6748051428571, -95.5566506122449);
              yield return new LatLng(29.6523106122449, -95.5724808163265);
              yield return new LatLng(29.7528160612245, -95.368091122449);
              yield return new LatLng(29.654198, -95.208645);
              yield return new LatLng(29.7566964897959, -95.3599047142857);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.8019884, -95.7691653);
              yield return new LatLng(29.752716, -95.3920298888889);
              yield return new LatLng(29.758179196536, -95.3829547732481);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7704622, -95.4137459);
              yield return new LatLng(29.7521732857143, -95.3769582244898);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7404931020408, -95.4186617142857);
              yield return new LatLng(29.7357367142857, -95.376253);
              yield return new LatLng(29.7346482359551, -95.4186096292135);
              yield return new LatLng(29.7382243, -95.3803352);
              yield return new LatLng(29.7353466122449, -95.4384295918367);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7147702775273, -95.4111359747848);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.856484, -95.545263);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.610755030303, -95.4358361818182);
              yield return new LatLng(29.856484, -95.545263);
              yield return new LatLng(29.71558, -95.548201);
              yield return new LatLng(29.8553604, -95.4953712678983);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7338739617692, -95.5759853814895);
              yield return new LatLng(29.74032015, -95.5763157166667);
              yield return new LatLng(29.7526511554621, -95.5908407851978);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.773809680876, -95.6363116454299);
              yield return new LatLng(29.782336, -95.6298665);
              yield return new LatLng(29.776190244898, -95.6390021428571);
              yield return new LatLng(29.7727107368998, -95.6377148499276);
              yield return new LatLng(29.7698892352941, -95.5939562941176);
              yield return new LatLng(29.7286452830721, -95.6195149536285);
              yield return new LatLng(29.7165005405405, -95.6150841621622);
              yield return new LatLng(29.7286452830721, -95.6195149536285);
              yield return new LatLng(29.7573389795918, -95.6365235306122);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.9419086, -95.2496622);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7843718282828, -95.3624417272727);
              yield return new LatLng(29.9569443, -95.3602904);
              yield return new LatLng(29.7490135, -95.3713055);
              yield return new LatLng(29.7866946938775, -95.3625121836735);
              yield return new LatLng(29.7970548979592, -95.3661357755102);
              yield return new LatLng(29.8452082, -95.3774922);
              yield return new LatLng(29.7552681836735, -95.3648550408163);
              yield return new LatLng(29.478761, -95.0503024);
              yield return new LatLng(29.7990551, -95.3746802);
              yield return new LatLng(29.7599257, -95.3624897);
              yield return new LatLng(29.8135301, -95.3611359);
              yield return new LatLng(29.7918121190476, -95.3780112380952);
              yield return new LatLng(29.788951244898, -95.3831846122449);
              yield return new LatLng(29.478761, -95.0503024);
              yield return new LatLng(29.7806343265306, -95.3727445918367);
              yield return new LatLng(29.780714, -95.381846);
              yield return new LatLng(29.7703681836735, -95.4110442857143);
              yield return new LatLng(29.7613989980568, -95.3754698178285);
              yield return new LatLng(29.7718849455017, -95.3828800850187);
              yield return new LatLng(29.7705866908186, -95.3821550316598);
              yield return new LatLng(29.7729136666667, -95.4186101212121);
              yield return new LatLng(29.7720079, -95.5590776);
              yield return new LatLng(29.7723159183673, -95.4273207346939);
              yield return new LatLng(29.7682594693878, -95.3921184897959);
              yield return new LatLng(29.7433773557047, -95.3875813154362);
              yield return new LatLng(29.6246156, -95.2150761);
              yield return new LatLng(29.8067407931086, -95.4309376679071);
              yield return new LatLng(29.7706218787879, -95.3786496969697);
              yield return new LatLng(29.677502, -95.353798);
              yield return new LatLng(29.7736816326531, -95.3706487346939);
              yield return new LatLng(29.7888025370815, -95.4462152486958);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8075672323232, -95.4589691010101);
              yield return new LatLng(29.8170294770612, -95.4772801010643);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.9146762, -95.4049674);
              yield return new LatLng(29.8193248484849, -95.3747545454546);
              yield return new LatLng(29.8416924122662, -95.3613358578213);
              yield return new LatLng(29.838187755102, -95.3616590816327);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.8283766363636, -95.3985314772727);
              yield return new LatLng(29.8181674646465, -95.3572139393939);
              yield return new LatLng(29.8462666177252, -95.3675766811208);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.873534, -95.366384);
              yield return new LatLng(29.8270454897959, -95.3613876530612);
              yield return new LatLng(29.8231181515151, -95.3682016666667);
              yield return new LatLng(29.8462881955999, -95.3661959595598);
              yield return new LatLng(29.8253427142857, -95.3715113265306);
              yield return new LatLng(29.8289772058786, -95.3645985192788);
              yield return new LatLng(29.8005895499873, -95.5504219446946);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7670070538475, -95.5576182329338);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.81065414527, -95.5370566953177);
              yield return new LatLng(29.7841390506329, -95.5966115063291);
              yield return new LatLng(29.8459822040816, -95.2901555102041);
              yield return new LatLng(29.792731, -95.5780590414316);
              yield return new LatLng(29.8137345777778, -95.4814834666667);
              yield return new LatLng(29.8011326336671, -95.4704600897479);
              yield return new LatLng(29.8056635214527, -95.4829388695608);
              yield return new LatLng(29.817171, -95.556958);
              yield return new LatLng(29.8218944081633, -95.5221194285714);
              yield return new LatLng(29.8078107272727, -95.5245286363636);
              yield return new LatLng(29.8218944081633, -95.5221194285714);
              yield return new LatLng(29.808031166369, -95.5024803135074);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8074873378741, -95.5066375956085);
              yield return new LatLng(29.8110242272727, -95.4998665454546);
              yield return new LatLng(29.8329732, -95.4908989);
              yield return new LatLng(29.8077027294411, -95.4851967992959);
              yield return new LatLng(29.808031166369, -95.5024803135074);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.8611644081633, -95.5179896326531);
              yield return new LatLng(29.8412559850727, -95.5044782316377);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.7852933, -95.370023);
              yield return new LatLng(29.7475920816327, -95.372230122449);
              yield return new LatLng(29.8525219901047, -95.5045599079696);
              yield return new LatLng(29.9689524, -95.5423929);
              yield return new LatLng(29.9496847596783, -95.546969696259);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.7805992040816, -95.4779164285714);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8463720204082, -95.3718984285714);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8558366875, -95.382625625);
              yield return new LatLng(29.8541237931034, -95.3845182137931);
              yield return new LatLng(29.8725104102564, -95.3850178974359);
              yield return new LatLng(29.8582242462312, -95.3704791356784);
              yield return new LatLng(29.8492088791946, -95.3700755100671);
              yield return new LatLng(29.8552620612245, -95.3720232653061);
              yield return new LatLng(29.77731, -95.537181);
              yield return new LatLng(29.8487425788195, -95.4015967229938);
              yield return new LatLng(29.8487425788195, -95.4015967229938);
              yield return new LatLng(29.8725104102564, -95.3850178974359);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.8003705348837, -95.3139906511628);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.922370101344, -95.4070732752013);
              yield return new LatLng(29.91946696875, -95.40647971875);
              yield return new LatLng(29.9499005, -95.4122458);
              yield return new LatLng(29.9710724766904, -95.4335248251753);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.95035, -95.4063125);
              yield return new LatLng(29.9495112097845, -95.4130029050834);
              yield return new LatLng(29.747684, -95.589111);
              yield return new LatLng(29.957373, -95.4232634897959);
              yield return new LatLng(29.9506993414634, -95.3976742439024);
              yield return new LatLng(29.950176, -95.4113291428571);
              yield return new LatLng(29.9485980408163, -95.4220784897959);
              yield return new LatLng(29.957373, -95.4232634897959);
              yield return new LatLng(29.7730552728268, -95.3185919237945);
              yield return new LatLng(29.5583047, -95.1373209);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7885994736842, -95.3359503157895);
              yield return new LatLng(29.79218, -95.3260862894737);
              yield return new LatLng(29.7918806969697, -95.3368621515151);
              yield return new LatLng(29.7936631588003, -95.325431119341);
              yield return new LatLng(29.7991851084337, -95.3206357228916);
              yield return new LatLng(29.7897875046706, -95.3116979602002);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.8032393691275, -95.3374924362416);
              yield return new LatLng(29.7834311111111, -95.3286446767677);
              yield return new LatLng(29.8075831791045, -95.3157364328358);
              yield return new LatLng(29.8257172189262, -95.3426854904308);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.851735244898, -95.3421008979592);
              yield return new LatLng(29.8476734950029, -95.3430468129269);
              yield return new LatLng(29.8388681720438, -95.3428809131663);
              yield return new LatLng(29.860247437979, -95.3342847878935);
              yield return new LatLng(29.8673124141414, -95.3616582525253);
              yield return new LatLng(29.8650564897959, -95.3349854081633);
              yield return new LatLng(29.9454387635916, -95.3097963662684);
              yield return new LatLng(29.8466878255034, -95.3059573355705);
              yield return new LatLng(29.8466878255034, -95.3059573355705);
              yield return new LatLng(29.8506791758794, -95.2989240744092);
              yield return new LatLng(29.8224707958503, -95.3230594522528);
              yield return new LatLng(29.8367424646465, -95.2991171010101);
              yield return new LatLng(29.8851615, -95.3008834);
              yield return new LatLng(29.813101, -95.286862);
              yield return new LatLng(29.8248674, -95.2845541);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.760895, -95.294516);
              yield return new LatLng(29.8379984848485, -95.2833697575758);
              yield return new LatLng(29.854973941334, -95.2662207688778);
              yield return new LatLng(29.858944530009, -95.2781933374482);
              yield return new LatLng(29.8543448666667, -95.2577378666667);
              yield return new LatLng(29.8588333772644, -95.2560389606162);
              yield return new LatLng(29.8686486236582, -95.3091190571872);
              yield return new LatLng(29.8797323222222, -95.3053598222222);
              yield return new LatLng(29.7409931399015, -95.2592071111489);
              yield return new LatLng(29.7792441632653, -95.3041599591837);
              yield return new LatLng(29.7640806273051, -95.3011256014521);
              yield return new LatLng(29.7577143670115, -95.3160404772194);
              yield return new LatLng(29.7828825306122, -95.3093630408163);
              yield return new LatLng(29.7825544476471, -95.2007817252982);
              yield return new LatLng(29.7681398571429, -95.2132294285714);
              yield return new LatLng(29.77218, -95.28391);
              yield return new LatLng(29.7835808, -95.1869253);
              yield return new LatLng(29.7894086557325, -95.2185629223153);
              yield return new LatLng(29.781324, -95.218698);
              yield return new LatLng(29.7880443184936, -95.189193511584);
              yield return new LatLng(29.7467714, -95.4188282);
              yield return new LatLng(29.7255016969697, -95.3638298787879);
          }
     }

     public class June_2017_Burglary_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}