using System.Data;
using System.Text;
using ExcelDataReader;

namespace ReadExcel;

public class ExcelReader
{
    public void Run()
    {
        string excelFilePath = "data.xlsx";
        using (var stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            IExcelDataReader reader = null;
            if (excelFilePath.EndsWith(".xls"))
            {
                reader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else if (excelFilePath.EndsWith(".xlsx"))
            {
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            if (reader == null)
                throw new Exception("could not read excel-file");

            var ds = reader.AsDataSet();
            
            int row_no = 1;
            DataRowCollection rows = ds.Tables[0].Rows;
            while (row_no < rows.Count)
            {
                DataRow aRow = rows[row_no];
                //dato in idx 0
                string dato = aRow[0].ToString();
                
                // timer in idx 2
                string timer = aRow[2].ToString();
                int timerAsInt = int.Parse(timer);
                

                Console.WriteLine($"{row_no}: {dato}, {timerAsInt}");
                row_no++;
            }
            
        }
    }
}