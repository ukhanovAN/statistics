using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitt
{
    internal class DataSalary
    {
        //public string NameOne { get; set; }

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
            //NameOne = worksheet.Name;
            // Получить количество строк и столбцов
            int rows = worksheet.Cells.MaxDataRow;
            //NameOne = worksheet.Cells[1, 3].StringValue;
            // Цикл по строкам
            for (int i = 0; i < rows+1; i++)
            {
                salaryOne[i] = worksheet.Cells[i, 1].DoubleValue;
                datesYear[i] = worksheet.Cells[i, 0].DoubleValue;
            }
        }
        //public string CoutMaxDiffOne()
        //{
        //    double maxDiffN = 0;
        //    DateTime dateMaxDiffN = dateTimes[0];
        //    double maxDiffP = 0;
        //    DateTime dateMaxDiffP = dateTimes[0];

        //    if (salaryOne[0] - salaryOne[1] < 0)Ы
        //    {
        //        maxDiffN = salaryOne[0] - salaryOne[1];
        //        dateMaxDiffN = dateTimes[0];
        //    }
        //    else
        //    {
        //        maxDiffP = salaryOne[0] - salaryOne[1];
        //        dateMaxDiffP = dateTimes[0];
        //    }

        //    for (int i = 0; i < dateTimes.Length - 1; i++)
        //    {
        //        if (salaryOne[i] - salaryOne[i + 1] < 0 && Math.Abs(salaryOne[i] - salaryOne[i + 1]) > Math.Abs(maxDiffN))
        //        {
        //            maxDiffN = salaryOne[i] - salaryOne[i + 1];
        //            dateMaxDiffN = dateTimes[i];
        //        }
        //        if (salaryOne[i] - salaryOne[i + 1] > 0 && Math.Abs(salaryOne[i] - salaryOne[i + 1]) > Math.Abs(maxDiffP))
        //        {
        //            maxDiffP = salaryOne[i] - salaryOne[i + 1];
        //            dateMaxDiffP = dateTimes[i];
        //        }
        //    }
        //    string text = "Максимальная прибавка за " + dateMaxDiffP.Date.ToShortDateString() + " число на " + Math.Round(maxDiffP, 5) +
        //        "\n Потеря за " + dateMaxDiffN.Date.ToShortDateString() + " число на " + Math.Round(maxDiffN, 5);
        //    return text;
        //}       
    }
}
