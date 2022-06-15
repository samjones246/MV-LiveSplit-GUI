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
        public List<Dictionary<string, object>> activators { get; set; }

        public override string ToString()
        {
            return name;
        }

        public void CopyFrom(SplitPoint blueprint)
        {
            name = blueprint.name;
            activators = new List<Dictionary<string, object>>();
            foreach (Dictionary<string, object> bpActivator in blueprint.activators)
            {
                Dictionary<string, object> activator = new Dictionary<string, object>();
                activators.Add(activator);
                foreach (string key in bpActivator.Keys)
                {
                    activator.Add(key, bpActivator[key]);
                }
            }
        }
    }
}
