using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询响应主体
    /// </summary>
    public class V1_MAINACCTPAYLIMITTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.5虚拟资金池主账户支付额度查询响应主体
        /// </summary>
        public MAINACCTPAYLIMITTRNRS MAINACCTPAYLIMITTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询响应主体
    /// </summary>
    public class MAINACCTPAYLIMITTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.5虚拟资金池主账户支付额度查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAINACCTPAYLIMITTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询响应内容
    /// </summary>
    public class MAINACCTPAYLIMITTRN_RSBODY
    {
        /// <summary>
        /// 主账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 主账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 主账户余额
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal MAINBALANCE { get; set; }
        /// <summary>
        /// 主账号可用余额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal AVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 账户透支合同编号
        /// </summary>
        [XmlElement(Order = 4)]
        public string MAINCONTRACTNO { get; set; }
        /// <summary>
        /// 透支合同额度
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal OVERDRAWCONTRACTQUOTA { get; set; }
        /// <summary>
        /// 非虚拟池担保额度
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal SECUREQUOTA { get; set; }
        /// <summary>
        /// 虚拟池担保额度
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal VENTUREQUOTA { get; set; }
        /// <summary>
        /// 已落实担保额度
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal PRACTQUOTA { get; set; }
        /// <summary>
        /// 成员贡献系数,大于等于0，小于等于1，小数精度为2 
        /// （其中已入虚拟池担保额度： 0 说明：为签约虚拟池保证金与定期账户余额之和* 安全系数）
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal CTRBTFACTOR { get; set; }
        /// <summary>
        /// 已透支金额
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal OVERDRAWAMOUNT { get; set; }
        /// <summary>
        /// 可透支额度
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal OVERDRAFTQUOTA { get; set; }
        /// <summary>
        /// 拟支付金额
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal PLANMONEY { get; set; }
        /// <summary>
        /// 活期需转保证金金额
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal DEMANDTOBAILMONEY { get; set; }
        /// <summary>
        /// 保证金最高可释放金额
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal MAXDEMANDMONEY { get; set; }
    }
}
