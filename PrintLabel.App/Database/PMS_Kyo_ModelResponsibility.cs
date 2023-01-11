using PrintLabel.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBSQLHelper;

namespace PrintLabel.App.Database
{
    public class PMS_Kyo_ModelResponsibility
    {
        public string Delete(string model)
        {
            try
            {
                SQLHelper.ExecQueryNonData($"DELETE FROM PMS_Kyo_Model WHERE PRODUCT_ID = '{model}'");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string SaveToDb(PMS_Kyo_Model model)
        {
            try
            {
                var isExist = SQLHelper.ExecQueryDataFistOrDefault<PMS_Kyo_Model>($"SELECT TOP(1) * FROM PMS_Kyo_Model WHERE PRODUCT_ID = '{model.PRODUCT_ID}'");
                if (isExist != null) return "Đã thêm model này rồi";
                string sql = $"INSERT INTO PMS_Kyo_Model(PRODUCT_ID,GROUP_ID,REV_CODE,MODIFIED_BY,MODIFIED_AT,ASSY_NO,MAC_START,MAC_END)" +
                    $"VALUES('{model.PRODUCT_ID}','{model.GROUP_ID}','{model.REV_CODE}','{model.MODIFIED_BY}','{DateTime.Now.ToString("yyyy-MM-dd")}','{model.ASSY_NO}'," +
                    $"'{model.MAC_START}','{model.MAC_END}')";
                SQLHelper.ExecQueryNonData(sql);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public List<PMS_Kyo_Model> GetListModel(string GroupId)
        {
            try
            {
                return (List<PMS_Kyo_Model>)SQLHelper.ExecQueryData<PMS_Kyo_Model>($"SELECT * FROM PMS_Kyo_Model WHERE GROUP_ID ='{GroupId}'");
            }
            catch (Exception ex)
            {
                return new List<PMS_Kyo_Model>();
            }
        }

        public string UpdateAllModel(List<PMS_Kyo_Model> list)
        {
            try
            {
                foreach(var  model in list)
                {
                    SQLHelper.ExecQueryNonData($"UPDATE PMS_Kyo_Model SET ASSY_NO = '{model.ASSY_NO}', REV_CODE = '{model.REV_CODE}' WHERE PRODUCT_ID = '{model.PRODUCT_ID}'");
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string UpdateLastBarcode(PMS_Kyo_Model model)
        {
            try
            {
                if (model.GROUP_ID == GROUP_ID.OEM)
                {
                    SQLHelper.ExecQueryNonData($"UPDATE PMS_Kyo_Model SET LATEST_BARCODE = '{model.LATEST_BARCODE}' WHERE PRODUCT_ID = '{model.PRODUCT_ID}'");
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public PMS_Kyo_Model GetModel(string productId)
        {
            try
            {
                return (PMS_Kyo_Model)SQLHelper.ExecQueryDataFistOrDefault<PMS_Kyo_Model>($"SELECT * FROM PMS_Kyo_Model WHERE PRODUCT_ID ='{productId}'");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
