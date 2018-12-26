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
    /// {{{conta_bancaria_portador_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ContaBancariaPortadorResponse :  IEquatable<ContaBancariaPortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaBancariaPortadorResponse" />class.
        /// </summary>
        /// <param name="Id">{{{conta_bancaria_portador_response_id_value}}}.</param>
        /// <param name="IdConta">{{{conta_bancaria_portador_response_id_conta_value}}}.</param>
        /// <param name="NomeAgencia">{{{conta_bancaria_portador_response_nome_agencia_value}}}.</param>
        /// <param name="Banco">{{{conta_bancaria_portador_response_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{conta_bancaria_portador_response_numero_agencia_value}}}.</param>
        /// <param name="DigitoAgencia">{{{conta_bancaria_portador_response_digito_agencia_value}}}.</param>
        /// <param name="NumeroConta">{{{conta_bancaria_portador_response_numero_conta_value}}}.</param>
        /// <param name="DigitoConta">{{{conta_bancaria_portador_response_digito_conta_value}}}.</param>
        /// <param name="FlagAtivo">{{{conta_bancaria_portador_response_flag_ativo_value}}}.</param>
        /// <param name="FlagContaOrigemDoc">{{{conta_bancaria_portador_response_flag_conta_origem_doc_value}}}.</param>
        /// <param name="IdPessoaFisica">{{{conta_bancaria_portador_response_id_pessoa_fisica_value}}}.</param>
        /// <param name="FlagContaPoupanca">{{{conta_bancaria_portador_response_flag_conta_poupanca_value}}}.</param>
        /// <param name="Favorecido">{{{conta_bancaria_portador_response_favorecido_value}}}.</param>
        /// <param name="NumeroReceiraFederal">{{{conta_bancaria_portador_response_numero_receira_federal_value}}}.</param>
        /// <param name="Titularidade">{{{conta_bancaria_portador_response_titularidade_value}}}.</param>

        public ContaBancariaPortadorResponse(long? Id = null, long? IdConta = null, string NomeAgencia = null, long? Banco = null, string NumeroAgencia = null, string DigitoAgencia = null, string NumeroConta = null, string DigitoConta = null, int? FlagAtivo = null, int? FlagContaOrigemDoc = null, long? IdPessoaFisica = null, int? FlagContaPoupanca = null, string Favorecido = null, string NumeroReceiraFederal = null, int? Titularidade = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.NomeAgencia = NomeAgencia;
            this.Banco = Banco;
            this.NumeroAgencia = NumeroAgencia;
            this.DigitoAgencia = DigitoAgencia;
            this.NumeroConta = NumeroConta;
            this.DigitoConta = DigitoConta;
            this.FlagAtivo = FlagAtivo;
            this.FlagContaOrigemDoc = FlagContaOrigemDoc;
            this.IdPessoaFisica = IdPessoaFisica;
            this.FlagContaPoupanca = FlagContaPoupanca;
            this.Favorecido = Favorecido;
            this.NumeroReceiraFederal = NumeroReceiraFederal;
            this.Titularidade = Titularidade;
            
        }
        
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_id_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_nome_agencia_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_nome_agencia_value}}}</value>
        [DataMember(Name="nomeAgencia", EmitDefaultValue=false)]
        public string NomeAgencia { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_banco_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_banco_value}}}</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public string NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_digito_agencia_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_digito_agencia_value}}}</value>
        [DataMember(Name="digitoAgencia", EmitDefaultValue=false)]
        public string DigitoAgencia { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_numero_conta_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_numero_conta_value}}}</value>
        [DataMember(Name="numeroConta", EmitDefaultValue=false)]
        public string NumeroConta { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_digito_conta_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_digito_conta_value}}}</value>
        [DataMember(Name="digitoConta", EmitDefaultValue=false)]
        public string DigitoConta { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_flag_conta_origem_doc_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_flag_conta_origem_doc_value}}}</value>
        [DataMember(Name="flagContaOrigemDoc", EmitDefaultValue=false)]
        public int? FlagContaOrigemDoc { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_id_pessoa_fisica_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_id_pessoa_fisica_value}}}</value>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public long? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_flag_conta_poupanca_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_flag_conta_poupanca_value}}}</value>
        [DataMember(Name="flagContaPoupanca", EmitDefaultValue=false)]
        public int? FlagContaPoupanca { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_favorecido_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_favorecido_value}}}</value>
        [DataMember(Name="favorecido", EmitDefaultValue=false)]
        public string Favorecido { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_numero_receira_federal_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_numero_receira_federal_value}}}</value>
        [DataMember(Name="numeroReceiraFederal", EmitDefaultValue=false)]
        public string NumeroReceiraFederal { get; set; }
    
        /// <summary>
        /// {{{conta_bancaria_portador_response_titularidade_value}}}
        /// </summary>
        /// <value>{{{conta_bancaria_portador_response_titularidade_value}}}</value>
        [DataMember(Name="titularidade", EmitDefaultValue=false)]
        public int? Titularidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaBancariaPortadorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NomeAgencia: ").Append(NomeAgencia).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  DigitoAgencia: ").Append(DigitoAgencia).Append("\n");
            sb.Append("  NumeroConta: ").Append(NumeroConta).Append("\n");
            sb.Append("  DigitoConta: ").Append(DigitoConta).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  FlagContaOrigemDoc: ").Append(FlagContaOrigemDoc).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  FlagContaPoupanca: ").Append(FlagContaPoupanca).Append("\n");
            sb.Append("  Favorecido: ").Append(Favorecido).Append("\n");
            sb.Append("  NumeroReceiraFederal: ").Append(NumeroReceiraFederal).Append("\n");
            sb.Append("  Titularidade: ").Append(Titularidade).Append("\n");
            
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
            return this.Equals(obj as ContaBancariaPortadorResponse);
        }

        /// <summary>
        /// Returns true if ContaBancariaPortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaBancariaPortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaBancariaPortadorResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.NomeAgencia == other.NomeAgencia ||
                    this.NomeAgencia != null &&
                    this.NomeAgencia.Equals(other.NomeAgencia)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.DigitoAgencia == other.DigitoAgencia ||
                    this.DigitoAgencia != null &&
                    this.DigitoAgencia.Equals(other.DigitoAgencia)
                ) && 
                (
                    this.NumeroConta == other.NumeroConta ||
                    this.NumeroConta != null &&
                    this.NumeroConta.Equals(other.NumeroConta)
                ) && 
                (
                    this.DigitoConta == other.DigitoConta ||
                    this.DigitoConta != null &&
                    this.DigitoConta.Equals(other.DigitoConta)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.FlagContaOrigemDoc == other.FlagContaOrigemDoc ||
                    this.FlagContaOrigemDoc != null &&
                    this.FlagContaOrigemDoc.Equals(other.FlagContaOrigemDoc)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.FlagContaPoupanca == other.FlagContaPoupanca ||
                    this.FlagContaPoupanca != null &&
                    this.FlagContaPoupanca.Equals(other.FlagContaPoupanca)
                ) && 
                (
                    this.Favorecido == other.Favorecido ||
                    this.Favorecido != null &&
                    this.Favorecido.Equals(other.Favorecido)
                ) && 
                (
                    this.NumeroReceiraFederal == other.NumeroReceiraFederal ||
                    this.NumeroReceiraFederal != null &&
                    this.NumeroReceiraFederal.Equals(other.NumeroReceiraFederal)
                ) && 
                (
                    this.Titularidade == other.Titularidade ||
                    this.Titularidade != null &&
                    this.Titularidade.Equals(other.Titularidade)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.NomeAgencia != null)
                    hash = hash * 59 + this.NomeAgencia.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.DigitoAgencia != null)
                    hash = hash * 59 + this.DigitoAgencia.GetHashCode();
                
                if (this.NumeroConta != null)
                    hash = hash * 59 + this.NumeroConta.GetHashCode();
                
                if (this.DigitoConta != null)
                    hash = hash * 59 + this.DigitoConta.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.FlagContaOrigemDoc != null)
                    hash = hash * 59 + this.FlagContaOrigemDoc.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.FlagContaPoupanca != null)
                    hash = hash * 59 + this.FlagContaPoupanca.GetHashCode();
                
                if (this.Favorecido != null)
                    hash = hash * 59 + this.Favorecido.GetHashCode();
                
                if (this.NumeroReceiraFederal != null)
                    hash = hash * 59 + this.NumeroReceiraFederal.GetHashCode();
                
                if (this.Titularidade != null)
                    hash = hash * 59 + this.Titularidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
