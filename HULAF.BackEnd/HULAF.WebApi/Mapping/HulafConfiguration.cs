using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace HULAF.WebApi.Mapping
{
    public class HulafConfiguration
    {
        private Lazy<MapperConfiguration> lazyConf;
        static MapperConfiguration HulafMapperConfig()
        {
            var expression = new MapperConfigurationExpression();
            expression.AddProfiles(
                  new[]{
                typeof(HulafControllerProfile),
                  });
            MapperConfiguration configureLazy = new MapperConfiguration(expression);

            return configureLazy;
        }

        public MapperConfiguration ConfigureProfilesLazy()
        {
            MapperConfiguration configuration;
            this.lazyConf = new Lazy<MapperConfiguration>(HulafMapperConfig);

            lock (lazyConf)
            {
                configuration = lazyConf.Value;
            };
            return configuration;
        }
    }
}