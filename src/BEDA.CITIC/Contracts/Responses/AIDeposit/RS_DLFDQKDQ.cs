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
    /// 靠档型智能存款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQKDQ : RsBase
    {
        /// <summary>
        /// 账户总余额decimal(15,2)
        /// </summary>
        [XmlElement("accBal")]
        public decimal AccBal { get; set; }
        /// <summary>
        /// 业务部分冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("bsnFrzAmt")]
        public decimal BsnFrzAmt { get; set; }
        /// <summary>
        /// 司法部分冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("lawFrzAmt")]
        public decimal LawFrzAmt { get; set; }
        /// <summary>
        /// 活期留存余额decimal(15,2)
        /// </summary>
        [XmlElement("curAccBal")]
        public decimal CurAccBal { get; set; }
        /// <summary>
        /// 子账户汇总金额decimal(15,2)
        /// </summary>
        [XmlElement("sbsmAmt")]
        public decimal SbsmAmt { get; set; }
        /// <summary>
        /// 冻结标志 char(1) 0：正常；1：部分冻结；2：全部冻结
        /// </summary>
        [XmlElement("xsfzFg")]
        public int XsfzFg { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositDetail> List { get; set; }
    }
}
