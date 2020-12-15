using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITGSite.Models.Manuals
{
    public class Manual
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string ExampleHeader { get; set; }
        public string Example { get; set; }
    }
}
