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
    /// {{{historico_pagamento_response_description}}}
    /// </summary>
    [DataContract]
    public partial class HistoricoPagamentoResponse :  IEquatable<HistoricoPagamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoPagamentoResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{historico_pagamento_response_id_conta_value}}}.</param>
        /// <param name="IdPagamento">{{{historico_pagamento_response_id_pagamento_value}}}.</param>
        /// <param name="IdEstabelecimento">{{{historico_pagamento_response_id_estabelecimento_value}}}.</param>
        /// <param name="IdBanco">{{{historico_pagamento_response_id_banco_value}}}.</param>
        /// <param name="IdCartao">{{{historico_pagamento_response_id_cartao_value}}}.</param>
        /// <param name="ValorPagamento">{{{historico_pagamento_response_valor_pagamento_value}}}.</param>
        /// <param name="DataHoraPagamento">{{{historico_pagamento_response_data_hora_pagamento_value}}}.</param>
        /// <param name="DataHoraEntradaPagamento">{{{historico_pagamento_response_data_hora_entrada_pagamento_value}}}.</param>
        /// <param name="Status">{{{historico_pagamento_response_status_value}}}.</param>

        public HistoricoPagamentoResponse(long? IdConta = null, long? IdPagamento = null, long? IdEstabelecimento = null, long? IdBanco = null, long? IdCartao = null, double? ValorPagamento = null, string DataHoraPagamento = null, string DataHoraEntradaPagamento = null, long? Status = null)
        {
            this.IdConta = IdConta;
            this.IdPagamento = IdPagamento;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdBanco = IdBanco;
            this.IdCartao = IdCartao;
            this.ValorPagamento = ValorPagamento;
            this.DataHoraPagamento = DataHoraPagamento;
            this.DataHoraEntradaPagamento = DataHoraEntradaPagamento;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// {{{historico_pagamento_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_id_pagamento_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_id_pagamento_value}}}</value>
        [DataMember(Name="idPagamento", EmitDefaultValue=false)]
        public long? IdPagamento { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_id_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_id_estabelecimento_value}}}</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_id_banco_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_id_banco_value}}}</value>
        [DataMember(Name="idBanco", EmitDefaultValue=false)]
        public long? IdBanco { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_valor_pagamento_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_valor_pagamento_value}}}</value>
        [DataMember(Name="valorPagamento", EmitDefaultValue=false)]
        public double? ValorPagamento { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_data_hora_pagamento_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_data_hora_pagamento_value}}}</value>
        [DataMember(Name="dataHoraPagamento", EmitDefaultValue=false)]
        public string DataHoraPagamento { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_data_hora_entrada_pagamento_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_data_hora_entrada_pagamento_value}}}</value>
        [DataMember(Name="dataHoraEntradaPagamento", EmitDefaultValue=false)]
        public string DataHoraEntradaPagamento { get; set; }
    
        /// <summary>
        /// {{{historico_pagamento_response_status_value}}}
        /// </summary>
        /// <value>{{{historico_pagamento_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoPagamentoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPagamento: ").Append(IdPagamento).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdBanco: ").Append(IdBanco).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  ValorPagamento: ").Append(ValorPagamento).Append("\n");
            sb.Append("  DataHoraPagamento: ").Append(DataHoraPagamento).Append("\n");
            sb.Append("  DataHoraEntradaPagamento: ").Append(DataHoraEntradaPagamento).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as HistoricoPagamentoResponse);
        }

        /// <summary>
        /// Returns true if HistoricoPagamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoPagamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoPagamentoResponse other)
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
                    this.IdPagamento == other.IdPagamento ||
                    this.IdPagamento != null &&
                    this.IdPagamento.Equals(other.IdPagamento)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdBanco == other.IdBanco ||
                    this.IdBanco != null &&
                    this.IdBanco.Equals(other.IdBanco)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.ValorPagamento == other.ValorPagamento ||
                    this.ValorPagamento != null &&
                    this.ValorPagamento.Equals(other.ValorPagamento)
                ) && 
                (
                    this.DataHoraPagamento == other.DataHoraPagamento ||
                    this.DataHoraPagamento != null &&
                    this.DataHoraPagamento.Equals(other.DataHoraPagamento)
                ) && 
                (
                    this.DataHoraEntradaPagamento == other.DataHoraEntradaPagamento ||
                    this.DataHoraEntradaPagamento != null &&
                    this.DataHoraEntradaPagamento.Equals(other.DataHoraEntradaPagamento)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdPagamento != null)
                    hash = hash * 59 + this.IdPagamento.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdBanco != null)
                    hash = hash * 59 + this.IdBanco.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.ValorPagamento != null)
                    hash = hash * 59 + this.ValorPagamento.GetHashCode();
                
                if (this.DataHoraPagamento != null)
                    hash = hash * 59 + this.DataHoraPagamento.GetHashCode();
                
                if (this.DataHoraEntradaPagamento != null)
                    hash = hash * 59 + this.DataHoraEntradaPagamento.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
