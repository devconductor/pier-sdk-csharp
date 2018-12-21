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
    /// Response of the integration register inclusion resource
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorResponse :  IEquatable<IntegracaoEmissorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the registetr in the IntegrationIssuer table.</param>
        /// <param name="IdConta">Identification Code of the Account.</param>
        /// <param name="IdArquivo">Identification Code of the file.</param>
        /// <param name="Status">Register Status.</param>
        /// <param name="DataInclusao">Date of the resgister inclusion.</param>
        /// <param name="DataAlteracao">Date of the last update of the register.</param>

        public IntegracaoEmissorResponse(long? Id = null, long? IdConta = null, long? IdArquivo = null, string Status = null, string DataInclusao = null, string DataAlteracao = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.IdArquivo = IdArquivo;
            this.Status = Status;
            this.DataInclusao = DataInclusao;
            this.DataAlteracao = DataAlteracao;
            
        }
        
    
        /// <summary>
        /// Identification Code of the registetr in the IntegrationIssuer table
        /// </summary>
        /// <value>Identification Code of the registetr in the IntegrationIssuer table</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the Account
        /// </summary>
        /// <value>Identification Code of the Account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the file
        /// </summary>
        /// <value>Identification Code of the file</value>
        [DataMember(Name="idArquivo", EmitDefaultValue=false)]
        public long? IdArquivo { get; set; }
    
        /// <summary>
        /// Register Status
        /// </summary>
        /// <value>Register Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Date of the resgister inclusion
        /// </summary>
        /// <value>Date of the resgister inclusion</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Date of the last update of the register
        /// </summary>
        /// <value>Date of the last update of the register</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegracaoEmissorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdArquivo: ").Append(IdArquivo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            
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
            return this.Equals(obj as IntegracaoEmissorResponse);
        }

        /// <summary>
        /// Returns true if IntegracaoEmissorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegracaoEmissorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegracaoEmissorResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdArquivo == other.IdArquivo ||
                    this.IdArquivo != null &&
                    this.IdArquivo.Equals(other.IdArquivo)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdArquivo != null)
                    hash = hash * 59 + this.IdArquivo.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
