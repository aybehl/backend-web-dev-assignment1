using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Method takes an integer input and applies the following mathematical operations to it -
        /// 1. {id} + 6
        /// 2. {id} - 3
        /// 3. {id} * 2
        /// 4. {id} / 10
        /// Returns an array of double datatype containing the results of the four operations
        /// </summary>
        /// <param name="id">An integer input</param>
        /// <example>
        /// GET /api/numbermachine/10 -> [16.0,7.0,20.0,1.0]
        /// </example>
        /// <example>
        /// GET /api/NumberMachine/-5 -> [1.0,-8.0,-10.0,-0.5]
        /// </example>
        /// <example>
        /// GET /api/numberMachine/30 -> [36.0,27.0,60.0,3.0]
        /// </example> 
        /// <returns>An array of double containing the results of the four operations</returns>
        public IEnumerable<double> Get(int id)
        {
            double add = id + 6;
            double subtract = id - 3;
            double multiply = id * 2;
            double division = (double)id / 10;
            
            return new double[] { add, subtract, multiply, division };
        }
    }
}
