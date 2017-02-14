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
    /// Objeto Notifica\u00C3\u00A7\u00C3\u00A3o SMS
    /// </summary>
    [DataContract]
    public partial class NotificacaoSMSResponse :  IEquatable<NotificacaoSMSResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" /> class.
        /// Initializes a new instance of the <see cref="NotificacaoSMSResponse" />class.
        /// </summary>
        /// <param name="Protocolo">N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es.</param>
        /// <param name="Mensagem">Mensagem de resposta da solicita\u00C3\u00A7\u00C3\u00B5es de envio.</param>

        public NotificacaoSMSResponse(string Protocolo = null, string Mensagem = null)
        {
            this.Protocolo = Protocolo;
            this.Mensagem = Mensagem;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <value>N\u00C3\u00BAmero do protocolo de envio de notifica\u00C3\u00A7\u00C3\u00B5es</value>
        [DataMember(Name="protocolo", EmitDefaultValue=false)]
        public string Protocolo { get; set; }
    
        /// <summary>
        /// Mensagem de resposta da solicita\u00C3\u00A7\u00C3\u00B5es de envio
        /// </summary>
        /// <value>Mensagem de resposta da solicita\u00C3\u00A7\u00C3\u00B5es de envio</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificacaoSMSResponse {\n");
            sb.Append("  Protocolo: ").Append(Protocolo).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            
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
            return this.Equals(obj as NotificacaoSMSResponse);
        }

        /// <summary>
        /// Returns true if NotificacaoSMSResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificacaoSMSResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificacaoSMSResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Protocolo == other.Protocolo ||
                    this.Protocolo != null &&
                    this.Protocolo.Equals(other.Protocolo)
                ) && 
                (
                    this.Mensagem == other.Mensagem ||
                    this.Mensagem != null &&
                    this.Mensagem.Equals(other.Mensagem)
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
                
                if (this.Protocolo != null)
                    hash = hash * 59 + this.Protocolo.GetHashCode();
                
                if (this.Mensagem != null)
                    hash = hash * 59 + this.Mensagem.GetHashCode();
                
                return hash;
            }
        }

    }
}
