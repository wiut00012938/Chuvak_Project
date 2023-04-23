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
    public class Product_Manager: DbManager
    {
        public void Create(Product c)
        {
            var connection = Connection; 
            try 
            {
                var sql = $"INSERT INTO pt_product (pt_name_12545,pt_remaining_12545,pt_priority_12545,pt_purchase_level_12545,pt_price_12545) VALUES ('{c.Name}','{Convert.ToInt32(c.Remaining)}','{Convert.ToInt32(c.Priority)}','{Convert.ToInt32(c.PurchaseLevel)}','{Convert.ToDouble(c.Price)}')";
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
        public void Update(Product c)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE pt_product SET pt_name_12545 = '{c.Name}',pt_remaining_12545 = '{c.Remaining}',pt_priority_12545 = '{c.Priority}',pt_purchase_level_12545 = '{c.PurchaseLevel}',pt_price_12545 = '{c.Price}' WHERE pt_id_12545 = {c.Id}";
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
        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"Delete from pt_product Where pt_id_12545 = {id}";
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

        public List<Product> GetAll()
        {
            var connection = Connection;
            var result = new List<Product>();
            try
            {
                var sql = "SELECT pt_id_12545,pt_name_12545,pt_remaining_12545,pt_priority_12545,pt_purchase_level_12545,pt_price_12545 FROM pt_product";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        var c = new Product
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Name = Convert.ToString(reader.GetValue(1)),
                            Remaining = Convert.ToInt32(reader.GetValue(2)),
                            Priority = Convert.ToInt32(reader.GetValue(3)),
                            PurchaseLevel = Convert.ToInt32(reader.GetValue(4)),
                            Price = Convert.ToDouble(reader.GetValue(5))
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
        public Product GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT pt_id_12545,pt_name_12545,pt_remaining_12545,pt_priority_12545,pt_purchase_level_12545,pt_price_12545 FROM pt_product Where pt_id_12545 = {id}";
                var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        var c = new Product
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Name = Convert.ToString(reader.GetValue(1)),
                            Remaining = Convert.ToInt32(reader.GetValue(2)),
                            Priority = Convert.ToInt32(reader.GetValue(3)),
                            PurchaseLevel = Convert.ToInt32(reader.GetValue(4)),
                            Price = Convert.ToDouble(reader.GetValue(5))
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
