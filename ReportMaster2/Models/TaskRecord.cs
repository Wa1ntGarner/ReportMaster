using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMaster.Models
{
    /// <summary>
    /// Класс для задач
    /// </summary>
    public class TaskRecord : RecordBase
    {
        public string Status { get; set; } // Статус: "В работе", "Выполнено" и т.д.
        public DateTime DueDate { get; set; } // Срок сдачи
    }
}