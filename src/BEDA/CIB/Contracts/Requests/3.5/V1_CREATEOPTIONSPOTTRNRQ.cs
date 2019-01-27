using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.5.10期权现货互转请求主体
    /// </summary>
    public class V1_CREATEOPTIONSPOTTRNRQ : IRequest<V1_CREATEOPTIONSPOTTRNRS>
    {
        /// <summary>
        /// 3.5.10期权现货互转请求主体
        /// </summary>
        public CREATEOPTIONSPOTTRNRQ CREATEOPTIONSPOTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.10期权现货互转请求主体
    /// </summary>
    public class CREATEOPTIONSPOTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.10期权现货互转请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CREATEOPTIONSPOTTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.10期权现货互转请求内容
    /// </summary>
    public class CREATEOPTIONSPOTTRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 转账类型(0:银转期,1:期转银)	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public int TRANSFERTYPE { get; set; }
        /// <summary>
        /// 资金账户，	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 交易金额，大于0，小数位最多两位	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal TRANSFERAMT { get; set; }
    }
}
