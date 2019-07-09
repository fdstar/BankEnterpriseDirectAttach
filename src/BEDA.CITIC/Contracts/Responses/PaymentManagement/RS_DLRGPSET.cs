using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 收款单位分组设置响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLRGPSET : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PayeeGroupSettingResult> List { get; set; }
    }
    /// <summary>
    /// 收款单位分组前
    /// </summary>
    public class PayeeGroupSettingResult: Requests.PayeeGroupSetting
    {
        /// <summary>
        /// 交易状态 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 交易状态信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}
