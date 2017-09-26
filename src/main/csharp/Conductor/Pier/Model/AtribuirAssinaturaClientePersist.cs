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
    /// Objeto que representa a atribui\u00C3\u00A7\u00C3\u00A3o da assinatura do cliente
    /// </summary>
    [DataContract]
    public partial class AtribuirAssinaturaClientePersist :  IEquatable<AtribuirAssinaturaClientePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtribuirAssinaturaClientePersist" /> class.
        /// Initializes a new instance of the <see cref="AtribuirAssinaturaClientePersist" />class.
        /// </summary>
        /// <param name="IdArquivo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Arquivo.</param>

        public AtribuirAssinaturaClientePersist(long? IdArquivo = null)
        {
            this.IdArquivo = IdArquivo;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Arquivo
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Arquivo</value>
        [DataMember(Name="idArquivo", EmitDefaultValue=false)]
        public long? IdArquivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtribuirAssinaturaClientePersist {\n");
            sb.Append("  IdArquivo: ").Append(IdArquivo).Append("\n");
            
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
            return this.Equals(obj as AtribuirAssinaturaClientePersist);
        }

        /// <summary>
        /// Returns true if AtribuirAssinaturaClientePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AtribuirAssinaturaClientePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtribuirAssinaturaClientePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdArquivo == other.IdArquivo ||
                    this.IdArquivo != null &&
                    this.IdArquivo.Equals(other.IdArquivo)
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
                
                if (this.IdArquivo != null)
                    hash = hash * 59 + this.IdArquivo.GetHashCode();
                
                return hash;
            }
        }

    }
}