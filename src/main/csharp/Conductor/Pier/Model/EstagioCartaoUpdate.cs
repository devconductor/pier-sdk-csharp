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
    /// EstagioCartaoUpdate
    /// </summary>
    [DataContract]
    public partial class EstagioCartaoUpdate :  IEquatable<EstagioCartaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstagioCartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="EstagioCartaoUpdate" />class.
        /// </summary>
        /// <param name="Id">ID do est\u00E1gio do cart\u00E3o.</param>

        public EstagioCartaoUpdate(long? Id = null)
        {
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// ID do est\u00E1gio do cart\u00E3o
        /// </summary>
        /// <value>ID do est\u00E1gio do cart\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstagioCartaoUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as EstagioCartaoUpdate);
        }

        /// <summary>
        /// Returns true if EstagioCartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of EstagioCartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstagioCartaoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                return hash;
            }
        }

    }
}
