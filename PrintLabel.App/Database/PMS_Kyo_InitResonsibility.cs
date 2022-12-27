using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PrintLabel.App.Extension;
using VBSQLHelper;

namespace PrintLabel.App.Database
{
    public class PMS_Kyo_InitResonsibility
    {
        public bool Add(PMS_Kyo_Init model)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                var query = "INSERT INTO PMS_Kyo_Init(BOARD_NO,PRODUCT_ID,ORDER_NO, UPD_TIME) VALUES(@BOARD_NO,@PRODUCT_ID,@ORDER_NO, @UPD_TIME)";
                var dp = new DynamicParameters();
                dp.Add("@BOARD_NO", model.BOARD_NO);
                dp.Add("@PRODUCT_ID", model.PRODUCT_ID);
                dp.Add("@ORDER_NO", model.ORDER_NO);
                dp.Add("@UPD_TIME", model.UPD_TIME);

                int res = db.Execute(query, dp);

                if (res > 0)
                {
                    return true;
                }
                return false;
            }

        }

        public string AddList(List<PMS_Kyo_Init> models)
        {
            try
            {
                var tableTempale = models.ToDataTable();
                SQLHelper.ExecProcedureNonData($"sp_PMS_Kyo_Init", new { Data = tableTempale });
                //foreach (var model in models)
                //{
                //    var query = "INSERT INTO PMS_Kyo_Init(BOARD_NO,PRODUCT_ID,ORDER_NO, UPD_TIME) VALUES(@BOARD_NO,@PRODUCT_ID,@ORDER_NO, @UPD_TIME)";
                //    var dp = new DynamicParameters();
                //    dp.Add("@BOARD_NO", model.BOARD_NO);
                //    dp.Add("@PRODUCT_ID", model.PRODUCT_ID);
                //    dp.Add("@ORDER_NO", model.ORDER_NO);
                //    dp.Add("@UPD_TIME", model.UPD_TIME);
                //    int res = db.Execute(query, dp);
                //}
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public PMS_Kyo_Init GetBySerial(string boardNo)
        {
            try
            {
                return SQLHelper.ExecQueryDataFistOrDefault<PMS_Kyo_Init>($"SELECT TOP(1) * FROM PMS_Kyo_Init WHERE BOARD_NO ='{boardNo}'");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}
