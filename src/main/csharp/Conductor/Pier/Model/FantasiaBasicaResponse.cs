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
    /// Representa\u00E7\u00E3o da resposta do recurso de operadora telef\u00F4nica
    /// </summary>
    [DataContract]
    public partial class FantasiaBasicaResponse :  IEquatable<FantasiaBasicaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FantasiaBasicaResponse" /> class.
        /// Initializes a new instance of the <see cref="FantasiaBasicaResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador da fantasia b\u00E1sica.</param>
        /// <param name="Nome">Nome da fantasia b\u00E1sica.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o da fantasia b\u00E1sica.</param>
        /// <param name="DescricaoArquivo">Descri\u00E7\u00E3o do arquivo da fantasia b\u00E1sica.</param>
        /// <param name="QuantidadeMaxProposta">Quantidade m\u00E1xima de propostas da fantasia b\u00E1sica.</param>

        public FantasiaBasicaResponse(long? Id = null, string Nome = null, string Descricao = null, string DescricaoArquivo = null, int? QuantidadeMaxProposta = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.DescricaoArquivo = DescricaoArquivo;
            this.QuantidadeMaxProposta = QuantidadeMaxProposta;
            
        }
        
    
        /// <summary>
        /// Identificador da fantasia b\u00E1sica
        /// </summary>
        /// <value>Identificador da fantasia b\u00E1sica</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome da fantasia b\u00E1sica
        /// </summary>
        /// <value>Nome da fantasia b\u00E1sica</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da fantasia b\u00E1sica
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da fantasia b\u00E1sica</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do arquivo da fantasia b\u00E1sica
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do arquivo da fantasia b\u00E1sica</value>
        [DataMember(Name="descricaoArquivo", EmitDefaultValue=false)]
        public string DescricaoArquivo { get; set; }
    
        /// <summary>
        /// Quantidade m\u00E1xima de propostas da fantasia b\u00E1sica
        /// </summary>
        /// <value>Quantidade m\u00E1xima de propostas da fantasia b\u00E1sica</value>
        [DataMember(Name="quantidadeMaxProposta", EmitDefaultValue=false)]
        public int? QuantidadeMaxProposta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FantasiaBasicaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  DescricaoArquivo: ").Append(DescricaoArquivo).Append("\n");
            sb.Append("  QuantidadeMaxProposta: ").Append(QuantidadeMaxProposta).Append("\n");
            
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
            return this.Equals(obj as FantasiaBasicaResponse);
        }

        /// <summary>
        /// Returns true if FantasiaBasicaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FantasiaBasicaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FantasiaBasicaResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.DescricaoArquivo == other.DescricaoArquivo ||
                    this.DescricaoArquivo != null &&
                    this.DescricaoArquivo.Equals(other.DescricaoArquivo)
                ) && 
                (
                    this.QuantidadeMaxProposta == other.QuantidadeMaxProposta ||
                    this.QuantidadeMaxProposta != null &&
                    this.QuantidadeMaxProposta.Equals(other.QuantidadeMaxProposta)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.DescricaoArquivo != null)
                    hash = hash * 59 + this.DescricaoArquivo.GetHashCode();
                
                if (this.QuantidadeMaxProposta != null)
                    hash = hash * 59 + this.QuantidadeMaxProposta.GetHashCode();
                
                return hash;
            }
        }

    }
}
