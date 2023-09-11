using Example01.Entities;
using Example01.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example01.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=CvDb; integrated security =true");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from Abouts where Id =1";

            connection.Open();
            var reader = command.ExecuteReader();

            About about = new About();

            while (reader.Read())
            {
                about.Id = reader.GetInt32(0);
                about.Fullname = reader.GetString(1);
                about.JobTitle = reader.GetString(2);
                about.Description =reader.GetString(3);
                about.ImagePath = reader.GetString(4);
            }

            connection.Close();
            reader.Close();

            return View(about);
        }

        public ActionResult Portfolio()
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=CvDb; integrated security =true");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "ap_ListSlogan";


            command.Parameters.Add("@sectionName", "Skills");

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var title = reader.GetString(2);
            }
            connection.Close();
            reader.Close();
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}