using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4.Banner UML
{
	public class Instructor : User
	{
		private Schedule _classSchedule;
		private List<Student> _waitListedStudents;
		List<StudentGrade> studentGrades;

		public void enterGrade(int section_id, int student_id, int assignment_id, int score)
		{
			throw new NotImplementedException();
		}

		public void overridePreqForStudent(int section_id, Student student)
		{
			throw new NotImplementedException();
		}

		public void viewSchedule()
		{
			throw new NotImplementedException();
		}

		public void viewWaitListedStudentsForClass()
		{
			throw new NotImplementedException();
		}

		public Instructor(int id, string fname, string lname)
		{
			throw new NotImplementedException();
		}
	}
}
