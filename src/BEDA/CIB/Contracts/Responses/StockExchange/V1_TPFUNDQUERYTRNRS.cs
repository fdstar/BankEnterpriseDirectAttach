using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.5.6第三方存管资金查询响应主体
    /// </summary>
    public class V1_TPFUNDQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.5.6第三方存管资金查询响应主体
        /// </summary>
        public TPFUNDQUERYTRNRS TPFUNDQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.5.6第三方存管资金查询响应主体
    /// </summary>
    public class TPFUNDQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.5.6第三方存管资金查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public TPFUNDQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.5.6第三方存管资金查询响应内容
    /// </summary>
    public class TPFUNDQUERYTRN_RSBODY
    {
        /// <summary>
        /// 账户代号  最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称  最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 资金账户，最长20位
        /// </summary>
        [XmlElement(Order = 2)]
        public string FUNDACCTID { get; set; }
        /// <summary>
        /// 可支取余额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? WDBAL { get; set; }
        /// <summary>
        /// 币种，2位
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 开户券商机构代号，最长8位
        /// </summary>
        [XmlElement(Order = 5)]
        public string BROKER { get; set; }
        /// <summary>
        /// 券商名称，2.0版本回
        /// </summary>
        [XmlElement(Order = 6)]
        public string TRUSTEENAME { get; set; }
        /// <summary>
        /// 账户余额，2.0版本回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal ACCTBALANCE { get; set; }
    }
}
