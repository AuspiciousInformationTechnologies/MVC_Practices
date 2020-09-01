using System.Web.Mvc;

namespace Textile_House2020.Areas.User
{
    public class UserAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "User_default",
                "User/{controller}/{action}/{id}",
                new {controller= "UserRegistration", action = "Index", id = UrlParameter.Optional }
            );  
        }
    }
}