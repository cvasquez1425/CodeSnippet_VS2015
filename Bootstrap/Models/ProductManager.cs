using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LINQ.Entities;

namespace Bootstrap.Models
{
    public class ProductManager
    {
        #region GetProductsCount method
        public int GetProductsCount()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = null;
            int ret = 0;
            cmd = new SqlCommand("SELECT Count(*) FROM Product");
            //cmd.Connection = new SqlConnection(AppSettings.Instance.ConnectString);
            cmd.Connection.Open();
            ret = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return ret;
        }
        #endregion

        private void GetProductsByPage()
        {
            //IQueryable<Product> query;

            //Convert products to IQueryable
            //query = Product.AsQueryable<Product>();
             
            //Convert back to List<Product>
            //Products = new List<Product>(query.ToList<Product>());

        }
    }
}