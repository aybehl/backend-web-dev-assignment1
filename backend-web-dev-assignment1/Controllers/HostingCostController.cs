using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend_web_dev_assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Method takes an integer input as the number of days which 
        /// have elapsed since the beginning of the hosting.
        /// We defined three variables - 
        /// 1. totalCost = no of fortnights * charge for one fortnight
        /// 2. taxesApplied = 13% tax * totalCost
        /// 3. totalCost = totalCost + taxesApplied
        /// </summary>
        /// <param name="id">An integer input</param>
        /// <example>
        /// GET /api/HostingCost -> 
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD”
        /// “Total = $6.22 CAD”
        /// </example>
        /// <returns>An array of strings</returns>

        public IEnumerable<string> Get(int id) {
            int noOfFortNightsElapsed = id / 14 + 1;
            double chargePerFortNight = 5.50;
            double totalCost = noOfFortNightsElapsed * chargePerFortNight;
            double tax = 0.13;
            double taxesApplied = totalCost * tax;
            double totalCostToClient = totalCost + taxesApplied;

            double roundedTotalCost = Math.Round(totalCost, 2);
            double roundedTaxesApplied = Math.Round(taxesApplied, 2);
            double roundedTotalCostToClient = Math.Round(totalCostToClient, 2);

            string s1 = $"{noOfFortNightsElapsed} fortnights at ${chargePerFortNight}/FN = {roundedTotalCost:F2} CAD";
            string s2 = $"HST 13% = ${roundedTaxesApplied:F2} CAD";
            string s3 = $"Total = ${roundedTotalCostToClient:F2} CAD";

            return new string[] { s1, s2, s3};
        }
    }
}
