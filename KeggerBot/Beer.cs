using System;
using System.Collections.Generic;

namespace KeggerBot
{
    public class Beer
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }

            public virtual List<Drink> Drinks { get; set; }
    }
}
