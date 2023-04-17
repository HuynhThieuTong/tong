using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using WebsiteBanHnag.Context;

namespace WebsiteBanHnag.Models
{
    [MetadataType(typeof(ProductMasterData))]
    public partial class Products
    {
        [NotMapped]
        public System.Web.HttpPostedFileBase ImageUpload { get; set; }
    }
}