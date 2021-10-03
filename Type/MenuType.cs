using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}
