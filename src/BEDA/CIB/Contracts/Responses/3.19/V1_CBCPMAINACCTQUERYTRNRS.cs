using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.8跨境资金池国内主账户信息查询响应主体
    /// </summary>
    public class V1_CBCPMAINACCTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.8跨境资金池国内主账户信息查询响应主体
        /// </summary>
        public CBCPMAINACCTQUERYTRNRS CBCPMAINACCTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.8跨境资金池国内主账户信息查询响应主体
    /// </summary>
    public class CBCPMAINACCTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.8跨境资金池国内主账户信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMAINACCTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.8跨境资金池国内主账户信息查询响应内容
    /// </summary>
    public class CBCPMAINACCTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 主办企业客户号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string NCID { get; set; }
        /// <summary>
        /// 货币种类	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 开户行	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 国内主账户账号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string HOMEACCTNO { get; set; }
        /// <summary>
        /// 国内主账户外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal HOMEBALANCE { get; set; }
        /// <summary>
        /// 国内主账户成员企业个数	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public int HOMMEMBERNUM { get; set; }
        /// <summary>
        /// 国际主账户账号	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string INTLACCTNO { get; set; }
        /// <summary>
        /// 国际主账户外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal INTLBALANCE { get; set; }
        /// <summary>
        /// 国际主账户成员企业个数	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public int INTLMEMBERNUM { get; set; }
        /// <summary>
        /// 经常项目外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal FREQUENTITEMBALANCE { get; set; }
        /// <summary>
        /// 资本项目外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal CAPITALITEMBALANCE { get; set; }
        /// <summary>
        /// 外债余额	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal DEBTBALANCE { get; set; }
        /// <summary>
        /// 对外放款余额	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal LOANBALANCE { get; set; }
        /// <summary>
        /// 资本金余额	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal CAPITALBALANCE { get; set; }
        /// <summary>
        /// 资产变现余额	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal REALIZATIONBALANCE { get; set; }
        /// <summary>
        /// 再投资余额	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal REINVESTBALANCE { get; set; }
        /// <summary>
        /// 可流入外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal INCOMEBALANCE { get; set; }
        /// <summary>
        /// 可流出外汇资金余额	必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal OUTGOBALANCE { get; set; }
    }
}
