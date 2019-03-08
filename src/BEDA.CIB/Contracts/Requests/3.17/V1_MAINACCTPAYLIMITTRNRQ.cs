using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询请求主体
    /// </summary>
    public class V1_MAINACCTPAYLIMITTRNRQ : IRequest<V1_MAINACCTPAYLIMITTRNRS>
    {
        /// <summary>
        /// 3.17.5虚拟资金池主账户支付额度查询请求主体
        /// </summary>
        public MAINACCTPAYLIMITTRNRQ MAINACCTPAYLIMITTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询请求主体
    /// </summary>
    public class MAINACCTPAYLIMITTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.17.5虚拟资金池主账户支付额度查询请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAINACCTPAYLIMITTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.17.5虚拟资金池主账户支付额度查询请求内容
    /// </summary>
    public class MAINACCTPAYLIMITTRN_RQBODY
    {
        /// <summary>
        /// 主账户	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 拟支付金额	非必输
        /// </summary>
        [XmlIgnore]
        public decimal? PLANMONEY { get; set; }
        /// <summary>
        /// 拟支付金额 对应<see cref="PLANMONEY"/> 非必输
        /// </summary>
        [XmlElement("PLANMONEY", Order = 1)]
        public string PLANMONEYStr
        {
            get
            {
                return this.PLANMONEY?.ToString();
            }
            set
            {
                this.PLANMONEY = value.TryConvert<decimal>();
            }
        }
    }
}
