using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMMV_LiveSplit_GUI
{
    public class PluginEntry
    {
        public string name { get; set; }
        public bool status { get; set; }
        public string description { get; set; }
        public Dictionary<string, string> parameters { get; set; }
        public PluginEntry(string name, bool status)
        {
            this.name = name;
            this.status = status;
            this.description = "";
            this.parameters = new Dictionary<string, string>();
        }
    }
    public class Autosplitter
    {
        public List<SplitPoint> splits { get; set; }
        public Dictionary<string, bool> defaults { get; set; }
    }
    public class SplitPoint
    {
        public string name { get; set; }
        public List<Activator> activators { get; set; }
        public bool Start { get; set; }

        public override string ToString()
        {
            return name;
        }

        public void CopyFrom(SplitPoint blueprint)
        {
            name = blueprint.name;
            Start = blueprint.Start;
            activators = new List<Activator>();
            foreach (Activator bpActivator in blueprint.activators)
            {
                activators.Add((Activator)bpActivator.Clone());
            }
        }
    }

    public class Activator
    {
        public string Type { get; set; }
        public int? Map { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }
        public int? Event { get; set; }
        public int? Page { get; set; }
        public int? Line { get; set; }
        public int? Id { get; set; }
        public int? Value { get; set; }
        public bool? Any { get; set; }
        public bool? Common { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
