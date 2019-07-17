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
    /// 预付卡备付金其他代付经办响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBFJYP2 : RsBase
    {
        /// <summary>
        /// 成功总笔数 int
        /// </summary>
        [XmlElement("sucTotalNum")]
        public int SucTotalNum { get; set; }
        /// <summary>
        /// 成功总金额decimal(15,2)
        /// </summary>
        [XmlElement("sucTotalAmt")]
        public decimal SucTotalAmt { get; set; }
        /// <summary>
        /// 失败总笔数 int
        /// </summary>
        [XmlElement("errTotalNum")]
        public int ErrTotalNum { get; set; }
        /// <summary>
        /// 失败总金额decimal(15,2)
        /// </summary>
        [XmlElement("errTotalAmt")]
        public decimal ErrTotalAmt { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<PayResult> List { get; set; }
    }
    /// <summary>
    /// 预付卡备付金其他代付
    /// </summary>
    public class PayResult
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
        /// <summary>
        /// 收款账号varchar(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
    }
}
