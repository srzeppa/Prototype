using System;

namespace ICloneablePrototype.Models
{
    public class Player : ICloneable
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
        public string Function => "Player";

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
