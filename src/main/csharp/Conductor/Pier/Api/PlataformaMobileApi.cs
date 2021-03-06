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
    public interface IPlataformaMobileApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar plataforma mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>PlataformaMobileResponse</returns>
        PlataformaMobileResponse AtualizarPlataformaMobile (long? id, PlataformaMobileUpdate update);
  
        /// <summary>
        /// Atualiza Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar plataforma mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        ApiResponse<PlataformaMobileResponse> AtualizarPlataformaMobileWithHttpInfo (long? id, PlataformaMobileUpdate update);
        
        /// <summary>
        /// Lista as plataformas mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>PagePlataformaMobileResponse</returns>
        PagePlataformaMobileResponse ListarPlataformasMobile (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
  
        /// <summary>
        /// Lista as plataformas mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>ApiResponse of PagePlataformaMobileResponse</returns>
        ApiResponse<PagePlataformaMobileResponse> ListarPlataformasMobileWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Cadastra Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar plataformas mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>PlataformaMobileResponse</returns>
        PlataformaMobileResponse SalvarPlataformaMobile (PlataformaMobilePersist persist);
  
        /// <summary>
        /// Cadastra Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar plataformas mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        ApiResponse<PlataformaMobileResponse> SalvarPlataformaMobileWithHttpInfo (PlataformaMobilePersist persist);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar plataforma mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PlataformaMobileResponse> AtualizarPlataformaMobileAsync (long? id, PlataformaMobileUpdate update);

        /// <summary>
        /// Atualiza Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite atualizar plataforma mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> AtualizarPlataformaMobileAsyncWithHttpInfo (long? id, PlataformaMobileUpdate update);
        
        /// <summary>
        /// Lista as plataformas mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>Task of PagePlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PagePlataformaMobileResponse> ListarPlataformasMobileAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null);

        /// <summary>
        /// Lista as plataformas mobile cadastradas
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PagePlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePlataformaMobileResponse>> ListarPlataformasMobileAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null);
        
        /// <summary>
        /// Cadastra Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar plataformas mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        System.Threading.Tasks.Task<PlataformaMobileResponse> SalvarPlataformaMobileAsync (PlataformaMobilePersist persist);

        /// <summary>
        /// Cadastra Plataforma Mobile
        /// </summary>
        /// <remarks>
        /// Esse recurso permite cadastrar plataformas mobile
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> SalvarPlataformaMobileAsyncWithHttpInfo (PlataformaMobilePersist persist);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlataformaMobileApi : IPlataformaMobileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlataformaMobileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlataformaMobileApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlataformaMobileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlataformaMobileApi(Configuration configuration = null)
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
        /// Atualiza Plataforma Mobile Esse recurso permite atualizar plataforma mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>PlataformaMobileResponse</returns>
        public PlataformaMobileResponse AtualizarPlataformaMobile (long? id, PlataformaMobileUpdate update)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = AtualizarPlataformaMobileWithHttpInfo(id, update);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza Plataforma Mobile Esse recurso permite atualizar plataforma mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param> 
        /// <param name="update">update</param> 
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        public ApiResponse< PlataformaMobileResponse > AtualizarPlataformaMobileWithHttpInfo (long? id, PlataformaMobileUpdate update)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PlataformaMobileApi->AtualizarPlataformaMobile");
            
            // verify the required parameter 'update' is set
            if (update == null)
                throw new ApiException(400, "Missing required parameter 'update' when calling PlataformaMobileApi->AtualizarPlataformaMobile");
            
    
            var localVarPath = "/api/plataformas-mobile/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarPlataformaMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarPlataformaMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// Atualiza Plataforma Mobile Esse recurso permite atualizar plataforma mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PlataformaMobileResponse> AtualizarPlataformaMobileAsync (long? id, PlataformaMobileUpdate update)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = await AtualizarPlataformaMobileAsyncWithHttpInfo(id, update);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza Plataforma Mobile Esse recurso permite atualizar plataforma mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Plataforma (id)</param>
        /// <param name="update">update</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> AtualizarPlataformaMobileAsyncWithHttpInfo (long? id, PlataformaMobileUpdate update)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarPlataformaMobile");
            // verify the required parameter 'update' is set
            if (update == null) throw new ApiException(400, "Missing required parameter 'update' when calling AtualizarPlataformaMobile");
            
    
            var localVarPath = "/api/plataformas-mobile/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AtualizarPlataformaMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarPlataformaMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }
        
        /// <summary>
        /// Lista as plataformas mobile cadastradas Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param> 
        /// <returns>PagePlataformaMobileResponse</returns>
        public PagePlataformaMobileResponse ListarPlataformasMobile (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PagePlataformaMobileResponse> localVarResponse = ListarPlataformasMobileWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as plataformas mobile cadastradas Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param> 
        /// <returns>ApiResponse of PagePlataformaMobileResponse</returns>
        public ApiResponse< PagePlataformaMobileResponse > ListarPlataformasMobileWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPlataformasMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPlataformasMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// Lista as plataformas mobile cadastradas Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>Task of PagePlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PagePlataformaMobileResponse> ListarPlataformasMobileAsync (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
             ApiResponse<PagePlataformaMobileResponse> localVarResponse = await ListarPlataformasMobileAsyncWithHttpInfo(sort, page, limit, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as plataformas mobile cadastradas Este m\u00E9todo permite que sejam listadas as plataformas mobile existentes na base do PIER
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="nome">Nome da Plataforma Mobile (optional)</param>
        /// <returns>Task of ApiResponse (PagePlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePlataformaMobileResponse>> ListarPlataformasMobileAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string nome = null)
        {
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarPlataformasMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarPlataformasMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePlataformaMobileResponse)));
            
        }
        
        /// <summary>
        /// Cadastra Plataforma Mobile Esse recurso permite cadastrar plataformas mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>PlataformaMobileResponse</returns>
        public PlataformaMobileResponse SalvarPlataformaMobile (PlataformaMobilePersist persist)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = SalvarPlataformaMobileWithHttpInfo(persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastra Plataforma Mobile Esse recurso permite cadastrar plataformas mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of PlataformaMobileResponse</returns>
        public ApiResponse< PlataformaMobileResponse > SalvarPlataformaMobileWithHttpInfo (PlataformaMobilePersist persist)
        {
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling PlataformaMobileApi->SalvarPlataformaMobile");
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPlataformaMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPlataformaMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }

        
        /// <summary>
        /// Cadastra Plataforma Mobile Esse recurso permite cadastrar plataformas mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of PlataformaMobileResponse</returns>
        public async System.Threading.Tasks.Task<PlataformaMobileResponse> SalvarPlataformaMobileAsync (PlataformaMobilePersist persist)
        {
             ApiResponse<PlataformaMobileResponse> localVarResponse = await SalvarPlataformaMobileAsyncWithHttpInfo(persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastra Plataforma Mobile Esse recurso permite cadastrar plataformas mobile
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (PlataformaMobileResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlataformaMobileResponse>> SalvarPlataformaMobileAsyncWithHttpInfo (PlataformaMobilePersist persist)
        {
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling SalvarPlataformaMobile");
            
    
            var localVarPath = "/api/plataformas-mobile";
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPlataformaMobile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPlataformaMobile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PlataformaMobileResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PlataformaMobileResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlataformaMobileResponse)));
            
        }
        
    }
    
}
