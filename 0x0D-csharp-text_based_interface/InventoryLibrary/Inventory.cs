using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the Inventory. </summary>
    public class Inventory : BaseClass
    {
        /// <summary> The id of a User. </summary>
        public string user_id;

        /// <summary> The id of an Item. </summary>
        public string item_id;

        /// <summary> The amount of items in the inventory. </summary>
        public int quantity;

        /// <summary> Sets the information on an Inventory object. </summary>
        /// <param name="u_id"> The id of the User. </param>
        /// <param name="i_id"> The id of the Item. </param>
        /// <param name="total"> The amount of items in the inventory. </param>
        public Inventory(string u_id, string i_id, int total = 1)
        {
            this.user_id = u_id;
            this.item_id = i_id;
            if (total < 1)
                total = 1;
            this.quantity = total;
        }
    }
}
