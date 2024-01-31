using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Post method that returns a string 
        /// </summary>
        /// <example>
        /// POST /api/Greeting -> "Hello World!"
        /// </example>
        /// <returns>A string - Hello World!</returns>
        public string Post() {
            return "Hello World!";
        }

        /// <summary>
        /// Method takes an integer input and returns a custom string concatenated with that integer
        /// </summary>
        /// <param name="id">An integer input</param>
        /// <example>
        /// GET /api/Greeting/3 -> "Greetings to 3 people!"
        /// </example>
        /// <example>
        /// GET /api/Greeting/6 -> "Greetings to 6 people!"
        /// </example>
        /// <example>
        /// GET /api/Greeting/0 -> "Greetings to 0 people!"
        /// </example> 
        /// <returns>A string - "Greetings to {id} people!"</returns>

        public string Get(int id) {
            return "Greetings to " + id + " people!";
        }
        
    }
}
