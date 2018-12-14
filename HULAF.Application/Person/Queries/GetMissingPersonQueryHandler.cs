using AutoMapper;
using HULAF.Application.Mapping;
using HULAF.Application.Person.Models;
using HULAF.DataAccess.Context;
using HULAF.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HULAF.Application.Person.Queries
{
    public class GetMissingPersonQueryHandler : MediatR.IRequestHandler<GetMissingPersonQuery, MissingPersonDto>
    {
        private readonly HULAFContext context;

        public GetMissingPersonQueryHandler(HULAFContext context)
        {
            this.context = context;
        }

        public async Task<MissingPersonDto> Handle(GetMissingPersonQuery request, CancellationToken cancellationToken)
        {
            Domain.Person.Person person = this.context.Person.Where(p => p.Guid == request.Guid).SingleOrDefault();

            if (person == null)
            {
                throw new KeyNotFoundException($"{string.Concat(nameof(Domain.Person.Person), request.Guid.ToString())}");
            }

            ////TODO: Move to proper layer
            //Mapper.Initialize(HulafMapperConfiguration.GetConfiguration);

            return Mapper.Map<Domain.Person.Person, MissingPersonDto>(person);
        }
    }
}
