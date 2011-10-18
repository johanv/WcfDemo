// HelloWorld.cs - example class in backend
// Copyright (C) 2011  Johan Vervloet
//
// This program is part of WcfDemo.
// WcfDemo is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// WcfDemo is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Backend
{
    public class HelloWorld
    {
        /// <summary>
        /// Roept de stored procedure 'HelloWorld' aan, en levert het resultaat af.
        /// </summary>
        /// <returns>De output van HelloWorld</returns>
        /// <remarks>Uiteraard koppel je in een echte toepassing de data access los van
        /// de businesslogica.</remarks>
        public string SayHello()
        {
            string result;

            var conStrSettings = ConfigurationManager.ConnectionStrings["DemoConnectionString"];

            using (var conn = new SqlConnection(conStrSettings.ConnectionString))
            {
                var cmd = new SqlCommand("HelloWorld", conn) { CommandType = CommandType.StoredProcedure };

                var param = new SqlParameter("@result", SqlDbType.VarChar)
                {
                    Size = -1,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(param);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                result = param.Value.ToString();
            }

            return result;
        }
    }
}
