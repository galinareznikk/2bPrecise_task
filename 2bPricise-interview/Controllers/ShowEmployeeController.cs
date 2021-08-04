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
using _2bPricise_interview.Models;

namespace _2bPricise_interview.Controllers
{
    public class ShowEmployeeController : ApiController
    {


        //needs to add parameter from angular

        [Route("api/getTasksList")]
        [HttpGet]
        public HttpResponseMessage getTasksList()
        {

           int employeeID = 3;
            string query = "select text,due_date from dbo.Task where employeeID="+ employeeID;
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

        [Route("api/getSubordinates")]
        [HttpGet]
        public HttpResponseMessage getSubordinates(int managerID)
        {
            //int managerID = 3;
            string query = "select PKID,first_name,last_name,position from dbo.employee where managerID=" + managerID;
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

        [Route("api/getManagerFullName")]
        [HttpGet]
        public HttpResponseMessage getManagerFullName(int employeeID)
        {
           // int employeeID = 3;
            string query = "select PKID, first_name, last_name,profile_pic from dbo.Employee where PKID in (select managerID from dbo.Employee where PKID=" + employeeID + ")";

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


        [Route("api/getEmployeeDtails")]
        [HttpGet]
        public HttpResponseMessage getEmployeeDtails()
        {
            int employeeID = 3;
            string query = "select PKID, first_name, last_name,profile_pic from dbo.Employee where PKID="+ employeeID;

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


        //dont work
        [Route("api/addTask")]
        public string addTask(Task ts)
        {
            //Task ts = new Task();
            try
            {
                string query = "insert into dbo.Task values("+ts.assign_date + ","+ ts.due_date + ","+ ts.EmployeeID+")";
               // string query = "insert into dbo.Task values(" + ts.text + "," + ts.assign_date + "," + ts.due_date + "," + ts.EmployeeID + ");";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["myDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Add!!";
            }

        }


        [Route("api/AddReport")]
        public string AddReport(Report rp)
        {
            try
            {
                string query = "insert into dbo.Report (text,date,mangerID,authorID) values(" + rp.text + "," + rp.date + "," + rp.mangerID + "," + rp.authorID + ")";
                DataTable table = new DataTable();
                Console.WriteLine(query+"");

                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["myDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Successfully!!";
            }
            catch (Exception e)
            {

                return e.ToString();
            }

        }


    }
}