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
    /// {{{status_oportunidade_a_u_d_response_description}}}
    /// </summary>
    [DataContract]
    public partial class StatusOportunidadeAUDResponse :  IEquatable<StatusOportunidadeAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOportunidadeAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="StatusOportunidadeAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">{{{status_oportunidade_a_u_d_response_rev_value}}}.</param>
        /// <param name="RevType">{{{status_oportunidade_a_u_d_response_rev_type_value}}}.</param>
        /// <param name="RevDate">{{{status_oportunidade_a_u_d_response_rev_date_value}}}.</param>
        /// <param name="Id">{{{status_oportunidade_a_u_d_response_id_value}}}.</param>
        /// <param name="IdTipoOportunidade">{{{status_oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}.</param>
        /// <param name="Nome">{{{status_oportunidade_a_u_d_response_nome_value}}}.</param>
        /// <param name="Descricao">{{{status_oportunidade_a_u_d_response_descricao_value}}}.</param>
        /// <param name="FlagAtivo">{{{status_oportunidade_a_u_d_response_flag_ativo_value}}}.</param>

        public StatusOportunidadeAUDResponse(long? Rev = null, long? RevType = null, string RevDate = null, long? Id = null, long? IdTipoOportunidade = null, string Nome = null, string Descricao = null, bool? FlagAtivo = null)
        {
            this.Rev = Rev;
            this.RevType = RevType;
            this.RevDate = RevDate;
            this.Id = Id;
            this.IdTipoOportunidade = IdTipoOportunidade;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_rev_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_rev_value}}}</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_rev_type_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_rev_type_value}}}</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public long? RevType { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_rev_date_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_rev_date_value}}}</value>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_id_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}</value>
        [DataMember(Name="idTipoOportunidade", EmitDefaultValue=false)]
        public long? IdTipoOportunidade { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_nome_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_descricao_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{status_oportunidade_a_u_d_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{status_oportunidade_a_u_d_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusOportunidadeAUDResponse {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoOportunidade: ").Append(IdTipoOportunidade).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
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
            return this.Equals(obj as StatusOportunidadeAUDResponse);
        }

        /// <summary>
        /// Returns true if StatusOportunidadeAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusOportunidadeAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusOportunidadeAUDResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdTipoOportunidade == other.IdTipoOportunidade ||
                    this.IdTipoOportunidade != null &&
                    this.IdTipoOportunidade.Equals(other.IdTipoOportunidade)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
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
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdTipoOportunidade != null)
                    hash = hash * 59 + this.IdTipoOportunidade.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
