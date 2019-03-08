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
    /// 3.5.7银期互转请求主体
    /// </summary>
    public class V1_BFEEXCHANGETRNRQ : IRequest<V1_BFEEXCHANGETRNRS>
    {
        /// <summary>
        /// 3.5.7银期互转请求主体
        /// </summary>
        public BFEEXCHANGETRNRQ BFEEXCHANGETRNRQ { get; set; }
    }
    /// <summary>
    /// 3.5.7银期互转请求主体
    /// </summary>
    public class BFEEXCHANGETRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.5.7银期互转请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public BFEEXCHANGETRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.5.7银期互转请求内容
    /// </summary>
    public class BFEEXCHANGETRN_RQBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 银行账户密码，最长6位（银转期时，个人客户必输）	有条件必输 
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTPWD { get; set; }
        /// <summary>
        /// 转账类型(0:银转期,1:期转银)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public int TRANSFERTYPE { get; set; }
        /// <summary>
        /// 资金账户，	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string FUNDACCTNO { get; set; }
        /// <summary>
        /// 资金密码	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string FUNDPWD { get; set; }
        /// <summary>
        /// 交易金额，大于0，小数位最多两位	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal TRANSFERAMT { get; set; }
    }
}
