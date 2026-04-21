using MediatR;
using OnionApp.Application.Base;
using OnionApp.Application.Features.Results.StatisticsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Queries.StatisticsQueries
{
    public class GetCarCountQuery:IRequest<BaseResult<GetCarCountQueryResult>> 
    {
    }
}
