using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMaster.Models
{
    /// <summary>
    /// Базовый класс для всех типов записей
    /// </summary>
    public abstract class RecordBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
    }
}