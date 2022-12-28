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
        public List<PMS_Kyo_Model> GetListModel(string GroupId)
        {
            try
            {
                return (List<PMS_Kyo_Model>) SQLHelper.ExecQueryData<PMS_Kyo_Model>($"SELECT * FROM PMS_Kyo_Model WHERE GROUP_ID ='{GroupId}'");
            }
            catch (Exception ex)
            {
                return new List<PMS_Kyo_Model>();
            }
        }
        public string UpdateLastBarcode(PMS_Kyo_Model model)
        {
            try
            {
                SQLHelper.ExecQueryNonData($"UPDATE PMS_Kyo_Model SET LATEST_BARCODE = '{model.LATEST_BARCODE}' WHERE PRODUCT_ID = '{model.PRODUCT_ID}'");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public PMS_Kyo_Model GetModel(string productId) {
            try
            {
                return  (PMS_Kyo_Model)SQLHelper.ExecQueryDataFistOrDefault<PMS_Kyo_Model>($"SELECT * FROM PMS_Kyo_Model WHERE PRODUCT_ID ='{productId}'");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
