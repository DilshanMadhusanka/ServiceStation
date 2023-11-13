using Microsoft.AspNetCore.Mvc;

namespace ServiceStation.Controllers
{
    public class ServicesController : Controller // create an controller
    {

        /*eka normal method ekak nemei dan. meka action ekak. meka load krann run krala web page eke
         url eke path ek gahnna.Services / HelloWorld. ( controller name eka / action name )
        
        methana HelloWorld kiyanne action ekak
         */

        public String HelloWorld()
        {
            return " This is the services controller";
        }

    }
}
