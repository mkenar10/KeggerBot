using System;
using System.Collections.Generic;

namespace KeggerBot
{
    public class Sensor
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Oz { get; set; }

            public virtual List<Drink> Drinks { get; set; }
        
    }
}
