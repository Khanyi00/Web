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
        private readonly IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


        [Test]
        public void GetDatabaseName_withConnectionstring_ShouldReturnDatabaseName()
        {
            //arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();
            var databaseName = "Timesheets";

            //act
            var conString = _db.ConnectionString;
            var result = _db.Database;

            //Assert
            Assert.That(conString.Contains(databaseName));
            Assert.That(databaseName, Is.EqualTo(result));
            Assert.That(result.Length, Is.EqualTo(10));
            Assert.That(result.Contains("Time"));
        }
        [Test]
        public void GetHoursPerPerson_WithDate_ShouldReturnTotalHours()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();

            var date = "2018-02-06";
            var month = DateTime.Parse(date).Month;
            var year = DateTime.Parse(date).Year;

            //act
            string query = "select  UserId, Sum(HoursCaptured) as TotalHours from Timeslots  " +
                           "where MONTH(Date)= @month AND YEAR(Date) = @year group by UserId";
            var result = _db.Query<UsersTimeslots>(query, new { month, year}).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(11));
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0].TotalHours,Is.EqualTo(83));
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
            var result = _db.Query<ProjectTimeslots>(query, new { month, year }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(6));
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0].TotalHours, Is.EqualTo(491));
        }

        [Test]
        public void GetUsers_WithUserName_ShouldReturnUsers()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();
            var userName = "no";

            //act
            string query = "select * from Users where Username like Concat('%',@userName,'%')";
            var result = _db.Query<Users>(query, new { userName }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0].Username, Is.EqualTo("Nompumelelo "));
        }

        [Test]
        public void GetFullTimeslots_WithDateAndUserName_ShouldReturnFullTimeslot()
        {
            //Arrange
            if (_db.State == ConnectionState.Closed)
                _db.Open();

            var date = "2018-02-06";
            var month = DateTime.Parse(date).Month;
            var year = DateTime.Parse(date).Year;
            var userName = "no";

            //act
            string query = "select  Timeslots.TimeslotId, Timeslots.ProjectId, Timeslots.Date,Timeslots.HoursCaptured,Users.UserId, Users.Username " +
                           " from Timeslots INNER JOIN Users  ON Timeslots.UserId = Users.UserId" +
                           " where Timeslots.UserId IN " +
                           "(select top 1 UserId from Users where Username like Concat('%',@userName,'%') and MONTH(Date)=02 AND YEAR(Date) =2018) ";
            var result = _db.Query<Timeslots>(query, new { userName,month, year }).ToList();

            //Assert
            Assert.That(result.Count, Is.EqualTo(13));
            Assert.That(result, Is.Not.Null);
            Assert.That(result[0].ProjectId, Is.EqualTo(3));
        }
    }
}
