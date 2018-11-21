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
    public interface IGlobaltagusuarioApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>string</returns>
        string AlterarSenhaLoginUsingPOST (string login, string senhaNova);
  
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaLoginUsingPOSTWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>string</returns>
        string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova);
  
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AlterarUsingPUT21 (long? id, UsuarioUpdateValue update);
  
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AlterarUsingPUT21WithHttpInfo (long? id, UsuarioUpdateValue update);
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse AtivarUsuarioUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> AtivarUsuarioUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse AtualizarUsingPUT1 (long? id, ControleSegurancaDispositivoUpdateValor update);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> AtualizarUsingPUT1WithHttpInfo (long? id, ControleSegurancaDispositivoUpdateValor update);
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageUsuarioContasResponse</returns>
        PageUsuarioContasResponse ConsultarContasVinculadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        ApiResponse<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        PageControleSegurancaDispositivoResponse ConsultarUsingGET13 (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        ApiResponse<PageControleSegurancaDispositivoResponse> ConsultarUsingGET13WithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse ConsultarUsingGET49 (long? id);
  
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> ConsultarUsingGET49WithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse DeletarUsingDELETE (long? id);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> DeletarUsingDELETEWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse DesativarUsuarioUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> DesativarUsuarioUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>PageUsuarioResponse</returns>
        PageUsuarioResponse ListarUsingGET58 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
  
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        ApiResponse<PageUsuarioResponse> ListarUsingGET58WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>string</returns>
        string RecuperarSenhaUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RecuperarSenhaUsingPOSTWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>UsuarioResponse</returns>
        UsuarioResponse SalvarUsingPOST31 (UsuarioPersistencia persist);
  
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of UsuarioResponse</returns>
        ApiResponse<UsuarioResponse> SalvarUsingPOST31WithHttpInfo (UsuarioPersistencia persist);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        ControleSegurancaDispositivoResponse SalvarUsingPOST8 (ControleSegurancaDispositivoPersistencia persist);
  
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        ApiResponse<ControleSegurancaDispositivoResponse> SalvarUsingPOST8WithHttpInfo (ControleSegurancaDispositivoPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>string</returns>
        string ValidarSenhaForteUsingPOST (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaForteUsingPOSTWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Object</returns>
        Object ValidarSenhaLoginUsingPOST (string login, string senha, ValidarSenhaLoginRequest request = null);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ValidarSenhaLoginUsingPOSTWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>string</returns>
        string ValidarSenhaUsingGET1 (string senha, long? id);
  
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>string</returns>
        string VincularContasUsingPOST (long? id);
  
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> VincularContasUsingPOSTWithHttpInfo (long? id);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaLoginUsingPOSTAsync (string login, string senhaNova);

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova);

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova);
        
        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AlterarUsingPUT21Async (long? id, UsuarioUpdateValue update);

        /// <summary>
        /// {{{usuario_resource_alterar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_alterar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsingPUT21AsyncWithHttpInfo (long? id, UsuarioUpdateValue update);
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_ativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarUsingPUT1Async (long? id, ControleSegurancaDispositivoUpdateValor update);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ControleSegurancaDispositivoUpdateValor update);
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarUsingGET13Async (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsingGET49Async (long? id);

        /// <summary>
        /// {{{usuario_resource_consultar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_consultar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsingGET49AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarUsingDELETEAsync (long? id);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarUsingDELETEAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_desativar_usuario_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsingGET58Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);

        /// <summary>
        /// {{{usuario_resource_listar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_listar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsingGET58AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null);
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_recuperar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaUsingPOSTAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        System.Threading.Tasks.Task<UsuarioResponse> SalvarUsingPOST31Async (UsuarioPersistencia persist);

        /// <summary>
        /// {{{usuario_resource_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_salvar_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsingPOST31AsyncWithHttpInfo (UsuarioPersistencia persist);
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarUsingPOST8Async (ControleSegurancaDispositivoPersistencia persist);

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}}
        /// </summary>
        /// <remarks>
        /// {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarUsingPOST8AsyncWithHttpInfo (ControleSegurancaDispositivoPersistencia persist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaForteUsingPOSTAsync (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_forte_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteUsingPOSTAsyncWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ValidarSenhaLoginUsingPOSTAsync (string login, string senha, ValidarSenhaLoginRequest request = null);

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_login_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null);
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id);

        /// <summary>
        /// {{{usuario_resource_validar_senha}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_resource_validar_senha_notes}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGET1AsyncWithHttpInfo (string senha, long? id);
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> VincularContasUsingPOSTAsync (long? id);

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}}
        /// </summary>
        /// <remarks>
        /// {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> VincularContasUsingPOSTAsyncWithHttpInfo (long? id);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobaltagusuarioApi : IGlobaltagusuarioApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagusuarioApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobaltagusuarioApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobaltagusuarioApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobaltagusuarioApi(Configuration configuration = null)
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
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param> 
        /// <returns>string</returns>
        public string AlterarSenhaLoginUsingPOST (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaLoginUsingPOSTWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaLoginUsingPOSTWithHttpInfo (string login, string senhaNova)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling GlobaltagusuarioApi->AlterarSenhaLoginUsingPOST");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling GlobaltagusuarioApi->AlterarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/alterar-senha";
    
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
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senhaNova != null) localVarHeaderParams.Add("senhaNova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaLoginUsingPOSTAsync (string login, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo(login, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha_login}}} {{{usuario_resource_alterar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_alterar_senha_login_param_login}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_login_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senhaNova)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling AlterarSenhaLoginUsingPOST");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/alterar-senha";
    
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
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senhaNova != null) localVarHeaderParams.Add("senhaNova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param> 
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param> 
        /// <returns>string</returns>
        public string AlterarSenhaUsingPUT (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = AlterarSenhaUsingPUTWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param> 
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param> 
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AlterarSenhaUsingPUTWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null)
                throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null)
                throw new ApiException(400, "Missing required parameter 'senhaNova' when calling GlobaltagusuarioApi->AlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/usuarios/{id}/alterar-senha";
    
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
            
            
            if (senhaAtual != null) localVarHeaderParams.Add("senha_atual", Configuration.ApiClient.ParameterToString(senhaAtual)); // header parameter
            if (senhaNova != null) localVarHeaderParams.Add("senha_nova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AlterarSenhaUsingPUTAsync (long? id, string senhaAtual, string senhaNova)
        {
             ApiResponse<string> localVarResponse = await AlterarSenhaUsingPUTAsyncWithHttpInfo(id, senhaAtual, senhaNova);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar_senha}}} {{{usuario_resource_alterar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_senha_param_id}}}</param>
        /// <param name="senhaAtual">{{{usuario_resource_alterar_senha_param_senha_atual}}}</param>
        /// <param name="senhaNova">{{{usuario_resource_alterar_senha_param_senha_nova}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AlterarSenhaUsingPUTAsyncWithHttpInfo (long? id, string senhaAtual, string senhaNova)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarSenhaUsingPUT");
            // verify the required parameter 'senhaAtual' is set
            if (senhaAtual == null) throw new ApiException(400, "Missing required parameter 'senhaAtual' when calling AlterarSenhaUsingPUT");
            // verify the required parameter 'senhaNova' is set
            if (senhaNova == null) throw new ApiException(400, "Missing required parameter 'senhaNova' when calling AlterarSenhaUsingPUT");
            
    
            var localVarPath = "/api/usuarios/{id}/alterar-senha";
    
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
            
            
            if (senhaAtual != null) localVarHeaderParams.Add("senha_atual", Configuration.ApiClient.ParameterToString(senhaAtual)); // header parameter
            if (senhaNova != null) localVarHeaderParams.Add("senha_nova", Configuration.ApiClient.ParameterToString(senhaNova)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarSenhaUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AlterarUsingPUT21 (long? id, UsuarioUpdateValue update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AlterarUsingPUT21WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AlterarUsingPUT21WithHttpInfo (long? id, UsuarioUpdateValue update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AlterarUsingPUT21");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagusuarioApi->AlterarUsingPUT21");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AlterarUsingPUT21Async (long? id, UsuarioUpdateValue update)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AlterarUsingPUT21AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_alterar}}} {{{usuario_resource_alterar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_alterar_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AlterarUsingPUT21AsyncWithHttpInfo (long? id, UsuarioUpdateValue update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT21");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AlterarUsingPUT21");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse AtivarUsuarioUsingPOST (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = AtivarUsuarioUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > AtivarUsuarioUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AtivarUsuarioUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/ativar-usuario";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> AtivarUsuarioUsingPOSTAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await AtivarUsuarioUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_ativar_usuario}}} {{{usuario_resource_ativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_ativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> AtivarUsuarioUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtivarUsuarioUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/ativar-usuario";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtivarUsuarioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse AtualizarUsingPUT1 (long? id, ControleSegurancaDispositivoUpdateValor update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = AtualizarUsingPUT1WithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > AtualizarUsingPUT1WithHttpInfo (long? id, ControleSegurancaDispositivoUpdateValor update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->AtualizarUsingPUT1");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling GlobaltagusuarioApi->AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> AtualizarUsingPUT1Async (long? id, ControleSegurancaDispositivoUpdateValor update)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await AtualizarUsingPUT1AsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_atualizar}}} {{{controle_seguranca_dispositivo_atualizar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> AtualizarUsingPUT1AsyncWithHttpInfo (long? id, ControleSegurancaDispositivoUpdateValor update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarUsingPUT1");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarUsingPUT1");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageUsuarioContasResponse</returns>
        public PageUsuarioContasResponse ConsultarContasVinculadasUsingGET (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = ConsultarContasVinculadasUsingGETWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioContasResponse</returns>
        public ApiResponse< PageUsuarioContasResponse > ConsultarContasVinculadasUsingGETWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ConsultarContasVinculadasUsingGET");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-contas";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageUsuarioContasResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioContasResponse> ConsultarContasVinculadasUsingGETAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageUsuarioContasResponse> localVarResponse = await ConsultarContasVinculadasUsingGETAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_recurso_listar_por_id_usuario}}} {{{usuario_recurso_listar_por_id_usuario_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_listar_por_id_param_id_usuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioContasResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioContasResponse>> ConsultarContasVinculadasUsingGETAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarContasVinculadasUsingGET");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-contas";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarContasVinculadasUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioContasResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioContasResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioContasResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>PageControleSegurancaDispositivoResponse</returns>
        public PageControleSegurancaDispositivoResponse ConsultarUsingGET13 (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = ConsultarUsingGET13WithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param> 
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <returns>ApiResponse of PageControleSegurancaDispositivoResponse</returns>
        public ApiResponse< PageControleSegurancaDispositivoResponse > ConsultarUsingGET13WithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null)
                throw new ApiException(400, "Missing required parameter 'idUsuario' when calling GlobaltagusuarioApi->ConsultarUsingGET13");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
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
            
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of PageControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<PageControleSegurancaDispositivoResponse> ConsultarUsingGET13Async (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageControleSegurancaDispositivoResponse> localVarResponse = await ConsultarUsingGET13AsyncWithHttpInfo(idUsuario, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_consultar}}} {{{controle_seguranca_dispositivo_consultar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idUsuario">{{{usuario_resource_consultar_param_idUsuario}}}</param>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageControleSegurancaDispositivoResponse>> ConsultarUsingGET13AsyncWithHttpInfo (long? idUsuario, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'idUsuario' is set
            if (idUsuario == null) throw new ApiException(400, "Missing required parameter 'idUsuario' when calling ConsultarUsingGET13");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
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
            
            if (idUsuario != null) localVarQueryParams.Add("idUsuario", Configuration.ApiClient.ParameterToString(idUsuario)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse ConsultarUsingGET49 (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = ConsultarUsingGET49WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > ConsultarUsingGET49WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ConsultarUsingGET49");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> ConsultarUsingGET49Async (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await ConsultarUsingGET49AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_consultar}}} {{{usuario_resource_consultar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_consultar_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> ConsultarUsingGET49AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET49");
            
    
            var localVarPath = "/api/usuarios/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET49: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}} {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse DeletarUsingDELETE (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = DeletarUsingDELETEWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}} {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > DeletarUsingDELETEWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->DeletarUsingDELETE");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}} {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> DeletarUsingDELETEAsync (long? id)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await DeletarUsingDELETEAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_deletar}}} {{{controle_seguranca_dispositivo_deletar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{controle_seguranca_dispositivo_resource_param_id}}}</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> DeletarUsingDELETEAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletarUsingDELETE");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeletarUsingDELETE: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletarUsingDELETE: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse DesativarUsuarioUsingPOST (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = DesativarUsuarioUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > DesativarUsuarioUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->DesativarUsuarioUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/desativar-usuario";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> DesativarUsuarioUsingPOSTAsync (long? id)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await DesativarUsuarioUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_desativar_usuario}}} {{{usuario_resource_desativar_usuario_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_desativar_usuario_param_id}}}</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> DesativarUsuarioUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DesativarUsuarioUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/desativar-usuario";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DesativarUsuarioUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param> 
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param> 
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param> 
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param> 
        /// <returns>PageUsuarioResponse</returns>
        public PageUsuarioResponse ListarUsingGET58 (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = ListarUsingGET58WithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param> 
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param> 
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param> 
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param> 
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param> 
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param> 
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param> 
        /// <returns>ApiResponse of PageUsuarioResponse</returns>
        public ApiResponse< PageUsuarioResponse > ListarUsingGET58WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
            
    
            var localVarPath = "/api/usuarios";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of PageUsuarioResponse</returns>
        public async System.Threading.Tasks.Task<PageUsuarioResponse> ListarUsingGET58Async (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
             ApiResponse<PageUsuarioResponse> localVarResponse = await ListarUsingGET58AsyncWithHttpInfo(sort, page, limit, nome, cpf, email, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_listar}}} {{{usuario_resource_listar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">{{{global_menssagem_sort_sort}}} (optional)</param>
        /// <param name="page">{{{global_menssagem_sort_page_value}}} (optional)</param>
        /// <param name="limit">{{{global_menssagem_sort_limit}}} (optional)</param>
        /// <param name="nome">{{{usuario_request_nome_value}}} (optional)</param>
        /// <param name="cpf">{{{usuario_request_cpf_value}}} (optional)</param>
        /// <param name="email">{{{usuario_request_email_value}}} (optional)</param>
        /// <param name="status">{{{usuario_request_status_value}}} (optional)</param>
        /// <returns>Task of ApiResponse (PageUsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageUsuarioResponse>> ListarUsingGET58AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null, string cpf = null, string email = null, string status = null)
        {
            
    
            var localVarPath = "/api/usuarios";
    
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
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET58: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageUsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageUsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageUsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param> 
        /// <returns>string</returns>
        public string RecuperarSenhaUsingPOST (long? id)
        {
             ApiResponse<string> localVarResponse = RecuperarSenhaUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RecuperarSenhaUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->RecuperarSenhaUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/recuperar-senha";
    
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RecuperarSenhaUsingPOSTAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await RecuperarSenhaUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_recuperar_senha}}} {{{usuario_resource_recuperar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_resource_recuperar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RecuperarSenhaUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RecuperarSenhaUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/recuperar-senha";
    
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
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RecuperarSenhaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>UsuarioResponse</returns>
        public UsuarioResponse SalvarUsingPOST31 (UsuarioPersistencia persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = SalvarUsingPOST31WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of UsuarioResponse</returns>
        public ApiResponse< UsuarioResponse > SalvarUsingPOST31WithHttpInfo (UsuarioPersistencia persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagusuarioApi->SalvarUsingPOST31");
            
    
            var localVarPath = "/api/usuarios";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of UsuarioResponse</returns>
        public async System.Threading.Tasks.Task<UsuarioResponse> SalvarUsingPOST31Async (UsuarioPersistencia persist)
        {
             ApiResponse<UsuarioResponse> localVarResponse = await SalvarUsingPOST31AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_salvar}}} {{{usuario_resource_salvar_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (UsuarioResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UsuarioResponse>> SalvarUsingPOST31AsyncWithHttpInfo (UsuarioPersistencia persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST31");
            
    
            var localVarPath = "/api/usuarios";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST31: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST31: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UsuarioResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UsuarioResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UsuarioResponse)));
            
        }
        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ControleSegurancaDispositivoResponse</returns>
        public ControleSegurancaDispositivoResponse SalvarUsingPOST8 (ControleSegurancaDispositivoPersistencia persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = SalvarUsingPOST8WithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of ControleSegurancaDispositivoResponse</returns>
        public ApiResponse< ControleSegurancaDispositivoResponse > SalvarUsingPOST8WithHttpInfo (ControleSegurancaDispositivoPersistencia persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling GlobaltagusuarioApi->SalvarUsingPOST8");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }

        
        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ControleSegurancaDispositivoResponse</returns>
        public async System.Threading.Tasks.Task<ControleSegurancaDispositivoResponse> SalvarUsingPOST8Async (ControleSegurancaDispositivoPersistencia persist)
        {
             ApiResponse<ControleSegurancaDispositivoResponse> localVarResponse = await SalvarUsingPOST8AsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{controle_seguranca_dispositivo_salvar}}} {{{controle_seguranca_dispositivo_salvar_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (ControleSegurancaDispositivoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ControleSegurancaDispositivoResponse>> SalvarUsingPOST8AsyncWithHttpInfo (ControleSegurancaDispositivoPersistencia persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarUsingPOST8");
            
    
            var localVarPath = "/api/controles-seguranca-dispositivos";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ControleSegurancaDispositivoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ControleSegurancaDispositivoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ControleSegurancaDispositivoResponse)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param> 
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param> 
        /// <returns>string</returns>
        public string ValidarSenhaForteUsingPOST (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaForteUsingPOSTWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param> 
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaForteUsingPOSTWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaForteUsingPOST");
            
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null)
                throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling GlobaltagusuarioApi->ValidarSenhaForteUsingPOST");
            
    
            var localVarPath = "/api/usuarios/validar-senha-forte";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (usuarioSenhaFortePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(usuarioSenhaFortePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = usuarioSenhaFortePersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaForteUsingPOSTAsync (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaForteUsingPOSTAsyncWithHttpInfo(senha, usuarioSenhaFortePersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_forte}}} {{{usuario_resource_validar_senha_forte_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_forte_param_senha}}}</param>
        /// <param name="usuarioSenhaFortePersist">{{{usuario_resource_validar_senha_forte_param_id_plataforma}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaForteUsingPOSTAsyncWithHttpInfo (string senha, UsuarioSenhaFortePersistencia usuarioSenhaFortePersist)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaForteUsingPOST");
            // verify the required parameter 'usuarioSenhaFortePersist' is set
            if (usuarioSenhaFortePersist == null) throw new ApiException(400, "Missing required parameter 'usuarioSenhaFortePersist' when calling ValidarSenhaForteUsingPOST");
            
    
            var localVarPath = "/api/usuarios/validar-senha-forte";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (usuarioSenhaFortePersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(usuarioSenhaFortePersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = usuarioSenhaFortePersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaForteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param> 
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>Object</returns>
        public Object ValidarSenhaLoginUsingPOST (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = ValidarSenhaLoginUsingPOSTWithHttpInfo(login, senha, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param> 
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param> 
        /// <param name="request">request (optional)</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ValidarSenhaLoginUsingPOSTWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            
            // verify the required parameter 'login' is set
            if (login == null)
                throw new ApiException(400, "Missing required parameter 'login' when calling GlobaltagusuarioApi->ValidarSenhaLoginUsingPOST");
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/validar-senha";
    
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
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ValidarSenhaLoginUsingPOSTAsync (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
             ApiResponse<Object> localVarResponse = await ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo(login, senha, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha_login}}} {{{usuario_resource_validar_senha_login_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="login">{{{usuario_resource_validar_senha_login_param_login}}}</param>
        /// <param name="senha">{{{usuario_resource_validar_senha_login_param_senha}}}</param>
        /// <param name="request">request (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ValidarSenhaLoginUsingPOSTAsyncWithHttpInfo (string login, string senha, ValidarSenhaLoginRequest request = null)
        {
            // verify the required parameter 'login' is set
            if (login == null) throw new ApiException(400, "Missing required parameter 'login' when calling ValidarSenhaLoginUsingPOST");
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaLoginUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{login}/validar-senha";
    
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
            if (login != null) localVarPathParams.Add("login", Configuration.ApiClient.ParameterToString(login)); // path parameter
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaLoginUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param> 
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param> 
        /// <returns>string</returns>
        public string ValidarSenhaUsingGET1 (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = ValidarSenhaUsingGET1WithHttpInfo(senha, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param> 
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ValidarSenhaUsingGET1WithHttpInfo (string senha, long? id)
        {
            
            // verify the required parameter 'senha' is set
            if (senha == null)
                throw new ApiException(400, "Missing required parameter 'senha' when calling GlobaltagusuarioApi->ValidarSenhaUsingGET1");
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->ValidarSenhaUsingGET1");
            
    
            var localVarPath = "/api/usuarios/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ValidarSenhaUsingGET1Async (string senha, long? id)
        {
             ApiResponse<string> localVarResponse = await ValidarSenhaUsingGET1AsyncWithHttpInfo(senha, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_resource_validar_senha}}} {{{usuario_resource_validar_senha_notes}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senha">{{{usuario_resource_validar_senha_param_senha}}}</param>
        /// <param name="id">{{{usuario_resource_validar_senha_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ValidarSenhaUsingGET1AsyncWithHttpInfo (string senha, long? id)
        {
            // verify the required parameter 'senha' is set
            if (senha == null) throw new ApiException(400, "Missing required parameter 'senha' when calling ValidarSenhaUsingGET1");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ValidarSenhaUsingGET1");
            
    
            var localVarPath = "/api/usuarios/{id}/validar-senha";
    
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
            
            
            if (senha != null) localVarHeaderParams.Add("senha", Configuration.ApiClient.ParameterToString(senha)); // header parameter
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ValidarSenhaUsingGET1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param> 
        /// <returns>string</returns>
        public string VincularContasUsingPOST (long? id)
        {
             ApiResponse<string> localVarResponse = VincularContasUsingPOSTWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > VincularContasUsingPOSTWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling GlobaltagusuarioApi->VincularContasUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-usuarios";
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> VincularContasUsingPOSTAsync (long? id)
        {
             ApiResponse<string> localVarResponse = await VincularContasUsingPOSTAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// {{{usuario_recurso_vincular_usuarios}}} {{{usuario_recurso_vincular_usuarios_notas}}}
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">{{{usuario_recurso_vincular_usuarios_param_id}}}</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> VincularContasUsingPOSTAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VincularContasUsingPOST");
            
    
            var localVarPath = "/api/usuarios/{id}/vincular-usuarios";
    
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
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling VincularContasUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
    }
    
}