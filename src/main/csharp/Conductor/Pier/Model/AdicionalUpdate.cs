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
    /// Objeto Adicional
    /// </summary>
    [DataContract]
    public partial class AdicionalUpdate :  IEquatable<AdicionalUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalUpdate" /> class.
        /// Initializes a new instance of the <see cref="AdicionalUpdate" />class.
        /// </summary>
        /// <param name="Nome">Nome completo do Adicional (required).</param>
        /// <param name="NomeImpresso">Nome do Adicional que ser\u00E1 gravado no Cart\u00E3o.</param>
        /// <param name="NumeroReceitaFederal">N\u00FAmero da Receita Federal (required).</param>
        /// <param name="DataNascimento">Data de Nascimento do Adicional em formato yyyy-MM-dd.</param>
        /// <param name="Sexo">Sexo do Adicional.</param>
        /// <param name="NumeroIdentidade">N\u00FAmero do Documento de Identidade do Adicional.</param>
        /// <param name="OrgaoExpedidorIdentidade">Nome do Org\u00E3o Emissor do Documento de Identidade do Adicional.</param>
        /// <param name="UnidadeFederativaIdentidade">Unidade Federativa da identidade.</param>
        /// <param name="DataEmissaoIdentidade">Data de emiss\u00E3o do Documento de Identidade do Adicional em formato yyyy-MM-dd.</param>
        /// <param name="IdParentesco">C\u00F3digo de identifica\u00E7\u00E3o do Parentesco do Adicional com o Titular.</param>
        /// <param name="FlagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual.</param>
        /// <param name="Telefones">Lista de telefones do adicional.</param>

        public AdicionalUpdate(string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdParentesco = null, bool? FlagDeficienteVisual = null, List<TelefoneAdicionalUpdate> Telefones = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for AdicionalUpdate and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "NumeroReceitaFederal" is required (not null)
            if (NumeroReceitaFederal == null)
            {
                throw new InvalidDataException("NumeroReceitaFederal is a required property for AdicionalUpdate and cannot be null");
            }
            else
            {
                this.NumeroReceitaFederal = NumeroReceitaFederal;
            }
            this.NomeImpresso = NomeImpresso;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdParentesco = IdParentesco;
            this.FlagDeficienteVisual = FlagDeficienteVisual;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// Nome completo do Adicional
        /// </summary>
        /// <value>Nome completo do Adicional</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Nome do Adicional que ser\u00E1 gravado no Cart\u00E3o
        /// </summary>
        /// <value>Nome do Adicional que ser\u00E1 gravado no Cart\u00E3o</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Receita Federal
        /// </summary>
        /// <value>N\u00FAmero da Receita Federal</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Data de Nascimento do Adicional em formato yyyy-MM-dd
        /// </summary>
        /// <value>Data de Nascimento do Adicional em formato yyyy-MM-dd</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Sexo do Adicional
        /// </summary>
        /// <value>Sexo do Adicional</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// N\u00FAmero do Documento de Identidade do Adicional
        /// </summary>
        /// <value>N\u00FAmero do Documento de Identidade do Adicional</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Nome do Org\u00E3o Emissor do Documento de Identidade do Adicional
        /// </summary>
        /// <value>Nome do Org\u00E3o Emissor do Documento de Identidade do Adicional</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Unidade Federativa da identidade
        /// </summary>
        /// <value>Unidade Federativa da identidade</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Data de emiss\u00E3o do Documento de Identidade do Adicional em formato yyyy-MM-dd
        /// </summary>
        /// <value>Data de emiss\u00E3o do Documento de Identidade do Adicional em formato yyyy-MM-dd</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Parentesco do Adicional com o Titular
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Parentesco do Adicional com o Titular</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Flag que identifica uma pessoa como deficiente visual
        /// </summary>
        /// <value>Flag que identifica uma pessoa como deficiente visual</value>
        [DataMember(Name="flagDeficienteVisual", EmitDefaultValue=false)]
        public bool? FlagDeficienteVisual { get; set; }
    
        /// <summary>
        /// Lista de telefones do adicional
        /// </summary>
        /// <value>Lista de telefones do adicional</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneAdicionalUpdate> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  FlagDeficienteVisual: ").Append(FlagDeficienteVisual).Append("\n");
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
            return this.Equals(obj as AdicionalUpdate);
        }

        /// <summary>
        /// Returns true if AdicionalUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.FlagDeficienteVisual == other.FlagDeficienteVisual ||
                    this.FlagDeficienteVisual != null &&
                    this.FlagDeficienteVisual.Equals(other.FlagDeficienteVisual)
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
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.FlagDeficienteVisual != null)
                    hash = hash * 59 + this.FlagDeficienteVisual.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
