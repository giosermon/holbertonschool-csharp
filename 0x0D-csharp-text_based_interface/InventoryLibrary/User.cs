using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the User. </summary>
    public class User : BaseClass
    {
        /// <summary> A required string that is the name of a User. </summary>
        public string name { get; set; }

        /// <summary> This is to initialize the User object </summary>
        /// <param name="n"> The name of the User </param>
        public User(string n)
        {
            this.name = n;
        }

        /// <summary> Organizes information about the User object. </summary>
        /// <returns> A string with information about this object. </returns>
        public override string ToString()
        {
            return base.ToString() + ": " + name.ToString();
        }
    }
}
