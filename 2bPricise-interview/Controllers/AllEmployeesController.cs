using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;


namespace _2bPricise_interview.Controllers
{
    public class AllEmployeesController: ApiController
    {
        public object ConfigurationManger { get; private set; }

        [Route ("api/getEmpolyeeList")]
        [HttpGet]
        public HttpResponseMessage getEmpolyeeList()
        {
            string query = @"select first_name,last_name,position from dbo.employee";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["myDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }



    }
}