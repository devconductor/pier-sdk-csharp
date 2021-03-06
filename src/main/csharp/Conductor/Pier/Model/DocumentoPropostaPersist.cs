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
    /// Classe de representa\u00E7\u00E3o dos par\u00E2metros utilizados por um persist
    /// </summary>
    [DataContract]
    public partial class DocumentoPropostaPersist :  IEquatable<DocumentoPropostaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoPropostaPersist" /> class.
        /// Initializes a new instance of the <see cref="DocumentoPropostaPersist" />class.
        /// </summary>
        /// <param name="IdProposta">C\u00F3digo de identifica\u00E7\u00E3o da proposta(id) (required).</param>
        /// <param name="IdDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento (required).</param>
        /// <param name="IdStatusDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito (required).</param>
        /// <param name="IdCondicoesDocumentosCredito">C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito.</param>
        /// <param name="IdTipoDocumentoCredito">C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito.</param>
        /// <param name="IdPessoaFisica">C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica.</param>
        /// <param name="IdLogAtendimento">C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento.</param>
        /// <param name="Responsavel">Respons\u00E1vel (required).</param>
        /// <param name="FlagDocumentoDigitalizado">Indica se o documento ser\u00E1 digitalizado (required).</param>
        /// <param name="DocumentoDigitalizado">Nome do documento digitalizado.</param>
        /// <param name="SeqAnaliseCondicao">C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o.</param>
        /// <param name="Observacao">Observa\u00E7\u00E3o.</param>
        /// <param name="DataStatus">Data de status (required).</param>

        public DocumentoPropostaPersist(long? IdProposta = null, long? IdDocumentosCredito = null, long? IdStatusDocumentosCredito = null, long? IdCondicoesDocumentosCredito = null, long? IdTipoDocumentoCredito = null, long? IdPessoaFisica = null, long? IdLogAtendimento = null, string Responsavel = null, int? FlagDocumentoDigitalizado = null, string DocumentoDigitalizado = null, long? SeqAnaliseCondicao = null, string Observacao = null, string DataStatus = null)
        {
            // to ensure "IdProposta" is required (not null)
            if (IdProposta == null)
            {
                throw new InvalidDataException("IdProposta is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.IdProposta = IdProposta;
            }
            // to ensure "IdDocumentosCredito" is required (not null)
            if (IdDocumentosCredito == null)
            {
                throw new InvalidDataException("IdDocumentosCredito is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.IdDocumentosCredito = IdDocumentosCredito;
            }
            // to ensure "IdStatusDocumentosCredito" is required (not null)
            if (IdStatusDocumentosCredito == null)
            {
                throw new InvalidDataException("IdStatusDocumentosCredito is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.IdStatusDocumentosCredito = IdStatusDocumentosCredito;
            }
            // to ensure "Responsavel" is required (not null)
            if (Responsavel == null)
            {
                throw new InvalidDataException("Responsavel is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.Responsavel = Responsavel;
            }
            // to ensure "FlagDocumentoDigitalizado" is required (not null)
            if (FlagDocumentoDigitalizado == null)
            {
                throw new InvalidDataException("FlagDocumentoDigitalizado is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.FlagDocumentoDigitalizado = FlagDocumentoDigitalizado;
            }
            // to ensure "DataStatus" is required (not null)
            if (DataStatus == null)
            {
                throw new InvalidDataException("DataStatus is a required property for DocumentoPropostaPersist and cannot be null");
            }
            else
            {
                this.DataStatus = DataStatus;
            }
            this.IdCondicoesDocumentosCredito = IdCondicoesDocumentosCredito;
            this.IdTipoDocumentoCredito = IdTipoDocumentoCredito;
            this.IdPessoaFisica = IdPessoaFisica;
            this.IdLogAtendimento = IdLogAtendimento;
            this.DocumentoDigitalizado = DocumentoDigitalizado;
            this.SeqAnaliseCondicao = SeqAnaliseCondicao;
            this.Observacao = Observacao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da proposta(id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da proposta(id)</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o para o tipo do documento</value>
        [DataMember(Name="idDocumentosCredito", EmitDefaultValue=false)]
        public long? IdDocumentosCredito { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Status do documento cr\u00E9dito</value>
        [DataMember(Name="idStatusDocumentosCredito", EmitDefaultValue=false)]
        public long? IdStatusDocumentosCredito { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da condi\u00E7\u00E3o do documento cr\u00E9dito</value>
        [DataMember(Name="idCondicoesDocumentosCredito", EmitDefaultValue=false)]
        public long? IdCondicoesDocumentosCredito { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo do documento cr\u00E9dito</value>
        [DataMember(Name="idTipoDocumentoCredito", EmitDefaultValue=false)]
        public long? IdTipoDocumentoCredito { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da pessoa f\u00EDsica</value>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Log de Atendimento</value>
        [DataMember(Name="idLogAtendimento", EmitDefaultValue=false)]
        public long? IdLogAtendimento { get; set; }
    
        /// <summary>
        /// Respons\u00E1vel
        /// </summary>
        /// <value>Respons\u00E1vel</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// Indica se o documento ser\u00E1 digitalizado
        /// </summary>
        /// <value>Indica se o documento ser\u00E1 digitalizado</value>
        [DataMember(Name="flagDocumentoDigitalizado", EmitDefaultValue=false)]
        public int? FlagDocumentoDigitalizado { get; set; }
    
        /// <summary>
        /// Nome do documento digitalizado
        /// </summary>
        /// <value>Nome do documento digitalizado</value>
        [DataMember(Name="documentoDigitalizado", EmitDefaultValue=false)]
        public string DocumentoDigitalizado { get; set; }
    
        /// <summary>
        /// C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de sequ\u00EAncia de analise de condi\u00E7\u00E3o</value>
        [DataMember(Name="seqAnaliseCondicao", EmitDefaultValue=false)]
        public long? SeqAnaliseCondicao { get; set; }
    
        /// <summary>
        /// Observa\u00E7\u00E3o
        /// </summary>
        /// <value>Observa\u00E7\u00E3o</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Data de status
        /// </summary>
        /// <value>Data de status</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoPropostaPersist {\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdDocumentosCredito: ").Append(IdDocumentosCredito).Append("\n");
            sb.Append("  IdStatusDocumentosCredito: ").Append(IdStatusDocumentosCredito).Append("\n");
            sb.Append("  IdCondicoesDocumentosCredito: ").Append(IdCondicoesDocumentosCredito).Append("\n");
            sb.Append("  IdTipoDocumentoCredito: ").Append(IdTipoDocumentoCredito).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  IdLogAtendimento: ").Append(IdLogAtendimento).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  FlagDocumentoDigitalizado: ").Append(FlagDocumentoDigitalizado).Append("\n");
            sb.Append("  DocumentoDigitalizado: ").Append(DocumentoDigitalizado).Append("\n");
            sb.Append("  SeqAnaliseCondicao: ").Append(SeqAnaliseCondicao).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            
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
            return this.Equals(obj as DocumentoPropostaPersist);
        }

        /// <summary>
        /// Returns true if DocumentoPropostaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentoPropostaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoPropostaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdDocumentosCredito == other.IdDocumentosCredito ||
                    this.IdDocumentosCredito != null &&
                    this.IdDocumentosCredito.Equals(other.IdDocumentosCredito)
                ) && 
                (
                    this.IdStatusDocumentosCredito == other.IdStatusDocumentosCredito ||
                    this.IdStatusDocumentosCredito != null &&
                    this.IdStatusDocumentosCredito.Equals(other.IdStatusDocumentosCredito)
                ) && 
                (
                    this.IdCondicoesDocumentosCredito == other.IdCondicoesDocumentosCredito ||
                    this.IdCondicoesDocumentosCredito != null &&
                    this.IdCondicoesDocumentosCredito.Equals(other.IdCondicoesDocumentosCredito)
                ) && 
                (
                    this.IdTipoDocumentoCredito == other.IdTipoDocumentoCredito ||
                    this.IdTipoDocumentoCredito != null &&
                    this.IdTipoDocumentoCredito.Equals(other.IdTipoDocumentoCredito)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.IdLogAtendimento == other.IdLogAtendimento ||
                    this.IdLogAtendimento != null &&
                    this.IdLogAtendimento.Equals(other.IdLogAtendimento)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.FlagDocumentoDigitalizado == other.FlagDocumentoDigitalizado ||
                    this.FlagDocumentoDigitalizado != null &&
                    this.FlagDocumentoDigitalizado.Equals(other.FlagDocumentoDigitalizado)
                ) && 
                (
                    this.DocumentoDigitalizado == other.DocumentoDigitalizado ||
                    this.DocumentoDigitalizado != null &&
                    this.DocumentoDigitalizado.Equals(other.DocumentoDigitalizado)
                ) && 
                (
                    this.SeqAnaliseCondicao == other.SeqAnaliseCondicao ||
                    this.SeqAnaliseCondicao != null &&
                    this.SeqAnaliseCondicao.Equals(other.SeqAnaliseCondicao)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.DataStatus == other.DataStatus ||
                    this.DataStatus != null &&
                    this.DataStatus.Equals(other.DataStatus)
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
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdDocumentosCredito != null)
                    hash = hash * 59 + this.IdDocumentosCredito.GetHashCode();
                
                if (this.IdStatusDocumentosCredito != null)
                    hash = hash * 59 + this.IdStatusDocumentosCredito.GetHashCode();
                
                if (this.IdCondicoesDocumentosCredito != null)
                    hash = hash * 59 + this.IdCondicoesDocumentosCredito.GetHashCode();
                
                if (this.IdTipoDocumentoCredito != null)
                    hash = hash * 59 + this.IdTipoDocumentoCredito.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.IdLogAtendimento != null)
                    hash = hash * 59 + this.IdLogAtendimento.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.FlagDocumentoDigitalizado != null)
                    hash = hash * 59 + this.FlagDocumentoDigitalizado.GetHashCode();
                
                if (this.DocumentoDigitalizado != null)
                    hash = hash * 59 + this.DocumentoDigitalizado.GetHashCode();
                
                if (this.SeqAnaliseCondicao != null)
                    hash = hash * 59 + this.SeqAnaliseCondicao.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
