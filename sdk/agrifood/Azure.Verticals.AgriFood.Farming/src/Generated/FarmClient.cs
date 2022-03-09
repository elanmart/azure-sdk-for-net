// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Farm service client. </summary>
    public partial class FarmClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FarmClient for mocking. </summary>
        protected FarmClient()
        {
        }

        /// <summary> Initializes a new instance of FarmClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   authProviderId: string,
        ///   operations: [string],
        ///   startYear: number,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetDataIngestionJobDetailsAsync(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a farm operation data ingestion job. </summary>
        /// <param name="jobId"> ID of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   authProviderId: string,
        ///   operations: [string],
        ///   startYear: number,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetDataIngestionJobDetails(string jobId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.GetDataIngestionJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetDataIngestionJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a farm operation data ingestion job. </summary>
        /// <param name="waitForCompletion"> true if the method should wait to return until the long-running operation has completed on the service; false if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   authProviderId: string (required),
        ///   operations: [string],
        ///   startYear: number (required),
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   authProviderId: string,
        ///   operations: [string],
        ///   startYear: number,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Operation<BinaryData>> CreateDataIngestionJobAsync(bool waitForCompletion, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, content, context);
                return await LowLevelOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "FarmClient.CreateDataIngestionJob", OperationFinalStateVia.Location, context, waitForCompletion).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a farm operation data ingestion job. </summary>
        /// <param name="waitForCompletion"> true if the method should wait to return until the long-running operation has completed on the service; false if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by user. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   farmerId: string (required),
        ///   authProviderId: string (required),
        ///   operations: [string],
        ///   startYear: number (required),
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   authProviderId: string,
        ///   operations: [string],
        ///   startYear: number,
        ///   id: string,
        ///   status: string,
        ///   durationInSeconds: number,
        ///   message: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   lastActionDateTime: string (ISO 8601 Format),
        ///   startTime: string (ISO 8601 Format),
        ///   endTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   properties: Dictionary&lt;string, AnyObject&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Operation<BinaryData> CreateDataIngestionJob(bool waitForCompletion, string jobId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("FarmClient.CreateDataIngestionJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateDataIngestionJobRequest(jobId, content, context);
                return LowLevelOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "FarmClient.CreateDataIngestionJob", OperationFinalStateVia.Location, context, waitForCompletion);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateDataIngestionJobRequest(string jobId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetDataIngestionJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farm-operations/ingest-data/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
