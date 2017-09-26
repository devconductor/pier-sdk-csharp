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
    public interface IAutorizacaoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarUsingPOST (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
  
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarUsingPOSTWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse AutorizarUsingPOST1 (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
  
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> AutorizarUsingPOST1WithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarUsingPOST2 (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarUsingPOST2WithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse CancelarUsingPOST3 (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
  
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> CancelarUsingPOST3WithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        List<Object> ListarCodigosProcessamentoAutorizacaoUsingGET ();
  
        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        ApiResponse<List<Object>> ListarCodigosProcessamentoAutorizacaoUsingGETWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>TransacaoOnUsResponse</returns>
        TransacaoOnUsResponse SimularUsingPOST (TransacaoOnUsRequest transacoesRequest);
  
        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        ApiResponse<TransacaoOnUsResponse> SimularUsingPOSTWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarUsingPOSTAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest);

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarUsingPOSTAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest);
        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarUsingPOST1Async (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarUsingPOST1AsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest);
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarUsingPOST2Async (CancelamentoTransacaoOnUsRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarUsingPOST2AsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest);
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarUsingPOST3Async (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarUsingPOST3AsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest);
        
        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        System.Threading.Tasks.Task<List<Object>> ListarCodigosProcessamentoAutorizacaoUsingGETAsync ();

        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosProcessamentoAutorizacaoUsingGETAsyncWithHttpInfo ();
        
        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularUsingPOSTAsync (TransacaoOnUsRequest transacoesRequest);

        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularUsingPOSTAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AutorizacaoApi : IAutorizacaoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AutorizacaoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutorizacaoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AutorizacaoApi(Configuration configuration = null)
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
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarUsingPOST (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarUsingPOSTWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarUsingPOSTWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null)
                throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling AutorizacaoApi->AutorizarUsingPOST");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarUsingPOSTAsync (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarUsingPOSTAsyncWithHttpInfo(autorizacaoOnUsRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autorizacaoOnUsRequest">autorizacaoOnUsRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarUsingPOSTAsyncWithHttpInfo (AutorizacaoOnUsRequest autorizacaoOnUsRequest)
        {
            // verify the required parameter 'autorizacaoOnUsRequest' is set
            if (autorizacaoOnUsRequest == null) throw new ApiException(400, "Missing required parameter 'autorizacaoOnUsRequest' when calling AutorizarUsingPOST");
            
    
            var localVarPath = "/api/autorizar-transacao";
    
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
            
            
            
            
            if (autorizacaoOnUsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(autorizacaoOnUsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autorizacaoOnUsRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse AutorizarUsingPOST1 (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = AutorizarUsingPOST1WithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > AutorizarUsingPOST1WithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->AutorizarUsingPOST1");
            
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizacaoApi->AutorizarUsingPOST1");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> AutorizarUsingPOST1Async (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await AutorizarUsingPOST1AsyncWithHttpInfo(id, transacaoOnUsPorIdCartaoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Autoriza transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo faz uma autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00A3o financeira com o idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="transacaoOnUsPorIdCartaoRequest">transacaoOnUsPorIdCartaoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> AutorizarUsingPOST1AsyncWithHttpInfo (long? id, TransacaoOnUsPorIdCartaoRequest transacaoOnUsPorIdCartaoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AutorizarUsingPOST1");
            // verify the required parameter 'transacaoOnUsPorIdCartaoRequest' is set
            if (transacaoOnUsPorIdCartaoRequest == null) throw new ApiException(400, "Missing required parameter 'transacaoOnUsPorIdCartaoRequest' when calling AutorizarUsingPOST1");
            
    
            var localVarPath = "/api/cartoes/{id}/autorizar-transacao";
    
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
            
            
            
            
            if (transacaoOnUsPorIdCartaoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacaoOnUsPorIdCartaoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacaoOnUsPorIdCartaoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AutorizarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarUsingPOST2 (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarUsingPOST2WithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarUsingPOST2WithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarUsingPOST2");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarUsingPOST2Async (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarUsingPOST2AsyncWithHttpInfo(cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarUsingPOST2AsyncWithHttpInfo (CancelamentoTransacaoOnUsRequest cancelamentoRequest)
        {
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarUsingPOST2");
            
    
            var localVarPath = "/api/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse CancelarUsingPOST3 (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = CancelarUsingPOST3WithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param> 
        /// <param name="cancelamentoRequest">cancelamentoRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > CancelarUsingPOST3WithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AutorizacaoApi->CancelarUsingPOST3");
            
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null)
                throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling AutorizacaoApi->CancelarUsingPOST3");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> CancelarUsingPOST3Async (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await CancelarUsingPOST3AsyncWithHttpInfo(id, cancelamentoRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancela transa\u00C3\u00A7\u00C3\u00A3o financeira por idCartao Este m\u00C3\u00A9todo permite que seja cancelada uma transa\u00C3\u00A7\u00C3\u00A3o a partir do idCartao.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id Cartao</param>
        /// <param name="cancelamentoRequest">cancelamentoRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> CancelarUsingPOST3AsyncWithHttpInfo (long? id, CancelamentoTransacaoPorIdCartaoRequest cancelamentoRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelarUsingPOST3");
            // verify the required parameter 'cancelamentoRequest' is set
            if (cancelamentoRequest == null) throw new ApiException(400, "Missing required parameter 'cancelamentoRequest' when calling CancelarUsingPOST3");
            
    
            var localVarPath = "/api/cartoes/{id}/cancelar-transacao";
    
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
            
            
            
            
            if (cancelamentoRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(cancelamentoRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancelamentoRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CancelarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Object&gt;</returns>
        public List<Object> ListarCodigosProcessamentoAutorizacaoUsingGET ()
        {
             ApiResponse<List<Object>> localVarResponse = ListarCodigosProcessamentoAutorizacaoUsingGETWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Object&gt;</returns>
        public ApiResponse< List<Object> > ListarCodigosProcessamentoAutorizacaoUsingGETWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }

        
        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Object&gt;</returns>
        public async System.Threading.Tasks.Task<List<Object>> ListarCodigosProcessamentoAutorizacaoUsingGETAsync ()
        {
             ApiResponse<List<Object>> localVarResponse = await ListarCodigosProcessamentoAutorizacaoUsingGETAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retorna c\u00C3\u00B3digos de processamento de autoriza\u00C3\u00A7\u00C3\u00A3o Este m\u00C3\u00A9todo retorna a lista dos c\u00C3\u00B3digos de processamento para autoriza\u00C3\u00A7\u00C3\u00A3o de transa\u00C3\u00A7\u00C3\u00B5es financeiras.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Object&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Object>>> ListarCodigosProcessamentoAutorizacaoUsingGETAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/consultar-codigos-processamento-autorizacao";
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacaoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarCodigosProcessamentoAutorizacaoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Object>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Object>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Object>)));
            
        }
        
        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>TransacaoOnUsResponse</returns>
        public TransacaoOnUsResponse SimularUsingPOST (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = SimularUsingPOSTWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param> 
        /// <returns>ApiResponse of TransacaoOnUsResponse</returns>
        public ApiResponse< TransacaoOnUsResponse > SimularUsingPOSTWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null)
                throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling AutorizacaoApi->SimularUsingPOST");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }

        
        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of TransacaoOnUsResponse</returns>
        public async System.Threading.Tasks.Task<TransacaoOnUsResponse> SimularUsingPOSTAsync (TransacaoOnUsRequest transacoesRequest)
        {
             ApiResponse<TransacaoOnUsResponse> localVarResponse = await SimularUsingPOSTAsyncWithHttpInfo(transacoesRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simula planos de transa\u00C3\u00A7\u00C3\u00B5es Este m\u00C3\u00A9todo permite que seja simulada um plano de transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transacoesRequest">transacoesRequest</param>
        /// <returns>Task of ApiResponse (TransacaoOnUsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransacaoOnUsResponse>> SimularUsingPOSTAsyncWithHttpInfo (TransacaoOnUsRequest transacoesRequest)
        {
            // verify the required parameter 'transacoesRequest' is set
            if (transacoesRequest == null) throw new ApiException(400, "Missing required parameter 'transacoesRequest' when calling SimularUsingPOST");
            
    
            var localVarPath = "/api/simular-transacao";
    
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
            
            
            
            
            if (transacoesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(transacoesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = transacoesRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SimularUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SimularUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TransacaoOnUsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransacaoOnUsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransacaoOnUsResponse)));
            
        }
        
    }
    
}