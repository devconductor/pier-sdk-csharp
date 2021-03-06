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
    /// Objeto Configura\u00E7\u00E3o EMAIL
    /// </summary>
    [DataContract]
    public partial class ConfiguracaoEmailResponse :  IEquatable<ConfiguracaoEmailResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracaoEmailResponse" /> class.
        /// Initializes a new instance of the <see cref="ConfiguracaoEmailResponse" />class.
        /// </summary>
        /// <param name="Id">Id da Configura\u00E7\u00E3o EMAIL.</param>
        /// <param name="Host">IP (Host) do servidor de e-mail.</param>
        /// <param name="Port">Porta usada pelo servidor de e-mail.</param>
        /// <param name="PortTLSSTARTTLS">Porta usada pelo servi\u00E7o TLS/STARTTLS.</param>
        /// <param name="PortSSL">Porta usada pelo servi\u00E7o SSL.</param>
        /// <param name="Protocolo">Protocolo de comunica\u00E7\u00E3o usado pelo servi\u00E7o de e-mail (Ex: smtp).</param>
        /// <param name="RequerAutenticacao">O servi\u00E7o de e-mail requer autentica\u00E7\u00E3o.</param>
        /// <param name="RequerSSL">O servi\u00E7o de e-mail requer SSL.</param>
        /// <param name="RequerTLS">O servi\u00E7o de e-mail requer TLS.</param>
        /// <param name="Usuario">Usuario do servi\u00E7o de e-mail.</param>
        /// <param name="Senha">Senha de usu\u00E1rio do servi\u00E7o de e-mail.</param>
        /// <param name="DataInclusao">Data de inclus\u00E3o.</param>
        /// <param name="DataAlteracao">Data de altera\u00E7\u00E3o.</param>

        public ConfiguracaoEmailResponse(long? Id = null, string Host = null, string Port = null, string PortTLSSTARTTLS = null, string PortSSL = null, string Protocolo = null, bool? RequerAutenticacao = null, bool? RequerSSL = null, bool? RequerTLS = null, string Usuario = null, string Senha = null, string DataInclusao = null, string DataAlteracao = null)
        {
            this.Id = Id;
            this.Host = Host;
            this.Port = Port;
            this.PortTLSSTARTTLS = PortTLSSTARTTLS;
            this.PortSSL = PortSSL;
            this.Protocolo = Protocolo;
            this.RequerAutenticacao = RequerAutenticacao;
            this.RequerSSL = RequerSSL;
            this.RequerTLS = RequerTLS;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.DataInclusao = DataInclusao;
            this.DataAlteracao = DataAlteracao;
            
        }
        
    
        /// <summary>
        /// Id da Configura\u00E7\u00E3o EMAIL
        /// </summary>
        /// <value>Id da Configura\u00E7\u00E3o EMAIL</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// IP (Host) do servidor de e-mail
        /// </summary>
        /// <value>IP (Host) do servidor de e-mail</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }
    
        /// <summary>
        /// Porta usada pelo servidor de e-mail
        /// </summary>
        /// <value>Porta usada pelo servidor de e-mail</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public string Port { get; set; }
    
        /// <summary>
        /// Porta usada pelo servi\u00E7o TLS/STARTTLS
        /// </summary>
        /// <value>Porta usada pelo servi\u00E7o TLS/STARTTLS</value>
        [DataMember(Name="portTLSSTARTTLS", EmitDefaultValue=false)]
        public string PortTLSSTARTTLS { get; set; }
    
        /// <summary>
        /// Porta usada pelo servi\u00E7o SSL
        /// </summary>
        /// <value>Porta usada pelo servi\u00E7o SSL</value>
        [DataMember(Name="portSSL", EmitDefaultValue=false)]
        public string PortSSL { get; set; }
    
        /// <summary>
        /// Protocolo de comunica\u00E7\u00E3o usado pelo servi\u00E7o de e-mail (Ex: smtp)
        /// </summary>
        /// <value>Protocolo de comunica\u00E7\u00E3o usado pelo servi\u00E7o de e-mail (Ex: smtp)</value>
        [DataMember(Name="protocolo", EmitDefaultValue=false)]
        public string Protocolo { get; set; }
    
        /// <summary>
        /// O servi\u00E7o de e-mail requer autentica\u00E7\u00E3o
        /// </summary>
        /// <value>O servi\u00E7o de e-mail requer autentica\u00E7\u00E3o</value>
        [DataMember(Name="requerAutenticacao", EmitDefaultValue=false)]
        public bool? RequerAutenticacao { get; set; }
    
        /// <summary>
        /// O servi\u00E7o de e-mail requer SSL
        /// </summary>
        /// <value>O servi\u00E7o de e-mail requer SSL</value>
        [DataMember(Name="requerSSL", EmitDefaultValue=false)]
        public bool? RequerSSL { get; set; }
    
        /// <summary>
        /// O servi\u00E7o de e-mail requer TLS
        /// </summary>
        /// <value>O servi\u00E7o de e-mail requer TLS</value>
        [DataMember(Name="requerTLS", EmitDefaultValue=false)]
        public bool? RequerTLS { get; set; }
    
        /// <summary>
        /// Usuario do servi\u00E7o de e-mail
        /// </summary>
        /// <value>Usuario do servi\u00E7o de e-mail</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Senha de usu\u00E1rio do servi\u00E7o de e-mail
        /// </summary>
        /// <value>Senha de usu\u00E1rio do servi\u00E7o de e-mail</value>
        [DataMember(Name="senha", EmitDefaultValue=false)]
        public string Senha { get; set; }
    
        /// <summary>
        /// Data de inclus\u00E3o
        /// </summary>
        /// <value>Data de inclus\u00E3o</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Data de altera\u00E7\u00E3o
        /// </summary>
        /// <value>Data de altera\u00E7\u00E3o</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfiguracaoEmailResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PortTLSSTARTTLS: ").Append(PortTLSSTARTTLS).Append("\n");
            sb.Append("  PortSSL: ").Append(PortSSL).Append("\n");
            sb.Append("  Protocolo: ").Append(Protocolo).Append("\n");
            sb.Append("  RequerAutenticacao: ").Append(RequerAutenticacao).Append("\n");
            sb.Append("  RequerSSL: ").Append(RequerSSL).Append("\n");
            sb.Append("  RequerTLS: ").Append(RequerTLS).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  Senha: ").Append(Senha).Append("\n");
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
            return this.Equals(obj as ConfiguracaoEmailResponse);
        }

        /// <summary>
        /// Returns true if ConfiguracaoEmailResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfiguracaoEmailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfiguracaoEmailResponse other)
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
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.PortTLSSTARTTLS == other.PortTLSSTARTTLS ||
                    this.PortTLSSTARTTLS != null &&
                    this.PortTLSSTARTTLS.Equals(other.PortTLSSTARTTLS)
                ) && 
                (
                    this.PortSSL == other.PortSSL ||
                    this.PortSSL != null &&
                    this.PortSSL.Equals(other.PortSSL)
                ) && 
                (
                    this.Protocolo == other.Protocolo ||
                    this.Protocolo != null &&
                    this.Protocolo.Equals(other.Protocolo)
                ) && 
                (
                    this.RequerAutenticacao == other.RequerAutenticacao ||
                    this.RequerAutenticacao != null &&
                    this.RequerAutenticacao.Equals(other.RequerAutenticacao)
                ) && 
                (
                    this.RequerSSL == other.RequerSSL ||
                    this.RequerSSL != null &&
                    this.RequerSSL.Equals(other.RequerSSL)
                ) && 
                (
                    this.RequerTLS == other.RequerTLS ||
                    this.RequerTLS != null &&
                    this.RequerTLS.Equals(other.RequerTLS)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
                ) && 
                (
                    this.Senha == other.Senha ||
                    this.Senha != null &&
                    this.Senha.Equals(other.Senha)
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
                
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                
                if (this.PortTLSSTARTTLS != null)
                    hash = hash * 59 + this.PortTLSSTARTTLS.GetHashCode();
                
                if (this.PortSSL != null)
                    hash = hash * 59 + this.PortSSL.GetHashCode();
                
                if (this.Protocolo != null)
                    hash = hash * 59 + this.Protocolo.GetHashCode();
                
                if (this.RequerAutenticacao != null)
                    hash = hash * 59 + this.RequerAutenticacao.GetHashCode();
                
                if (this.RequerSSL != null)
                    hash = hash * 59 + this.RequerSSL.GetHashCode();
                
                if (this.RequerTLS != null)
                    hash = hash * 59 + this.RequerTLS.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                if (this.Senha != null)
                    hash = hash * 59 + this.Senha.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
