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
    /// 1.9.查询历史通知（新）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS1_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetHisNoticeEX
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetHisNoticeEX";
        /// <summary>
        /// 1.9.查询历史通知（新）响应集合
        /// </summary>
        [XmlElement("DCHISMSGZ")]
        public List<DCHISMSGZ> List { get; set; }
        /// <summary>
        /// NCBCHOPR	批量支付经办结果通知 集合
        /// </summary>
        [XmlElement("NCBCHOPRY")]
        public List<NCBCHOPRY> NCBCHOPRList { get; set; }
        /// <summary>
        /// NCCRTTRS 到帐通知 集合
        /// </summary>
        [XmlElement("NCCRTTRSY")]
        public List<NCCRTTRSY> NCCRTTRSList { get; set; }
        /// <summary>
        /// NCDBTTRS 付款通知
        /// </summary>
        [XmlElement("NCDBTTRSY")]
        public List<NCDBTTRSY> NCDBTTRSList { get; set; }
        /// <summary>
        /// NCDRTPAY 直接支付结果通知 集合
        /// </summary>
        [XmlElement("NCDRTPAYY")]
        public List<NCDRTPAYY> NCDRTPAYList { get; set; }
        /// <summary>
        /// NCBUSFIN 业务完成通知 集合
        /// </summary>
        [XmlElement("NCBUSFINY")]
        public List<NCBUSFINY> NCBUSFINList { get; set; }
    }
    /// <summary>
    /// 1.9.查询历史通知（新）响应内容
    /// </summary>
    public class DCHISMSGZ : FBDLRHMGZ
    {
    }
}
