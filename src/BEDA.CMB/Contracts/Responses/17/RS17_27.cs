using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 17.27.删除公司卡关联付款方信息请求报文说明响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_27 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMDRDD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRDD";
    }
}
