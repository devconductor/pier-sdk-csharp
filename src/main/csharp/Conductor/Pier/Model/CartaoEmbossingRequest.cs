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
    /// Request Parameters of the embossing card creation
    /// </summary>
    [DataContract]
    public partial class CartaoEmbossingRequest :  IEquatable<CartaoEmbossingRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoEmbossingRequest" /> class.
        /// Initializes a new instance of the <see cref="CartaoEmbossingRequest" />class.
        /// </summary>
        /// <param name="IdPessoa">Identification Code of the Person which the card belongs (id).</param>
        /// <param name="IdTipoPlastico">Identification Code of TypePlastic (id).</param>

        public CartaoEmbossingRequest(long? IdPessoa = null, long? IdTipoPlastico = null)
        {
            this.IdPessoa = IdPessoa;
            this.IdTipoPlastico = IdTipoPlastico;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Person which the card belongs (id)
        /// </summary>
        /// <value>Identification Code of the Person which the card belongs (id)</value>
        [DataMember(Name="id_pessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identification Code of TypePlastic (id)
        /// </summary>
        /// <value>Identification Code of TypePlastic (id)</value>
        [DataMember(Name="id_tipo_plastico", EmitDefaultValue=false)]
        public long? IdTipoPlastico { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoEmbossingRequest {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdTipoPlastico: ").Append(IdTipoPlastico).Append("\n");
            
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
            return this.Equals(obj as CartaoEmbossingRequest);
        }

        /// <summary>
        /// Returns true if CartaoEmbossingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoEmbossingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoEmbossingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdTipoPlastico == other.IdTipoPlastico ||
                    this.IdTipoPlastico != null &&
                    this.IdTipoPlastico.Equals(other.IdTipoPlastico)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdTipoPlastico != null)
                    hash = hash * 59 + this.IdTipoPlastico.GetHashCode();
                
                return hash;
            }
        }

    }
}
