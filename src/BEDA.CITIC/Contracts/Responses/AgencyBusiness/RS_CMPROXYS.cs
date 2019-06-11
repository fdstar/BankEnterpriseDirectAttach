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
    /// 现金管理代理收款信息上传（推送账单）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMPROXYS : RsBase
    {
        /// <summary>
        /// 成功总笔数 int
        /// </summary>
        [XmlElement("succCount")]
        public int SuccCount { get; set; }
        /// <summary>
        /// 成功总金额decimal(15,2)
        /// </summary>
        [XmlElement("succAmt")]
        public decimal SuccAmt { get; set; }
        /// <summary>
        /// 失败总笔数 int
        /// </summary>
        [XmlElement("failCount")]
        public int FailCount { get; set; }
        /// <summary>
        /// 失败总金额decimal(15,2)
        /// </summary>
        [XmlElement("failAmt")]
        public decimal FailAmt { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<TransResult> List { get; set; }
    }
}
