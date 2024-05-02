using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Feautures.CQRS.Queries.AdressQueries
{
    public class GetAdressByIdQuery
    {
        public int Id { get; set; }

        public GetAdressByIdQuery(int id)
        {
            Id = id;
        }
    }

    
}
