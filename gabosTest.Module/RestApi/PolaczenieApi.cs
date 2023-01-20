﻿using DevExpress.XtraPrinting.Native.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gabosTest.Module
{
    public partial class PolaczenieApi
    {
        private string _baseUrl = "";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public bool ReadResponseAsString { get; set; }
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings 
        { 
            get 
            { 
                return _settings.Value; 
            } 
        }

        public PolaczenieApi(string baseUrl, HttpClient httpClien) 
        {
            _baseUrl = baseUrl;
            _httpClient = httpClien;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings { Converters = new Newtonsoft.Json.JsonConverter[] { new JsonExceptionConverter() } };
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public async Task<EntityResponse> PolaczRestApiAsync(string Nip)
        {
            return await NipdateAsync(Nip, DateTime.Now.Date, System.Threading.CancellationToken.None);
        }

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

        public async System.Threading.Tasks.Task<EntityResponse> NipdateAsync(string nip, System.DateTimeOffset date, System.Threading.CancellationToken cancellationToken)
        {
            if (nip == null)
                throw new System.ArgumentNullException("nip");

            if (date == null)
                throw new System.ArgumentNullException("date");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(_baseUrl != null ? _baseUrl.TrimEnd('/') : "").Append("/api/search/nip/{nip}?");
            urlBuilder_.Replace("{nip}", System.Uri.EscapeDataString(ConvertToString(nip, System.Globalization.CultureInfo.InvariantCulture)));
            urlBuilder_.Append(System.Uri.EscapeDataString("date") + "=").Append(System.Uri.EscapeDataString(date.ToString("s", System.Globalization.CultureInfo.InvariantCulture).Split('T')[0])).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;

            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                            {
                                headers_[item_.Key] = item_.Value;
                            }
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();

                        if (status_ == "200")
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<EntityResponse>(response_, headers_).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else if (status_ == "400")
                        {
                            //var objectResponse_ = await ReadObjectResponseAsync<System.Exception>(response_, headers_).ConfigureAwait(false);
                            //var responseObject_ = objectResponse_.Object != null ? objectResponse_.Object : new System.Exception();
                            //responseObject_.Data.Add("HttpStatus", status_);
                            //responseObject_.Data.Add("HttpHeaders", headers_);
                            //responseObject_.Data.Add("HttpResponse", objectResponse_.Text);
                            //throw new ApiException("niepoprawny parametr na wej\u015bciu", (int)response_.StatusCode, objectResponse_.Text, headers_, responseObject_);
                            return null;
                        }
                        else if (status_ != "200" && status_ != "204")
                        {
                            //var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            //throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                            return null;
                        }

                        return default(EntityResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }

            public T Object { get; }

            public string Text { get; }
        }

        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return System.Convert.ToString(value, cultureInfo);
        }
    }
}
