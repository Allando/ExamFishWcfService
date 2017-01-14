using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

namespace ExamFishWcfService
{
    [DataContract]
    public class Catch
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Species { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public int Week { get; set; }

        public Catch(int id, string name, string species, double weight, int week)
        {
            Id = id;
            Name = name;
            Species = species;
            Weight = weight;
            Week = week;
        }
    }
}