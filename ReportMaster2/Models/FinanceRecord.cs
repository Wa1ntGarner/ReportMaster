using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMaster.Models
{
    /// <summary>
    /// Класс для финансовых записей
    /// </summary>
    public class FinanceRecord : RecordBase
    {
        public decimal Amount { get; set; } // Сумма (отрицательная - расход, положительная - доход)
    }
}