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
    /// 成员单位利息分配经办查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPPDQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<UnitInterestShare> List { get; set; }
    }
    /// <summary>
    /// 成员单位利息分配经办
    /// </summary>
    public class UnitInterestShare : UnitInterest
    {
        /// <summary>
        /// 已付利息 decimal(15,2)
        /// </summary>
        [XmlElement("payedAmt")]
        public decimal PayedAmt { get; set; }
        /// <summary>
        /// 已收利息 decimal(15,2)
        /// </summary>
        [XmlElement("rcvedAmt")]
        public decimal RcvedAmt { get; set; }
    }
}
