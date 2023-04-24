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
    public class PurchasePurchaseOrder_Manager: DbManager
    {
        public void Create(PurchaseOrder c)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                    INSERT INTO po_purchase_order (po_date_12545
                                            ,po_total_12545) 
                    VALUES ('{c.Date.Ticks}',
                            '{Convert.ToDouble(c.TotalAmount)}')";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
        
        public List<PurchaseOrder> GetAll()
        {
            var connection = Connection;
            var result = new List<PurchaseOrder>();
            try
            {
                var sql = @"
SELECT po_id_12545
        ,po_date_12545
        ,po_total_12545
FROM po_purchase_order";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        var c = new PurchaseOrder
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Date = new DateTime(Convert.ToInt64(reader.GetValue(1))),
                            TotalAmount = Convert.ToDouble(reader.GetValue(2)),
                        };
                        result.Add(c);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return result;
        }
        public PurchaseOrder GetById(int Id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
SELECT po_id_12545
                ,po_date_12545
                ,po_total_12545
FROM po_purchase_order WHERE po_id_12545 = '{Id}'";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        var c = new PurchaseOrder
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Date = new DateTime(Convert.ToInt64(reader.GetValue(1))),
                            TotalAmount = Convert.ToDouble(reader.GetValue(2))
                        };
                        return c;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }


            return null;
        }
    }
}
