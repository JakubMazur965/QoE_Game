// using System;
// using MySql.Data.MySqlClient;
// using UnityEngine;
//
// public class DBHelper : MonoBehaviour
// {
//     private string _connectionString;
//     
//     void Start()
//     {
//         string server = "mysql.agh.edu.pl";
//         int port = 3306;
//         string username = "jakubma1";
//         string password = "x99YAgt20iYtAP8z";
//         string database = "jakubma1";
//         
//         // Połączenie z bazą danych
//         _connectionString = $"Server={server};Port={port};Database={database};User Id={username};Password={password}";
//
//         using (MySqlConnection connection = new MySqlConnection(_connectionString))
//         {
//             connection.Open();
//
//             string insertQuery = "INSERT INTO Data (graphics_card) VALUES (@gpu)";
//             MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
//             cmd.Parameters.AddWithValue("@gpu", DataToDBDTO.GraphicsCard);
//
//             try
//             {
//                 cmd.ExecuteNonQuery();
//                 Debug.Log("Dodano rekord do tabeli Data.");
//             }
//             catch (Exception e)
//             {
//                 Debug.LogError("Błąd podczas dodawania rekordu: " + e.Message);
//             }
//         }
//     }
// }
