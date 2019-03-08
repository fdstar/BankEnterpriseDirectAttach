using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.1.3贵金属交易资金查询响应主体
    /// </summary>
    public class V1_PMFUNDQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.3贵金属交易资金查询响应主体
        /// </summary>
        public PMFUNDQUERYTRNRS PMFUNDQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.3贵金属交易资金查询响应主体
    /// </summary>
    public class PMFUNDQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.3贵金属交易资金查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMFUNDQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.3贵金属交易资金查询响应内容
    /// </summary>
    public class PMFUNDQUERYTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// 客户名称，最长50位	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 客户类别，1位	必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string CUSTTYPE { get; set; }

        /// <summary>
        /// 可提资金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal PICKFUND { get; set; }
        /// <summary>
        /// 可用资金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal AVBLFUND { get; set; }
        /// <summary>
        /// 冻结资金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal FRZFUND { get; set; }
        /// <summary>
        /// 持仓保证金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal HOLDMARGIN { get; set; }
        /// <summary>
        /// 提货保证金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal PICKMARGIN { get; set; }
        /// <summary>
        /// 仓储费保证金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal STRGMARGIN { get; set; }
        /// <summary>
        /// 基础保证金，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal BASEMARGIN { get; set; }
        /// <summary>
        /// 浮动盈亏，decimal(15,2) 即整数位最长13位，小数位2位 必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal PAL { get; set; }
    }
}
