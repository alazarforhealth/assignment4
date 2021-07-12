using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4.Banner UML
{
	public class Student : User
	{
		private string _classYear;
		private string _academicStatus;
		private StudentRegistration registeredClasses;
		private List<StudentRegistration> plannedClasses;
		private Schedule _currentClassSchedule;
		private List<CourseSection> _waitlListedClasses;
		private bool allowRegistration;

		public void registerCourse(int course_id, int semester_id)
		{
			throw new NotImplementedException();
		}

		public void dropCourse(int course_id, int semester_id)
		{
			throw new NotImplementedException();
		}

		public void waitListCourse(int course_id)
		{
			throw new NotImplementedException();
		}

		public Schedule getClassSchedule()
		{
			throw new NotImplementedException();
		}

		public void changeRegistrationStatus(bool status)
		{
			throw new NotImplementedException();
		}

		public void viewClassSchedule()
		{
			throw new NotImplementedException();
		}

		public void evaluateDegreeProgress()
		{
			throw new NotImplementedException();
		}

		public Student(int id, string fname, string lname)
		{
			throw new NotImplementedException();
		}
	}
}
