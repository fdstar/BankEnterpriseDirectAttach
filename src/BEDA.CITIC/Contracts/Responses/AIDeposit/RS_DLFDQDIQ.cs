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
    /// 靠档型智能存款利息凭证信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQDIQ : RsBase
    {
        /// <summary>
        /// 账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 账户名称char(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositInterestVoucher> List { get; set; }
    }
}
