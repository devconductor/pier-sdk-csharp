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
    /// Objeto de persist\u00EAncia da opera\u00E7\u00E3o banc\u00E1ria
    /// </summary>
    [DataContract]
    public partial class OperacaoBancariaPersist :  IEquatable<OperacaoBancariaPersist>
    { 
    
        /// <summary>
        /// Status da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Status da opera\u00E7\u00E3o</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "NORMAL")]
            Normal,
            
            [EnumMember(Value = "CANCELADA")]
            Cancelada,
            
            [EnumMember(Value = "PROCESSADA")]
            Processada,
            
            [EnumMember(Value = "PENDENTE")]
            Pendente,
            
            [EnumMember(Value = "DESFEITA")]
            Desfeita,
            
            [EnumMember(Value = "ESTORNADA")]
            Estornada,
            
            [EnumMember(Value = "AGENDADA")]
            Agendada,
            
            [EnumMember(Value = "CANCELADA_SEM_SALDO")]
            CanceladaSemSaldo,
            
            [EnumMember(Value = "ESTORNO_INFOS_INCORRETAS")]
            EstornoInfosIncorretas,
            
            [EnumMember(Value = "ESTORNO_TED")]
            EstornoTed
        }

    
        /// <summary>
        /// Status da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Status da opera\u00E7\u00E3o</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperacaoBancariaPersist" /> class.
        /// Initializes a new instance of the <see cref="OperacaoBancariaPersist" />class.
        /// </summary>
        /// <param name="IdTipoOperacaoBancaria">C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria (required).</param>
        /// <param name="IdContaDestino">C\u00F3digo identificador da conta de destino.</param>
        /// <param name="IdCartaoOrigem">C\u00F3digo identificador do cart\u00E3o de origem.</param>
        /// <param name="IdCartaoDestino">C\u00F3digo identificador do cart\u00E3o de destino.</param>
        /// <param name="BancoPagador">N\u00FAmero do banco pagador.</param>
        /// <param name="AgenciaPagadora">N\u00FAmero da ag\u00EAncia pagadora.</param>
        /// <param name="ContaPagadora">N\u00FAmero da conta pagadora.</param>
        /// <param name="DvContaPagadora">D\u00EDgito verificador da conta do favorecido.</param>
        /// <param name="NomePagador">Nome do pagador.</param>
        /// <param name="CpfCnpjBeneficiario">CPF/CNPJ do benefici\u00E1rio.</param>
        /// <param name="IdEventoAjusteOrigem">Identificador evento origem.</param>
        /// <param name="IdEventoAjusteDestino">Identificador evento destino.</param>
        /// <param name="IdExterno">C\u00F3digo identificador de opera\u00E7\u00F5es externas.</param>
        /// <param name="CodigoIspb">C\u00F3digo ISPB do banco de destino.</param>
        /// <param name="ValorOperacao">Valor da opera\u00E7\u00E3o banc\u00E1ria (required).</param>
        /// <param name="ValorTarifa">Valor da tarifa cobrada pela opera\u00E7\u00E3o.</param>
        /// <param name="DataHoraOperacao">Data e hora da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="DataAgendamento">Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="DataRealizacao">Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="Status">Status da opera\u00E7\u00E3o.</param>
        /// <param name="IdDadosBancariosConta">Identificador da conta banc\u00E1ria (required).</param>
        /// <param name="IdOperacaoBancariaOriginal">Identificador da opera\u00E7\u00E3o banc\u00E1ria original.</param>
        /// <param name="Observacao">Observa\u00E7\u00E3o.</param>
        /// <param name="NumeroBilheteUnico">N\u00FAmero do bilhete \u00FAnico.</param>
        /// <param name="IdDocumento">Identificador do documento.</param>
        /// <param name="IdCelularRecarga">Identificador do celular.</param>
        /// <param name="NomeBeneficiario">Nome do benefici\u00E1rio envolvendo transfer\u00EAncias.</param>
        /// <param name="BancoBeneficiario">Origem do banco do benefici\u00E1rio envolvendo transfer\u00EAncias.</param>
        /// <param name="AgenciaBeneficiario">Origem da ag\u00EAncia do benefici\u00E1rio envolvendo transfer\u00EAncias.</param>
        /// <param name="ContaBeneficiario">Conta origem do benefici\u00E1rio envolvendo transfer\u00EAncias.</param>
        /// <param name="DvContaBeneficiario">D\u00EDgito da conta do benefici\u00E1rio origem envolvendo transfer\u00EAncias.</param>
        /// <param name="Operadora">Descri\u00E7\u00E3o da operadora do celular.</param>
        /// <param name="Celular">N\u00FAmero da operadora.</param>
        /// <param name="Ddd">DDD do celular.</param>

        public OperacaoBancariaPersist(long? IdTipoOperacaoBancaria = null, long? IdContaDestino = null, long? IdCartaoOrigem = null, long? IdCartaoDestino = null, string BancoPagador = null, string AgenciaPagadora = null, string ContaPagadora = null, string DvContaPagadora = null, string NomePagador = null, string CpfCnpjBeneficiario = null, long? IdEventoAjusteOrigem = null, long? IdEventoAjusteDestino = null, string IdExterno = null, string CodigoIspb = null, double? ValorOperacao = null, double? ValorTarifa = null, string DataHoraOperacao = null, string DataAgendamento = null, string DataRealizacao = null, StatusEnum? Status = null, long? IdDadosBancariosConta = null, long? IdOperacaoBancariaOriginal = null, string Observacao = null, long? NumeroBilheteUnico = null, long? IdDocumento = null, long? IdCelularRecarga = null, string NomeBeneficiario = null, string BancoBeneficiario = null, string AgenciaBeneficiario = null, string ContaBeneficiario = null, string DvContaBeneficiario = null, string Operadora = null, string Celular = null, string Ddd = null)
        {
            // to ensure "IdTipoOperacaoBancaria" is required (not null)
            if (IdTipoOperacaoBancaria == null)
            {
                throw new InvalidDataException("IdTipoOperacaoBancaria is a required property for OperacaoBancariaPersist and cannot be null");
            }
            else
            {
                this.IdTipoOperacaoBancaria = IdTipoOperacaoBancaria;
            }
            // to ensure "ValorOperacao" is required (not null)
            if (ValorOperacao == null)
            {
                throw new InvalidDataException("ValorOperacao is a required property for OperacaoBancariaPersist and cannot be null");
            }
            else
            {
                this.ValorOperacao = ValorOperacao;
            }
            // to ensure "IdDadosBancariosConta" is required (not null)
            if (IdDadosBancariosConta == null)
            {
                throw new InvalidDataException("IdDadosBancariosConta is a required property for OperacaoBancariaPersist and cannot be null");
            }
            else
            {
                this.IdDadosBancariosConta = IdDadosBancariosConta;
            }
            this.IdContaDestino = IdContaDestino;
            this.IdCartaoOrigem = IdCartaoOrigem;
            this.IdCartaoDestino = IdCartaoDestino;
            this.BancoPagador = BancoPagador;
            this.AgenciaPagadora = AgenciaPagadora;
            this.ContaPagadora = ContaPagadora;
            this.DvContaPagadora = DvContaPagadora;
            this.NomePagador = NomePagador;
            this.CpfCnpjBeneficiario = CpfCnpjBeneficiario;
            this.IdEventoAjusteOrigem = IdEventoAjusteOrigem;
            this.IdEventoAjusteDestino = IdEventoAjusteDestino;
            this.IdExterno = IdExterno;
            this.CodigoIspb = CodigoIspb;
            this.ValorTarifa = ValorTarifa;
            this.DataHoraOperacao = DataHoraOperacao;
            this.DataAgendamento = DataAgendamento;
            this.DataRealizacao = DataRealizacao;
            this.Status = Status;
            this.IdOperacaoBancariaOriginal = IdOperacaoBancariaOriginal;
            this.Observacao = Observacao;
            this.NumeroBilheteUnico = NumeroBilheteUnico;
            this.IdDocumento = IdDocumento;
            this.IdCelularRecarga = IdCelularRecarga;
            this.NomeBeneficiario = NomeBeneficiario;
            this.BancoBeneficiario = BancoBeneficiario;
            this.AgenciaBeneficiario = AgenciaBeneficiario;
            this.ContaBeneficiario = ContaBeneficiario;
            this.DvContaBeneficiario = DvContaBeneficiario;
            this.Operadora = Operadora;
            this.Celular = Celular;
            this.Ddd = Ddd;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="idTipoOperacaoBancaria", EmitDefaultValue=false)]
        public long? IdTipoOperacaoBancaria { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta de destino
        /// </summary>
        /// <value>C\u00F3digo identificador da conta de destino</value>
        [DataMember(Name="idContaDestino", EmitDefaultValue=false)]
        public long? IdContaDestino { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do cart\u00E3o de origem
        /// </summary>
        /// <value>C\u00F3digo identificador do cart\u00E3o de origem</value>
        [DataMember(Name="idCartaoOrigem", EmitDefaultValue=false)]
        public long? IdCartaoOrigem { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do cart\u00E3o de destino
        /// </summary>
        /// <value>C\u00F3digo identificador do cart\u00E3o de destino</value>
        [DataMember(Name="idCartaoDestino", EmitDefaultValue=false)]
        public long? IdCartaoDestino { get; set; }
    
        /// <summary>
        /// N\u00FAmero do banco pagador
        /// </summary>
        /// <value>N\u00FAmero do banco pagador</value>
        [DataMember(Name="bancoPagador", EmitDefaultValue=false)]
        public string BancoPagador { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia pagadora
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia pagadora</value>
        [DataMember(Name="agenciaPagadora", EmitDefaultValue=false)]
        public string AgenciaPagadora { get; set; }
    
        /// <summary>
        /// N\u00FAmero da conta pagadora
        /// </summary>
        /// <value>N\u00FAmero da conta pagadora</value>
        [DataMember(Name="contaPagadora", EmitDefaultValue=false)]
        public string ContaPagadora { get; set; }
    
        /// <summary>
        /// D\u00EDgito verificador da conta do favorecido
        /// </summary>
        /// <value>D\u00EDgito verificador da conta do favorecido</value>
        [DataMember(Name="dvContaPagadora", EmitDefaultValue=false)]
        public string DvContaPagadora { get; set; }
    
        /// <summary>
        /// Nome do pagador
        /// </summary>
        /// <value>Nome do pagador</value>
        [DataMember(Name="nomePagador", EmitDefaultValue=false)]
        public string NomePagador { get; set; }
    
        /// <summary>
        /// CPF/CNPJ do benefici\u00E1rio
        /// </summary>
        /// <value>CPF/CNPJ do benefici\u00E1rio</value>
        [DataMember(Name="cpfCnpjBeneficiario", EmitDefaultValue=false)]
        public string CpfCnpjBeneficiario { get; set; }
    
        /// <summary>
        /// Identificador evento origem
        /// </summary>
        /// <value>Identificador evento origem</value>
        [DataMember(Name="idEventoAjusteOrigem", EmitDefaultValue=false)]
        public long? IdEventoAjusteOrigem { get; set; }
    
        /// <summary>
        /// Identificador evento destino
        /// </summary>
        /// <value>Identificador evento destino</value>
        [DataMember(Name="idEventoAjusteDestino", EmitDefaultValue=false)]
        public long? IdEventoAjusteDestino { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador de opera\u00E7\u00F5es externas
        /// </summary>
        /// <value>C\u00F3digo identificador de opera\u00E7\u00F5es externas</value>
        [DataMember(Name="idExterno", EmitDefaultValue=false)]
        public string IdExterno { get; set; }
    
        /// <summary>
        /// C\u00F3digo ISPB do banco de destino
        /// </summary>
        /// <value>C\u00F3digo ISPB do banco de destino</value>
        [DataMember(Name="codigoIspb", EmitDefaultValue=false)]
        public string CodigoIspb { get; set; }
    
        /// <summary>
        /// Valor da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Valor da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="valorOperacao", EmitDefaultValue=false)]
        public double? ValorOperacao { get; set; }
    
        /// <summary>
        /// Valor da tarifa cobrada pela opera\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da tarifa cobrada pela opera\u00E7\u00E3o</value>
        [DataMember(Name="valorTarifa", EmitDefaultValue=false)]
        public double? ValorTarifa { get; set; }
    
        /// <summary>
        /// Data e hora da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data e hora da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataHoraOperacao", EmitDefaultValue=false)]
        public string DataHoraOperacao { get; set; }
    
        /// <summary>
        /// Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data de agendameto da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Data de realiza\u00E7\u00E3o da opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="dataRealizacao", EmitDefaultValue=false)]
        public string DataRealizacao { get; set; }
    
        /// <summary>
        /// Identificador da conta banc\u00E1ria
        /// </summary>
        /// <value>Identificador da conta banc\u00E1ria</value>
        [DataMember(Name="idDadosBancariosConta", EmitDefaultValue=false)]
        public long? IdDadosBancariosConta { get; set; }
    
        /// <summary>
        /// Identificador da opera\u00E7\u00E3o banc\u00E1ria original
        /// </summary>
        /// <value>Identificador da opera\u00E7\u00E3o banc\u00E1ria original</value>
        [DataMember(Name="idOperacaoBancariaOriginal", EmitDefaultValue=false)]
        public long? IdOperacaoBancariaOriginal { get; set; }
    
        /// <summary>
        /// Observa\u00E7\u00E3o
        /// </summary>
        /// <value>Observa\u00E7\u00E3o</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do bilhete \u00FAnico
        /// </summary>
        /// <value>N\u00FAmero do bilhete \u00FAnico</value>
        [DataMember(Name="numeroBilheteUnico", EmitDefaultValue=false)]
        public long? NumeroBilheteUnico { get; set; }
    
        /// <summary>
        /// Identificador do documento
        /// </summary>
        /// <value>Identificador do documento</value>
        [DataMember(Name="idDocumento", EmitDefaultValue=false)]
        public long? IdDocumento { get; set; }
    
        /// <summary>
        /// Identificador do celular
        /// </summary>
        /// <value>Identificador do celular</value>
        [DataMember(Name="idCelularRecarga", EmitDefaultValue=false)]
        public long? IdCelularRecarga { get; set; }
    
        /// <summary>
        /// Nome do benefici\u00E1rio envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Nome do benefici\u00E1rio envolvendo transfer\u00EAncias</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// Origem do banco do benefici\u00E1rio envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Origem do banco do benefici\u00E1rio envolvendo transfer\u00EAncias</value>
        [DataMember(Name="bancoBeneficiario", EmitDefaultValue=false)]
        public string BancoBeneficiario { get; set; }
    
        /// <summary>
        /// Origem da ag\u00EAncia do benefici\u00E1rio envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Origem da ag\u00EAncia do benefici\u00E1rio envolvendo transfer\u00EAncias</value>
        [DataMember(Name="agenciaBeneficiario", EmitDefaultValue=false)]
        public string AgenciaBeneficiario { get; set; }
    
        /// <summary>
        /// Conta origem do benefici\u00E1rio envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>Conta origem do benefici\u00E1rio envolvendo transfer\u00EAncias</value>
        [DataMember(Name="contaBeneficiario", EmitDefaultValue=false)]
        public string ContaBeneficiario { get; set; }
    
        /// <summary>
        /// D\u00EDgito da conta do benefici\u00E1rio origem envolvendo transfer\u00EAncias
        /// </summary>
        /// <value>D\u00EDgito da conta do benefici\u00E1rio origem envolvendo transfer\u00EAncias</value>
        [DataMember(Name="dvContaBeneficiario", EmitDefaultValue=false)]
        public string DvContaBeneficiario { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da operadora do celular
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da operadora do celular</value>
        [DataMember(Name="operadora", EmitDefaultValue=false)]
        public string Operadora { get; set; }
    
        /// <summary>
        /// N\u00FAmero da operadora
        /// </summary>
        /// <value>N\u00FAmero da operadora</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// DDD do celular
        /// </summary>
        /// <value>DDD do celular</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperacaoBancariaPersist {\n");
            sb.Append("  IdTipoOperacaoBancaria: ").Append(IdTipoOperacaoBancaria).Append("\n");
            sb.Append("  IdContaDestino: ").Append(IdContaDestino).Append("\n");
            sb.Append("  IdCartaoOrigem: ").Append(IdCartaoOrigem).Append("\n");
            sb.Append("  IdCartaoDestino: ").Append(IdCartaoDestino).Append("\n");
            sb.Append("  BancoPagador: ").Append(BancoPagador).Append("\n");
            sb.Append("  AgenciaPagadora: ").Append(AgenciaPagadora).Append("\n");
            sb.Append("  ContaPagadora: ").Append(ContaPagadora).Append("\n");
            sb.Append("  DvContaPagadora: ").Append(DvContaPagadora).Append("\n");
            sb.Append("  NomePagador: ").Append(NomePagador).Append("\n");
            sb.Append("  CpfCnpjBeneficiario: ").Append(CpfCnpjBeneficiario).Append("\n");
            sb.Append("  IdEventoAjusteOrigem: ").Append(IdEventoAjusteOrigem).Append("\n");
            sb.Append("  IdEventoAjusteDestino: ").Append(IdEventoAjusteDestino).Append("\n");
            sb.Append("  IdExterno: ").Append(IdExterno).Append("\n");
            sb.Append("  CodigoIspb: ").Append(CodigoIspb).Append("\n");
            sb.Append("  ValorOperacao: ").Append(ValorOperacao).Append("\n");
            sb.Append("  ValorTarifa: ").Append(ValorTarifa).Append("\n");
            sb.Append("  DataHoraOperacao: ").Append(DataHoraOperacao).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  DataRealizacao: ").Append(DataRealizacao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdDadosBancariosConta: ").Append(IdDadosBancariosConta).Append("\n");
            sb.Append("  IdOperacaoBancariaOriginal: ").Append(IdOperacaoBancariaOriginal).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  NumeroBilheteUnico: ").Append(NumeroBilheteUnico).Append("\n");
            sb.Append("  IdDocumento: ").Append(IdDocumento).Append("\n");
            sb.Append("  IdCelularRecarga: ").Append(IdCelularRecarga).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  BancoBeneficiario: ").Append(BancoBeneficiario).Append("\n");
            sb.Append("  AgenciaBeneficiario: ").Append(AgenciaBeneficiario).Append("\n");
            sb.Append("  ContaBeneficiario: ").Append(ContaBeneficiario).Append("\n");
            sb.Append("  DvContaBeneficiario: ").Append(DvContaBeneficiario).Append("\n");
            sb.Append("  Operadora: ").Append(Operadora).Append("\n");
            sb.Append("  Celular: ").Append(Celular).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            
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
            return this.Equals(obj as OperacaoBancariaPersist);
        }

        /// <summary>
        /// Returns true if OperacaoBancariaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of OperacaoBancariaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperacaoBancariaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoOperacaoBancaria == other.IdTipoOperacaoBancaria ||
                    this.IdTipoOperacaoBancaria != null &&
                    this.IdTipoOperacaoBancaria.Equals(other.IdTipoOperacaoBancaria)
                ) && 
                (
                    this.IdContaDestino == other.IdContaDestino ||
                    this.IdContaDestino != null &&
                    this.IdContaDestino.Equals(other.IdContaDestino)
                ) && 
                (
                    this.IdCartaoOrigem == other.IdCartaoOrigem ||
                    this.IdCartaoOrigem != null &&
                    this.IdCartaoOrigem.Equals(other.IdCartaoOrigem)
                ) && 
                (
                    this.IdCartaoDestino == other.IdCartaoDestino ||
                    this.IdCartaoDestino != null &&
                    this.IdCartaoDestino.Equals(other.IdCartaoDestino)
                ) && 
                (
                    this.BancoPagador == other.BancoPagador ||
                    this.BancoPagador != null &&
                    this.BancoPagador.Equals(other.BancoPagador)
                ) && 
                (
                    this.AgenciaPagadora == other.AgenciaPagadora ||
                    this.AgenciaPagadora != null &&
                    this.AgenciaPagadora.Equals(other.AgenciaPagadora)
                ) && 
                (
                    this.ContaPagadora == other.ContaPagadora ||
                    this.ContaPagadora != null &&
                    this.ContaPagadora.Equals(other.ContaPagadora)
                ) && 
                (
                    this.DvContaPagadora == other.DvContaPagadora ||
                    this.DvContaPagadora != null &&
                    this.DvContaPagadora.Equals(other.DvContaPagadora)
                ) && 
                (
                    this.NomePagador == other.NomePagador ||
                    this.NomePagador != null &&
                    this.NomePagador.Equals(other.NomePagador)
                ) && 
                (
                    this.CpfCnpjBeneficiario == other.CpfCnpjBeneficiario ||
                    this.CpfCnpjBeneficiario != null &&
                    this.CpfCnpjBeneficiario.Equals(other.CpfCnpjBeneficiario)
                ) && 
                (
                    this.IdEventoAjusteOrigem == other.IdEventoAjusteOrigem ||
                    this.IdEventoAjusteOrigem != null &&
                    this.IdEventoAjusteOrigem.Equals(other.IdEventoAjusteOrigem)
                ) && 
                (
                    this.IdEventoAjusteDestino == other.IdEventoAjusteDestino ||
                    this.IdEventoAjusteDestino != null &&
                    this.IdEventoAjusteDestino.Equals(other.IdEventoAjusteDestino)
                ) && 
                (
                    this.IdExterno == other.IdExterno ||
                    this.IdExterno != null &&
                    this.IdExterno.Equals(other.IdExterno)
                ) && 
                (
                    this.CodigoIspb == other.CodigoIspb ||
                    this.CodigoIspb != null &&
                    this.CodigoIspb.Equals(other.CodigoIspb)
                ) && 
                (
                    this.ValorOperacao == other.ValorOperacao ||
                    this.ValorOperacao != null &&
                    this.ValorOperacao.Equals(other.ValorOperacao)
                ) && 
                (
                    this.ValorTarifa == other.ValorTarifa ||
                    this.ValorTarifa != null &&
                    this.ValorTarifa.Equals(other.ValorTarifa)
                ) && 
                (
                    this.DataHoraOperacao == other.DataHoraOperacao ||
                    this.DataHoraOperacao != null &&
                    this.DataHoraOperacao.Equals(other.DataHoraOperacao)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.DataRealizacao == other.DataRealizacao ||
                    this.DataRealizacao != null &&
                    this.DataRealizacao.Equals(other.DataRealizacao)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdDadosBancariosConta == other.IdDadosBancariosConta ||
                    this.IdDadosBancariosConta != null &&
                    this.IdDadosBancariosConta.Equals(other.IdDadosBancariosConta)
                ) && 
                (
                    this.IdOperacaoBancariaOriginal == other.IdOperacaoBancariaOriginal ||
                    this.IdOperacaoBancariaOriginal != null &&
                    this.IdOperacaoBancariaOriginal.Equals(other.IdOperacaoBancariaOriginal)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.NumeroBilheteUnico == other.NumeroBilheteUnico ||
                    this.NumeroBilheteUnico != null &&
                    this.NumeroBilheteUnico.Equals(other.NumeroBilheteUnico)
                ) && 
                (
                    this.IdDocumento == other.IdDocumento ||
                    this.IdDocumento != null &&
                    this.IdDocumento.Equals(other.IdDocumento)
                ) && 
                (
                    this.IdCelularRecarga == other.IdCelularRecarga ||
                    this.IdCelularRecarga != null &&
                    this.IdCelularRecarga.Equals(other.IdCelularRecarga)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.BancoBeneficiario == other.BancoBeneficiario ||
                    this.BancoBeneficiario != null &&
                    this.BancoBeneficiario.Equals(other.BancoBeneficiario)
                ) && 
                (
                    this.AgenciaBeneficiario == other.AgenciaBeneficiario ||
                    this.AgenciaBeneficiario != null &&
                    this.AgenciaBeneficiario.Equals(other.AgenciaBeneficiario)
                ) && 
                (
                    this.ContaBeneficiario == other.ContaBeneficiario ||
                    this.ContaBeneficiario != null &&
                    this.ContaBeneficiario.Equals(other.ContaBeneficiario)
                ) && 
                (
                    this.DvContaBeneficiario == other.DvContaBeneficiario ||
                    this.DvContaBeneficiario != null &&
                    this.DvContaBeneficiario.Equals(other.DvContaBeneficiario)
                ) && 
                (
                    this.Operadora == other.Operadora ||
                    this.Operadora != null &&
                    this.Operadora.Equals(other.Operadora)
                ) && 
                (
                    this.Celular == other.Celular ||
                    this.Celular != null &&
                    this.Celular.Equals(other.Celular)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
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
                
                if (this.IdTipoOperacaoBancaria != null)
                    hash = hash * 59 + this.IdTipoOperacaoBancaria.GetHashCode();
                
                if (this.IdContaDestino != null)
                    hash = hash * 59 + this.IdContaDestino.GetHashCode();
                
                if (this.IdCartaoOrigem != null)
                    hash = hash * 59 + this.IdCartaoOrigem.GetHashCode();
                
                if (this.IdCartaoDestino != null)
                    hash = hash * 59 + this.IdCartaoDestino.GetHashCode();
                
                if (this.BancoPagador != null)
                    hash = hash * 59 + this.BancoPagador.GetHashCode();
                
                if (this.AgenciaPagadora != null)
                    hash = hash * 59 + this.AgenciaPagadora.GetHashCode();
                
                if (this.ContaPagadora != null)
                    hash = hash * 59 + this.ContaPagadora.GetHashCode();
                
                if (this.DvContaPagadora != null)
                    hash = hash * 59 + this.DvContaPagadora.GetHashCode();
                
                if (this.NomePagador != null)
                    hash = hash * 59 + this.NomePagador.GetHashCode();
                
                if (this.CpfCnpjBeneficiario != null)
                    hash = hash * 59 + this.CpfCnpjBeneficiario.GetHashCode();
                
                if (this.IdEventoAjusteOrigem != null)
                    hash = hash * 59 + this.IdEventoAjusteOrigem.GetHashCode();
                
                if (this.IdEventoAjusteDestino != null)
                    hash = hash * 59 + this.IdEventoAjusteDestino.GetHashCode();
                
                if (this.IdExterno != null)
                    hash = hash * 59 + this.IdExterno.GetHashCode();
                
                if (this.CodigoIspb != null)
                    hash = hash * 59 + this.CodigoIspb.GetHashCode();
                
                if (this.ValorOperacao != null)
                    hash = hash * 59 + this.ValorOperacao.GetHashCode();
                
                if (this.ValorTarifa != null)
                    hash = hash * 59 + this.ValorTarifa.GetHashCode();
                
                if (this.DataHoraOperacao != null)
                    hash = hash * 59 + this.DataHoraOperacao.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.DataRealizacao != null)
                    hash = hash * 59 + this.DataRealizacao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdDadosBancariosConta != null)
                    hash = hash * 59 + this.IdDadosBancariosConta.GetHashCode();
                
                if (this.IdOperacaoBancariaOriginal != null)
                    hash = hash * 59 + this.IdOperacaoBancariaOriginal.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.NumeroBilheteUnico != null)
                    hash = hash * 59 + this.NumeroBilheteUnico.GetHashCode();
                
                if (this.IdDocumento != null)
                    hash = hash * 59 + this.IdDocumento.GetHashCode();
                
                if (this.IdCelularRecarga != null)
                    hash = hash * 59 + this.IdCelularRecarga.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.BancoBeneficiario != null)
                    hash = hash * 59 + this.BancoBeneficiario.GetHashCode();
                
                if (this.AgenciaBeneficiario != null)
                    hash = hash * 59 + this.AgenciaBeneficiario.GetHashCode();
                
                if (this.ContaBeneficiario != null)
                    hash = hash * 59 + this.ContaBeneficiario.GetHashCode();
                
                if (this.DvContaBeneficiario != null)
                    hash = hash * 59 + this.DvContaBeneficiario.GetHashCode();
                
                if (this.Operadora != null)
                    hash = hash * 59 + this.Operadora.GetHashCode();
                
                if (this.Celular != null)
                    hash = hash * 59 + this.Celular.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                return hash;
            }
        }

    }
}
