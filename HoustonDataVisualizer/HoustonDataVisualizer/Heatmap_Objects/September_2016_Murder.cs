using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GoogleMaps.Samples.Data.Sources
{
     [DataObject(true)]
     public static class September_2016_Murder
     {
         public static IEnumerable<September_2016_Murder_HeatmapDataObject> GetDataObjects()
         {
             return GetRawData().Select(x => new September_2016_Murder_HeatmapDataObject { Lat = x.Latitude, Lng = x.Longitude });
         }

         public static IEnumerable<LatLng> GetRawData()
         {
              yield return new LatLng(29.7296879387755, -95.3631155306122);
              yield return new LatLng(29.7022014186559, -95.3703776181183);
              yield return new LatLng(29.59336, -95.223391);
              yield return new LatLng(29.6522676030648, -95.373450901126);
              yield return new LatLng(29.643139, -95.3996723);
              yield return new LatLng(29.6509721428571, -95.4770705238095);
              yield return new LatLng(29.6547435151515, -95.439672010101);
              yield return new LatLng(29.6820825862069, -95.4176731724138);
              yield return new LatLng(29.7034901, -95.5987156);
              yield return new LatLng(29.6378818041522, -95.4952816522666);
              yield return new LatLng(29.688766, -95.59222);
              yield return new LatLng(29.7327835, -95.5716659);
              yield return new LatLng(29.6681274070024, -95.5955218681459);
              yield return new LatLng(29.6750819, -95.5527736);
              yield return new LatLng(29.7799850606061, -95.3858927272727);
              yield return new LatLng(29.828074794328, -95.4003307741891);
              yield return new LatLng(29.8051338571429, -95.4849743877551);
              yield return new LatLng(29.849807452381, -95.3846406428571);
              yield return new LatLng(29.9178870649351, -95.3935894935065);
              yield return new LatLng(29.9252572805138, -95.4040057959984);
              yield return new LatLng(29.7833209183673, -95.3351229387755);
              yield return new LatLng(29.9589647346939, -95.3023681836735);
              yield return new LatLng(29.8227487667553, -95.3050832444147);
              yield return new LatLng(29.7417333333333, -95.2563366666667);
          }
     }

     public class September_2016_Murder_HeatmapDataObject
     {
          public double Lat { get; set; }

          public double Lng { get; set; }
     }
}
