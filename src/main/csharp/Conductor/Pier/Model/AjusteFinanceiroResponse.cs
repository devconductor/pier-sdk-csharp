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
    /// {{{ajuste_financeiro_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AjusteFinanceiroResponse :  IEquatable<AjusteFinanceiroResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AjusteFinanceiroResponse" /> class.
        /// Initializes a new instance of the <see cref="AjusteFinanceiroResponse" />class.
        /// </summary>
        /// <param name="Id">{{{ajuste_financeiro_response_id_value}}}.</param>
        /// <param name="IdTipoAjuste">{{{ajuste_financeiro_response_id_tipo_ajuste_value}}}.</param>
        /// <param name="IdConta">{{{ajuste_financeiro_response_id_conta_value}}}.</param>
        /// <param name="DataAjuste">{{{ajuste_financeiro_response_data_ajuste_value}}}.</param>
        /// <param name="Valor">{{{ajuste_financeiro_response_valor_value}}}.</param>
        /// <param name="IdentificadorExterno">{{{ajuste_financeiro_response_identificador_externo_value}}}.</param>
        /// <param name="Status">{{{ajuste_financeiro_response_status_value}}}.</param>

        public AjusteFinanceiroResponse(long? Id = null, long? IdTipoAjuste = null, long? IdConta = null, string DataAjuste = null, double? Valor = null, string IdentificadorExterno = null, long? Status = null)
        {
            this.Id = Id;
            this.IdTipoAjuste = IdTipoAjuste;
            this.IdConta = IdConta;
            this.DataAjuste = DataAjuste;
            this.Valor = Valor;
            this.IdentificadorExterno = IdentificadorExterno;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// {{{ajuste_financeiro_response_id_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_id_tipo_ajuste_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_id_tipo_ajuste_value}}}</value>
        [DataMember(Name="idTipoAjuste", EmitDefaultValue=false)]
        public long? IdTipoAjuste { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_data_ajuste_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_data_ajuste_value}}}</value>
        [DataMember(Name="dataAjuste", EmitDefaultValue=false)]
        public string DataAjuste { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_valor_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_identificador_externo_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_identificador_externo_value}}}</value>
        [DataMember(Name="identificadorExterno", EmitDefaultValue=false)]
        public string IdentificadorExterno { get; set; }
    
        /// <summary>
        /// {{{ajuste_financeiro_response_status_value}}}
        /// </summary>
        /// <value>{{{ajuste_financeiro_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AjusteFinanceiroResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoAjuste: ").Append(IdTipoAjuste).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataAjuste: ").Append(DataAjuste).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  IdentificadorExterno: ").Append(IdentificadorExterno).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as AjusteFinanceiroResponse);
        }

        /// <summary>
        /// Returns true if AjusteFinanceiroResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AjusteFinanceiroResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AjusteFinanceiroResponse other)
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
                    this.IdTipoAjuste == other.IdTipoAjuste ||
                    this.IdTipoAjuste != null &&
                    this.IdTipoAjuste.Equals(other.IdTipoAjuste)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DataAjuste == other.DataAjuste ||
                    this.DataAjuste != null &&
                    this.DataAjuste.Equals(other.DataAjuste)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.IdentificadorExterno == other.IdentificadorExterno ||
                    this.IdentificadorExterno != null &&
                    this.IdentificadorExterno.Equals(other.IdentificadorExterno)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdTipoAjuste != null)
                    hash = hash * 59 + this.IdTipoAjuste.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataAjuste != null)
                    hash = hash * 59 + this.DataAjuste.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.IdentificadorExterno != null)
                    hash = hash * 59 + this.IdentificadorExterno.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
