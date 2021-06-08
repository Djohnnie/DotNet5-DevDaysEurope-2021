using _09_SourceGenerators.Attributes;

namespace _09_SourceGenerators.Demo
{
    [SwaggerClient(SwaggerDescriptor = 
        "http://localhost:5000/swagger/v1/swagger.json")]
    public partial class HttpClient
    {

    }
}