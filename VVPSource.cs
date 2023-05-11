using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitt
{
    public class VVPSource
    {
        public double vvp { get; set; }
        public double vnp { get; set; }
        public int years { get; set; }
        public VVPSource() { }
        public VVPSource(double Vvp, double Vnp, int Years)
        {
            vvp = Vvp;
            vnp = Vnp;
            years = Years;
        }
        public List<VVPSource> FillList()
        {
            List<VVPSource> vvp = new List<VVPSource>();
            // Загрузить файл Excel
            Workbook wb = new Workbook("Source\\vvp.xlsx");

            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;


            // Получить рабочий лист, используя его индекс
            Worksheet worksheetOne = collection[0];
            Worksheet worksheetTwo = collection[1];

            // Получить количество строк и столбцов
            int rows1 = worksheetOne.Cells.MaxDataRow;
            // Цикл по строкам
            for (int i = 0; i < rows1 - 1; i++)
            {
                vvp.Add(new VVPSource(
                    worksheetOne.Cells[i + 1, 1].DoubleValue,
                    worksheetTwo.Cells[i + 1, 1].DoubleValue,
                    worksheetOne.Cells[i + 1, 0].IntValue));

            }
            return vvp;

        }
    }
}
