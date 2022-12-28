using Microsoft.Win32;
using PrintLabel.App._6THA3SOEMMain;
using PrintLabel.App.Database;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PrintLabel.App
{
    public static class Ultils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public static void Write(string path, string content)
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(content);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="line_del"></param>
        public static void RemoveLine(string path, string line_del)
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(path))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != line_del)
                        sw.WriteLine(line);
                }
            }
            File.Delete(path);
            File.Move(tempFile, path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        public static void CreateFolder(string path, string fileName)
        {
            bool exists = Directory.Exists(path);
            if (!exists)
            {
                Directory.CreateDirectory(path);
                string fullPath = $@"{path}\{fileName}.txt";
                if (!File.Exists(fileName))
                    File.Create(fullPath).Dispose();
            }
            else
            {
                string fullPath = $@"{path}\{fileName}.txt";
                if (!File.Exists(fileName))
                    File.Create(fullPath).Dispose();
            }
        }

        public static List<string> ReadAllLines(string path, Encoding encoding)
        {
            List<string> lines = new List<string>();
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lines.Add(line);
                    }
                    reader.Close();

                }
            }
            catch
            {


            }

            return lines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="encoding"></param>
        /// <param name="newline"></param>
        /// <returns></returns>
        public static string ReadLastLine(string path, Encoding encoding, string newline)
        {
            string line = null;
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (reader.Peek() == -1)
                    {
                        return line;
                    }
                }
                reader.Close();
            }
            return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int CountLine(string path)
        {
            int count = 0;
            using (var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(file))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
                reader.Close();
                return count;
            }
        }
        public static string GetLine(string path, int line)
        {
            string value;
            using (var sr = new StreamReader(path))
            {
                for (int i = 1; i < line; i++)
                {
                    sr.ReadLine();
                }
                value = sr.ReadLine();
                sr.Dispose();
                return value;
            }
        }

        public static string SaveToDb(DataGridView gridIn, string orderNo)
        {
            var kyoResponsitory = new PMS_Kyo_InitResponsibility();
            var kyoModelResponsitory = new PMS_Kyo_ModelResponsibility();
            if (gridIn.RowCount > 0)
            {
                DataGridViewRow dr = new DataGridViewRow();
                var list = new List<PMS_Kyo_Init>();
                for (int j = 0; j < gridIn.Rows.Count; j++)
                {
                    dr = gridIn.Rows[j];
                    var createTime = DateTime.Now;
                    list.Add(new PMS_Kyo_Init()
                    {
                        PRODUCT_ID = dr.Cells[0].Value.ToString(),
                        ORDER_NO = orderNo,
                        BOARD_NO = dr.Cells[2].Value.ToString(),
                        UPD_TIME = createTime,
                        CREATE_AT = createTime,
                        ASSY_NO = dr.Cells[1].Value.ToString()
                    });
                }

                var result = kyoResponsitory.AddList(list);
                if (result == "OK")
                {
                    var lastBarcode = list[gridIn.Rows.Count - 1];
                    result = kyoModelResponsitory.UpdateLastBarcode(new PMS_Kyo_Model()
                    {
                        PRODUCT_ID = lastBarcode.PRODUCT_ID,
                        LATEST_BARCODE = lastBarcode.BOARD_NO
                    });
                }
                return result;

            }
            return "OK";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gridIn"></param>
        /// <param name="outputFile"></param>
        public static void WriteCSV(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile, true, Encoding.ASCII);

                ////write header rows to csv
                //for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                //{
                //    if (i > 0)
                //    {
                //        swOut.Write(",");
                //    }
                //    swOut.Write(gridIn.Columns[i].HeaderText);
                //}

                //swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");
                        swOut.Write(value);
                    }
                }
                swOut.WriteLine();
                swOut.Close();
            }
        }

        public static void WriteAppendCSV(DataGridView gridIn, bool append, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                // FileMode.Create => ghi đè
                // FileMode.Append => ghi tiếp dòng tiếp theo
                using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (StreamWriter swOut = new StreamWriter(fs))
                {
                    //write DataGridView rows to csv
                    for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            swOut.WriteLine();
                        }

                        dr = gridIn.Rows[j];

                        for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                swOut.Write(",");
                            }

                            value = dr.Cells[i].Value.ToString();
                            //replace comma's with spaces
                            value = value.Replace(',', ' ');
                            //replace embedded newlines with spaces
                            value = value.Replace(Environment.NewLine, " ");
                            swOut.Write(value);
                        }
                    }
                    swOut.WriteLine();
                    swOut.Close();
                }
            }
        }
        public static void WriteTxtFromDataGridView(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile, false, Encoding.ASCII);
                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }
                    dr = gridIn.Rows[j];
                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");
                        swOut.Write(value);
                    }
                }
                swOut.WriteLine();
                swOut.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="content"></param>
        public static void WriteRegistry(string rootKey, string keyName, string content)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey($@"SOFTWARE\{rootKey}");
            if (!string.IsNullOrEmpty(keyName) && !string.IsNullOrEmpty(content))
            {
                key.SetValue(keyName, content);
                key.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="content"></param>
        public static void WriteRegistryArray(string rootKey, string keyName, string content)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey($@"SOFTWARE\{rootKey}");
            if (!string.IsNullOrEmpty(keyName) && !string.IsNullOrEmpty(content))
            {
                string exitsValue = GetValueRegistryKey(rootKey, keyName);
                if (exitsValue != null)
                {
                    exitsValue += content + ";";
                    key.SetValue(keyName, exitsValue);
                }
                else
                {
                    key.SetValue(keyName, content + ";");
                }
                key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string GetValueRegistryKey(string rootKey, string keyName)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey($@"SOFTWARE\{rootKey}");
            string value = null;
            if (key != null)
            {
                if (key.GetValue(keyName) != null)
                {
                    value = key.GetValue(keyName).ToString();
                    key.Close();
                    return value;
                }
            }

            return null;
        }

        public static List<OEMMains> MakeSerial(PMS_Kyo_Model entity, string startNo, double qty, Dictionary<string, int> dic, string month, string year)
        {
            List<OEMMains> result = new List<OEMMains>();
            int start = Convert.ToInt32($"{dic[startNo.Left(1)]}{startNo.Right(4)}");
            var special = entity.PRODUCT_ID.LeftOf('-').Right(1);
            for (int i = 0; i < qty; i++)
            {
                //string symbol = startNo.Left(1);
                //var key = dic[symbol];
                var a = start.ToString().Left(2);
                string symbol = dic.FirstOrDefault(x => x.Value.ToString() == a).Key;
                //if (start.ToString().Right(4) == "0000")
                //{
                //    qty++;
                //    continue;
                //}
                result.Add(new OEMMains()
                {
                    model = entity.PRODUCT_ID,
                    assyNo = "ASSY No. " + entity.ASSY_NO,
                    barcode = $"{entity.REV_CODE}1{special}{year}{month}{symbol}{start.ToString().Right(4)}",
                    comment = $"{entity.PRODUCT_ID.Substring(2, 7)}"
                });
                start++;
            }
            return result;
        }
        public static string GetNumberStart(string startNo, Dictionary<string, int> dic)
        {
            int start = Convert.ToInt32($"{dic[startNo.Left(1)]}{startNo.Right(4)}");
            start++;
            var head = start.ToString().Left(2);
            string symbol = dic.FirstOrDefault(x => x.Value.ToString() == head).Key;
            return $"{ symbol}{start.ToString().Right(4)}";
        }
    }
}
