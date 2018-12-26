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
    /// {{{cancelamento_transacao_on_us_request_description}}}
    /// </summary>
    [DataContract]
    public partial class CancelamentoTransacaoOnUsRequest :  IEquatable<CancelamentoTransacaoOnUsRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelamentoTransacaoOnUsRequest" /> class.
        /// Initializes a new instance of the <see cref="CancelamentoTransacaoOnUsRequest" />class.
        /// </summary>
        /// <param name="NsuAutorizacaoTransacaoCancelada">{{{cancelamento_transacao_on_us_request_nsu_autorizacao_transacao_cancelada_value}}} (required).</param>
        /// <param name="NsuOrigem">{{{transacao_on_us_request_nsu_origem_value}}} (required).</param>
        /// <param name="NsuOrigemTransacaoCancelada">{{{desfazimento_transacao_on_us_request_nsu_origem_transacao_cancelada_value}}} (required).</param>
        /// <param name="CodigoProcessamento">{{{transacao_on_us_request_codigo_processamento_value}}} (required).</param>
        /// <param name="DataHoraTransacaoCancelada">{{{desfazimento_transacao_on_us_request_data_hora_transacao_cancelada_value}}} (required).</param>
        /// <param name="ValorTransacao">{{{transacao_on_us_request_valor_transacao_value}}} (required).</param>
        /// <param name="NumeroRealCartao">{{{transacao_on_us_request_numero_real_cartao_value}}} (required).</param>
        /// <param name="DataValidadeCartao">{{{transacao_on_us_request_data_validade_cartao_value}}} (required).</param>
        /// <param name="NumeroEstabelecimento">{{{transacao_on_us_request_numero_estabelecimento_value}}} (required).</param>
        /// <param name="DataHoraTerminal">{{{transacao_on_us_request_data_hora_terminal_value}}} (required).</param>
        /// <param name="TerminalRequisitante">{{{transacao_on_us_request_terminal_requisitante_value}}} (required).</param>

        public CancelamentoTransacaoOnUsRequest(string NsuAutorizacaoTransacaoCancelada = null, string NsuOrigem = null, string NsuOrigemTransacaoCancelada = null, string CodigoProcessamento = null, string DataHoraTransacaoCancelada = null, double? ValorTransacao = null, string NumeroRealCartao = null, string DataValidadeCartao = null, long? NumeroEstabelecimento = null, string DataHoraTerminal = null, string TerminalRequisitante = null)
        {
            // to ensure "NsuAutorizacaoTransacaoCancelada" is required (not null)
            if (NsuAutorizacaoTransacaoCancelada == null)
            {
                throw new InvalidDataException("NsuAutorizacaoTransacaoCancelada is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NsuAutorizacaoTransacaoCancelada = NsuAutorizacaoTransacaoCancelada;
            }
            // to ensure "NsuOrigem" is required (not null)
            if (NsuOrigem == null)
            {
                throw new InvalidDataException("NsuOrigem is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NsuOrigem = NsuOrigem;
            }
            // to ensure "NsuOrigemTransacaoCancelada" is required (not null)
            if (NsuOrigemTransacaoCancelada == null)
            {
                throw new InvalidDataException("NsuOrigemTransacaoCancelada is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NsuOrigemTransacaoCancelada = NsuOrigemTransacaoCancelada;
            }
            // to ensure "CodigoProcessamento" is required (not null)
            if (CodigoProcessamento == null)
            {
                throw new InvalidDataException("CodigoProcessamento is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.CodigoProcessamento = CodigoProcessamento;
            }
            // to ensure "DataHoraTransacaoCancelada" is required (not null)
            if (DataHoraTransacaoCancelada == null)
            {
                throw new InvalidDataException("DataHoraTransacaoCancelada is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataHoraTransacaoCancelada = DataHoraTransacaoCancelada;
            }
            // to ensure "ValorTransacao" is required (not null)
            if (ValorTransacao == null)
            {
                throw new InvalidDataException("ValorTransacao is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.ValorTransacao = ValorTransacao;
            }
            // to ensure "NumeroRealCartao" is required (not null)
            if (NumeroRealCartao == null)
            {
                throw new InvalidDataException("NumeroRealCartao is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroRealCartao = NumeroRealCartao;
            }
            // to ensure "DataValidadeCartao" is required (not null)
            if (DataValidadeCartao == null)
            {
                throw new InvalidDataException("DataValidadeCartao is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataValidadeCartao = DataValidadeCartao;
            }
            // to ensure "NumeroEstabelecimento" is required (not null)
            if (NumeroEstabelecimento == null)
            {
                throw new InvalidDataException("NumeroEstabelecimento is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.NumeroEstabelecimento = NumeroEstabelecimento;
            }
            // to ensure "DataHoraTerminal" is required (not null)
            if (DataHoraTerminal == null)
            {
                throw new InvalidDataException("DataHoraTerminal is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.DataHoraTerminal = DataHoraTerminal;
            }
            // to ensure "TerminalRequisitante" is required (not null)
            if (TerminalRequisitante == null)
            {
                throw new InvalidDataException("TerminalRequisitante is a required property for CancelamentoTransacaoOnUsRequest and cannot be null");
            }
            else
            {
                this.TerminalRequisitante = TerminalRequisitante;
            }
            
        }
        
    
        /// <summary>
        /// {{{cancelamento_transacao_on_us_request_nsu_autorizacao_transacao_cancelada_value}}}
        /// </summary>
        /// <value>{{{cancelamento_transacao_on_us_request_nsu_autorizacao_transacao_cancelada_value}}}</value>
        [DataMember(Name="nsuAutorizacaoTransacaoCancelada", EmitDefaultValue=false)]
        public string NsuAutorizacaoTransacaoCancelada { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_nsu_origem_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_nsu_origem_value}}}</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public string NsuOrigem { get; set; }
    
        /// <summary>
        /// {{{desfazimento_transacao_on_us_request_nsu_origem_transacao_cancelada_value}}}
        /// </summary>
        /// <value>{{{desfazimento_transacao_on_us_request_nsu_origem_transacao_cancelada_value}}}</value>
        [DataMember(Name="nsuOrigemTransacaoCancelada", EmitDefaultValue=false)]
        public string NsuOrigemTransacaoCancelada { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_codigo_processamento_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_codigo_processamento_value}}}</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// {{{desfazimento_transacao_on_us_request_data_hora_transacao_cancelada_value}}}
        /// </summary>
        /// <value>{{{desfazimento_transacao_on_us_request_data_hora_transacao_cancelada_value}}}</value>
        [DataMember(Name="dataHoraTransacaoCancelada", EmitDefaultValue=false)]
        public string DataHoraTransacaoCancelada { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_valor_transacao_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_valor_transacao_value}}}</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_numero_real_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_numero_real_cartao_value}}}</value>
        [DataMember(Name="numeroRealCartao", EmitDefaultValue=false)]
        public string NumeroRealCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_data_validade_cartao_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_data_validade_cartao_value}}}</value>
        [DataMember(Name="dataValidadeCartao", EmitDefaultValue=false)]
        public string DataValidadeCartao { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_numero_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_numero_estabelecimento_value}}}</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public long? NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_data_hora_terminal_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_data_hora_terminal_value}}}</value>
        [DataMember(Name="dataHoraTerminal", EmitDefaultValue=false)]
        public string DataHoraTerminal { get; set; }
    
        /// <summary>
        /// {{{transacao_on_us_request_terminal_requisitante_value}}}
        /// </summary>
        /// <value>{{{transacao_on_us_request_terminal_requisitante_value}}}</value>
        [DataMember(Name="terminalRequisitante", EmitDefaultValue=false)]
        public string TerminalRequisitante { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelamentoTransacaoOnUsRequest {\n");
            sb.Append("  NsuAutorizacaoTransacaoCancelada: ").Append(NsuAutorizacaoTransacaoCancelada).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  NsuOrigemTransacaoCancelada: ").Append(NsuOrigemTransacaoCancelada).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  DataHoraTransacaoCancelada: ").Append(DataHoraTransacaoCancelada).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  NumeroRealCartao: ").Append(NumeroRealCartao).Append("\n");
            sb.Append("  DataValidadeCartao: ").Append(DataValidadeCartao).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  DataHoraTerminal: ").Append(DataHoraTerminal).Append("\n");
            sb.Append("  TerminalRequisitante: ").Append(TerminalRequisitante).Append("\n");
            
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
            return this.Equals(obj as CancelamentoTransacaoOnUsRequest);
        }

        /// <summary>
        /// Returns true if CancelamentoTransacaoOnUsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelamentoTransacaoOnUsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelamentoTransacaoOnUsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NsuAutorizacaoTransacaoCancelada == other.NsuAutorizacaoTransacaoCancelada ||
                    this.NsuAutorizacaoTransacaoCancelada != null &&
                    this.NsuAutorizacaoTransacaoCancelada.Equals(other.NsuAutorizacaoTransacaoCancelada)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.NsuOrigemTransacaoCancelada == other.NsuOrigemTransacaoCancelada ||
                    this.NsuOrigemTransacaoCancelada != null &&
                    this.NsuOrigemTransacaoCancelada.Equals(other.NsuOrigemTransacaoCancelada)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.DataHoraTransacaoCancelada == other.DataHoraTransacaoCancelada ||
                    this.DataHoraTransacaoCancelada != null &&
                    this.DataHoraTransacaoCancelada.Equals(other.DataHoraTransacaoCancelada)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.NumeroRealCartao == other.NumeroRealCartao ||
                    this.NumeroRealCartao != null &&
                    this.NumeroRealCartao.Equals(other.NumeroRealCartao)
                ) && 
                (
                    this.DataValidadeCartao == other.DataValidadeCartao ||
                    this.DataValidadeCartao != null &&
                    this.DataValidadeCartao.Equals(other.DataValidadeCartao)
                ) && 
                (
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.DataHoraTerminal == other.DataHoraTerminal ||
                    this.DataHoraTerminal != null &&
                    this.DataHoraTerminal.Equals(other.DataHoraTerminal)
                ) && 
                (
                    this.TerminalRequisitante == other.TerminalRequisitante ||
                    this.TerminalRequisitante != null &&
                    this.TerminalRequisitante.Equals(other.TerminalRequisitante)
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
                
                if (this.NsuAutorizacaoTransacaoCancelada != null)
                    hash = hash * 59 + this.NsuAutorizacaoTransacaoCancelada.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.NsuOrigemTransacaoCancelada != null)
                    hash = hash * 59 + this.NsuOrigemTransacaoCancelada.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.DataHoraTransacaoCancelada != null)
                    hash = hash * 59 + this.DataHoraTransacaoCancelada.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.NumeroRealCartao != null)
                    hash = hash * 59 + this.NumeroRealCartao.GetHashCode();
                
                if (this.DataValidadeCartao != null)
                    hash = hash * 59 + this.DataValidadeCartao.GetHashCode();
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.DataHoraTerminal != null)
                    hash = hash * 59 + this.DataHoraTerminal.GetHashCode();
                
                if (this.TerminalRequisitante != null)
                    hash = hash * 59 + this.TerminalRequisitante.GetHashCode();
                
                return hash;
            }
        }

    }
}
