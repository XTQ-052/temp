using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
	public class Author : BaseEntity
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }

		//one to many
		public List<Book> books { get; set; }
	}
}
