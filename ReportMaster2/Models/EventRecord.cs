using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMaster.Models
{
    /// <summary>
    /// Класс для событий
    /// </summary>
    public class EventRecord : RecordBase
    {
        public string Place { get; set; } // Место проведения
        public bool NeedRemind { get; set; } // Напомнить (Да/Нет)
    }
}   