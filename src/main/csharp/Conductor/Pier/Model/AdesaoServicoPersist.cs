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
    /// {{{adesao_servico_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class AdesaoServicoPersist :  IEquatable<AdesaoServicoPersist>
    { 
    
        /// <summary>
        /// {{{adesao_servico_persistencia_tipo_sms_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_tipo_sms_descricao}}}</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoSmsEnum {
            
            [EnumMember(Value = "CONTROLE")]
            Controle,
            
            [EnumMember(Value = "NOTIFICACAO")]
            Notificacao,
            
            [EnumMember(Value = "ALERTA")]
            Alerta
        }

    
        /// <summary>
        /// {{{adesao_servico_persistencia_tipo_sms_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_tipo_sms_descricao}}}</value>
        [DataMember(Name="tipoSms", EmitDefaultValue=false)]
        public TipoSmsEnum? TipoSms { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoServicoPersist" /> class.
        /// Initializes a new instance of the <see cref="AdesaoServicoPersist" />class.
        /// </summary>
        /// <param name="Canal">{{{adesao_servico_persistencia_canal_descricao}}}.</param>
        /// <param name="Estabelecimento">{{{adesao_servico_persistencia_estabelecimento_descricao}}}.</param>
        /// <param name="TipoEnvioFatura">{{{adesao_servico_persistencia_tipo_envio_fatura_descricao}}}.</param>
        /// <param name="TipoSms">{{{adesao_servico_persistencia_tipo_sms_descricao}}}.</param>
        /// <param name="CobrancaLimiteCredito">{{{adesao_servico_persistencia_cobranca_limite_credito_descricao}}}.</param>
        /// <param name="FlagPromocoes">{{{adesao_servico_persistencia_ofertas_promocoes_descricao}}}.</param>
        /// <param name="Responsavel">{{{adesao_servico_persistencia_responsavel_descricao}}}.</param>
        /// <param name="FlagTipoEnvioFatura">{{{adesao_servico_persistencia_ofertar_tipo_envio_fatura_descricao}}}.</param>
        /// <param name="FlagTipoSms">{{{adesao_servico_persistencia_ofertar_tipo_sms_descricao}}}.</param>
        /// <param name="FlagCobrancaLimiteCredito">{{{adesao_servico_persistencia_ofertar_cobranca_limite_credito_descricao}}}.</param>
        /// <param name="FlagOfertasPromocoes">{{{adesao_servico_persistencia_ofertar_ofertas_promocoes_descricao}}}.</param>

        public AdesaoServicoPersist(string Canal = null, int? Estabelecimento = null, int? TipoEnvioFatura = null, TipoSmsEnum? TipoSms = null, bool? CobrancaLimiteCredito = null, bool? FlagPromocoes = null, string Responsavel = null, bool? FlagTipoEnvioFatura = null, bool? FlagTipoSms = null, bool? FlagCobrancaLimiteCredito = null, bool? FlagOfertasPromocoes = null)
        {
            this.Canal = Canal;
            this.Estabelecimento = Estabelecimento;
            this.TipoEnvioFatura = TipoEnvioFatura;
            this.TipoSms = TipoSms;
            this.CobrancaLimiteCredito = CobrancaLimiteCredito;
            this.FlagPromocoes = FlagPromocoes;
            this.Responsavel = Responsavel;
            this.FlagTipoEnvioFatura = FlagTipoEnvioFatura;
            this.FlagTipoSms = FlagTipoSms;
            this.FlagCobrancaLimiteCredito = FlagCobrancaLimiteCredito;
            this.FlagOfertasPromocoes = FlagOfertasPromocoes;
            
        }
        
    
        /// <summary>
        /// {{{adesao_servico_persistencia_canal_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_canal_descricao}}}</value>
        [DataMember(Name="canal", EmitDefaultValue=false)]
        public string Canal { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_estabelecimento_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_estabelecimento_descricao}}}</value>
        [DataMember(Name="estabelecimento", EmitDefaultValue=false)]
        public int? Estabelecimento { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_tipo_envio_fatura_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_tipo_envio_fatura_descricao}}}</value>
        [DataMember(Name="tipoEnvioFatura", EmitDefaultValue=false)]
        public int? TipoEnvioFatura { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_cobranca_limite_credito_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_cobranca_limite_credito_descricao}}}</value>
        [DataMember(Name="cobrancaLimiteCredito", EmitDefaultValue=false)]
        public bool? CobrancaLimiteCredito { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_ofertas_promocoes_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_ofertas_promocoes_descricao}}}</value>
        [DataMember(Name="flagPromocoes", EmitDefaultValue=false)]
        public bool? FlagPromocoes { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_responsavel_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_responsavel_descricao}}}</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_ofertar_tipo_envio_fatura_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_ofertar_tipo_envio_fatura_descricao}}}</value>
        [DataMember(Name="flagTipoEnvioFatura", EmitDefaultValue=false)]
        public bool? FlagTipoEnvioFatura { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_ofertar_tipo_sms_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_ofertar_tipo_sms_descricao}}}</value>
        [DataMember(Name="flagTipoSms", EmitDefaultValue=false)]
        public bool? FlagTipoSms { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_ofertar_cobranca_limite_credito_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_ofertar_cobranca_limite_credito_descricao}}}</value>
        [DataMember(Name="flagCobrancaLimiteCredito", EmitDefaultValue=false)]
        public bool? FlagCobrancaLimiteCredito { get; set; }
    
        /// <summary>
        /// {{{adesao_servico_persistencia_ofertar_ofertas_promocoes_descricao}}}
        /// </summary>
        /// <value>{{{adesao_servico_persistencia_ofertar_ofertas_promocoes_descricao}}}</value>
        [DataMember(Name="flagOfertasPromocoes", EmitDefaultValue=false)]
        public bool? FlagOfertasPromocoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoServicoPersist {\n");
            sb.Append("  Canal: ").Append(Canal).Append("\n");
            sb.Append("  Estabelecimento: ").Append(Estabelecimento).Append("\n");
            sb.Append("  TipoEnvioFatura: ").Append(TipoEnvioFatura).Append("\n");
            sb.Append("  TipoSms: ").Append(TipoSms).Append("\n");
            sb.Append("  CobrancaLimiteCredito: ").Append(CobrancaLimiteCredito).Append("\n");
            sb.Append("  FlagPromocoes: ").Append(FlagPromocoes).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  FlagTipoEnvioFatura: ").Append(FlagTipoEnvioFatura).Append("\n");
            sb.Append("  FlagTipoSms: ").Append(FlagTipoSms).Append("\n");
            sb.Append("  FlagCobrancaLimiteCredito: ").Append(FlagCobrancaLimiteCredito).Append("\n");
            sb.Append("  FlagOfertasPromocoes: ").Append(FlagOfertasPromocoes).Append("\n");
            
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
            return this.Equals(obj as AdesaoServicoPersist);
        }

        /// <summary>
        /// Returns true if AdesaoServicoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoServicoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoServicoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Canal == other.Canal ||
                    this.Canal != null &&
                    this.Canal.Equals(other.Canal)
                ) && 
                (
                    this.Estabelecimento == other.Estabelecimento ||
                    this.Estabelecimento != null &&
                    this.Estabelecimento.Equals(other.Estabelecimento)
                ) && 
                (
                    this.TipoEnvioFatura == other.TipoEnvioFatura ||
                    this.TipoEnvioFatura != null &&
                    this.TipoEnvioFatura.Equals(other.TipoEnvioFatura)
                ) && 
                (
                    this.TipoSms == other.TipoSms ||
                    this.TipoSms != null &&
                    this.TipoSms.Equals(other.TipoSms)
                ) && 
                (
                    this.CobrancaLimiteCredito == other.CobrancaLimiteCredito ||
                    this.CobrancaLimiteCredito != null &&
                    this.CobrancaLimiteCredito.Equals(other.CobrancaLimiteCredito)
                ) && 
                (
                    this.FlagPromocoes == other.FlagPromocoes ||
                    this.FlagPromocoes != null &&
                    this.FlagPromocoes.Equals(other.FlagPromocoes)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.FlagTipoEnvioFatura == other.FlagTipoEnvioFatura ||
                    this.FlagTipoEnvioFatura != null &&
                    this.FlagTipoEnvioFatura.Equals(other.FlagTipoEnvioFatura)
                ) && 
                (
                    this.FlagTipoSms == other.FlagTipoSms ||
                    this.FlagTipoSms != null &&
                    this.FlagTipoSms.Equals(other.FlagTipoSms)
                ) && 
                (
                    this.FlagCobrancaLimiteCredito == other.FlagCobrancaLimiteCredito ||
                    this.FlagCobrancaLimiteCredito != null &&
                    this.FlagCobrancaLimiteCredito.Equals(other.FlagCobrancaLimiteCredito)
                ) && 
                (
                    this.FlagOfertasPromocoes == other.FlagOfertasPromocoes ||
                    this.FlagOfertasPromocoes != null &&
                    this.FlagOfertasPromocoes.Equals(other.FlagOfertasPromocoes)
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
                
                if (this.Canal != null)
                    hash = hash * 59 + this.Canal.GetHashCode();
                
                if (this.Estabelecimento != null)
                    hash = hash * 59 + this.Estabelecimento.GetHashCode();
                
                if (this.TipoEnvioFatura != null)
                    hash = hash * 59 + this.TipoEnvioFatura.GetHashCode();
                
                if (this.TipoSms != null)
                    hash = hash * 59 + this.TipoSms.GetHashCode();
                
                if (this.CobrancaLimiteCredito != null)
                    hash = hash * 59 + this.CobrancaLimiteCredito.GetHashCode();
                
                if (this.FlagPromocoes != null)
                    hash = hash * 59 + this.FlagPromocoes.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.FlagTipoEnvioFatura != null)
                    hash = hash * 59 + this.FlagTipoEnvioFatura.GetHashCode();
                
                if (this.FlagTipoSms != null)
                    hash = hash * 59 + this.FlagTipoSms.GetHashCode();
                
                if (this.FlagCobrancaLimiteCredito != null)
                    hash = hash * 59 + this.FlagCobrancaLimiteCredito.GetHashCode();
                
                if (this.FlagOfertasPromocoes != null)
                    hash = hash * 59 + this.FlagOfertasPromocoes.GetHashCode();
                
                return hash;
            }
        }

    }
}