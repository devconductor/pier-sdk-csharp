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
    /// Representa a resposta de uma aplica\u00E7\u00E3o mobile
    /// </summary>
    [DataContract]
    public partial class AplicacaoMobileEmissorResponse :  IEquatable<AplicacaoMobileEmissorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AplicacaoMobileEmissorResponse" /> class.
        /// Initializes a new instance of the <see cref="AplicacaoMobileEmissorResponse" />class.
        /// </summary>
        /// <param name="Id">Id da aplica\u00E7\u00E3o mobile.</param>

        public AplicacaoMobileEmissorResponse(long? Id = null)
        {
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Id da aplica\u00E7\u00E3o mobile
        /// </summary>
        /// <value>Id da aplica\u00E7\u00E3o mobile</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AplicacaoMobileEmissorResponse {\n");
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
            return this.Equals(obj as AplicacaoMobileEmissorResponse);
        }

        /// <summary>
        /// Returns true if AplicacaoMobileEmissorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AplicacaoMobileEmissorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AplicacaoMobileEmissorResponse other)
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
