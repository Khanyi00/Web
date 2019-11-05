using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
  public  class DataDB
    {
        public static List<UsersTimeslots> GetTotalHoursPerPerson(DateTime date)
        {
            
            var month = date.Month;
            var year = date.Year;
            
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select  UserId, Sum(HoursCaptured) as TotalHours from Timeslots  " +
                               "where MONTH(Date)= @month AND YEAR(Date) = @year group by UserId";
                return db.Query<UsersTimeslots>(query, new { month, year}).ToList();
            }
        }

        public static List<ProjectTimeslots> GetTotalHoursPerProject(DateTime date)
        {
            var month = date.Month;
            var year = date.Year;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT ProjectId, Sum(HoursCaptured) as TotalHours from Timeslots " +
                               "where MONTH(Date)= @month AND YEAR(Date) = @year group by ProjectId";
                return db.Query<ProjectTimeslots>(query, new { month, year }).ToList();
            }
        }

        public static List<Users> GetUsers(string userName)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select * from Users where Username like Concat('%',@userName,'%')";
                return db.Query<Users>(query, new { userName }).ToList();
            }
        }

        public static List<Timeslots> GetFullTimeSlots(string userName, DateTime date)
        {
            var month = date.Month;
            var year = date.Year;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select Timeslots.TimeslotId, Timeslots.ProjectId, Timeslots.Date,Timeslots.HoursCaptured,  Users.Username " +
                               " from Timeslots INNER JOIN Users  ON Timeslots.UserId = Users.UserId "+
                               "where Username like Concat('%',@userName,'%') and MONTH(Date)=  @month AND YEAR(Date) = @year order by Users.Username";
                return db.Query<Timeslots>(query, new { userName, month, year }).ToList();
            }
        }
    }
}
