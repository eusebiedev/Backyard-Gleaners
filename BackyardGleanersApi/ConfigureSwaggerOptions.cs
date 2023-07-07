using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

internal class ConfigureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
{
  private readonly IApiVersionDescriptionProvider _provider;

  public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
    {
      _provider = provider;
    }

  public void Configure(SwaggerGenOptions options)
  {
    foreach (var description in _provider.ApiVersionDescriptions)
    {
      options.SwaggerDoc(
              description.GroupName,
              CreateVersionInfo(description));
    }
  }

  public void Configure(string name, SwaggerGenOptions options)
  {
    Configure(options);
  }

  private OpenApiInfo CreateVersionInfo(ApiVersionDescription desc)
  {
    var info = new OpenApiInfo()
    {
      Title = ".NET Core (.NET 6) Web API",
      Version = desc.ApiVersion.ToString()
    };

    if (desc.IsDeprecated)
    {
      info.Description += " This API version has been deprecated. Please use one of the new APIs available from the explorer.";
    }
    return info;
  }
}