using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.4.6.支付机构上传汇款业务项下支出明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_4_6 : RQ12_3_2
    {
    }
}
