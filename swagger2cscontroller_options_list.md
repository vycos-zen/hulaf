Command: swagger2cscontroller
  Generates CSharp Web API controller code from a Swagger specification.

Arguments:
  ControllerBaseClass
    The controller base class (empty for 'ApiController').
  ControllerStyle
    The controller generation style (partial, abstract; default: partial).
  UseCancellationToken
    Add a cancellation token parameter (default: false).
  AspNetNamespace
    The ASP.NET (Core) framework namespace (default: 'System.Web.Http').
  RouteNamingStrategy
    The strategy for naming controller routes (none, operationid; default: none).
  ClassName
    The class name of the generated client.
  OperationGenerationMode
    The operation generation mode ('SingleClientFromOperationId' or 'MultipleClientsFromPathSegments').
  AdditionalNamespaceUsages
    The additional namespace usages.
  AdditionalContractNamespaceUsages
    The additional contract namespace usages.
  GenerateOptionalParameters
    Specifies whether to reorder parameters (required first, optional at the end) and generate optional parameters (default: false).
  GenerateJsonMethods
    Specifies whether to render ToJson() and FromJson() methods for DTOs (default: true).
  EnforceFlagEnums
    Specifies whether enums should be always generated as bit flags (default: false).
  ParameterArrayType
    The generic array .NET type of operation parameters (default: 'IEnumerable').
  ParameterDictionaryType
    The generic dictionary .NET type of operation parameters (default: 'IDictionary').
  ResponseArrayType
    The generic array .NET type of operation responses (default: 'ICollection').
  ResponseDictionaryType
    The generic dictionary .NET type of operation responses (default: 'IDictionary').
  WrapResponses
    Specifies whether to wrap success responses to allow full response access.
  WrapResponseMethods
    List of methods where responses are wrapped ('ControllerName.MethodName', WrapResponses must be true).
  GenerateResponseClasses
    Specifies whether to generate response classes (default: true).
  ResponseClass
    The response class (default 'SwaggerResponse', may use '{controller}' placeholder).
  Namespace
    The namespace of the generated classes.
  RequiredPropertiesMustBeDefined
    Specifies whether a required property must be defined in JSON (sets Required.Always when the property is required).
  DateType
    The date .NET type (default: 'DateTimeOffset').
  JsonConverters
    Specifies the custom Json.NET converter types (optional, comma separated).
  DateTimeType
    The date time .NET type (default: 'DateTimeOffset').
  TimeType
    The time .NET type (default: 'TimeSpan').
  TimeSpanType
    The time span .NET type (default: 'TimeSpan').
  ArrayType
    The generic array .NET type (default: 'ICollection').
  ArrayInstanceType
    The generic array .NET instance type (default: empty = ArrayType).
  DictionaryType
    The generic dictionary .NET type (default: 'IDictionary').
  DictionaryInstanceType
    The generic dictionary .NET instance type (default: empty = DictionaryType).
  ArrayBaseType
    The generic array .NET type (default: 'Collection').
  DictionaryBaseType
    The generic dictionary .NET type (default: 'Dictionary').
  ClassStyle
    The CSharp class style, 'Poco' or 'Inpc' (default: 'Poco').
  GenerateDefaultValues
    Specifies whether to generate default values for properties (may generate CSharp 6 code, default: true).
  GenerateDataAnnotations
    Specifies whether to generate data annotation attributes on DTO classes (default: true).
  ExcludedTypeNames
    The excluded DTO type names (must be defined in an import or other namespace).
  HandleReferences
    Use preserve references handling (All) in the JSON serializer (default: false).
  GenerateImmutableArrayProperties
    Specifies whether to remove the setter for non-nullable array properties (default: false).
  GenerateImmutableDictionaryProperties
    Specifies whether to remove the setter for non-nullable dictionary properties (default: false).
  JsonSerializerSettingsTransformationMethod
    The name of a static method which is called to transform the JsonSerializerSettings used in the generated ToJson()/FromJson() methods (default: none).
  TemplateDirectory
    The Liquid template directory (experimental).
  TypeNameGenerator
    The custom ITypeNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  PropertyNameGeneratorType
    The custom IPropertyNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  EnumNameGeneratorType
    The custom IEnumNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  Input
    A file path or URL to the data or the JSON data itself.
  ServiceHost
    Overrides the service host of the web document (optional, use '.' to remove the hostname).
  ServiceSchemes
    Overrides the allowed schemes of the web service (optional, comma separated, 'http', 'https', 'ws', 'wss').
  Output
    The output file path (optional).
Press <enter> key for next command...

Command: swagger2tsclient
  Generates TypeScript client code from a Swagger specification.

Arguments:
  ClassName
    The class name of the generated client.
  ModuleName
    The TypeScript module name (default: '', no module).
  Namespace
    The TypeScript namespace (default: '', no namespace).
  TypeScriptVersion
    The target TypeScript version (default: 2.7).
  Template
    The type of the asynchronism handling ('JQueryCallbacks', 'JQueryPromises', 'AngularJS', 'Angular', 'Fetch', 'Aurelia').
  PromiseType
    The promise type ('Promise' or 'QPromise').
  HttpClass
    The Angular HTTP service class (default 'Http', 'HttpClient').
  UseSingletonProvider
    Specifies whether to use the Angular 6 Singleton Provider (Angular template only, default: false).
  InjectionTokenType
    The Angular injection token type (default 'InjectionToken', 'OpaqueToken').
  RxJsVersion
    The target RxJs version (default: 6.0).
  DateTimeType
    The date time type ('Date', 'MomentJS', 'OffsetMomentJS', 'string').
  NullValue
    The null value used in object initializers (default 'Undefined', 'Null').
  GenerateClientClasses
    Specifies whether generate client classes.
  GenerateClientInterfaces
    Specifies whether generate interfaces for the client classes (default: false).
  GenerateOptionalParameters
    Specifies whether to reorder parameters (required first, optional at the end) and generate optional parameters (default: false).
  ExportTypes
    Specifies whether the export keyword should be added to all classes, interfaces and enums (default: true).
  WrapDtoExceptions
    Specifies whether DTO exceptions are wrapped in a SwaggerException instance (default: false).
  ClientBaseClass
    The base class of the generated client classes (optional, must be imported or implemented in the extension code).
  WrapResponses
    Specifies whether to wrap success responses to allow full response access (experimental).
  WrapResponseMethods
    List of methods where responses are wrapped ('ControllerName.MethodName', WrapResponses must be true).
  GenerateResponseClasses
    Specifies whether to generate response classes (default: true).
  ResponseClass
    The response class (default 'SwaggerResponse', may use '{controller}' placeholder).
  ProtectedMethods
    List of methods with a protected access modifier ('classname.methodname').
  ConfigurationClass
    The configuration class. The setting ClientBaseClass must be set. (empty for no configuration class).
  UseTransformOptionsMethod
    Call 'transformOptions' on the base class or extension class (default: false).
  UseTransformResultMethod
    Call 'transformResult' on the base class or extension class (default: false).
  GenerateDtoTypes
    Specifies whether to generate DTO classes.
  OperationGenerationMode
    The operation generation mode ('SingleClientFromOperationId' or 'MultipleClientsFromPathSegments').
  MarkOptionalProperties
    Specifies whether to mark optional properties with ? (default: false).
  GenerateCloneMethod
    Specifies whether a clone() method should be generated in the DTO classes (default: false).
  TypeStyle
    The type style (default: Class).
  ClassTypes
    The type names which always generate plain TypeScript classes.
  ExtendedClasses
    The list of extended classes.
  ExtensionCode
    The extension code (string or file path).
  GenerateDefaultValues
    Specifies whether to generate default values for properties (default: true).
  ExcludedTypeNames
    The excluded DTO type names (must be defined in an import or other namespace).
  HandleReferences
    Handle JSON references (default: false).
  GenerateConstructorInterface
    Generate an class interface which is used in the constructor to initialize the class (only available when TypeStyle is Class, default: true).
  ConvertConstructorInterfaceData
    Convert POJO objects in the constructor data to DTO instances (GenerateConstructorInterface must be enabled, default: false).
  ImportRequiredTypes
    Specifies whether required types should be imported (default: true).
  UseGetBaseUrlMethod
    Specifies whether to use the 'getBaseUrl(defaultUrl: string)' method from the base class (default: false).
  BaseUrlTokenName
    The token name for injecting the API base URL string (used in the Angular template, default: 'API_BASE_URL').
  QueryNullValue
    The null value used for query parameters which are null (default: '').
  TemplateDirectory
    The Liquid template directory (experimental).
  TypeNameGenerator
    The custom ITypeNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  PropertyNameGeneratorType
    The custom IPropertyNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  EnumNameGeneratorType
    The custom IEnumNameGenerator implementation type in the form 'assemblyName:fullTypeName' or 'fullTypeName').
  Input
    A file path or URL to the data or the JSON data itself.
  ServiceHost
    Overrides the service host of the web document (optional, use '.' to remove the hostname).
  ServiceSchemes
    Overrides the allowed schemes of the web service (optional, comma separated, 'http', 'https', 'ws', 'wss').
  Output
    The output file path (optional).