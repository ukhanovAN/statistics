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
            int cols = worksheet.Cells.MaxDataColumn;
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
            int cols = worksheet.Cells.MaxDataColumn;
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
    }
}
