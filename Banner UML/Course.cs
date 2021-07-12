using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4.BannerUML
{
	public class Course
	{
		private List<CourseSection> _sections;
		private int _courseId;
		private Schedule _schedule;
		private HashSet<int> _preqIds;
		private HashSet<int> _semesters;

		public void addSection(DateTime start, DateTime end, string instructor, int avaliableSeats)
		{
			throw new NotImplementedException();
		}

		public void addSection(CourseSection section)
		{
			throw new NotImplementedException();
		}

		public void addPreq(int preReqId)
		{
			throw new NotImplementedException();
		}

		public void removePreq(int preReqId)
		{
			throw new NotImplementedException();
		}

		public void removeAllPreq()
		{
			throw new NotImplementedException();
		}

		public void addSemester(int semester_id)
		{
			throw new NotImplementedException();
		}

		public void removeSemester(int semester_id)
		{
			throw new NotImplementedException();
		}

		public void AddNewSeatLimit(int sectionId)
		{
			throw new NotImplementedException();
		}

		public Course(int course_id, Schedule schedule)
		{
			throw new NotImplementedException();
		}
	}
}
