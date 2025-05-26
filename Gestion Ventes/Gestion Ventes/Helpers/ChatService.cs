using Microsoft.Data.SqlClient;

namespace Gestion_Ventes.Helpers
{
    public class ChatService
    {
        private readonly string _connectionString;

        public ChatService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<Dictionary<string, object>>> ExecuteSqlQuery(string query)
        {
            var analysis = RemoveBackticks(query);
            if (analysis.Length == 0)
                return new List<Dictionary<string, object>>();

            var results = new List<Dictionary<string, object>>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(analysis, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }
            return results;
        }

        public string RemoveBackticks(string query)
        {
            if (query.StartsWith("``") && query.EndsWith("``"))
            {
                query = query.Substring(3, query.Length - 6);
            }
            return query;
        }
    }
}
