using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace gitt
{
    internal class ClassOfSourceCourse
    {
        public double PriceOne {get;set;}
        public double PriceTwo { get;set;}
        public DateTime DateCource { get;set;}

        public ClassOfSourceCourse () { }
        public ClassOfSourceCourse (double priceOne, double priceTwo, DateTime dateCource)
        {
            PriceOne = priceOne;
            PriceTwo = priceTwo;
            DateCource = dateCource;
        }

        public List<ClassOfSourceCourse> FillList ()
        {
            List<ClassOfSourceCourse> Courses = new List<ClassOfSourceCourse>();
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\course.xlsx");

            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;

            
            // Получить рабочий лист, используя его индекс
            Worksheet worksheetOne = collection[0];
            Worksheet worksheetTwo = collection[1];
            // Получить количество строк и столбцов
            int rows = worksheetOne.Cells.MaxDataRow;            
            // Цикл по строкам
            for (int i = 0; i < rows; i++)
            {
                Courses.Add(new ClassOfSourceCourse
                    (
                    worksheetOne.Cells[i + 1, 2].DoubleValue, 
                    worksheetTwo.Cells[i + 1, 2].DoubleValue, 
                    worksheetOne.Cells[i + 1, 1].DateTimeValue
                    ));
                
            }
            return Courses;
        }
    }
}
