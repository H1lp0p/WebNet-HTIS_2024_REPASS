﻿using System.ComponentModel.DataAnnotations;

namespace webNet_courses.Domain.Entities
{
	public class Notification
	{
		[Required]
		public string Text { get; set; }

		[Required]
		public bool IsImportant { get; set; } = false;

		public Guid CampusCourseId { get; set; }
	}
}
