using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(s => s.Id);
            Field(s => s.Name);
            Field(s => s.Phone);
            Field(s => s.Time);
            Field(s => s.TotalPeople);
            Field(s => s.Date);
            Field(s => s.Email);
        }
    }
}
