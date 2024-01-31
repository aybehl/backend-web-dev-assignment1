using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Method takes an integer input and returns square of it
        /// </summary>
        /// <param name="id">An integer input</param>
        /// <example>
        /// GET /api/Square/2 -> 4
        /// </example>
        /// <example>
        /// GET /api/square/-2 -> 4
        /// </example>
        /// <example>
        /// GET /api/Square/10 -> 100
        /// </example> 
        /// <returns>{id} raised to the power of 2</returns>
        public int Get(int id)
        {
            return (int)Math.Pow(id, 2);
        }
    }
}
