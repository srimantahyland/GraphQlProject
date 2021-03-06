using GraphQL;
using GraphQL.Types;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using GraphQlProject.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                resolve: context =>
                {
                    return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
                });

            /*Field<MenuType>("updateProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" },
                new QueryArgument<MenuInputType> { Name = "product" }),
                resolve: context =>
                {
                    var productObject = context.GetArgument<SubMenu>("product");
                    var productId = context.GetArgument<int>("id");
                    return productService.UpdateProduct(productId, productObject);
                });

            Field<StringGraphType>("deleteProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
               resolve: context =>
               {
                   var productId = context.GetArgument<int>("id");
                   productService.DeleteProduct(productId);
                   return "The product against the id " + productId + " has been deleted.";
               });*/
        }
    }
}
