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
    /// 现金池可用资金查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMPLACQY : RsBase
    {
        /// <summary>
        /// 成员单位实际总余额 decimal(15,2)
        /// </summary>
        public decimal ACBL { get; set; }
        /// <summary>
        /// 成员单位冻结总金额 decimal(15,2)
        /// </summary>
        public decimal FZAM { get; set; }
        /// <summary>
        /// 成员单位应付未付总金额 decimal(15,2)
        /// </summary>
        public decimal YFAM { get; set; }
        /// <summary>
        /// 池看管额度 decimal(15,2)
        /// </summary>
        public decimal KGED { get; set; }
        /// <summary>
        /// 池法人透支可用额度 decimal(15,2)
        /// </summary>
        public decimal TZKD { get; set; }
        /// <summary>
        /// 池法人透支可用余额 decimal(15,2)
        /// </summary>
        public decimal TZBL { get; set; }
        /// <summary>
        /// 池成员单位自身法人透支可用额度 decimal(15,2)
        /// </summary>
        public decimal ZTKD { get; set; }
        /// <summary>
        /// 池主成员单位自身可用余额 decimal(15,2)，现金池中所有主成员单位的可用余额的总和
        /// </summary>
        public decimal MMBL { get; set; }
        /// <summary>
        /// 池可用余额 decimal(15,2)
        /// </summary>
        public decimal KYBL { get; set; }
        /// <summary>
        /// 池可用资金 decimal(15,2)
        /// </summary>
        public decimal ZJBL { get; set; }
    }
}
