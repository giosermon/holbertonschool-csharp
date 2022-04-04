using System;
using System.Reflection;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding an Item. </summary>
    public class Item : BaseClass
    {
        /// <summary> A required string that's the name of an Item. </summary>
        public string name { get; set; }

        /// <summary> An optional string that's the description of the Item. </summary>
        public string description { get; set; }

        /// <summary> An optional 2 point float that's the price of the Item. </summary>
        public float price { get; set; }

        /// <summary> An optional list of strings that's the tags of the Item. </summary>
        public List<string> tags { get; set; }

        /// <summary> Initializes an Item object </summary>
        /// <param name="n"> The name of the Item. Required. </param>
        /// <param name="describe"> The description of the Item. Optional. </param>
        /// <param name="cost"> The price of the Item. Optional. </param>
        /// <param name="info"> The tags of the Item. Optional. </param>
        public Item(string n, string describe = null, float cost = 0.00f, List<string> info = null)
        {
            this.name = n;
            this.description = describe;
            this.price = (float)(Math.Truncate((double) cost * 100.0) / 100.0);
            this.tags = new List<string>();
            this.tags = info;
        }

        /// <summary> Organizes information about the Item object. </summary>
        /// <returns> A string with information about this object. </returns>
        public override string ToString()
        {
            string info = @"______________________________________________________
|
| ID: {0}    Date Created: {1}    Date Updated: {2}
| Name: {3}    Description: {4}    Price: {5}    Tags: {6}
|_____________________________________________________
";

            return string.Format(info, this.id, this.date_created, this.date_updated, this.name, this.description, this.price.ToString("0.00"), String.Join(", ", this.tags));
        }
    }
}
