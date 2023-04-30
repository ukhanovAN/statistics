using Aspose.Cells;
using System;
using System.Collections.Generic;

namespace gitt
{
    internal class SalarySource
    {
            public double MidSalary { get; set; }
            public double DateSalary { get; set; }

            public SalarySource() { }
            public SalarySource(double midSalary, double dateSalary)
            {
                MidSalary = midSalary;
                DateSalary = dateSalary;
            }

            public List<SalarySource> FillList()
            {
                List<SalarySource> Salary = new List<SalarySource>();
                // Загрузить файл Excel
                Workbook wb = new Workbook("Source\\salary.xlsx");

                // Получить все рабочие листы
                WorksheetCollection collection = wb.Worksheets;


                // Получить рабочий лист, используя его индекс
                Worksheet worksheetOne = collection[0];
                //Worksheet worksheetTwo = collection[1];

                // Получить количество строк и столбцов
                int rows = worksheetOne.Cells.MaxDataRow;
                // Цикл по строкам
                for (int i = 0; i < rows+1; i++)
                {
                    Salary.Add(new SalarySource(
                        worksheetOne.Cells[i, 1].DoubleValue,
                        worksheetOne.Cells[i, 0].DoubleValue
                                                )
                               );

                }
                return Salary;
            }
        }
    }