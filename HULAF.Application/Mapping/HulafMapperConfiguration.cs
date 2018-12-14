using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace HULAF.Application.Mapping
{
    public class HulafMapperConfiguration
    {
        static IMapperConfigurationExpression HulafMapperConfig()
        {
            var expression = new MapperConfigurationExpression();
            expression.AddProfiles(new[]
                {
                    typeof(PersonProfile),
                });

            return expression;
        }

        private static IMapperConfigurationExpression MapperConfiguration
        {
            get
            {
                var lazyConf = new Lazy<IMapperConfigurationExpression>(HulafMapperConfig);
                return lazyConf.Value;
            }
        }

        public static void GetConfiguration(IMapperConfigurationExpression configuration)
        {
            configuration = MapperConfiguration;
        }
    }
}