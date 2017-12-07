using System.Reflection;

namespace ReflectionClonePrototype.Models
{
    public class Player
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
        public string Function => "Player";

        public object Clone()
        {
            // Get all the fields of the type, also the privates.
            FieldInfo[] fis = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            // Create a new person object
            Player newPlayer = new Player();
            // Loop through all the fields and copy the information from the parameter class
            // to the newPerson class.
            foreach (FieldInfo fi in fis)
            {
                fi.SetValue(newPlayer, fi.GetValue(this));
            }
            // Return the cloned object.
            return newPlayer;
        }
    }
}
