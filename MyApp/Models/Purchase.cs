using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Models
{
    [MetadataType(typeof(AirInfoMetadata))]
    public partial class Purchase
    {
        [Bind(Exclude = "PurchaseId")]
        public class AirInfoMetadata
        {
            [ScaffoldColumn(false)]
            public int PurchaseId { get; set; }

            [DisplayName("Person")]
            [Required(ErrorMessage = "Поле не заполнено.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Person { get; set; }

            [DisplayName("LastName")]
            [Required(ErrorMessage = "Поле не заполнено.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string LastName { get; set; }

            [DisplayName("Address")]
            [Required(ErrorMessage = "Поле не заполнено.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Address { get; set; }

            [DisplayName("Serial")]
            [Required(ErrorMessage = "Поле не заполнено.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Serial { get; set; }
        }
    }
}