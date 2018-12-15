using HULAF.Application.Dto.Personal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Personal.Queries
{
    public class GetMissingPersonQuery : IRequest<MissingPersonDto>
    {
        public Guid Guid { get; set; }
    }
}
