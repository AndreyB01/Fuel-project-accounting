using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_project_accounting.PutList
{
    public class ExcelEx
    {
        public void ExcelExpotr(DataGridView grid)
        {
            if (grid == null || grid.Rows.Count <= 0)
            {
                MessageBox.Show("Данные для экспорта не обнаружены.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Microsoft.Office.Interop.Excel.Application exel = new Microsoft.Office.Interop.Excel.Application();
                exel.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i<grid.Columns.Count + 1; i++)
                {
                    exel.Cells[1,i]= grid.Columns[i - 1].HeaderText;
                }
                for(int i=0; i<grid.Rows.Count;i++)
                {
                    for(int j=0; j<grid.Columns.Count;j++)
                    {
                        exel.Cells[i+2,j+1] = grid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                exel.Columns.AutoFit();
                exel.Visible = true;
                exel = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при экспорте: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



    }
}
