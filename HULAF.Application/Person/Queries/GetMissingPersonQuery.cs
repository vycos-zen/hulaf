using HULAF.Application.Person.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HULAF.Application.Person.Queries
{
    public class GetMissingPersonQuery : IRequest<MissingPersonDto>
    {
        public Guid Guid { get; set; }
    }
}
