using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLabel.App.Database
{
    public class PMS_Kyo_Model
    {
        public string PRODUCT_ID { get; set; }
        public string GROUP_ID { get; set; }
        public string BARCODE_HEADER { get; set; }
        public string REV_CODE { get; set; }
        public string LATEST_BARCODE { get; set; }
        public string MODIFIED_BY { get; set; }
        public DateTime MODIFIED_AT { get; set; }
        public string ASSY_NO { get; set; }
        public string MAC_START { get; set; }
        public string MAC_END { get; set; }
       
    }
}
