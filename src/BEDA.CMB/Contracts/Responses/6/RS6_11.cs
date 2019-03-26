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
    /// 6.11.订单单笔查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQRYORY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQRYORY";
        /// <summary>
        /// 6.11.订单单笔查询响应内容
        /// </summary>
        public NTORDINQZ NTORDINQZ { get; set; }
    }
}
