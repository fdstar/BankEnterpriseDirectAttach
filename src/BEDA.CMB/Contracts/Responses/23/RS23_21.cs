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
    /// 23.21 公司卡中止业务功能（锁卡）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_21 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTLCKSET
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTLCKSET";
        /// <summary>
        /// 23.21 公司卡中止业务功能（锁卡）响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
    }
}
