using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Linq;

namespace finalprojectxz
{
    public class User
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int Value { get; set; }
        public string Salt { get; set; }
    }

    public static class UserManager
    {
        private static readonly string bd = "users.json";

        // Метод для хеширования пароля с солью
        public static (string hash, string salt) HashPassword(string password)
        {
            // Генерируем соль
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);

            // Хешируем пароль с солью
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                string hashString = Convert.ToBase64String(hash);
                return (hashString, salt);
            }
        }

        // Метод для проверки пароля
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                string hashString = Convert.ToBase64String(hash);
                return hashString == storedHash;
            }
        }

        // Загрузка всех пользователей из JSON
        public static List<User> LoadUsers()
        {
            if (!File.Exists(bd))
                return new List<User>();

            string json = File.ReadAllText(bd);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        // Сохранение пользователей в JSON
        public static void SaveUsers(List<User> users)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(bd, json);
        }

        // Проверка существования пользователя
        public static bool UserExists(string login)
        {
            var users = LoadUsers();
            return users.Any(u => u.Login == login);
        }

        // Регистрация нового пользователя
        public static bool RegisterUser(string login, string password, int value = 0)
        {
            if (UserExists(login))
                return false;

            var users = LoadUsers();
            var (hash, salt) = HashPassword(password);

            users.Add(new User
            {
                Login = login,
                PasswordHash = hash,
                Salt = salt,
                Value = value
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

            return VerifyPassword(password, user.PasswordHash, user.Salt);
        }
    }
}