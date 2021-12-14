using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
	public class Book : BaseEntity
	{
		public string Name { get; set; }
		public int PageCount { get; set; }

		//many to many
		public List<Student> students { get; set; }

		//one to many
		public Author authors { get; set; }
		public BookType bookType { get; set; }
	}
}
