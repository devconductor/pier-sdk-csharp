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
    /// Representa\u00E7\u00E3o com os par\u00E2mentros necess\u00E1rios para envio de Boleto por email
    /// </summary>
    [DataContract]
    public partial class BoletoEmailRequest :  IEquatable<BoletoEmailRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoletoEmailRequest" /> class.
        /// Initializes a new instance of the <see cref="BoletoEmailRequest" />class.
        /// </summary>
        /// <param name="Email">Email para envio do boleto.</param>
        /// <param name="IdTemplateNotificacao">Identifica\u00E7\u00E3o do template de notifica\u00E7\u00E3o.</param>
        /// <param name="Parametros">Mapa de par\u00E2metros utilizados na cria\u00E7\u00E3o do template do email.</param>

        public BoletoEmailRequest(string Email = null, long? IdTemplateNotificacao = null, Object Parametros = null)
        {
            this.Email = Email;
            this.IdTemplateNotificacao = IdTemplateNotificacao;
            this.Parametros = Parametros;
            
        }
        
    
        /// <summary>
        /// Email para envio do boleto
        /// </summary>
        /// <value>Email para envio do boleto</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o do template de notifica\u00E7\u00E3o
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o do template de notifica\u00E7\u00E3o</value>
        [DataMember(Name="idTemplateNotificacao", EmitDefaultValue=false)]
        public long? IdTemplateNotificacao { get; set; }
    
        /// <summary>
        /// Mapa de par\u00E2metros utilizados na cria\u00E7\u00E3o do template do email
        /// </summary>
        /// <value>Mapa de par\u00E2metros utilizados na cria\u00E7\u00E3o do template do email</value>
        [DataMember(Name="parametros", EmitDefaultValue=false)]
        public Object Parametros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoletoEmailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdTemplateNotificacao: ").Append(IdTemplateNotificacao).Append("\n");
            sb.Append("  Parametros: ").Append(Parametros).Append("\n");
            
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
            return this.Equals(obj as BoletoEmailRequest);
        }

        /// <summary>
        /// Returns true if BoletoEmailRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BoletoEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoletoEmailRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.IdTemplateNotificacao == other.IdTemplateNotificacao ||
                    this.IdTemplateNotificacao != null &&
                    this.IdTemplateNotificacao.Equals(other.IdTemplateNotificacao)
                ) && 
                (
                    this.Parametros == other.Parametros ||
                    this.Parametros != null &&
                    this.Parametros.Equals(other.Parametros)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.IdTemplateNotificacao != null)
                    hash = hash * 59 + this.IdTemplateNotificacao.GetHashCode();
                
                if (this.Parametros != null)
                    hash = hash * 59 + this.Parametros.GetHashCode();
                
                return hash;
            }
        }

    }
}
