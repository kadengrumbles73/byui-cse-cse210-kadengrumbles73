using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private static string _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "journal.db");
    private string _connectionString = $"Data Source={_dbPath}";

    public Journal()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = 
            @"
                CREATE TABLE IF NOT EXISTS entries (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    date TEXT,
                    prompt TEXT,
                    response TEXT
                )
            ";
            command.ExecuteNonQuery();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO entries (date, prompt, response) VALUES ($date, $prompt, $response)";
            command.Parameters.AddWithValue("$date", newEntry._date);
            command.Parameters.AddWithValue("$prompt", newEntry._promptText);
            command.Parameters.AddWithValue("$response", newEntry._entryText);
            command.ExecuteNonQuery();
        }
        _entries.Add(newEntry);
    }

    public void LoadFromDatabase()
    {
        _entries.Clear();
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT date, prompt, response FROM entries";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entry entry = new Entry();
                    entry._date = reader.GetString(0);
                    entry._promptText = reader.GetString(1);
                    entry._entryText = reader.GetString(2);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded from database!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display. Load from database first.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}