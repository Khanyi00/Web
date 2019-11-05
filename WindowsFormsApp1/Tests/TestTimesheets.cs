using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp1.Model;
using Dapper;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests
{
    [TestFixture]
    public class TestTimesheets
    {
        readonly IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        [Test]
        public void GetHoursPerPerson_WithDate_ShouldReturnTotalHours()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();

            var date = "2018-02-06";
           // var parameters = new {  month = DateTime.Parse(date).Month, year = DateTime.Parse(date).Year };
            var month = DateTime.Parse(date).Month;
            var year = DateTime.Parse(date).Year;

            //act
            string query = "select  UserId, Sum(HoursCaptured) as TotalHours from Timeslots  " +
                           "where MONTH(Date)= @month AND YEAR(Date) = @year group by UserId";
            var result = _db.Query<UsersTimeslots>(query, new { month, year}).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(11));
            Assert.That(result, Is.Not.Null);
            //Assert.That(result[0].HoursCaptured,Is.EqualTo(8));
        }

        [Test]
        public void GetPerProject_WithDate_ShouldReturnTotalHours()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();

            var date = "2018-02-06";
            var month = DateTime.Parse(date).Month;
            var year = DateTime.Parse(date).Year;

            //act
            string query = "SELECT ProjectId, Sum(HoursCaptured) as TotalHours from Timeslots " +
                           "where MONTH(Date)= @month AND YEAR(Date) = @year group by ProjectId";
            var result = _db.Query<Users>(query, new { month, year }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(6));
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetUser_WithUserName_ShouldReturnUser()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();
            string userName = "no";

            //act
            string query = "select * from Users where Username like Concat('%',@userName,'%')";
            var result = _db.Query<Users>(query, new { userName }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetFullTimeslots_WithDateAndUserName_ShouldReturnFullslot()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();

            var date = "2018-02-06";
            var month = DateTime.Parse(date).Month;
            var year = DateTime.Parse(date).Year;
            string userName = "no";

            //act
            string query = "select Timeslots.TimeslotId, Timeslots.ProjectId, Timeslots.Date,Timeslots.HoursCaptured,  Users.Username " +
                           " from Timeslots INNER JOIN Users  ON Timeslots.UserId = Users.UserId " +
                           "where Username like Concat('%',@userName,'%') and MONTH(Date)=  @month AND YEAR(Date) = @year order by Users.Username";
            var result = _db.Query<Users>(query, new { userName,month, year }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(31));
            Assert.That(result, Is.Not.Null);
        }
    }
}
