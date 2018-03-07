using System;
using System.Collections.Generic;

namespace KeggerBot
{
    public class User
    {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }

            public virtual List<Beer> Drinks { get; set; }
    }
}
