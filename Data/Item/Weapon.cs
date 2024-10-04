using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Item
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public enum DamageType { get; set; } // e.g., "Slashing", "Piercing", etc.

        public Weapon()
        {
            Type = "Weapon"; // Set the Type property to "Weapon"
        }
    }
}
