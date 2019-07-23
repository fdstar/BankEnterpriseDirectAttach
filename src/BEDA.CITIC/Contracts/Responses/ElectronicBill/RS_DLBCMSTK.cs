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
    /// 票据状态同步响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMSTK : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillStatus> List { get; set; }
    }
    /// <summary>
    /// 票据状态
    /// </summary>
    public class BillStatus
    {
        /// <summary>
        /// 票据交易状态 char(3) 见附录4.1.7
        /// </summary>
        [XmlElement("TRASTAT")]
        public string TRASTAT { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)，出票登记时返回
        /// </summary>
        [XmlElement("BILLNO")]
        public string BILLNO { get; set; }
        /// <summary>
        /// 票据状态char(6) 可空 见附录4.1.8
        /// </summary>
        [XmlElement("BILSTAT")]
        public string BILSTAT { get; set; }
        /// <summary>
        /// 制单状态标志 char(1) 0 成功 1 失败 2未知 3审核拒绝 4 用户撤销
        /// </summary>
        [XmlElement("STT")]
        public int STT { get; set; }
        /// <summary>
        /// 处理码char(7)，可空
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 返回的处理信息varchar(254)，可空
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
    }
}