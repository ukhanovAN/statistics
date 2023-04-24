using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitt
{
    internal class DataCourse
    {
        public string NameOne { get; set; }
        public string NameTwo { get; set; }

        public  double []  courseOne = new double[22];
        public double[] courseTwo = new double[22];
        public double[] datesChisla = new double[22];
        public DateTime [] dateTimes = new DateTime[22];

        public void CoutOne()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\course.xlsx");
            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;
            // Индекс рабочего листа
            int worksheetIndex = 0;
            // Получить рабочий лист, используя его индекс
            Worksheet worksheet = collection[worksheetIndex];
            // Получить количество строк и столбцов
            int rows = worksheet.Cells.MaxDataRow;
            NameOne = worksheet.Cells[1, 3].StringValue;
            // Цикл по строкам
            for (int i = 0; i < rows; i++)
            {
                courseOne[i] = worksheet.Cells[i + 1, 2].DoubleValue;
                datesChisla[i] = worksheet.Cells[i + 1, 0].DoubleValue;
                dateTimes[i] = worksheet.Cells[i + 1, 1].DateTimeValue;
            }
        }
        public void CoutTwo()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\course.xlsx");
            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;
            // Индекс рабочего листа
            int worksheetIndex = 1;
            // Получить рабочий лист, используя его индекс
            Worksheet worksheet = collection[worksheetIndex];
            // Получить количество строк и столбцов
            int rows = worksheet.Cells.MaxDataRow;
            NameOne = worksheet.Cells[1, 3].StringValue;

            
            // Цикл по строкам
            for (int i = 0; i < rows; i++)
            {
                courseTwo[i] = worksheet.Cells[i + 1, 2].DoubleValue;
                datesChisla[i] = worksheet.Cells[i + 1, 0].DoubleValue;
                dateTimes[i] = worksheet.Cells[i + 1, 1].DateTimeValue;
            }
            NameTwo = worksheet.Cells[1, 3].StringValue;
        }

        public string CoutMaxDiffOne()
        {
            double maxDiffN = 0;
            DateTime dateMaxDiffN = dateTimes[0];
            double maxDiffP = 0;
            DateTime dateMaxDiffP = dateTimes[0];

            if (courseOne[0] - courseOne[1] < 0)
            {
                maxDiffN = courseOne[0] - courseOne[1];
                dateMaxDiffN = dateTimes[0];
            }
            else
            {
                maxDiffP = courseOne[0] - courseOne[1];
                dateMaxDiffP = dateTimes[0];
            }

            for (int i = 0; i < dateTimes.Length-1; i++)
            {
                if (courseOne[i] - courseOne[i+1] < 0 && Math.Abs(courseOne[i] - courseOne[i + 1]) > Math.Abs(maxDiffN))
                {
                    maxDiffN = courseOne[i] - courseOne[i + 1];
                    dateMaxDiffN = dateTimes[i];
                }
                if (courseOne[i] - courseOne[i + 1] > 0 && Math.Abs(courseOne[i] - courseOne[i + 1]) > Math.Abs(maxDiffP))
                {
                    maxDiffP = courseOne[i] - courseOne[i + 1];
                    dateMaxDiffP = dateTimes[i];
                }
            }
            string text = "Максимальная прибавка за " + dateMaxDiffP.Date.ToShortDateString() + " число на " + Math.Round(maxDiffP, 5) +
                "\n Потеря за " + dateMaxDiffN.Date.ToShortDateString() + " число на " + Math.Round(maxDiffN, 5);
            return text;
        }
        public string CoutMaxDiffTwo()
        {
            double maxDiffN = 0;
            DateTime dateMaxDiffN = dateTimes[0];
            double maxDiffP = 0;
            DateTime dateMaxDiffP = dateTimes[0];

            if (courseTwo[0] - courseTwo[1] < 0)
            {
                maxDiffN = courseTwo[0] - courseTwo[1];
                dateMaxDiffN = dateTimes[0];
            }
            else
            {
                maxDiffP = courseTwo[0] - courseTwo[1];
                dateMaxDiffP = dateTimes[0];
            }

            for (int i = 0; i < dateTimes.Length - 1; i++)
            {
                if (courseTwo[i] - courseTwo[i + 1] < 0 && Math.Abs(courseTwo[i] - courseTwo[i + 1]) > Math.Abs(maxDiffN))
                {
                    maxDiffN = courseTwo[i] - courseTwo[i + 1];
                    dateMaxDiffN = dateTimes[i];
                }
                if (courseTwo[i] - courseTwo[i + 1] > 0 && Math.Abs(courseTwo[i] - courseTwo[i + 1]) > Math.Abs(maxDiffP))
                {
                    maxDiffP = courseTwo[i] - courseTwo[i + 1];
                    dateMaxDiffP = dateTimes[i];
                }
            }
            string text = "Максимальная прибавка за " + dateMaxDiffP.Date.ToShortDateString() + " число на " + Math.Round(maxDiffP, 5) +
                "\n Потеря за " + dateMaxDiffN.Date.ToShortDateString() + " число на " + Math.Round(maxDiffN, 5);
            return text;
        }
    }
}
