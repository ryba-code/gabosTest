using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gabosTest.Module
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityPerson
    {
        [Newtonsoft.Json.JsonProperty("companyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(160)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("pesel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pesel { get; set; }

        [Newtonsoft.Json.JsonProperty("nip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 10)]
        public string Nip { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityCheck
    {
        /// <summary>Czy rachunek przypisany do podmiotu czynnego
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accountAssigned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountAssigned { get; set; }

        [Newtonsoft.Json.JsonProperty("requestDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(19)]
        public string RequestDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(18)]
        public string RequestId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Entity
    {
        /// <summary>Firma (nazwa) lub imię i nazwisko
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("nip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 10)]
        public string Nip { get; set; }

        /// <summary>Status podatnika VAT.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusVat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EntityStatusVat StatusVat { get; set; }

        /// <summary>Numer identyfikacyjny REGON
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^\d{9}$|^\d{14}$")]
        public string Regon { get; set; }

        [Newtonsoft.Json.JsonProperty("pesel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pesel { get; set; }

        /// <summary>numer KRS jeżeli został nadany
        /// </summary>
        [Newtonsoft.Json.JsonProperty("krs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 10)]
        public string Krs { get; set; }

        /// <summary>Adres siedziby działalności gospodarczej (Adres siedziby OSOBY FIZYCZNEJ prowadzącej działalność gospodarczą)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("residenceAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string ResidenceAddress { get; set; }

        /// <summary>Adres rejestracyjny (Adres zamieszkania OSOBY FIZYCZNEJ lub adres siedziby ORGANIZACJI.).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workingAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string WorkingAddress { get; set; }

        /// <summary>Imiona i nazwiska osób wchodzących w skład organu uprawnionego do reprezentowania podmiotu oraz ich numery NIP i/lub PESEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("representatives", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<EntityPerson> Representatives { get; set; }

        /// <summary>Imiona i nazwiska prokurentów oraz ich numery NIP i/lub PESEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizedClerks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<EntityPerson> AuthorizedClerks { get; set; }

        /// <summary>Imiona i nazwiska lub firmę (nazwa) wspólnika oraz jego numeryNIP i/lub PESEL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partners", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<EntityPerson> Partners { get; set; }

        /// <summary>Data rejestracji jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrationLegalDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset RegistrationLegalDate { get; set; }

        /// <summary>Data odmowy rejestracji jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrationDenialDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset RegistrationDenialDate { get; set; }

        /// <summary>Podstawa prawna odmowy rejestracji
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registrationDenialBasis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string RegistrationDenialBasis { get; set; }

        /// <summary>Data przywrócenia jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restorationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset RestorationDate { get; set; }

        /// <summary>Podstawa prawna przywrócenia jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restorationBasis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string RestorationBasis { get; set; }

        /// <summary>Data wykreślenia odmowy rejestracji jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("removalDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset RemovalDate { get; set; }

        /// <summary>Podstawa prawna wykreślenia odmowy rejestracji jako podatnika VAT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("removalBasis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string RemovalBasis { get; set; }

        [Newtonsoft.Json.JsonProperty("accountNumbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AccountNumbers { get; set; }

        /// <summary>Podmiot posiada maski kont wirtualnych
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hasVirtualAccounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasVirtualAccounts { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityItem
    {
        [Newtonsoft.Json.JsonProperty("subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Entity Subject { get; set; }

        [Newtonsoft.Json.JsonProperty("requestDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(19)]
        public string RequestDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(18)]
        public string RequestId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityList
    {
        /// <summary>Lista podmiotów
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Entity> Subjects { get; set; }

        [Newtonsoft.Json.JsonProperty("requestDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(19)]
        public string RequestDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(18)]
        public string RequestId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Entry
    {
        /// <summary>Przekazany identyfikator (Nip, Regon, Numer rachunku bankowego)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Identifier { get; set; }

        /// <summary>Lista podmiotów</summary>
        [Newtonsoft.Json.JsonProperty("subjects", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Entity> Subjects { get; set; } = new System.Collections.ObjectModel.Collection<Entity>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntryError
    {
        /// <summary>Przekazany identyfikator (Nip, Regon, Numer rachunku bankowego)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Identifier { get; set; }

        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Always)]
        public Error Error { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntryList
    {
        /// <summary>Lista odpowiedzi</summary>
        [Newtonsoft.Json.JsonProperty("entries", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Entry> Entries { get; set; } = new System.Collections.ObjectModel.Collection<Entry>();

        [Newtonsoft.Json.JsonProperty("requestDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(19)]
        public string RequestDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(18)]
        public string RequestId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityResponse
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EntityItem Result { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public static implicit operator Task<object>(EntityResponse v)
        {
            throw new NotImplementedException();
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityCheckResponse
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EntityCheck Result { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntityListResponse
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EntityList Result { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EntryListResponse
    {
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EntryList Result { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum EntityStatusVat
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Czynny")]
        Czynny = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Zwolniony")]
        Zwolniony = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Niezarejestrowany")]
        Niezarejestrowany = 2,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    [Newtonsoft.Json.JsonObjectAttribute]
    public partial class Error
    {
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string Message { get; set; }

        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.5.0 (NJsonSchema v10.0.22.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.5.0 (NJsonSchema v10.0.22.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.5.0 (NJsonSchema v10.0.22.0 (Newtonsoft.Json v11.0.0.0))")]
    internal class JsonExceptionConverter : Newtonsoft.Json.JsonConverter
    {
        private readonly Newtonsoft.Json.Serialization.DefaultContractResolver _defaultContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
        private readonly System.Collections.Generic.IDictionary<string, System.Reflection.Assembly> _searchedNamespaces;
        private readonly bool _hideStackTrace = false;

        public JsonExceptionConverter()
        {
            _searchedNamespaces = new System.Collections.Generic.Dictionary<string, System.Reflection.Assembly> { { typeof(System.Exception).Namespace, System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(System.Exception)).Assembly } };
        }

        public override bool CanWrite => true;

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var exception = value as System.Exception;
            if (exception != null)
            {
                var resolver = serializer.ContractResolver as Newtonsoft.Json.Serialization.DefaultContractResolver ?? _defaultContractResolver;

                var jObject = new Newtonsoft.Json.Linq.JObject();
                jObject.Add(resolver.GetResolvedPropertyName("discriminator"), exception.GetType().Name);
                jObject.Add(resolver.GetResolvedPropertyName("Message"), exception.Message);
                jObject.Add(resolver.GetResolvedPropertyName("StackTrace"), _hideStackTrace ? "HIDDEN" : exception.StackTrace);
                jObject.Add(resolver.GetResolvedPropertyName("Source"), exception.Source);
                jObject.Add(resolver.GetResolvedPropertyName("InnerException"),
                    exception.InnerException != null ? Newtonsoft.Json.Linq.JToken.FromObject(exception.InnerException, serializer) : null);

                foreach (var property in GetExceptionProperties(value.GetType()))
                {
                    var propertyValue = property.Key.GetValue(exception);
                    if (propertyValue != null)
                    {
                        jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(resolver.GetResolvedPropertyName(property.Value),
                            Newtonsoft.Json.Linq.JToken.FromObject(propertyValue, serializer)));
                    }
                }

                value = jObject;
            }

            serializer.Serialize(writer, value);
        }

        public override bool CanConvert(System.Type objectType)
        {
            return System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(System.Exception)).IsAssignableFrom(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType));
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
            if (jObject == null)
                return null;

            var newSerializer = new Newtonsoft.Json.JsonSerializer();
            newSerializer.ContractResolver = (Newtonsoft.Json.Serialization.IContractResolver)System.Activator.CreateInstance(serializer.ContractResolver.GetType());

            var field = GetField(typeof(Newtonsoft.Json.Serialization.DefaultContractResolver), "_sharedCache");
            if (field != null)
                field.SetValue(newSerializer.ContractResolver, false);

            dynamic resolver = newSerializer.ContractResolver;
            if (System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperty(newSerializer.ContractResolver.GetType(), "IgnoreSerializableAttribute") != null)
                resolver.IgnoreSerializableAttribute = true;
            if (System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperty(newSerializer.ContractResolver.GetType(), "IgnoreSerializableInterface") != null)
                resolver.IgnoreSerializableInterface = true;

            Newtonsoft.Json.Linq.JToken token;
            if (jObject.TryGetValue("discriminator", System.StringComparison.OrdinalIgnoreCase, out token))
            {
                var discriminator = Newtonsoft.Json.Linq.Extensions.Value<string>(token);
                if (objectType.Name.Equals(discriminator) == false)
                {
                    var exceptionType = System.Type.GetType("System." + discriminator, false);
                    if (exceptionType != null)
                        objectType = exceptionType;
                    else
                    {
                        foreach (var pair in _searchedNamespaces)
                        {
                            exceptionType = pair.Value.GetType(pair.Key + "." + discriminator);
                            if (exceptionType != null)
                            {
                                objectType = exceptionType;
                                break;
                            }
                        }

                    }
                }
            }

            var value = jObject.ToObject(objectType, newSerializer);
            foreach (var property in GetExceptionProperties(value.GetType()))
            {
                var jValue = jObject.GetValue(resolver.GetResolvedPropertyName(property.Value));
                var propertyValue = (object)jValue?.ToObject(property.Key.PropertyType);
                if (property.Key.SetMethod != null)
                    property.Key.SetValue(value, propertyValue);
                else
                {
                    field = GetField(objectType, "m_" + property.Value.Substring(0, 1).ToLowerInvariant() + property.Value.Substring(1));
                    if (field != null)
                        field.SetValue(value, propertyValue);
                }
            }

            SetExceptionFieldValue(jObject, "Message", value, "_message", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "StackTrace", value, "_stackTraceString", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "Source", value, "_source", resolver, newSerializer);
            SetExceptionFieldValue(jObject, "InnerException", value, "_innerException", resolver, serializer);

            return value;
        }

        private System.Reflection.FieldInfo GetField(System.Type type, string fieldName)
        {
            var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(type).GetDeclaredField(fieldName);
            if (field == null && System.Reflection.IntrospectionExtensions.GetTypeInfo(type).BaseType != null)
                return GetField(System.Reflection.IntrospectionExtensions.GetTypeInfo(type).BaseType, fieldName);
            return field;
        }

        private System.Collections.Generic.IDictionary<System.Reflection.PropertyInfo, string> GetExceptionProperties(System.Type exceptionType)
        {
            var result = new System.Collections.Generic.Dictionary<System.Reflection.PropertyInfo, string>();
            foreach (var property in System.Linq.Enumerable.Where(System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(exceptionType),
                p => p.GetMethod?.IsPublic == true))
            {
                var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Newtonsoft.Json.JsonPropertyAttribute>(property);
                var propertyName = attribute != null ? attribute.PropertyName : property.Name;

                if (!System.Linq.Enumerable.Contains(new[] { "Message", "StackTrace", "Source", "InnerException", "Data", "TargetSite", "HelpLink", "HResult" }, propertyName))
                    result[property] = propertyName;
            }
            return result;
        }

        private void SetExceptionFieldValue(Newtonsoft.Json.Linq.JObject jObject, string propertyName, object value, string fieldName, Newtonsoft.Json.Serialization.IContractResolver resolver, Newtonsoft.Json.JsonSerializer serializer)
        {
            var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(System.Exception)).GetDeclaredField(fieldName);
            var jsonPropertyName = resolver is Newtonsoft.Json.Serialization.DefaultContractResolver ? ((Newtonsoft.Json.Serialization.DefaultContractResolver)resolver).GetResolvedPropertyName(propertyName) : propertyName;
            var property = System.Linq.Enumerable.FirstOrDefault(jObject.Properties(), p => System.String.Equals(p.Name, jsonPropertyName, System.StringComparison.OrdinalIgnoreCase));
            if (property != null)
            {
                var fieldValue = property.Value.ToObject(field.FieldType, serializer);
                field.SetValue(value, fieldValue);
            }
        }
    }
}
