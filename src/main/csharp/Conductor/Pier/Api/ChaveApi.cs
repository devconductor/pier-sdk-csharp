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
    public interface IChaveApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Listar tipos chaves
        /// </summary>
        /// <remarks>
        /// Listar tipos chaves notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>PageTipoChaveResponse</returns>
        PageTipoChaveResponse ListarTiposChaves (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
  
        /// <summary>
        /// Listar tipos chaves
        /// </summary>
        /// <remarks>
        /// Listar tipos chaves notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>ApiResponse of PageTipoChaveResponse</returns>
        ApiResponse<PageTipoChaveResponse> ListarTiposChavesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Listar tipos chaves
        /// </summary>
        /// <remarks>
        /// Listar tipos chaves notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>Task of PageTipoChaveResponse</returns>
        System.Threading.Tasks.Task<PageTipoChaveResponse> ListarTiposChavesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);

        /// <summary>
        /// Listar tipos chaves
        /// </summary>
        /// <remarks>
        /// Listar tipos chaves notes
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoChaveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoChaveResponse>> ListarTiposChavesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChaveApi : IChaveApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChaveApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaveApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChaveApi(Configuration configuration = null)
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
        /// Listar tipos chaves Listar tipos chaves notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Tipo chave id (optional)</param> 
        /// <param name="descricao">Tipo chave descricao (optional)</param> 
        /// <returns>PageTipoChaveResponse</returns>
        public PageTipoChaveResponse ListarTiposChaves (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoChaveResponse> localVarResponse = ListarTiposChavesWithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar tipos chaves Listar tipos chaves notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Tipo chave id (optional)</param> 
        /// <param name="descricao">Tipo chave descricao (optional)</param> 
        /// <returns>ApiResponse of PageTipoChaveResponse</returns>
        public ApiResponse< PageTipoChaveResponse > ListarTiposChavesWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-chaves";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposChaves: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposChaves: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoChaveResponse)));
            
        }

        
        /// <summary>
        /// Listar tipos chaves Listar tipos chaves notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>Task of PageTipoChaveResponse</returns>
        public async System.Threading.Tasks.Task<PageTipoChaveResponse> ListarTiposChavesAsync (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
             ApiResponse<PageTipoChaveResponse> localVarResponse = await ListarTiposChavesAsyncWithHttpInfo(sort, page, limit, id, descricao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar tipos chaves Listar tipos chaves notes
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">Tipo chave id (optional)</param>
        /// <param name="descricao">Tipo chave descricao (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoChaveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoChaveResponse>> ListarTiposChavesAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string descricao = null)
        {
            
    
            var localVarPath = "/api/tipos-chaves";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposChaves: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarTiposChaves: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoChaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoChaveResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoChaveResponse)));
            
        }
        
    }
    
}
