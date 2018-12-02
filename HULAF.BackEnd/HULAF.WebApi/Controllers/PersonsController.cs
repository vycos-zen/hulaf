﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.0.0.0 (NJsonSchema v9.12.2.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HULAF.WebApi.Controllers
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.0.0 (NJsonSchema v9.12.2.0 (Newtonsoft.Json v11.0.0.0))")]
    public abstract class PersonControllerBase : ControllerBase
    {
        /// <summary>Gets a missing person by guid.</summary>
        /// <param name="personGuid">Guid of person</param>
        /// <returns>Returns a missing person</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("missingperson/{personGuid}")]
        public abstract System.Threading.Tasks.Task<MissingPersonDto> Missingperson(string personGuid);
    
        /// <summary>Lists missing persons</summary>
        /// <returns>Missing person list.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("missingpersonlist")]
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.List<MissingPersonDto>> Missingpersonlist();
    
        /// <summary>A person seeks a missing person</summary>
        /// <returns>Get a person by guid</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("seekerperson")]
        public abstract System.Threading.Tasks.Task<SeekerPersonDto> Seekerperson();
    
    }
    
    

    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "personType")]
    [JsonInheritanceAttribute("MissingPersonDto", typeof(MissingPersonDto))]
    [JsonInheritanceAttribute("SeekerPersonDto", typeof(SeekerPersonDto))]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PersonDto 
    {
        [Newtonsoft.Json.JsonProperty("guid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("characteristics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Characteristics { get; set; }
    
        [Newtonsoft.Json.JsonProperty("contactInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object ContactInfo { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static PersonDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    /// <summary>A missing person</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MissingPersonDto : PersonDto
    {
        [Newtonsoft.Json.JsonProperty("lastSeenLocations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<object> LastSeenLocations { get; set; } = new System.Collections.Generic.List<object>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static MissingPersonDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MissingPersonDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    /// <summary>A person looking form someone missing</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SeekerPersonDto : PersonDto
    {
        [Newtonsoft.Json.JsonProperty("locationsOfSearch", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<object> LocationsOfSearch { get; set; } = new System.Collections.Generic.List<object>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static SeekerPersonDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SeekerPersonDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CharateristicsDto 
    {
        [Newtonsoft.Json.JsonProperty("guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approxHeightMin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApproxHeightMin { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approxHeightMax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApproxHeightMax { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hairColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object HairColor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eyeColor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object EyeColor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approxAgeMin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApproxAgeMin { get; set; }
    
        [Newtonsoft.Json.JsonProperty("approxAgeMax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApproxAgeMax { get; set; }
    
        [Newtonsoft.Json.JsonProperty("knownNames", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> KnownNames { get; set; } = new System.Collections.Generic.List<string>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static CharateristicsDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CharateristicsDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum EyeColorDto
    {
        [System.Runtime.Serialization.EnumMember(Value = "green")]
        Green = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "blue")]
        Blue = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum HairColorDto
    {
        [System.Runtime.Serialization.EnumMember(Value = "brown")]
        Brown = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "blonde")]
        Blonde = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactInfoDto 
    {
        [Newtonsoft.Json.JsonProperty("guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static ContactInfoDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ContactInfoDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CityDto 
    {
        [Newtonsoft.Json.JsonProperty("Guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Country Country { get; set; } = new Country();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static CityDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CityDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CoordinatesDto 
    {
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Lat { get; set; }
    
        [Newtonsoft.Json.JsonProperty("lng", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Lng { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static CoordinatesDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CoordinatesDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CountryDto 
    {
        [Newtonsoft.Json.JsonProperty("Guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("DialingCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int DialingCode { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static CountryDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CountryDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class LocationDto 
    {
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CountryDto Country { get; set; } = new CountryDto();
    
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CityDto City { get; set; } = new CityDto();
    
        [Newtonsoft.Json.JsonProperty("coordinates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CoordinatesDto Coordinates { get; set; } = new CoordinatesDto();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static LocationDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LocationDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Country 
    {
        [Newtonsoft.Json.JsonProperty("Guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("DialingCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int DialingCode { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static Country FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Country>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "12.0.0.0 (NJsonSchema v9.12.2.0 (Newtonsoft.Json v11.0.0.0))")]
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : System.Attribute
    {
        public JsonInheritanceAttribute(string key, System.Type type)
        {
            Key = key;
            Type = type;
        }
    
        public string Key { get; }
    
        public System.Type Type { get; }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "12.0.0.0 (NJsonSchema v9.12.2.0 (Newtonsoft.Json v11.0.0.0))")]
    internal class JsonInheritanceConverter : Newtonsoft.Json.JsonConverter
    {
        internal static readonly string DefaultDiscriminatorName = "discriminator";
    
        private readonly string _discriminator;
    
        [System.ThreadStatic]
        private static bool _isReading;
    
        [System.ThreadStatic]
        private static bool _isWriting;
    
        public JsonInheritanceConverter()
        {
            _discriminator = DefaultDiscriminatorName;
        }
    
        public JsonInheritanceConverter(string discriminator)
        {
            _discriminator = discriminator;
        }
    
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            try
            {
                _isWriting = true;
    
                var jObject = Newtonsoft.Json.Linq.JObject.FromObject(value, serializer);
                jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(_discriminator, GetSubtypeDiscriminator(value.GetType())));
                writer.WriteToken(jObject.CreateReader());
            }
            finally
            {
                _isWriting = false;
            }
        }
    
        public override bool CanWrite
        {
            get
            {
                if (_isWriting)
                {
                    _isWriting = false;
                    return false;
                }
                return true;
            }
        }
    
        public override bool CanRead
        {
            get
            {
                if (_isReading)
                {
                    _isReading = false;
                    return false;
                }
                return true;
            }
        }
    
        public override bool CanConvert(System.Type objectType)
        {
            return true;
        }
    
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
            if (jObject == null)
                return null;
    
            var discriminator = Newtonsoft.Json.Linq.Extensions.Value<string>(jObject.GetValue(_discriminator));
            var subtype = GetObjectSubtype(objectType, discriminator);
    
            try
            {
                _isReading = true;
                return serializer.Deserialize(jObject.CreateReader(), subtype);
            }
            finally
            {
                _isReading = false;
            }
        }
    
        private System.Type GetObjectSubtype(System.Type objectType, string discriminator)
        {
            foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true))
            {
                if (attribute.Key == discriminator)
                    return attribute.Type;
            }
    
            return objectType;
        }
    
        private string GetSubtypeDiscriminator(System.Type objectType)
        {
            foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true))
            {
                if (attribute.Type == objectType)
                    return attribute.Key;
            }
    
            return objectType.Name;
        }
    }

}