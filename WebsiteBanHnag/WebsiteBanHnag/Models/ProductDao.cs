using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteBanHnag.Context;

namespace WebsiteBanHnag.Models
{
    public class ProductDao
    {
        WebsiteBanHangEntities objWebsiteBanHangEntities = new WebsiteBanHangEntities();
        public List<Product> SearchByKey(string key)
        {
            return objWebsiteBanHangEntities.Products.SqlQuery("Select * From Product Where Name like '%" + key + "%'").ToList();
        }
    }
}