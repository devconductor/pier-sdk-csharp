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
    /// Object Prosecutor
    /// </summary>
    [DataContract]
    public partial class PromotorResponse :  IEquatable<PromotorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotorResponse" /> class.
        /// Initializes a new instance of the <see cref="PromotorResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the Prosecutor (id).</param>
        /// <param name="Nome">Prosecutor Name.</param>
        /// <param name="DataCadastro">Inclusion date.</param>
        /// <param name="IdEstabelecimento">Identification Code of the Merchant.</param>
        /// <param name="IdUsuario">Identification Code of the user.</param>

        public PromotorResponse(long? Id = null, string Nome = null, string DataCadastro = null, long? IdEstabelecimento = null, long? IdUsuario = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DataCadastro = DataCadastro;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdUsuario = IdUsuario;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Prosecutor (id)
        /// </summary>
        /// <value>Identification Code of the Prosecutor (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Prosecutor Name
        /// </summary>
        /// <value>Prosecutor Name</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Inclusion date
        /// </summary>
        /// <value>Inclusion date</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant
        /// </summary>
        /// <value>Identification Code of the Merchant</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Identification Code of the user
        /// </summary>
        /// <value>Identification Code of the user</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromotorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            
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
            return this.Equals(obj as PromotorResponse);
        }

        /// <summary>
        /// Returns true if PromotorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PromotorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotorResponse other)
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
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
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
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
