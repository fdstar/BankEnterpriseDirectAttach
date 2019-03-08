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
    /// 3.12.4通知转活期请求主体
    /// </summary>
    public class V1_CCCALL2CURRTRNRQ : IRequest<V1_CCCALL2CURRTRNRS>
    {
        /// <summary>
        /// 3.12.4通知转活期请求主体
        /// </summary>
        public CCCALL2CURRTRNRQ CCCALL2CURRTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.12.4通知转活期请求主体
    /// </summary>
    public class CCCALL2CURRTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.12.4通知转活期请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public CCCALL2CURRTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.12.4通知转活期请求内容
    /// </summary>
    public class CCCALL2CURRTRN_RQBODY
    {
        /// <summary>
        /// 通知存款账号，最长32位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 支取金额，decimal(15,2) 即整数位最长13位，小数位2位 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 动作类型(4：预约,6:立即支取)，默认为6(立即支取)
        /// </summary>
        [XmlElement(Order = 2)]
        public int ACTIONTYPE { get; set; } = 6;
    }
}
