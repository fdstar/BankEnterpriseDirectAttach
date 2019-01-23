using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询响应主体
    /// </summary>
    public class V1_VATSTMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.6虚拟子账户余额及交易明细查询响应主体
        /// </summary>
        public VATSTMTTRNRS VATSTMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询响应主体
    /// </summary>
    public class VATSTMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.6虚拟子账户余额及交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VATSTMTRS VATSTMTRS { get; set; }
    }
    /// <summary>
    /// 3.6.6虚拟子账户余额及交易明细查询响应内容
    /// </summary>
    public class VATSTMTRS
    {
        /// <summary>
        /// 支付类型：1－虚拟子账户对外支付
        /// </summary>
        [XmlElement(Order = 0)]
        public int VATTYPE { get; set; } = 1;
        /// <summary>
        /// 实体扣款账户
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 虚拟小序号
        /// </summary>
        [XmlElement(Order = 2)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 默认货币代码
        /// </summary>
        [XmlElement(Order = 3)]
        public string CURDEF { get; set; }
        /// <summary>
        /// 付款账户信息
        /// </summary>
        [XmlElement(Order = 4)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 账户交易明细
        /// </summary>
        [XmlElement(Order = 5)]
        public TRANLIST TRANLIST { get; set; }
        /// <summary>
        /// 总账余额， 必回
        /// </summary>
        [XmlElement(Order = 6)]
        public BALANCE LEDGERBAL { get; set; }
        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement(Order = 7)]
        public BALANCE AVAILBAL { get; set; }
    }
}
