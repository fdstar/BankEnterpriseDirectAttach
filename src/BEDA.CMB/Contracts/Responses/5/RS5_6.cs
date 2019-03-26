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
    /// 5.6.查询信用证详细信息（单笔，带单据信息）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS5_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// DCLCAXML
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCLCAXML";
        /// <summary>
        /// 5.6.查询信用证详细信息（单笔，带单据信息）响应内容
        /// </summary>
        public Requests.DCLCAXMLY DCLCAXMLY { get; set; }
        /// <summary>
        /// 5.6.查询信用证详细信息（单笔，带单据信息）响应内容 LCALCB=’A’时返回
        /// </summary>
        public NTLCAINFZ1 NTLCAINFZ1 { get; set; }
        /// <summary>
        /// 5.6.查询信用证详细信息（单笔，带单据信息）响应内容 LCALCB=’B’时返回
        /// </summary>
        public NTLCBINFZ1 NTLCBINFZ1 { get; set; }
    }
}
