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
    /// 21.2.1.网银贷记响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_2_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIBCOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIBCOPR";
        /// <summary>
        /// 21.2.1.网银贷记响应内容 等待时间
        /// </summary>
        public NTOPRDRTZ NTOPRDRTZ { get; set; }
        /// <summary>
        /// 21.2.1.网银贷记响应集合
        /// </summary>
        [XmlElement("NTOPRRTNZ")]
        public List<NTOPRRTNZ> List { get; set; }
    }
    /// <summary>
    /// 21.2.1.网银贷记响应内容 等待时间
    /// </summary>
    public class NTOPRDRTZ
    {
        /// <summary>
        /// 等待时间	N(3)    单位：秒
        /// </summary>
        public int RTNTIM { get; set; }
        /// <summary>
        /// 保留字段 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
