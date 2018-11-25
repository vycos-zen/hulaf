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
    public interface IPersonController
    {
        /// <summary>Gets a missing person by guid.</summary>
        /// <param name="personGuid">Guid of person</param>
        /// <returns>Returns a missing person</returns>
        System.Threading.Tasks.Task<MissingPersonDto> GetMissingPersonAsync(string personGuid);
    
        /// <summary>Lists missing persons</summary>
        /// <returns>Missing person list.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.IList<MissingPersonDto>> GetMissingPersonListAsync();
    
        /// <summary>A person seeks a missing person</summary>
        /// <returns>Get a person by guid</returns>
        System.Threading.Tasks.Task<SeekerPersonDto> SeekerpersonAsync();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.0.0 (NJsonSchema v9.12.2.0 (Newtonsoft.Json v11.0.0.0))")]
    [Microsoft.AspNetCore.Mvc.RoutePrefix("api")]
    public partial class PersonController : ControllerBase
    {
        private IPersonController _implementation;
    
        public PersonController(IPersonController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>Gets a missing person by guid.</summary>
        /// <param name="personGuid">Guid of person</param>
        /// <returns>Returns a missing person</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("missingperson/{personGuid}")]
        public System.Threading.Tasks.Task<MissingPersonDto> GetMissingPerson(string personGuid)
        {
            return _implementation.GetMissingPersonAsync(personGuid);
        }
    
        /// <summary>Lists missing persons</summary>
        /// <returns>Missing person list.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("missingpersonlist")]
        public System.Threading.Tasks.Task<System.Collections.Generic.IList<MissingPersonDto>> GetMissingPersonList()
        {
            return _implementation.GetMissingPersonListAsync();
        }
    
        /// <summary>A person seeks a missing person</summary>
        /// <returns>Get a person by guid</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("seekerperson")]
        public System.Threading.Tasks.Task<SeekerPersonDto> Seekerperson()
        {
            return _implementation.SeekerpersonAsync();
        }
    
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MissingPersonDto 
    {
        [Newtonsoft.Json.JsonProperty("guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static MissingPersonDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MissingPersonDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.2.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SeekerPersonDto 
    {
        [Newtonsoft.Json.JsonProperty("guid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Guid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
        
        public static SeekerPersonDto FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SeekerPersonDto>(data, new Newtonsoft.Json.JsonSerializerSettings { PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All });
        }
    
    }

}