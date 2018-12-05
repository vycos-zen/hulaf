using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace HULAF.WebApi.Mapping
{
    public class HulafMappingConfig
    {

        public delegate MapperConfiguration ConfiugreProfilesDelegate();



        public void GetConfigurationProfiles()
        {
            HulafConfiguration hulafConfiguration = new HulafConfiguration();
            ConfiugreProfilesDelegate confiugre = hulafConfiguration.ConfigureProfilesLazy;
            confiugre();
        }
    }
}