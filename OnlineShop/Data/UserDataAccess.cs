using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace OnlineShop.Data
{
    public class UserDataAccess : DbDataAccess<User>
    {
        public override void Insert(User user)
        {
            string insertSqlScript = "insert into Users values (@FullName, @Phone)";

            using (var transaction = connection.BeginTransaction())
            {
                using (var command = factory.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = insertSqlScript;

                    try
                    {
                        command.Transaction = transaction;

                        var fullNameParameter = factory.CreateParameter();
                        fullNameParameter.DbType = System.Data.DbType.String;
                        fullNameParameter.Value = user.FullName;
                        fullNameParameter.ParameterName = "FullName";

                        command.Parameters.Add(fullNameParameter);

                        var phoneParameter = factory.CreateParameter();
                        phoneParameter.DbType = System.Data.DbType.String;
                        phoneParameter.Value = user.Phone;
                        phoneParameter.ParameterName = "Phone";

                        command.Parameters.Add(phoneParameter);

                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (DbException)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
