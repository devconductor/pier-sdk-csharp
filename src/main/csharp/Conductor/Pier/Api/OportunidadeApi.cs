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
    public interface IOportunidadeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse AlterarStatusUsingPUT (long? id, long? idStatus, StatusOportunidade persist);
  
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> AlterarStatusUsingPUTWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist);
        
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse AlterarUsingPUT4 (long? id, OportunidadeUpdate update);
  
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> AlterarUsingPUT4WithHttpInfo (long? id, OportunidadeUpdate update);
        
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse AlterarUsingPUT8 (long? id, TipoOportunidade persist);
  
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> AlterarUsingPUT8WithHttpInfo (long? id, TipoOportunidade persist);
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse ConsultarStatusUsingGET (long? id, long? idStatus);
  
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> ConsultarStatusUsingGETWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse ConsultarUsingGET22 (long? id);
  
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> ConsultarUsingGET22WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        PageStatusOportunidadeAUDResponse ListarAuditoriasStatusUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        ApiResponse<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>PageOportunidadeAUDResponse</returns>
        PageOportunidadeAUDResponse ListarAuditoriasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        ApiResponse<PageOportunidadeAUDResponse> ListarAuditoriasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        PageTipoOportunidadeAUDResponse ListarAuditoriasUsingGET1 (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
  
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        ApiResponse<PageTipoOportunidadeAUDResponse> ListarAuditoriasUsingGET1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>PageStatusOportunidadeResponse</returns>
        PageStatusOportunidadeResponse ListarStatusUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        ApiResponse<PageStatusOportunidadeResponse> ListarStatusUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>PageOportunidadeResponse</returns>
        PageOportunidadeResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        ApiResponse<PageOportunidadeResponse> ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>PageTipoOportunidadeResponse</returns>
        PageTipoOportunidadeResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
  
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        ApiResponse<PageTipoOportunidadeResponse> ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>StatusOportunidadeResponse</returns>
        StatusOportunidadeResponse SalvarStatusUsingPOST (long? id, StatusOportunidade persist);
  
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        ApiResponse<StatusOportunidadeResponse> SalvarStatusUsingPOSTWithHttpInfo (long? id, StatusOportunidade persist);
        
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>OportunidadeResponse</returns>
        OportunidadeResponse SalvarUsingPOST12 (OportunidadePersist persist);
  
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        ApiResponse<OportunidadeResponse> SalvarUsingPOST12WithHttpInfo (OportunidadePersist persist);
        
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>TipoOportunidadeResponse</returns>
        TipoOportunidadeResponse SalvarUsingPOST17 (TipoOportunidade persist);
  
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        ApiResponse<TipoOportunidadeResponse> SalvarUsingPOST17WithHttpInfo (TipoOportunidade persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusUsingPUTAsync (long? id, long? idStatus, StatusOportunidade persist);

        /// <summary>
        /// Altera o status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusUsingPUTAsyncWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist);
        
        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> AlterarUsingPUT4Async (long? id, OportunidadeUpdate update);

        /// <summary>
        /// Altera as oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, OportunidadeUpdate update);
        
        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> AlterarUsingPUT8Async (long? id, TipoOportunidade persist);

        /// <summary>
        /// Altera os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? id, TipoOportunidade persist);
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusUsingGETAsync (long? id, long? idStatus);

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusUsingGETAsyncWithHttpInfo (long? id, long? idStatus);
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> ConsultarUsingGET22Async (long? id);

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> ConsultarUsingGET22AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias dos status oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias das oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as auditorias das oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null);
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditoriasUsingGET1Async (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditoriasUsingGET1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null);
        
        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os status do tipo oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os status do tipo oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageOportunidadeResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista as oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar as oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<PageTipoOportunidadeResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);

        /// <summary>
        /// Lista os tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar os tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null);
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusUsingPOSTAsync (long? id, StatusOportunidade persist);

        /// <summary>
        /// Cadastra status para o tipo oportunidade
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusUsingPOSTAsyncWithHttpInfo (long? id, StatusOportunidade persist);
        
        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        System.Threading.Tasks.Task<OportunidadeResponse> SalvarUsingPOST12Async (OportunidadePersist persist);

        /// <summary>
        /// Cadastra as oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarUsingPOST12AsyncWithHttpInfo (OportunidadePersist persist);
        
        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        System.Threading.Tasks.Task<TipoOportunidadeResponse> SalvarUsingPOST17Async (TipoOportunidade persist);

        /// <summary>
        /// Cadastra tipos oportunidades
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar tipos oportunidades.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> SalvarUsingPOST17AsyncWithHttpInfo (TipoOportunidade persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OportunidadeApi : IOportunidadeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OportunidadeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OportunidadeApi(Configuration configuration = null)
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
        /// Altera o status do tipo oportunidade Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse AlterarStatusUsingPUT (long? id, long? idStatus, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = AlterarStatusUsingPUTWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > AlterarStatusUsingPUTWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarStatusUsingPUT");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OportunidadeApi->AlterarStatusUsingPUT");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->AlterarStatusUsingPUT");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> AlterarStatusUsingPUTAsync (long? id, long? idStatus, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await AlterarStatusUsingPUTAsyncWithHttpInfo(id, idStatus, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera o status do tipo oportunidade Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> AlterarStatusUsingPUTAsyncWithHttpInfo (long? id, long? idStatus, StatusOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarStatusUsingPUT");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling AlterarStatusUsingPUT");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarStatusUsingPUT");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarStatusUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Altera as oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse AlterarUsingPUT4 (long? id, OportunidadeUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = AlterarUsingPUT4WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera as oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > AlterarUsingPUT4WithHttpInfo (long? id, OportunidadeUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarUsingPUT4");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling OportunidadeApi->AlterarUsingPUT4");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera as oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> AlterarUsingPUT4Async (long? id, OportunidadeUpdate update)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await AlterarUsingPUT4AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera as oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, OportunidadeUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT4");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT4");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
            
            
            
            
            if (update.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(update); // http body (model) parameter
            }
            else
            {
                localVarPostBody = update; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Altera os tipos oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse AlterarUsingPUT8 (long? id, TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = AlterarUsingPUT8WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera os tipos oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > AlterarUsingPUT8WithHttpInfo (long? id, TipoOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->AlterarUsingPUT8");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->AlterarUsingPUT8");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Altera os tipos oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> AlterarUsingPUT8Async (long? id, TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await AlterarUsingPUT8AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera os tipos oportunidades Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> AlterarUsingPUT8AsyncWithHttpInfo (long? id, TipoOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT8");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling AlterarUsingPUT8");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse ConsultarStatusUsingGET (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = ConsultarStatusUsingGETWithHttpInfo(id, idStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > ConsultarStatusUsingGETWithHttpInfo (long? id, long? idStatus)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarStatusUsingGET");
            
            // verify the required parameter 'idStatus' is set
            if (idStatus == null)
                throw new ApiException(400, "Missing required parameter 'idStatus' when calling OportunidadeApi->ConsultarStatusUsingGET");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> ConsultarStatusUsingGETAsync (long? id, long? idStatus)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await ConsultarStatusUsingGETAsyncWithHttpInfo(id, idStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado status do tipo oportunidade Este recurso permite consultar dados de um determinado status do tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (idStatus).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="idStatus">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do status (idStatus).</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> ConsultarStatusUsingGETAsyncWithHttpInfo (long? id, long? idStatus)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarStatusUsingGET");
            // verify the required parameter 'idStatus' is set
            if (idStatus == null) throw new ApiException(400, "Missing required parameter 'idStatus' when calling ConsultarStatusUsingGET");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status/{idStatus}";
    
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
            if (idStatus != null) localVarPathParams.Add("idStatus", Configuration.ApiClient.ParameterToString(idStatus)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse ConsultarUsingGET10 (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarUsingGET10");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de uma determinada oportunidade Este recurso permite consultar dados de uma determinada oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da oportunidade (id).</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
            var localVarPath = "/api/oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse ConsultarUsingGET22 (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = ConsultarUsingGET22WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > ConsultarUsingGET22WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ConsultarUsingGET22");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> ConsultarUsingGET22Async (long? id)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await ConsultarUsingGET22AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta dados de um determinado tipo oportunidade Este recurso permite consultar dados de um determinado tipo oportunidade a partir de seu codigo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> ConsultarUsingGET22AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET22");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>PageStatusOportunidadeAUDResponse</returns>
        public PageStatusOportunidadeAUDResponse ListarAuditoriasStatusUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = ListarAuditoriasStatusUsingGETWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeAUDResponse</returns>
        public ApiResponse< PageStatusOportunidadeAUDResponse > ListarAuditoriasStatusUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageStatusOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeAUDResponse> ListarAuditoriasStatusUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageStatusOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasStatusUsingGETAsyncWithHttpInfo(sort, page, limit, revType, revDate, id, idTipoOportunidade, nome, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias dos status oportunidades Este recurso permite listar os status oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="idTipoOportunidade">C\u00C3\u00B3digo identificador do tipo oportunidade (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeAUDResponse>> ListarAuditoriasStatusUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, long? idTipoOportunidade = null, string nome = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-status-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoOportunidade != null) localVarQueryParams.Add("idTipoOportunidade", Configuration.ApiClient.ParameterToString(idTipoOportunidade)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param> 
        /// <param name="revDate">Data da auditoria (optional)</param> 
        /// <param name="revType">Tipo da auditoria (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>PageOportunidadeAUDResponse</returns>
        public PageOportunidadeAUDResponse ListarAuditoriasUsingGET (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = ListarAuditoriasUsingGETWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param> 
        /// <param name="revDate">Data da auditoria (optional)</param> 
        /// <param name="revType">Tipo da auditoria (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeAUDResponse</returns>
        public ApiResponse< PageOportunidadeAUDResponse > ListarAuditoriasUsingGETWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeAUDResponse> ListarAuditoriasUsingGETAsync (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
             ApiResponse<PageOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasUsingGETAsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, datatFimVigencia, flagAtivo, revDate, revType, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias das oportunidades Este recurso permite listar as auditorias das oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">In\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="datatFimVigencia">Fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <param name="revDate">Data da auditoria (optional)</param>
        /// <param name="revType">Tipo da auditoria (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeAUDResponse>> ListarAuditoriasUsingGETAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string datatFimVigencia = null, bool? flagAtivo = null, string revDate = null, string revType = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (datatFimVigencia != null) localVarQueryParams.Add("datatFimVigencia", Configuration.ApiClient.ParameterToString(datatFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>PageTipoOportunidadeAUDResponse</returns>
        public PageTipoOportunidadeAUDResponse ListarAuditoriasUsingGET1 (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = ListarAuditoriasUsingGET1WithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param> 
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeAUDResponse</returns>
        public ApiResponse< PageTipoOportunidadeAUDResponse > ListarAuditoriasUsingGET1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }

        
        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of PageTipoOportunidadeAUDResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeAUDResponse> ListarAuditoriasUsingGET1Async (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
             ApiResponse<PageTipoOportunidadeAUDResponse> localVarResponse = await ListarAuditoriasUsingGET1AsyncWithHttpInfo(sort, page, limit, revType, revDate, id, descricao, flagAtivo, revUser);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as auditorias dos tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="revType">C\u00C3\u00B3digo que representa o tipo de a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="revDate">Data da a\u00C3\u00A7\u00C3\u00A3o realizada no recurso de tipos oportunidades (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo identificador do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade no qual foi realizado a a\u00C3\u00A7\u00C3\u00A3o (optional)</param>
        /// <param name="flagAtivo">Atributo que representa se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <param name="revUser">Usu\u00C3\u00A1rio da auditoria (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeAUDResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeAUDResponse>> ListarAuditoriasUsingGET1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? revType = null, string revDate = null, long? id = null, string descricao = null, bool? flagAtivo = null, string revUser = null)
        {
            
    
            var localVarPath = "/api/auditorias-tipos-oportunidades";
    
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
            if (revType != null) localVarQueryParams.Add("revType", Configuration.ApiClient.ParameterToString(revType)); // query parameter
            if (revDate != null) localVarQueryParams.Add("revDate", Configuration.ApiClient.ParameterToString(revDate)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (revUser != null) localVarQueryParams.Add("revUser", Configuration.ApiClient.ParameterToString(revUser)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarAuditoriasUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeAUDResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeAUDResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeAUDResponse)));
            
        }
        
        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>PageStatusOportunidadeResponse</returns>
        public PageStatusOportunidadeResponse ListarStatusUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = ListarStatusUsingGETWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="nome">Nome do status oportunidade (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>ApiResponse of PageStatusOportunidadeResponse</returns>
        public ApiResponse< PageStatusOportunidadeResponse > ListarStatusUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->ListarStatusUsingGET");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PageStatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageStatusOportunidadeResponse> ListarStatusUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageStatusOportunidadeResponse> localVarResponse = await ListarStatusUsingGETAsyncWithHttpInfo(id, sort, page, limit, nome, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os status do tipo oportunidades Este recurso permite listar os status do tipo oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="nome">Nome do status oportunidade (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do status oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o status oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageStatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageStatusOportunidadeResponse>> ListarStatusUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null, string nome = null, string descricao = null, bool? flagAtivo = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarStatusUsingGET");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarStatusUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageStatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageStatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageStatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param> 
        /// <returns>PageOportunidadeResponse</returns>
        public PageOportunidadeResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = ListarUsingGET14WithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param> 
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param> 
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param> 
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param> 
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param> 
        /// <returns>ApiResponse of PageOportunidadeResponse</returns>
        public ApiResponse< PageOportunidadeResponse > ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>Task of PageOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageOportunidadeResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
             ApiResponse<PageOportunidadeResponse> localVarResponse = await ListarUsingGET14AsyncWithHttpInfo(sort, page, limit, idStatusOportunidade, dataCadastro, dataAtualizacao, numeroReceitaFederal, dataInicioVigencia, dataFimVigencia, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as oportunidades Este recurso permite listar as oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idStatusOportunidade">C\u00C3\u00B3digo identificador do status oportunidade (optional)</param>
        /// <param name="dataCadastro">Data do cadastro da oportunidade (optional)</param>
        /// <param name="dataAtualizacao">Data da atualiza\u00C3\u00A7\u00C3\u00A3o da oportunidade (optional)</param>
        /// <param name="numeroReceitaFederal">N\u00C3\u00BAmero receita federal do cliente ao qual ser\u00C3\u00A1 ofertada a oportunidade (optional)</param>
        /// <param name="dataInicioVigencia">Data de in\u00C3\u00ADcio da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="dataFimVigencia">Data do fim da vig\u00C3\u00AAncia da oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se a oportunidade est\u00C3\u00A1 ativa (optional)</param>
        /// <returns>Task of ApiResponse (PageOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOportunidadeResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idStatusOportunidade = null, string dataCadastro = null, string dataAtualizacao = null, string numeroReceitaFederal = null, string dataInicioVigencia = null, string dataFimVigencia = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/oportunidades";
    
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
            if (idStatusOportunidade != null) localVarQueryParams.Add("idStatusOportunidade", Configuration.ApiClient.ParameterToString(idStatusOportunidade)); // query parameter
            if (dataCadastro != null) localVarQueryParams.Add("dataCadastro", Configuration.ApiClient.ParameterToString(dataCadastro)); // query parameter
            if (dataAtualizacao != null) localVarQueryParams.Add("dataAtualizacao", Configuration.ApiClient.ParameterToString(dataAtualizacao)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (dataInicioVigencia != null) localVarQueryParams.Add("dataInicioVigencia", Configuration.ApiClient.ParameterToString(dataInicioVigencia)); // query parameter
            if (dataFimVigencia != null) localVarQueryParams.Add("dataFimVigencia", Configuration.ApiClient.ParameterToString(dataFimVigencia)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>PageTipoOportunidadeResponse</returns>
        public PageTipoOportunidadeResponse ListarUsingGET27 (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = ListarUsingGET27WithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param> 
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param> 
        /// <returns>ApiResponse of PageTipoOportunidadeResponse</returns>
        public ApiResponse< PageTipoOportunidadeResponse > ListarUsingGET27WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of PageTipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoOportunidadeResponse> ListarUsingGET27Async (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
             ApiResponse<PageTipoOportunidadeResponse> localVarResponse = await ListarUsingGET27AsyncWithHttpInfo(sort, page, limit, descricao, flagAtivo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os tipos oportunidades Este recurso permite listar os tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (optional)</param>
        /// <param name="flagAtivo">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o tipo oportunidade est\u00C3\u00A1 ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoOportunidadeResponse>> ListarUsingGET27AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string descricao = null, bool? flagAtivo = null)
        {
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET27: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>StatusOportunidadeResponse</returns>
        public StatusOportunidadeResponse SalvarStatusUsingPOST (long? id, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = SalvarStatusUsingPOSTWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of StatusOportunidadeResponse</returns>
        public ApiResponse< StatusOportunidadeResponse > SalvarStatusUsingPOSTWithHttpInfo (long? id, StatusOportunidade persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OportunidadeApi->SalvarStatusUsingPOST");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarStatusUsingPOST");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of StatusOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<StatusOportunidadeResponse> SalvarStatusUsingPOSTAsync (long? id, StatusOportunidade persist)
        {
             ApiResponse<StatusOportunidadeResponse> localVarResponse = await SalvarStatusUsingPOSTAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra status para o tipo oportunidade Esse recurso permite cadastrar status para o tipo oportunidade.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo oportunidade (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (StatusOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusOportunidadeResponse>> SalvarStatusUsingPOSTAsyncWithHttpInfo (long? id, StatusOportunidade persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarStatusUsingPOST");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarStatusUsingPOST");
            
    
            var localVarPath = "/api/tipos-oportunidades/{id}/status";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarStatusUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StatusOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusOportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>OportunidadeResponse</returns>
        public OportunidadeResponse SalvarUsingPOST12 (OportunidadePersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = SalvarUsingPOST12WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of OportunidadeResponse</returns>
        public ApiResponse< OportunidadeResponse > SalvarUsingPOST12WithHttpInfo (OportunidadePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarUsingPOST12");
            
    
            var localVarPath = "/api/oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of OportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<OportunidadeResponse> SalvarUsingPOST12Async (OportunidadePersist persist)
        {
             ApiResponse<OportunidadeResponse> localVarResponse = await SalvarUsingPOST12AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra as oportunidades Esse recurso permite cadastrar oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (OportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OportunidadeResponse>> SalvarUsingPOST12AsyncWithHttpInfo (OportunidadePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST12");
            
    
            var localVarPath = "/api/oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OportunidadeResponse)));
            
        }
        
        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>TipoOportunidadeResponse</returns>
        public TipoOportunidadeResponse SalvarUsingPOST17 (TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = SalvarUsingPOST17WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of TipoOportunidadeResponse</returns>
        public ApiResponse< TipoOportunidadeResponse > SalvarUsingPOST17WithHttpInfo (TipoOportunidade persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling OportunidadeApi->SalvarUsingPOST17");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }

        
        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of TipoOportunidadeResponse</returns>
        public async System.Threading.Tasks.Task<TipoOportunidadeResponse> SalvarUsingPOST17Async (TipoOportunidade persist)
        {
             ApiResponse<TipoOportunidadeResponse> localVarResponse = await SalvarUsingPOST17AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra tipos oportunidades Esse recurso permite cadastrar tipos oportunidades.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (TipoOportunidadeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoOportunidadeResponse>> SalvarUsingPOST17AsyncWithHttpInfo (TipoOportunidade persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST17");
            
    
            var localVarPath = "/api/tipos-oportunidades";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST17: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoOportunidadeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoOportunidadeResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoOportunidadeResponse)));
            
        }
        
    }
    
}