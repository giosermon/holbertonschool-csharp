using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary> A public class that manages all the information obtained. </summary>
    public class JSONStorage
    {
        /// <summary> Dictionary containing all objects. </summary>
        /// <value> Comes from storage stored through JSON. </value>
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        /// <summary> Used to get all objects. </summary>
        /// <returns> The entire `objects` dictionary. </returns>
        public Dictionary<string, object> All()
        {
            return this.objects;
        }

        /// <summary> Adds a new key-value pair to `objects`. </summary>
        /// <param name="obj"> The new object to save into `objects`. </param>
        public void New(BaseClass obj)
        {
            if (obj != null)
                this.objects.Add(obj.GetType().Name + "." + obj.id, obj);
        }

        /// <summary> Saves `objects` to the JSON file in Storage after serializing. </summary>
        public void Save()
        {
            string JSONString = JsonConvert.SerializeObject(objects);
            string JSONFile = @"../storage/inventory_manager.json";
            File.WriteAllText(JSONFile, JSONString);
        }

        /// <summary> Creates `objects` based off the deserialization of the JSON file. </summary>
        public void Load()
        {
            //Dictionary<string, List<string>> temp;
            string JSONFile = @"../storage/inventory_manager.json";
            string JSONString = File.ReadAllText(JSONFile);
            if (JSONString == null || JSONString == "")
                return;

            this.objects = JsonConvert.DeserializeObject<Dictionary<string, object>>(JSONString);

        }
    }
}
