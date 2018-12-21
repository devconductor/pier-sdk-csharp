using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// Respose onject of the commercial origin types resource
    /// </summary>
    [DataContract]
    public partial class TipoOrigemComercialResponse :  IEquatable<TipoOrigemComercialResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOrigemComercialResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOrigemComercialResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Commercial Origin Type.</param>
        /// <param name="Nome">Name of the commercial origin type.</param>

        public TipoOrigemComercialResponse(long? Id = null, string Nome = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Commercial Origin Type
        /// </summary>
        /// <value>Identification Code of the Commercial Origin Type</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Name of the commercial origin type
        /// </summary>
        /// <value>Name of the commercial origin type</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOrigemComercialResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TipoOrigemComercialResponse);
        }

        /// <summary>
        /// Returns true if TipoOrigemComercialResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOrigemComercialResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOrigemComercialResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                return hash;
            }
        }

    }
}
