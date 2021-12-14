using homework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
	public class Student : BaseEntity
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string SchoolNumber { get; set; }
		public Gender Gender { get; set; }
		public DateTime Birthdate { get; set; }
		public string PhoneNumber { get; set; }

		//many to many
		public List<Book> books { get; set; }
	}
}
