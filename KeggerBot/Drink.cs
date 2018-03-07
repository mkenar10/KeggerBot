using System;
namespace KeggerBot
{
    public class Drink
    {
            public int ID { get; set; }
            public int UserId { get; set; }
            public int BeerId { get; set; }
            public int SensorId { get; set; }

            public virtual Sensor Sensor { get; set; }
            public virtual Beer Beer { get; set; }
            public virtual User User { get; set; }
        
    }
}
