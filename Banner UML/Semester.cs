using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4.BannerUML
{
	public class Semester
	{
		private DateTime endDate;
		int semesterId;
		private DateTime startDate;
		private static Dictionary<int, CourseSection> _courseList;
		public string _season;
		public int _year;

		public List<CourseSection> browseCourses(string search)
		{
			throw new NotImplementedException();
		}

		Semester(string season, int year, DateTime startDate, DateTime endDate)
		{
			throw new NotImplementedException();
		}
	}
}
