using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class January_2017_Rape
     {
         public static IEnumerable<January_2017_Rape_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new January_2017_Rape_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7407925454545, -95.314962030303);
              yield return new LatLng(29.7329125510204, -95.3297560204082);
              yield return new LatLng(29.7398688571429, -95.3268446530612);
              yield return new LatLng(29.7229186363636, -95.3229599393939);
              yield return new LatLng(29.7308741317824, -95.3696723882895);
              yield return new LatLng(29.7067508054591, -95.3566842296938);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.6395925357143, -95.50304725);
              yield return new LatLng(29.7280926923077, -95.4956195);
              yield return new LatLng(29.7291373, -95.6375669);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.6934985, -95.545542125);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.67502588, -95.5850326);
              yield return new LatLng(29.6671541462843, -95.5934734820541);
              yield return new LatLng(29.6724684411581, -95.5773314418661);
              yield return new LatLng(29.6558708163265, -95.5780712244898);
              yield return new LatLng(29.748254, -95.367857122449);
              yield return new LatLng(29.752453, -95.370427);
              yield return new LatLng(29.7305870438773, -95.5943704231359);
              yield return new LatLng(29.7351347, -95.6496473);
              yield return new LatLng(29.8609169, -95.5449342);
              yield return new LatLng(29.7381136531329, -95.6136149506046);
              yield return new LatLng(29.758898, -95.6252269387755);
              yield return new LatLng(29.9523053254493, -95.4181850813623);
              yield return new LatLng(29.831063755102, -95.3929654081633);
              yield return new LatLng(29.812594, -95.556586);
              yield return new LatLng(29.798190562061, -95.5240907582418);
              yield return new LatLng(29.8480125, -95.3490638);
              yield return new LatLng(29.8591635151515, -95.3847932020202);
              yield return new LatLng(29.8563800681818, -95.3847415909091);
              yield return new LatLng(29.8641481, -95.4734586);
              yield return new LatLng(29.9419908726522, -95.4397403261603);
              yield return new LatLng(29.9507094081633, -95.3963921020408);
              yield return new LatLng(29.949261, -95.388183);
              yield return new LatLng(29.8051504026846, -95.3331526778523);
              yield return new LatLng(29.8022963434343, -95.3343956868687);
              yield return new LatLng(29.8324691236203, -95.3392955435368);
              yield return new LatLng(29.8216286530612, -95.3502214693877);
              yield return new LatLng(29.8514307752809, -95.3438635280899);
              yield return new LatLng(29.8428180408163, -95.2771907142857);
              yield return new LatLng(29.8522667935883, -95.2721688763325);
              yield return new LatLng(29.8523672978723, -95.2624699574468);
              yield return new LatLng(29.7846965510204, -95.3103749387755);
              yield return new LatLng(29.7846965510204, -95.3103749387755);
              yield return new LatLng(29.8140815, -95.3173096);
              yield return new LatLng(29.7756095918367, -95.3041699795918);
              yield return new LatLng(29.8200083561244, -95.2139835234013);
              yield return new LatLng(29.77218, -95.28391);
              yield return new LatLng(29.7145610408163, -95.3969194693878);
              yield return new LatLng(29.7082498947368, -95.4019241578947);
              yield return new LatLng(29.7252476938776, -95.3798290612245);
              yield return new LatLng(29.7108802244898, -95.2956379183673);
              yield return new LatLng(29.5357912, -95.466331);
              yield return new LatLng(29.644544, -95.244962);
              yield return new LatLng(29.6384852046948, -95.2080442867469);
              yield return new LatLng(29.7098515, -95.278095);
              yield return new LatLng(29.6325724705882, -95.2759275735294);
              yield return new LatLng(29.7336803, -95.3479811);
              yield return new LatLng(29.6828916621569, -95.3672815614084);
              yield return new LatLng(29.6578615483871, -95.3554037419355);
              yield return new LatLng(29.6780286966421, -95.3343517809311);
              yield return new LatLng(29.5786175918367, -95.517316);
          }
     }

     public class January_2017_Rape_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
