using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClienteKit
    {
        public int ClienteKitID { get; set; }
        public int ClienteID { get; set; }
        public int KitID { get; set; }
        public virtual Cliente _Cliente { get; set; }
        public virtual Kit _Kit { get; set; }

    }
}
