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
    /// {{{tipo_oportunidade_persist_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoOportunidadePersistValue :  IEquatable<TipoOportunidadePersistValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOportunidadePersistValue" /> class.
        /// Initializes a new instance of the <see cref="TipoOportunidadePersistValue" />class.
        /// </summary>
        /// <param name="Descricao">{{{tipo_oportunidade_persist_descricao_value}}} (required).</param>
        /// <param name="FlagAtivo">{{{tipo_oportunidade_persist_flag_ativo_value}}} (required).</param>

        public TipoOportunidadePersistValue(string Descricao = null, bool? FlagAtivo = null)
        {
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for TipoOportunidadePersistValue and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "FlagAtivo" is required (not null)
            if (FlagAtivo == null)
            {
                throw new InvalidDataException("FlagAtivo is a required property for TipoOportunidadePersistValue and cannot be null");
            }
            else
            {
                this.FlagAtivo = FlagAtivo;
            }
            
        }
        
    
        /// <summary>
        /// {{{tipo_oportunidade_persist_descricao_value}}}
        /// </summary>
        /// <value>{{{tipo_oportunidade_persist_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{tipo_oportunidade_persist_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{tipo_oportunidade_persist_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOportunidadePersistValue {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as TipoOportunidadePersistValue);
        }

        /// <summary>
        /// Returns true if TipoOportunidadePersistValue instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOportunidadePersistValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOportunidadePersistValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}