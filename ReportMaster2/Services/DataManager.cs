using Newtonsoft.Json;
using ReportMaster.Models;
using ReportMaster2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMaster.Services
{
    public class DataManager
    {
        // Свойства для доступа к данным
        public List<FinanceRecord> Finances
        {
            get { return UserManager.CurrentUser?.Finances ?? new List<FinanceRecord>(); }
            set { if (UserManager.CurrentUser != null) UserManager.CurrentUser.Finances = value; }
        }

        public List<TaskRecord> Tasks
        {
            get { return UserManager.CurrentUser?.Tasks ?? new List<TaskRecord>(); }
            set { if (UserManager.CurrentUser != null) UserManager.CurrentUser.Tasks = value; }
        }

        public List<EventRecord> Events
        {
            get { return UserManager.CurrentUser?.Events ?? new List<EventRecord>(); }
            set { if (UserManager.CurrentUser != null) UserManager.CurrentUser.Events = value; }
        }

        public DataManager()
        {
            // Инициализация списков, если они null
            if (UserManager.CurrentUser != null)
            {
                if (UserManager.CurrentUser.Finances == null)
                    UserManager.CurrentUser.Finances = new List<FinanceRecord>();

                if (UserManager.CurrentUser.Tasks == null)
                    UserManager.CurrentUser.Tasks = new List<TaskRecord>();

                if (UserManager.CurrentUser.Events == null)
                    UserManager.CurrentUser.Events = new List<EventRecord>();
            }
        }

        public void LoadData()
        {
            // Данные уже загружены в UserManager.CurrentUser
            // Просто убедимся, что списки инициализированы
            if (UserManager.CurrentUser != null)
            {
                if (UserManager.CurrentUser.Finances == null)
                    UserManager.CurrentUser.Finances = new List<FinanceRecord>();

                if (UserManager.CurrentUser.Tasks == null)
                    UserManager.CurrentUser.Tasks = new List<TaskRecord>();

                if (UserManager.CurrentUser.Events == null)
                    UserManager.CurrentUser.Events = new List<EventRecord>();
            }
        }

        public void SaveData()
        {
            UserManager.SaveCurrentUser();
        }

        // Методы для получения следующих ID
        public int GetNextFinanceId()
        {
            if (Finances.Count == 0) return 1;
            return Finances.Max(f => f.Id) + 1;
        }

        public int GetNextTaskId()
        {
            if (Tasks.Count == 0) return 1;
            return Tasks.Max(t => t.Id) + 1;
        }

        public int GetNextEventId()
        {
            if (Events.Count == 0) return 1;
            return Events.Max(e => e.Id) + 1;
        }
    }
}