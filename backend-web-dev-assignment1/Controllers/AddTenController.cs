using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Method takes an integer input and returns a number after adding 10 to it
        /// </summary>
        /// <param name="id">An integer input</param>
        /// <example>
        /// GET /api/AddTen/21 -> 31
        /// </example>
        /// <example>
        /// GET /api/AddTen/0 -> 10
        /// </example>
        /// <example>
        /// GET /api/AddTen/-9 -> 1
        /// </example> 
        /// <returns>An integer equal to {id} + 10</returns>
        public int Get(int id) {
            return id + 10;
        }
    }
}
