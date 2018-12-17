using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace HULAF.Application.Mapping
{
    public class HulafMapperConfiguration
    {
        static HulafMapperConfiguration()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(new[]
                {
                    typeof(PersonProfile),
                    typeof(LocationProfile),
                });
            });
        }

        //static IMapperConfigurationExpression HulafMapperConfig()
        //{
        //    var expression = new MapperConfigurationExpression();
        //    expression.AddProfiles(new[]
        //        {
        //            typeof(PersonProfile),
        //            typeof(LocationProfile),
        //        });


        //    return expression;
        //}



        //private static IMapperConfigurationExpression MapperConfiguration
        //{
        //    get
        //    {
        //        var lazyConf = new Lazy<IMapperConfigurationExpression>(HulafMapperConfig);
        //        return lazyConf.Value;
        //    }
        //}

        public static IMapper HulafMapper
        {
            get
            {
                return Mapper.Instance;
            }
        }

        //public static void Configuration(IMapperConfigurationExpression configuration)
        //{
        //    configuration = MapperConfiguration;
        //}
    }
}