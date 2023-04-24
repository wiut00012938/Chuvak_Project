using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDuperMarket.DAL
{
    public class ToOrder_Manager: DbManager
    {
        public List<ToOrder> GetAll()
        {
            var connection = Connection;
            var result = new List<ToOrder>();
            try
            {
                var sql = $@"SELECT pt_name_12545,pt_priority_12545,pt_remaining_12545,pt_purchase_level_12545,pt_price_12545 FROM pt_product";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = new ToOrder
                    {
                        ProductName = Convert.ToString(reader.GetValue(0)),
                        Priority = Convert.ToInt32(reader.GetValue(1)),
                        Remaining = Convert.ToInt32(reader.GetValue(2)),
                        PurchaseLevel = Convert.ToInt32(reader.GetValue(3)),
                        Price = Convert.ToDouble(reader.GetValue(4))


                    };
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }
        public List<ToOrder> Sorting()
        {
            return GetAll().OrderByDescending(a => a.Priority).ToList();

        }
        public List<ToOrder> Filtering()
        {
            return GetAll().Where(a => Convert.ToInt32(a.Remaining) - Convert.ToInt32(a.PurchaseLevel) < 0).ToList();
        }
    }
}
