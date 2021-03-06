using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Pier.Client;
using Conductor.Pier.Model;

namespace Conductor.Pier.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServicoContaApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        AdesaoPacoteTarifaResponse AderirPacoteTarifa (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist);
  
        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        ApiResponse<AdesaoPacoteTarifaResponse> AderirPacoteTarifaWithHttpInfo (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        AdesaoPacoteTarifaResponse AlterarAdesaoPacoteTarifa (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        ApiResponse<AdesaoPacoteTarifaResponse> AlterarAdesaoPacoteTarifaWithHttpInfo (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate);
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Object</returns>
        Object AtivarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtivarEnvioFaturaEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>Object</returns>
        Object AtribuirAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null);
  
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null);
        
        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        AdesaoPacoteTarifaResponse ConsultarAdesaoPacoteTarifa (long? id);
  
        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        ApiResponse<AdesaoPacoteTarifaResponse> ConsultarAdesaoPacoteTarifaWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Object</returns>
        Object DesativarEnvioFaturaEmail (long? id);
  
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarEnvioFaturaEmailWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa servi\u00E7o das contas
        /// </summary>
        /// <remarks>
        /// Recurso que desativa servi\u00E7o das contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>Object</returns>
        Object DesativarServicoConta (long? id);
  
        /// <summary>
        /// Desativa servi\u00E7o das contas
        /// </summary>
        /// <remarks>
        /// Recurso que desativa servi\u00E7o das contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DesativarServicoContaWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageAnuidadeResponse</returns>
        PageAnuidadeResponse ListarAnuidades (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        ApiResponse<PageAnuidadeResponse> ListarAnuidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageOperadoraResponse</returns>
        PageOperadoraResponse ListarOperadorasTelefonicas (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        ApiResponse<PageOperadoraResponse> ListarOperadorasTelefonicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os servi\u00E7os ativos
        /// </summary>
        /// <remarks>
        /// Recurso que lista os servi\u00E7os ativos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>PageServicoContaResponse</returns>
        PageServicoContaResponse ListarServicosContas (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
  
        /// <summary>
        /// Lista os servi\u00E7os ativos
        /// </summary>
        /// <remarks>
        /// Recurso que lista os servi\u00E7os ativos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>ApiResponse of PageServicoContaResponse</returns>
        ApiResponse<PageServicoContaResponse> ListarServicosContasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageTipoServicoResponse</returns>
        PageTipoServicoResponse ListarTipoServico (List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageTipoServicoResponse</returns>
        ApiResponse<PageTipoServicoResponse> ListarTipoServicoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Ativa servi\u00E7os para contas
        /// </summary>
        /// <remarks>
        /// Ativa servi\u00E7os para contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Object</returns>
        Object SalvarServicoConta (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist);
  
        /// <summary>
        /// Ativa servi\u00E7os para contas
        /// </summary>
        /// <remarks>
        /// Ativa servi\u00E7os para contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SalvarServicoContaWithHttpInfo (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AderirPacoteTarifaAsync (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist);

        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AderirPacoteTarifaAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AlterarAdesaoPacoteTarifaAsync (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AlterarAdesaoPacoteTarifaAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate);
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null);

        /// <summary>
        /// Atribuir Anuidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null);
        
        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> ConsultarAdesaoPacoteTarifaAsync (long? id);

        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <remarks>
        /// Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> ConsultarAdesaoPacoteTarifaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id);

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <remarks>
        /// Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Desativa servi\u00E7o das contas
        /// </summary>
        /// <remarks>
        /// Recurso que desativa servi\u00E7o das contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DesativarServicoContaAsync (long? id);

        /// <summary>
        /// Desativa servi\u00E7o das contas
        /// </summary>
        /// <remarks>
        /// Recurso que desativa servi\u00E7o das contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DesativarServicoContaAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Anuidades
        /// </summary>
        /// <remarks>
        /// Lista as anuidades
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar Operadoras
        /// </summary>
        /// <remarks>
        /// Lista as operadoras
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os servi\u00E7os ativos
        /// </summary>
        /// <remarks>
        /// Recurso que lista os servi\u00E7os ativos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>Task of PageServicoContaResponse</returns>
        System.Threading.Tasks.Task<PageServicoContaResponse> ListarServicosContasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);

        /// <summary>
        /// Lista os servi\u00E7os ativos
        /// </summary>
        /// <remarks>
        /// Recurso que lista os servi\u00E7os ativos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageServicoContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageServicoContaResponse>> ListarServicosContasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null);
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoServicoResponse</returns>
        System.Threading.Tasks.Task<PageTipoServicoResponse> ListarTipoServicoAsync (List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os
        /// </summary>
        /// <remarks>
        /// Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoServicoResponse>> ListarTipoServicoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Ativa servi\u00E7os para contas
        /// </summary>
        /// <remarks>
        /// Ativa servi\u00E7os para contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SalvarServicoContaAsync (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist);

        /// <summary>
        /// Ativa servi\u00E7os para contas
        /// </summary>
        /// <remarks>
        /// Ativa servi\u00E7os para contas
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SalvarServicoContaAsyncWithHttpInfo (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServicoContaApi : IServicoContaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicoContaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicoContaApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicoContaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServicoContaApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param> 
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        public AdesaoPacoteTarifaResponse AderirPacoteTarifa (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = AderirPacoteTarifaWithHttpInfo(id, adesaoPacoteTarifaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param> 
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        public ApiResponse< AdesaoPacoteTarifaResponse > AderirPacoteTarifaWithHttpInfo (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AderirPacoteTarifa");
            
            // verify the required parameter 'adesaoPacoteTarifaPersist' is set
            if (adesaoPacoteTarifaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaPersist' when calling ServicoContaApi->AderirPacoteTarifa");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoPacoteTarifaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AderirPacoteTarifaAsync (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = await AderirPacoteTarifaAsyncWithHttpInfo(id, adesaoPacoteTarifaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a ades\u00E3o de um pacote de tarifa Esse recurso permite \u00E0 conta aderir um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <param name="adesaoPacoteTarifaPersist">adesaoPacoteTarifaPersist</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AderirPacoteTarifaAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaPersist adesaoPacoteTarifaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AderirPacoteTarifa");
            // verify the required parameter 'adesaoPacoteTarifaPersist' is set
            if (adesaoPacoteTarifaPersist == null) throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaPersist' when calling AderirPacoteTarifa");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoPacoteTarifaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AderirPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param> 
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param> 
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        public AdesaoPacoteTarifaResponse AlterarAdesaoPacoteTarifa (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = AlterarAdesaoPacoteTarifaWithHttpInfo(id, adesaoPacoteTarifaUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param> 
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param> 
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        public ApiResponse< AdesaoPacoteTarifaResponse > AlterarAdesaoPacoteTarifaWithHttpInfo (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AlterarAdesaoPacoteTarifa");
            
            // verify the required parameter 'adesaoPacoteTarifaUpdate' is set
            if (adesaoPacoteTarifaUpdate == null)
                throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaUpdate' when calling ServicoContaApi->AlterarAdesaoPacoteTarifa");
            
    
            var localVarPath = "/api/contas/adesoes-pacotes-tarifas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoPacoteTarifaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdesaoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdesaoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> AlterarAdesaoPacoteTarifaAsync (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = await AlterarAdesaoPacoteTarifaAsyncWithHttpInfo(id, adesaoPacoteTarifaUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o da ades\u00E3o do pacote de tarifa Esse recurso permite alterar uma ades\u00E3o do pacote de tarifa da conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da ades\u00E3o do pacote de tarifa (id).</param>
        /// <param name="adesaoPacoteTarifaUpdate">adesaoPacoteTarifaUpdate</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> AlterarAdesaoPacoteTarifaAsyncWithHttpInfo (long? id, AdesaoPacoteTarifaUpdate adesaoPacoteTarifaUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarAdesaoPacoteTarifa");
            // verify the required parameter 'adesaoPacoteTarifaUpdate' is set
            if (adesaoPacoteTarifaUpdate == null) throw new ApiException(400, "Missing required parameter 'adesaoPacoteTarifaUpdate' when calling AlterarAdesaoPacoteTarifa");
            
    
            var localVarPath = "/api/contas/adesoes-pacotes-tarifas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (adesaoPacoteTarifaUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adesaoPacoteTarifaUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adesaoPacoteTarifaUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdesaoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarAdesaoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }
        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>Object</returns>
        public Object AtivarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = AtivarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtivarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AtivarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtivarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await AtivarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa o servi\u00E7o de envio de fatura por email Este recurso ativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtivarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/ativar-fatura-email";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param> 
        /// <returns>Object</returns>
        public Object AtribuirAnuidade (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null)
        {
             ApiResponse<Object> localVarResponse = AtribuirAnuidadeWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial, colaborador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idAnuidade">Identificador da anuidade</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="DDD">DDD do celular (optional)</param> 
        /// <param name="celular">N\u00FAmero do celular (optional)</param> 
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param> 
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param> 
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAnuidadeWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->AtribuirAnuidade");
            
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null)
                throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling ServicoContaApi->AtribuirAnuidade");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (colaborador != null) localVarQueryParams.Add("colaborador", Configuration.ApiClient.ParameterToString(colaborador)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAnuidadeAsync (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAnuidadeAsyncWithHttpInfo(id, idAnuidade, sort, page, limit, DDD, celular, idOperadora, idOrigemComercial, colaborador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atribuir Anuidade Esse recurso permite configurar qual a regra de Anuidade que ser\u00E1 atribu\u00EDda a uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idAnuidade">Identificador da anuidade</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="DDD">DDD do celular (optional)</param>
        /// <param name="celular">N\u00FAmero do celular (optional)</param>
        /// <param name="idOperadora">Identificador da operadora do celular (optional)</param>
        /// <param name="idOrigemComercial">Identificador da origem comercial (optional)</param>
        /// <param name="colaborador">Matr\u00EDcula do colaborador (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAnuidadeAsyncWithHttpInfo (long? id, long? idAnuidade, List<string> sort = null, int? page = null, int? limit = null, string DDD = null, string celular = null, long? idOperadora = null, long? idOrigemComercial = null, string colaborador = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAnuidade");
            // verify the required parameter 'idAnuidade' is set
            if (idAnuidade == null) throw new ApiException(400, "Missing required parameter 'idAnuidade' when calling AtribuirAnuidade");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-anuidade";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idAnuidade != null) localVarQueryParams.Add("idAnuidade", Configuration.ApiClient.ParameterToString(idAnuidade)); // query parameter
            if (DDD != null) localVarQueryParams.Add("DDD", Configuration.ApiClient.ParameterToString(DDD)); // query parameter
            if (celular != null) localVarQueryParams.Add("celular", Configuration.ApiClient.ParameterToString(celular)); // query parameter
            if (idOperadora != null) localVarQueryParams.Add("idOperadora", Configuration.ApiClient.ParameterToString(idOperadora)); // query parameter
            if (idOrigemComercial != null) localVarQueryParams.Add("idOrigemComercial", Configuration.ApiClient.ParameterToString(idOrigemComercial)); // query parameter
            if (colaborador != null) localVarQueryParams.Add("colaborador", Configuration.ApiClient.ParameterToString(colaborador)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAnuidade: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAnuidade: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <returns>AdesaoPacoteTarifaResponse</returns>
        public AdesaoPacoteTarifaResponse ConsultarAdesaoPacoteTarifa (long? id)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = ConsultarAdesaoPacoteTarifaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param> 
        /// <returns>ApiResponse of AdesaoPacoteTarifaResponse</returns>
        public ApiResponse< AdesaoPacoteTarifaResponse > ConsultarAdesaoPacoteTarifaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->ConsultarAdesaoPacoteTarifa");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAdesaoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAdesaoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }

        
        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of AdesaoPacoteTarifaResponse</returns>
        public async System.Threading.Tasks.Task<AdesaoPacoteTarifaResponse> ConsultarAdesaoPacoteTarifaAsync (long? id)
        {
             ApiResponse<AdesaoPacoteTarifaResponse> localVarResponse = await ConsultarAdesaoPacoteTarifaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza uma consulta de uma ades\u00E3o de um pacote de tarifa Esse recurso permite consultar uma ades\u00E3o de um pacote de tarifa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id da conta</param>
        /// <returns>Task of ApiResponse (AdesaoPacoteTarifaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdesaoPacoteTarifaResponse>> ConsultarAdesaoPacoteTarifaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarAdesaoPacoteTarifa");
            
    
            var localVarPath = "/api/contas/{id}/adesoes-pacotes-tarifas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAdesaoPacoteTarifa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarAdesaoPacoteTarifa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdesaoPacoteTarifaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdesaoPacoteTarifaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdesaoPacoteTarifaResponse)));
            
        }
        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>Object</returns>
        public Object DesativarEnvioFaturaEmail (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarEnvioFaturaEmailWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarEnvioFaturaEmailWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->DesativarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarEnvioFaturaEmailAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarEnvioFaturaEmailAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa o servi\u00E7o de envio de fatura por email Este recurso desativa o servi\u00E7o de envio de fatura por email
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarEnvioFaturaEmailAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarEnvioFaturaEmail");
            
    
            var localVarPath = "/api/contas/{id}/desativar-fatura-email";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarEnvioFaturaEmail: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Desativa servi\u00E7o das contas Recurso que desativa servi\u00E7o das contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param> 
        /// <returns>Object</returns>
        public Object DesativarServicoConta (long? id)
        {
             ApiResponse<Object> localVarResponse = DesativarServicoContaWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Desativa servi\u00E7o das contas Recurso que desativa servi\u00E7o das contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DesativarServicoContaWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServicoContaApi->DesativarServicoConta");
            
    
            var localVarPath = "/api/contas/servicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Desativa servi\u00E7o das contas Recurso que desativa servi\u00E7o das contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DesativarServicoContaAsync (long? id)
        {
             ApiResponse<Object> localVarResponse = await DesativarServicoContaAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Desativa servi\u00E7o das contas Recurso que desativa servi\u00E7o das contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo Identificador do servi\u00E7o conta</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DesativarServicoContaAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarServicoConta");
            
    
            var localVarPath = "/api/contas/servicos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarServicoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageAnuidadeResponse</returns>
        public PageAnuidadeResponse ListarAnuidades (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = ListarAnuidadesWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageAnuidadeResponse</returns>
        public ApiResponse< PageAnuidadeResponse > ListarAnuidadesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }

        
        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageAnuidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageAnuidadeResponse> ListarAnuidadesAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageAnuidadeResponse> localVarResponse = await ListarAnuidadesAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Anuidades Lista as anuidades
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageAnuidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageAnuidadeResponse>> ListarAnuidadesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/anuidades";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidades: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAnuidades: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageAnuidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageAnuidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageAnuidadeResponse)));
            
        }
        
        /// <summary>
        /// Listar Operadoras Lista as operadoras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageOperadoraResponse</returns>
        public PageOperadoraResponse ListarOperadorasTelefonicas (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = ListarOperadorasTelefonicasWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar Operadoras Lista as operadoras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageOperadoraResponse</returns>
        public ApiResponse< PageOperadoraResponse > ListarOperadorasTelefonicasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }

        
        /// <summary>
        /// Listar Operadoras Lista as operadoras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageOperadoraResponse</returns>
        public async System.Threading.Tasks.Task<PageOperadoraResponse> ListarOperadorasTelefonicasAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageOperadoraResponse> localVarResponse = await ListarOperadorasTelefonicasAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar Operadoras Lista as operadoras
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageOperadoraResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOperadoraResponse>> ListarOperadorasTelefonicasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/operadoras-telefonicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOperadorasTelefonicas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOperadoraResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOperadoraResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOperadoraResponse)));
            
        }
        
        /// <summary>
        /// Lista os servi\u00E7os ativos Recurso que lista os servi\u00E7os ativos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param> 
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param> 
        /// <returns>PageServicoContaResponse</returns>
        public PageServicoContaResponse ListarServicosContas (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
             ApiResponse<PageServicoContaResponse> localVarResponse = ListarServicosContasWithHttpInfo(sort, page, limit, idConta, idTipoServico);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os servi\u00E7os ativos Recurso que lista os servi\u00E7os ativos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param> 
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param> 
        /// <returns>ApiResponse of PageServicoContaResponse</returns>
        public ApiResponse< PageServicoContaResponse > ListarServicosContasWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
            
    
            var localVarPath = "/api/contas/servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoServico != null) localVarQueryParams.Add("idTipoServico", Configuration.ApiClient.ParameterToString(idTipoServico)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageServicoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageServicoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageServicoContaResponse)));
            
        }

        
        /// <summary>
        /// Lista os servi\u00E7os ativos Recurso que lista os servi\u00E7os ativos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>Task of PageServicoContaResponse</returns>
        public async System.Threading.Tasks.Task<PageServicoContaResponse> ListarServicosContasAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
             ApiResponse<PageServicoContaResponse> localVarResponse = await ListarServicosContasAsyncWithHttpInfo(sort, page, limit, idConta, idTipoServico);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os servi\u00E7os ativos Recurso que lista os servi\u00E7os ativos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo Identificador da conta (optional)</param>
        /// <param name="idTipoServico">C\u00F3digo Identificador do tipo de servi\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageServicoContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageServicoContaResponse>> ListarServicosContasAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idTipoServico = null)
        {
            
    
            var localVarPath = "/api/contas/servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idTipoServico != null) localVarQueryParams.Add("idTipoServico", Configuration.ApiClient.ParameterToString(idTipoServico)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosContas: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarServicosContas: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageServicoContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageServicoContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageServicoContaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageTipoServicoResponse</returns>
        public PageTipoServicoResponse ListarTipoServico (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoResponse> localVarResponse = ListarTipoServicoWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageTipoServicoResponse</returns>
        public ApiResponse< PageTipoServicoResponse > ListarTipoServicoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de Servi\u00E7os Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageTipoServicoResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoServicoResponse> ListarTipoServicoAsync (List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageTipoServicoResponse> localVarResponse = await ListarTipoServicoAsyncWithHttpInfo(sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de Servi\u00E7os Esse recurso permite listar os Tipos de Servi\u00E7os
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoServicoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoServicoResponse>> ListarTipoServicoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null)
        {
            
    
            var localVarPath = "/api/tipos-servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "*/*"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServico: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTipoServico: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoServicoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoServicoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoServicoResponse)));
            
        }
        
        /// <summary>
        /// Ativa servi\u00E7os para contas Ativa servi\u00E7os para contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param> 
        /// <returns>Object</returns>
        public Object SalvarServicoConta (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist)
        {
             ApiResponse<Object> localVarResponse = SalvarServicoContaWithHttpInfo(servicoContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ativa servi\u00E7os para contas Ativa servi\u00E7os para contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SalvarServicoContaWithHttpInfo (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist)
        {
            
            // verify the required parameter 'servicoContaPersist' is set
            if (servicoContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'servicoContaPersist' when calling ServicoContaApi->SalvarServicoConta");
            
    
            var localVarPath = "/api/contas/servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (servicoContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(servicoContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = servicoContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Ativa servi\u00E7os para contas Ativa servi\u00E7os para contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SalvarServicoContaAsync (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist)
        {
             ApiResponse<Object> localVarResponse = await SalvarServicoContaAsyncWithHttpInfo(servicoContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ativa servi\u00E7os para contas Ativa servi\u00E7os para contas
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="servicoContaPersist">servicoContaPersist</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SalvarServicoContaAsyncWithHttpInfo (RepresentaoDaEntradaDoRecursoDeCadastrarUmServioConta servicoContaPersist)
        {
            // verify the required parameter 'servicoContaPersist' is set
            if (servicoContaPersist == null) throw new ApiException(400, "Missing required parameter 'servicoContaPersist' when calling SalvarServicoConta");
            
    
            var localVarPath = "/api/contas/servicos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (servicoContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(servicoContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = servicoContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarServicoConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
    }
    
}
