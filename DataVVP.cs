using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitt
{
    class DataVVP
    {
        public string NameOne { get; set; }
        public string NameTwo { get; set; }

        public double[] vvp = new double[15];
        public double[] vnp = new double[15];
        public double[] years = new double[15];
        public double[] percentVVP = new double[15];
        public double[] percentVNP = new double[15];

        public void InputVVP()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\vvp.xlsx");
            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;
            // Индекс рабочего листа
            int worksheetIndex = 0;
            // Получить рабочий лист, используя его индекс
            Worksheet worksheet = collection[worksheetIndex];
            NameOne = worksheet.Name;
            // Цикл по строкам
            for (int i = 0; i < 15; i++)
            {
                vvp[i] = worksheet.Cells[i + 1, 1].DoubleValue;
                years[i] = worksheet.Cells[i + 1, 0].DoubleValue;
            }
        }
        public void InputVNP()
        {
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\vvp.xlsx");
            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;
            // Индекс рабочего листа
            int worksheetIndex = 1;
            // Получить рабочий лист, используя его индекс
            Worksheet worksheet = collection[worksheetIndex];
            NameTwo = worksheet.Name;
            // Цикл по строкам
            for (int i = 0; i < 15; i++)
            {
                vnp[i] = worksheet.Cells[i + 1, 1].DoubleValue;
                years[i] = worksheet.Cells[i + 1, 0].DoubleValue;
            }
        }

        public string PercentVVP()
        {
            percentVVP[0] = 0;
            for (int i = 1; i < 15; i++)
            {
                percentVVP[i] = (vvp[i] * 100 / vvp[i - 1]) - 100;
            }
            string text = "";
            for (int i = 0; i < 15; i++)
            {
                text += "  " + years[i].ToString() + ": " + Math.Round(percentVVP[i], 2).ToString() + "\n";
            }
            return text;
        }

        public string PercentVNP()
        {
            percentVNP[0] = 1;
            for (int i = 1; i < 15; i++)
            {
                percentVNP[i] = (vnp[i] * 100 / vnp[i - 1]) - 100;
            }
            string text = "";
            for (int i = 0; i < 15; i++)
            {
                text += "  " + years[i].ToString() + ": " + Math.Round(percentVNP[i], 2).ToString() + "\n";
                //text += years[i].ToString() + ": " + vnp[i].ToString() + "\n";
            }
            return text;
        }

    }
}
