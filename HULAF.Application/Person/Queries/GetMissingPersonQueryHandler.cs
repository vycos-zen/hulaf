using AutoMapper;
using HULAF.Application.Dto.Personal;
using HULAF.Application.Mapping;
using HULAF.Application.Personal.Queries;
using HULAF.Application.Personal;
using HULAF.DataAccess.Context;
using HULAF.Domain.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HULAF.Application.Personal.Queries
{
    public class GetMissingPersonQueryHandler : MediatR.IRequestHandler<GetMissingPersonQuery, MissingPersonDto>
    {
        private readonly HULAFContext context;

        private readonly IMapper mapper;

        public GetMissingPersonQueryHandler(HULAFContext context)
        {
            this.context = context;
            this.mapper = HulafMapperConfig.HulafMapper;
        }

        public async Task<MissingPersonDto> Handle(GetMissingPersonQuery request, CancellationToken cancellationToken)
        {
            Person person = this.context.Person.Where(p => p.PersonGuid == request.Guid).SingleOrDefault();

            if (person == null)
            {
                throw new KeyNotFoundException($"{string.Concat(nameof(Person), request.Guid.ToString())}");
            }

            ////TODO: Move to proper layer
            //Mapper.Initialize(HulafMapperConfiguration.GetConfiguration);

            return mapper.Map<Person, MissingPersonDto>(person);
        }
    }
}
