﻿using System.Xml.Linq;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Kamla_Raul_Lab2_HW.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column("Price", TypeName = "decimal(6, 2)")]
        public decimal Price
        {
            get; set;
        }

        [DataType(DataType.Date)]
        public DateTime PublishingDate
        {
            get; set;
        }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }//navigation property
    }
}
