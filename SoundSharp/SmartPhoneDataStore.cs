using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;

namespace SoundSharp
{
    public class UserAccount
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }

        public UserAccount(string username, string password, int failedloginattempts, bool islocked)
        {
            Username = username;
            Password = password;
            FailedLoginAttempts = failedloginattempts;
            IsLocked = islocked;
        }
    }

    public class SmartPhoneDataStore
    {
        public List<SmartPhone> phones { get; set; } = new List<SmartPhone>();
        public List<UserAccount> users { get; set; } = new List<UserAccount>();
    }

    

    public class SmartPhoneJsonStore
    {
        static string current_dir = Environment.CurrentDirectory;
        static string dataPath = Directory.GetParent(current_dir).Parent.Parent.FullName;
        static string filePath = Path.Combine(dataPath, "data.json");
        private static readonly JsonSerializerOptions Options = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        public SmartPhoneDataStore data { get; set; } = new SmartPhoneDataStore();

        public void Save()
        {
    
            var json = JsonSerializer.Serialize(data, Options);
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                data = JsonSerializer.Deserialize<SmartPhoneDataStore>(json, Options) ?? new SmartPhoneDataStore();
            }
        }
    }
}
