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
    /// {{{adicional_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AdicionalDetalheResponse :  IEquatable<AdicionalDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="AdicionalDetalheResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{adicional_detalhe_response_id_conta_value}}}.</param>
        /// <param name="IdPessoa">{{{adicional_detalhe_response_id_pessoa_value}}}.</param>
        /// <param name="Nome">{{{adicional_detalhe_response_nome_value}}}.</param>
        /// <param name="NomeImpresso">{{{adicional_detalhe_response_nome_impresso_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{adicional_detalhe_response_numero_receita_federal_value}}}.</param>
        /// <param name="DataNascimento">{{{adicional_detalhe_response_data_nascimento_value}}}.</param>
        /// <param name="Sexo">{{{adicional_detalhe_response_sexo_value}}}.</param>
        /// <param name="NumeroIdentidade">{{{adicional_detalhe_response_numero_identidade_value}}}.</param>
        /// <param name="OrgaoExpedidorIdentidade">{{{adicional_detalhe_response_orgao_expedidor_identidade_value}}}.</param>
        /// <param name="UnidadeFederativaIdentidade">{{{adicional_detalhe_response_unidade_federativa_identidade_value}}}.</param>
        /// <param name="DataEmissaoIdentidade">{{{adicional_detalhe_response_data_emissao_identidade_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{adicional_detalhe_response_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{adicional_detalhe_response_id_profissao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{adicional_detalhe_response_id_nacionalidade_value}}}.</param>
        /// <param name="IdParentesco">{{{adicional_detalhe_response_id_parentesco_value}}}.</param>
        /// <param name="Email">{{{adicional_detalhe_response_email_value}}}.</param>
        /// <param name="FlagAtivo">{{{adicional_detalhe_response_flag_ativo_value}}}.</param>
        /// <param name="DataCadastroPortador">{{{adicional_detalhe_response_data_cadastro_portador_value}}}.</param>
        /// <param name="DataCancelamentoPortador">{{{adicional_detalhe_response_data_cancelamento_portador_value}}}.</param>
        /// <param name="Telefones">{{{adicional_detalhe_response_telefones_value}}}.</param>

        public AdicionalDetalheResponse(long? IdConta = null, long? IdPessoa = null, string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdEstadoCivil = null, long? IdProfissao = null, long? IdNacionalidade = null, long? IdParentesco = null, string Email = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null, List<TelefoneResponse> Telefones = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.NomeImpresso = NomeImpresso;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNacionalidade = IdNacionalidade;
            this.IdParentesco = IdParentesco;
            this.Email = Email;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_nome_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_data_nascimento_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_data_nascimento_value}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_sexo_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_sexo_value}}}</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_numero_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_numero_identidade_value}}}</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_orgao_expedidor_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_orgao_expedidor_identidade_value}}}</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_unidade_federativa_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_unidade_federativa_identidade_value}}}</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_data_emissao_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_data_emissao_identidade_value}}}</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_profissao_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public long? IdProfissao { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_id_parentesco_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_id_parentesco_value}}}</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_email_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_data_cadastro_portador_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_data_cadastro_portador_value}}}</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_data_cancelamento_portador_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_data_cancelamento_portador_value}}}</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// {{{adicional_detalhe_response_telefones_value}}}
        /// </summary>
        /// <value>{{{adicional_detalhe_response_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalDetalheResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            sb.Append("  DataCancelamentoPortador: ").Append(DataCancelamentoPortador).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            
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
            return this.Equals(obj as AdicionalDetalheResponse);
        }

        /// <summary>
        /// Returns true if AdicionalDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalDetalheResponse other)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
                ) && 
                (
                    this.DataCancelamentoPortador == other.DataCancelamentoPortador ||
                    this.DataCancelamentoPortador != null &&
                    this.DataCancelamentoPortador.Equals(other.DataCancelamentoPortador)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                if (this.DataCancelamentoPortador != null)
                    hash = hash * 59 + this.DataCancelamentoPortador.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
