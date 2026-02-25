using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ReportMaster.Models;

namespace ReportMaster2
{
    public class User
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        // Данные пользователя
        public List<FinanceRecord> Finances { get; set; } = new List<FinanceRecord>();
        public List<TaskRecord> Tasks { get; set; } = new List<TaskRecord>();
        public List<EventRecord> Events { get; set; } = new List<EventRecord>();

        // Для совместимости со старым форматом
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Value { get; set; }
    }

    public static class UserManager
    {
        private static readonly string bd = "users.json";
        private static User _currentUser;

        // Текущий пользователь
        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        // Метод для хеширования пароля (упрощенный)
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Загрузка всех пользователей из JSON
        public static List<User> LoadUsers()
        {
            if (!File.Exists(bd))
                return new List<User>();

            string json = File.ReadAllText(bd);
            return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
        }

        // Сохранение пользователей в JSON
        public static void SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(bd, json);
        }

        // Сохранение текущего пользователя
        public static void SaveCurrentUser()
        {
            if (_currentUser == null) return;

            var users = LoadUsers();
            var index = users.FindIndex(u => u.Login == _currentUser.Login);

            if (index >= 0)
            {
                users[index] = _currentUser;
                SaveUsers(users);
            }
        }

        // Проверка существования пользователя
        public static bool UserExists(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }

        // Регистрация нового пользователя
        public static bool RegisterUser(string login, string password)
        {
            if (UserExists(login))
                return false;

            var users = LoadUsers();

            users.Add(new User
            {
                Login = login,
                PasswordHash = HashPassword(password),
                Finances = new List<FinanceRecord>(),
                Tasks = new List<TaskRecord>(),
                Events = new List<EventRecord>()
            });

            SaveUsers(users);
            return true;
        }

        // Проверка логина и пароля
        public static bool ValidateUser(string login, string password)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Login == login);

            if (user == null)
                return false;

            string hash = HashPassword(password);

            if (user.PasswordHash == hash)
            {
                _currentUser = user;
                return true;
            }

            return false;
        }

        // Выход пользователя
        public static void Logout()
        {
            _currentUser = null;
        }
    }
}