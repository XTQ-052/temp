using homework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
	public class BaseEntity
	{
		public BaseEntity()
		{
			CreatedDate = DateTime.Now;
			Status = DataStatus.Inserted;
		}

		[Key]
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
		public DataStatus Status { get; set; }
	}
}
