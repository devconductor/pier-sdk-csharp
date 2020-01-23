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
    /// Objecto de resposta de um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class ParametroAcumuladorContaOperacaoResponse :  IEquatable<ParametroAcumuladorContaOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroAcumuladorContaOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ParametroAcumuladorContaOperacaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">C\u00F3digo de identifica\u00E7\u00E3o da conta.</param>
        /// <param name="IdOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o.</param>
        /// <param name="QtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia.</param>
        /// <param name="QtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana.</param>
        /// <param name="QtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs.</param>
        /// <param name="ValorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC).</param>

        public ParametroAcumuladorContaOperacaoResponse(long? IdConta = null, long? IdOperacao = null, int? QtdOperacoesGratuitasDia = null, int? QtdOperacoesGratuitasSemana = null, int? QtdOperacoesGratuitasMes = null, double? ValorTAC = null)
        {
            this.IdConta = IdConta;
            this.IdOperacao = IdOperacao;
            this.QtdOperacoesGratuitasDia = QtdOperacoesGratuitasDia;
            this.QtdOperacoesGratuitasSemana = QtdOperacoesGratuitasSemana;
            this.QtdOperacoesGratuitasMes = QtdOperacoesGratuitasMes;
            this.ValorTAC = ValorTAC;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da conta
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia</value>
        [DataMember(Name="qtdOperacoesGratuitasDia", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasDia { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana</value>
        [DataMember(Name="qtdOperacoesGratuitasSemana", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasSemana { get; set; }
    
        /// <summary>
        /// Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs
        /// </summary>
        /// <value>Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs</value>
        [DataMember(Name="qtdOperacoesGratuitasMes", EmitDefaultValue=false)]
        public int? QtdOperacoesGratuitasMes { get; set; }
    
        /// <summary>
        /// Valor da taxa de abertura de cr\u00E9dito (TAC)
        /// </summary>
        /// <value>Valor da taxa de abertura de cr\u00E9dito (TAC)</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroAcumuladorContaOperacaoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  QtdOperacoesGratuitasDia: ").Append(QtdOperacoesGratuitasDia).Append("\n");
            sb.Append("  QtdOperacoesGratuitasSemana: ").Append(QtdOperacoesGratuitasSemana).Append("\n");
            sb.Append("  QtdOperacoesGratuitasMes: ").Append(QtdOperacoesGratuitasMes).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            
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
            return this.Equals(obj as ParametroAcumuladorContaOperacaoResponse);
        }

        /// <summary>
        /// Returns true if ParametroAcumuladorContaOperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroAcumuladorContaOperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroAcumuladorContaOperacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.QtdOperacoesGratuitasDia == other.QtdOperacoesGratuitasDia ||
                    this.QtdOperacoesGratuitasDia != null &&
                    this.QtdOperacoesGratuitasDia.Equals(other.QtdOperacoesGratuitasDia)
                ) && 
                (
                    this.QtdOperacoesGratuitasSemana == other.QtdOperacoesGratuitasSemana ||
                    this.QtdOperacoesGratuitasSemana != null &&
                    this.QtdOperacoesGratuitasSemana.Equals(other.QtdOperacoesGratuitasSemana)
                ) && 
                (
                    this.QtdOperacoesGratuitasMes == other.QtdOperacoesGratuitasMes ||
                    this.QtdOperacoesGratuitasMes != null &&
                    this.QtdOperacoesGratuitasMes.Equals(other.QtdOperacoesGratuitasMes)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.QtdOperacoesGratuitasDia != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasDia.GetHashCode();
                
                if (this.QtdOperacoesGratuitasSemana != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasSemana.GetHashCode();
                
                if (this.QtdOperacoesGratuitasMes != null)
                    hash = hash * 59 + this.QtdOperacoesGratuitasMes.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                return hash;
            }
        }

    }
}
