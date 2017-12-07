using System;

namespace DeepPrototype.Model
{
    [Serializable]
    public class Player : PlayerAbstract
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
        public string Function => "Player";

        public override Player Clone()
        {
            var clonedPlayer = MemberwiseClone();
            return (Player) clonedPlayer;
        }
    }
}
