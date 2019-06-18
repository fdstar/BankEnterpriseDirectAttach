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
    /// 不归集额度查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCMGSBQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NoCollectionQuota> List { get; set; }
    }
    /// <summary>
    /// 不归集额度
    /// </summary>
    public class NoCollectionQuota
    {
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 不归集金额 decimal(15,2)
        /// </summary>
        [XmlElement("noCollAmt")]
        public decimal NoCollAmt { get; set; }
        /// <summary>
        /// 不归集金额启用标志 char(1) 0：未启用；1：已启用
        /// </summary>
        [XmlElement("noCollAmtFlg")]
        public int NoCollAmtFlg { get; set; }
    }
}
