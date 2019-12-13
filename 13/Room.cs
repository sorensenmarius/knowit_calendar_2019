using System;
using System.Collections.Generic;
using System.Text;

namespace _13
{
    class Room
    {
        public int x { get; }
        public int y { get; }
        public Boolean nord { get; }
        public Boolean aust { get; }
        public Boolean syd { get; }
        public Boolean vest { get; }
        public Boolean notvisited { get; set; }

        public Room(int x, int y, Boolean nord, Boolean aust, Boolean syd, Boolean vest)
        {
            this.x = x;
            this.y = y;
            this.nord = nord;
            this.aust = aust;
            this.syd = syd;
            this.vest = vest;
            notvisited = true;
        }

        override
        public string ToString()
        {
            return $"({x}, {y}): ({nord}, {aust}, {syd}, {vest}) - {notvisited}";
        }
    }
}
