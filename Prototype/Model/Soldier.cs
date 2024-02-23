using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsGoF.Prototype.Model
{
    public class Soldier : ICloneable
    {
        public string Weapon { get; set; }
        public string Name { get; set; }
        public Acessory Acessory { get; set; }

        public Soldier()
        {

        }

        public Soldier(Soldier soldier)
        {
            this.Name = soldier.Name;
            this.Weapon = soldier.Weapon;
            this.Acessory = soldier.Acessory;
        }

        public object Clone()
        {
            Soldier soldier = (Soldier)this.MemberwiseClone(); // This function is used for copy bit a bit the information of the property,
                                                               //             return new Soldado(this); if you use without the other objects case have a complex object like Acessory always will be the object of the Last object.
            soldier.Acessory = this.Acessory.Clone();
            return soldier;
        }

        public object Clone(bool simple)
        {

            return new Soldier(this);

        }
    }
}
