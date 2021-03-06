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
    /// Objeto Oportunidade
    /// </summary>
    [DataContract]
    public partial class OportunidadePersist :  IEquatable<OportunidadePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadePersist" /> class.
        /// Initializes a new instance of the <see cref="OportunidadePersist" />class.
        /// </summary>
        /// <param name="IdTipoOportunidade">C\u00F3digo identificador do tipo oportunidade (required).</param>
        /// <param name="IdStatusOportunidade">C\u00F3digo identificador do status oportunidade (required).</param>
        /// <param name="NumeroReceitaFederal">N\u00FAmero Receita Federal (required).</param>
        /// <param name="DataInicioVigencia">Date de in\u00EDcio da vig\u00EAncia da oportunidade (required).</param>
        /// <param name="DataFimVigencia">Data do fim da vig\u00EAncia da oportunidade (required).</param>
        /// <param name="FlagAtivo">Atributo que indica se a oportunidade est\u00E1 ativa (required).</param>
        /// <param name="Detalhes">Lista de detalhes (required).</param>

        public OportunidadePersist(long? IdTipoOportunidade = null, long? IdStatusOportunidade = null, string NumeroReceitaFederal = null, string DataInicioVigencia = null, string DataFimVigencia = null, bool? FlagAtivo = null, List<DetalheOportunidadePersist> Detalhes = null)
        {
            // to ensure "IdTipoOportunidade" is required (not null)
            if (IdTipoOportunidade == null)
            {
                throw new InvalidDataException("IdTipoOportunidade is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.IdTipoOportunidade = IdTipoOportunidade;
            }
            // to ensure "IdStatusOportunidade" is required (not null)
            if (IdStatusOportunidade == null)
            {
                throw new InvalidDataException("IdStatusOportunidade is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.IdStatusOportunidade = IdStatusOportunidade;
            }
            // to ensure "NumeroReceitaFederal" is required (not null)
            if (NumeroReceitaFederal == null)
            {
                throw new InvalidDataException("NumeroReceitaFederal is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.NumeroReceitaFederal = NumeroReceitaFederal;
            }
            // to ensure "DataInicioVigencia" is required (not null)
            if (DataInicioVigencia == null)
            {
                throw new InvalidDataException("DataInicioVigencia is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.DataInicioVigencia = DataInicioVigencia;
            }
            // to ensure "DataFimVigencia" is required (not null)
            if (DataFimVigencia == null)
            {
                throw new InvalidDataException("DataFimVigencia is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.DataFimVigencia = DataFimVigencia;
            }
            // to ensure "FlagAtivo" is required (not null)
            if (FlagAtivo == null)
            {
                throw new InvalidDataException("FlagAtivo is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.FlagAtivo = FlagAtivo;
            }
            // to ensure "Detalhes" is required (not null)
            if (Detalhes == null)
            {
                throw new InvalidDataException("Detalhes is a required property for OportunidadePersist and cannot be null");
            }
            else
            {
                this.Detalhes = Detalhes;
            }
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do tipo oportunidade
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo oportunidade</value>
        [DataMember(Name="idTipoOportunidade", EmitDefaultValue=false)]
        public long? IdTipoOportunidade { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do status oportunidade
        /// </summary>
        /// <value>C\u00F3digo identificador do status oportunidade</value>
        [DataMember(Name="idStatusOportunidade", EmitDefaultValue=false)]
        public long? IdStatusOportunidade { get; set; }
    
        /// <summary>
        /// N\u00FAmero Receita Federal
        /// </summary>
        /// <value>N\u00FAmero Receita Federal</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Date de in\u00EDcio da vig\u00EAncia da oportunidade
        /// </summary>
        /// <value>Date de in\u00EDcio da vig\u00EAncia da oportunidade</value>
        [DataMember(Name="dataInicioVigencia", EmitDefaultValue=false)]
        public string DataInicioVigencia { get; set; }
    
        /// <summary>
        /// Data do fim da vig\u00EAncia da oportunidade
        /// </summary>
        /// <value>Data do fim da vig\u00EAncia da oportunidade</value>
        [DataMember(Name="dataFimVigencia", EmitDefaultValue=false)]
        public string DataFimVigencia { get; set; }
    
        /// <summary>
        /// Atributo que indica se a oportunidade est\u00E1 ativa
        /// </summary>
        /// <value>Atributo que indica se a oportunidade est\u00E1 ativa</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Lista de detalhes
        /// </summary>
        /// <value>Lista de detalhes</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<DetalheOportunidadePersist> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OportunidadePersist {\n");
            sb.Append("  IdTipoOportunidade: ").Append(IdTipoOportunidade).Append("\n");
            sb.Append("  IdStatusOportunidade: ").Append(IdStatusOportunidade).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataInicioVigencia: ").Append(DataInicioVigencia).Append("\n");
            sb.Append("  DataFimVigencia: ").Append(DataFimVigencia).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as OportunidadePersist);
        }

        /// <summary>
        /// Returns true if OportunidadePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of OportunidadePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OportunidadePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoOportunidade == other.IdTipoOportunidade ||
                    this.IdTipoOportunidade != null &&
                    this.IdTipoOportunidade.Equals(other.IdTipoOportunidade)
                ) && 
                (
                    this.IdStatusOportunidade == other.IdStatusOportunidade ||
                    this.IdStatusOportunidade != null &&
                    this.IdStatusOportunidade.Equals(other.IdStatusOportunidade)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.DataInicioVigencia == other.DataInicioVigencia ||
                    this.DataInicioVigencia != null &&
                    this.DataInicioVigencia.Equals(other.DataInicioVigencia)
                ) && 
                (
                    this.DataFimVigencia == other.DataFimVigencia ||
                    this.DataFimVigencia != null &&
                    this.DataFimVigencia.Equals(other.DataFimVigencia)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdTipoOportunidade != null)
                    hash = hash * 59 + this.IdTipoOportunidade.GetHashCode();
                
                if (this.IdStatusOportunidade != null)
                    hash = hash * 59 + this.IdStatusOportunidade.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.DataInicioVigencia != null)
                    hash = hash * 59 + this.DataInicioVigencia.GetHashCode();
                
                if (this.DataFimVigencia != null)
                    hash = hash * 59 + this.DataFimVigencia.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
