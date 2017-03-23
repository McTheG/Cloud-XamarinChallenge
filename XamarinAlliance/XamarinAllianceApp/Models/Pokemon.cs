using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Character
    {
        Int32 id;
        string name;
        string type;
        string databankUrl;
        string imageUrl;
        string description;
        //ICollection<Pokemon> evolutions;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "type")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [JsonProperty(PropertyName = "databankUrl")]
        public string DatabankUrl
        {
            get { return databankUrl; }
            set { databankUrl = value; }
        }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /*
        [JsonProperty(PropertyName = "evolutions")]
        public ICollection<Pokemon> Evolutions
        {
            get { return evolutions; }
            set { evolutions = value; }
        }
        */
        public string Version { get; set; }
    }
}
