using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.23.1生成批量余额对账指令请求主体
    /// </summary>
    public class V1_BATCHCHECKTRNRQ : IRequest<V1_BATCHCHECKTRNRS>
    {
        /// <summary>
        /// 3.23.1生成批量余额对账指令请求主体
        /// </summary>
        public BATCHCHECKTRNRQ BATCHCHECKTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.23.1生成批量余额对账指令请求主体
    /// </summary>
    public class BATCHCHECKTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.23.1生成批量余额对账指令请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public BATCHCHECKTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.23.1生成批量余额对账指令请求内容
    /// </summary>
    public class BATCHCHECKTRN_RQBODY
    {
        /// <summary>
        /// 格式yyyyMM 必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string RECONCILEDATE { get; set; }
        /// <summary>
        /// 对账账户	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string RECONCILEACCOUNT { get; set; }
    }
}
