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
    /// Response Representation of the Integration Document Resource
    /// </summary>
    [DataContract]
    public partial class DocumentoIntegracaoResponse :  IEquatable<DocumentoIntegracaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoIntegracaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DocumentoIntegracaoResponse" />class.
        /// </summary>
        /// <param name="Id">ID of the Integrated Document.</param>
        /// <param name="IdTemplate">ID of the Template of the associated Document.</param>
        /// <param name="Nome">Name of the Document.</param>

        public DocumentoIntegracaoResponse(long? Id = null, long? IdTemplate = null, string Nome = null)
        {
            this.Id = Id;
            this.IdTemplate = IdTemplate;
            this.Nome = Nome;
            
        }
        
    
        /// <summary>
        /// ID of the Integrated Document
        /// </summary>
        /// <value>ID of the Integrated Document</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// ID of the Template of the associated Document
        /// </summary>
        /// <value>ID of the Template of the associated Document</value>
        [DataMember(Name="idTemplate", EmitDefaultValue=false)]
        public long? IdTemplate { get; set; }
    
        /// <summary>
        /// Name of the Document
        /// </summary>
        /// <value>Name of the Document</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoIntegracaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTemplate: ").Append(IdTemplate).Append("\n");
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
            return this.Equals(obj as DocumentoIntegracaoResponse);
        }

        /// <summary>
        /// Returns true if DocumentoIntegracaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoIntegracaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoIntegracaoResponse other)
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
                    this.IdTemplate == other.IdTemplate ||
                    this.IdTemplate != null &&
                    this.IdTemplate.Equals(other.IdTemplate)
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
                
                if (this.IdTemplate != null)
                    hash = hash * 59 + this.IdTemplate.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                return hash;
            }
        }

    }
}
