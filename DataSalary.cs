using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace gitt
{
    internal class DataSalary
    {
        public double[] salaryOne = new double[15];
        public double[] datesYear = new double[15];

        public void ShowGraph()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\salary.xlsx");
            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;
            // Индекс рабочего листа
            int worksheetIndex = 0;
            // Получить рабочий лист, используя его индекс
            Worksheet worksheet = collection[worksheetIndex];
            // Получить количество строк и столбцов
            int rows = worksheet.Cells.MaxDataRow;
            // Цикл по строкам
            for (int i = 0; i < rows+1; i++)
            {
                salaryOne[i] = worksheet.Cells[i, 1].DoubleValue;
                datesYear[i] = worksheet.Cells[i, 0].DoubleValue;
            }
        }
        public string ShowPercent()
        {
            ShowGraph();
            double percent = Math.Round(salaryOne[14] / salaryOne[0] * 100, 0);
            string text = "Заработная плата в " + datesYear[0] + " была равна " + salaryOne[0] +
                "\nЗаработная плата в " + datesYear[14] + " была равна " + salaryOne[14] +
                "\nПроцент роста заработной платы: " + percent + "%";
            return text;
        }
    }
}
