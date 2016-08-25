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
    /// Lista de Est\u00C3\u00A1gios Cart\u00C3\u00B5es
    /// </summary>
    [DataContract]
    public partial class ListaDeEstgiosCartes :  IEquatable<ListaDeEstgiosCartes>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaDeEstgiosCartes" /> class.
        /// Initializes a new instance of the <see cref="ListaDeEstgiosCartes" />class.
        /// </summary>
        /// <param name="EstagiosCartoes">Lista de est\u00C3\u00A1gios cart\u00C3\u00B5es.</param>

        public ListaDeEstgiosCartes(List<EstgioCarto> EstagiosCartoes = null)
        {
            this.EstagiosCartoes = EstagiosCartoes;
            
        }
        
    
        /// <summary>
        /// Lista de est\u00C3\u00A1gios cart\u00C3\u00B5es
        /// </summary>
        /// <value>Lista de est\u00C3\u00A1gios cart\u00C3\u00B5es</value>
        [DataMember(Name="estagiosCartoes", EmitDefaultValue=false)]
        public List<EstgioCarto> EstagiosCartoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaDeEstgiosCartes {\n");
            sb.Append("  EstagiosCartoes: ").Append(EstagiosCartoes).Append("\n");
            
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
            return this.Equals(obj as ListaDeEstgiosCartes);
        }

        /// <summary>
        /// Returns true if ListaDeEstgiosCartes instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaDeEstgiosCartes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaDeEstgiosCartes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EstagiosCartoes == other.EstagiosCartoes ||
                    this.EstagiosCartoes != null &&
                    this.EstagiosCartoes.SequenceEqual(other.EstagiosCartoes)
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
                
                if (this.EstagiosCartoes != null)
                    hash = hash * 59 + this.EstagiosCartoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
