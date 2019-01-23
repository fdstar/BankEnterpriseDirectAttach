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
    /// 3.8.2理财产品赎回/撤销赎回功能请求主体
    /// </summary>
    public class V1_FPREDMTRNRQ : IRequest<V1_FPREDMTRNRS>
    {
        /// <summary>
        /// 3.8.2理财产品赎回/撤销赎回功能请求主体
        /// </summary>
        public FPREDMTRNRQ FPREDMTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.8.2理财产品赎回/撤销赎回功能请求主体
    /// </summary>
    public class FPREDMTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.8.2理财产品赎回/撤销赎回功能请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public FPREDMTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.8.2理财产品赎回/撤销赎回功能请求内容
    /// </summary>
    public class FPREDMTRN_RQBODY
    {
        /// <summary>
        /// 交易种类 0 赎回 1 撤销赎回	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int TRNTYPE { get; set; }
        /// <summary>
        /// 产品代码，8位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 账号代号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 业务受理编号，最长16位 必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCEPTNO { get; set; }
        /// <summary>
        /// 赎回份额，decimal(15,2)，即整数位最长13位，小数位2位	必输，默认值为0.00，赎回时小于等于可用份额。
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal REDMAMT { get; set; }
    }
}
