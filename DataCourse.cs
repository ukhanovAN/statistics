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


        List <double > courseOne = new List <double> ();
        List<double> courseTwo = new List<double>();
        List<DateTime> dateTimes = new List<DateTime> ();

        public void ListsData()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source//курс.xlsx");

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
                courseOne.Add(worksheet.Cells[i, 2].DoubleValue);
                dateTimes.Add(worksheet.Cells[i, 1].DateTimeValue);
            }
            // Индекс рабочего листа
            worksheetIndex ++;
            worksheet = collection[worksheetIndex];
            // Получить количество строк и столбцов
            rows = worksheet.Cells.MaxDataRow;
            cols = worksheet.Cells.MaxDataColumn;
            NameTwo = worksheet.Cells[1, 3].StringValue;
            // Цикл по строкам
            for (int i = 0; i < rows; i++)
            {
                courseTwo.Add(worksheet.Cells[i, 2].DoubleValue);
            }

        }

    }
}
