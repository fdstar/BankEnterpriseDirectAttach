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
    /// 现金管理积数查询（当期）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMCFINCA : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CashProduct> List { get; set; }
    }
    /// <summary>
    /// 现金管理积数（当期）
    /// </summary>
    public class CashProduct
    {
        /// <summary>
        /// 响应码 char(7)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
        /// <summary>
        /// 响应信息 varchar(254)
        /// </summary>
        [XmlElement("statusText")]
        public string StatusText { get; set; }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 本期归集利率decimal(9,7)
        /// </summary>
        public decimal XSGJLL { get; set; }
        /// <summary>
        /// 本期归集积数decimal(20,0)
        /// </summary>
        public decimal XSGJJS { get; set; }
        /// <summary>
        /// 本期归集应收利息decimal(15,2)
        /// </summary>
        public decimal XSGJLX { get; set; }
        /// <summary>
        /// 本期超归集下拨占用利率decimal(9,7)
        /// </summary>
        public decimal XSCGLL { get; set; }
        /// <summary>
        /// 本期超归集下拨占用积数decimal(20,0)
        /// </summary>
        public decimal XSCGJS { get; set; }
        /// <summary>
        /// 本期超归集下拨应付利息decimal(15,2)
        /// </summary>
        public decimal XSCGLX { get; set; }
        /// <summary>
        /// 本期日终填平占用利率decimal(9,7)
        /// </summary>
        public decimal XSTZLL { get; set; }
        /// <summary>
        /// 本期日终填平占用积数decimal(20,0)
        /// </summary>
        public decimal XSTZJS { get; set; }
        /// <summary>
        /// 本期日终填平占用应付利息decimal(15,2)
        /// </summary>
        public decimal XSTZLX { get; set; }
        /// <summary>
        /// 本期日终填平上存利率decimal(9,7)
        /// </summary>
        public decimal XSTCLL { get; set; }
        /// <summary>
        /// 本期日终填平上存积数decimal(20,0)
        /// </summary>
        public decimal XSTCJS { get; set; }
        /// <summary>
        /// 本期日终填平上存应收利息decimal(15,2)
        /// </summary>
        public decimal XSTCLX { get; set; }
    }
}
