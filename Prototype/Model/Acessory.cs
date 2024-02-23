using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsGoF.Prototype.Model
{
    public class Acessory
    {
        public string Name { get; set; }


        public Acessory Clone()
        {
            return (Acessory)this.MemberwiseClone();
        }
    }
}
