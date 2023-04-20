using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    // SOTTOCLASSE
    public class Water : itemShop
    {
        private string waterName;
        private float capacity;
        private float MaxCapacity = 1.5f;

        // COSTRUTTORE
        public Water(string name, string waterName, float capacity) : base(name)
        {
            this.waterName = waterName;
            this.capacity = capacity;
        }

        // GETTERS

        public string GetWaterName()
        {
            return this.waterName;
        }

        public float GetCapacity()
        {
            return this.capacity;
        }

        //SETTERS

        public void SetCapacity(float capacity)
        {
           
            if (capacity > MaxCapacity)
            {
                Console.WriteLine("La capacità massima della bottiglia è di 1,5L");
            } else
            {
                this.capacity = capacity;
            }
        }
        // METODI

        
    }
}
