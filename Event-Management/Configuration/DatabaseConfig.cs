using System;

namespace Event_Management.Configuration
{
    public static class DatabaseConfig
    {
        // Centralized Connection String
        public static string ConnectionString { get; } = @"Data Source=.\SQLEXPRESS;Initial Catalog=EventManagementDB;Integrated Security=True;";
    }
}