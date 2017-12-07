namespace DeepPrototype.Model
{
    public class Trainer
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
        public string Function => "Trainer";

    }
}
