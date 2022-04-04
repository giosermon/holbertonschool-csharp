using System;
using System.Globalization;

namespace InventoryLibrary
{
    /// <summary> The class all other classes will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> A string of the object's id. </summary>
        public string id { get; set; }

        /// <summary> DateTime object. The time an object was created. </summary>
        public DateTime date_created { get; set; }

        /// <summary> DateTime object. The time an object was updated. </summary>
        public DateTime date_updated { get; set; }

        /// <summary> Sets the basic info for each class </summary>
        public BaseClass() {
            this.id = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Trim('=');
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
