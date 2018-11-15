using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class October_2016_Rape
     {
         public static IEnumerable<October_2016_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new October_2016_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7573885454545, -95.3454361136364);
              yield return new LatLng(29.748967244898, -95.3478358979592);
              yield return new LatLng(29.7101527979798, -95.4173646464646);
              yield return new LatLng(29.7145024419846, -95.2967330112853);
              yield return new LatLng(29.7092851212121, -95.2986796666667);
              yield return new LatLng(29.6809827755102, -95.2575608571429);
              yield return new LatLng(29.6354136666667, -95.243653);
              yield return new LatLng(29.6311210386213, -95.2443265493498);
              yield return new LatLng(29.6672755714286, -95.2734766530612);
              yield return new LatLng(29.724058, -95.323657);
              yield return new LatLng(29.6887908163265, -95.3537368163265);
              yield return new LatLng(29.6598917272727, -95.3610092424242);
              yield return new LatLng(29.6657225959596, -95.3261327676768);
              yield return new LatLng(29.6570062857143, -95.3374864081633);
              yield return new LatLng(29.6625347346939, -95.3347785510204);
              yield return new LatLng(29.626451023891, -95.3657103299667);
              yield return new LatLng(29.7067424, -95.3940886);
              yield return new LatLng(29.606104, -95.449994);
              yield return new LatLng(29.717746, -95.5199709);
              yield return new LatLng(29.7200735, -95.490992);
              yield return new LatLng(29.7296298015552, -95.4640650201527);
              yield return new LatLng(29.725947, -95.495117);
              yield return new LatLng(29.7361066112446, -95.4951988245413);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.692069122449, -95.5517520816327);
              yield return new LatLng(29.7491880408163, -95.362068244898);
              yield return new LatLng(29.711528892301, -95.393814784801);
              yield return new LatLng(29.7095989393939, -95.5453973636364);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7095989393939, -95.5453973636364);
              yield return new LatLng(29.7215871, -95.5627328);
              yield return new LatLng(29.7145460533232, -95.5473556485833);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7338424487372, -95.5637593180638);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.7447932020202, -95.5762127272727);
              yield return new LatLng(29.853837, -95.5402232);
              yield return new LatLng(29.7841669795918, -95.6065738979592);
              yield return new LatLng(29.8035378136759, -95.3691052795008);
              yield return new LatLng(29.7736935510204, -95.3695450204082);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.953026, -95.418244);
              yield return new LatLng(29.8241086938775, -95.4027448571429);
              yield return new LatLng(29.8376779347826, -95.3666047173913);
              yield return new LatLng(29.8617474, -95.5442895);
              yield return new LatLng(29.8104123061225, -95.5545369795918);
              yield return new LatLng(29.8198585779508, -95.5307355086236);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7845772, -95.6424152);
              yield return new LatLng(29.8294505, -95.505946);
              yield return new LatLng(29.795835, -95.514004);
              yield return new LatLng(29.8460116475842, -95.369982438287);
              yield return new LatLng(29.8793271183346, -95.5014682639364);
              yield return new LatLng(29.949261, -95.388183);
              yield return new LatLng(29.9545776767471, -95.4231410911162);
              yield return new LatLng(29.9595747229091, -95.4320487974526);
              yield return new LatLng(29.812608, -95.351688);
              yield return new LatLng(29.9477908888889, -95.3006962929293);
              yield return new LatLng(29.8400516442953, -95.3109041342282);
              yield return new LatLng(29.8470750519481, -95.2624207922078);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8572029117647, -95.2723206764706);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
              yield return new LatLng(29.775889, -95.2191189795918);
              yield return new LatLng(29.7758349166667, -95.2214492916667);
          }
     }

     public class October_2016_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
