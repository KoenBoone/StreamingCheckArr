using Microsoft.Data.Sqlite;
using System;

public class DatabaseManager
{
    private readonly string _connectionString;

    public DatabaseManager()
    {
        _connectionString = "Data Source=Data/database.db";
    }

    public void CreateTable()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL
                );
            ";
            command.ExecuteNonQuery();
        }
    }

    public void InsertUser(string name)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Users (Name) VALUES (@name)";
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }
    }

    public void ShowUsers()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}");
                }
            }
        }
    }
}