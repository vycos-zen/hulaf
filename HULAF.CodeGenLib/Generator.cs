using System;
using NSwag;
using NSwag.Collections;
using NSwag.CodeGeneration;
using NSwag.CodeGeneration.CSharp;
using System.Threading.Tasks;
using System.IO;
using YamlDotNet.RepresentationModel;
using NJsonSchema.CodeGeneration.CSharp;

namespace HULAF.CodeGenLib
{
    public class Generator
    {
        public async Task<string> Generate()
        {
            using (var fileStream = File.OpenText("hulaf-contract.yaml"))
            {
                var yaml = await fileStream.ReadToEndAsync();

                var document = await SwaggerYamlDocument.FromYamlAsync(yaml);

                var settings = new SwaggerToCSharpControllerGeneratorSettings();
               settings.CSharpGeneratorSettings.ClassStyle =  CSharpClassStyle.Poco;
            //    settings.CodeGeneratorSettings.s

                var generator = new SwaggerToCSharpControllerGeneratorSettings{
                    AspNetNamespace = "HULAF.WebApi",
                    
                };
                generator.CodeGeneratorSettings.TemplateDirectory = "./";

                // generator.

                return generator.GenerateControllerName("ApiController");
            }
        }
    }
}
