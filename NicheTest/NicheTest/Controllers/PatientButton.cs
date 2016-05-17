using NicheTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NicheTest.Controllers
{
    public class PatientButton
    {
        protected void FindPatient(Patient patient)
        {
            //This is where the SQL would be performed and the result return
            //The SQL statment would look like:

            SELECT FirstName, LastName from patients where PatientId = 1
        }
    }
}