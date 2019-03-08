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
    /// 3.23.2查询批量余额对账指令请求主体
    /// </summary>
    public class V1_BATCHCHECKQUERYTRNRQ : IRequest<V1_BATCHCHECKQUERYTRNRS>
    {
        /// <summary>
        /// 3.23.2查询批量余额对账指令请求主体
        /// </summary>
        public BATCHCHECKQUERYTRNRQ BATCHCHECKQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.23.2查询批量余额对账指令请求主体
    /// </summary>
    public class BATCHCHECKQUERYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.23.2查询批量余额对账指令请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public BATCHCHECKQUERYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.23.2查询批量余额对账指令请求内容
    /// </summary>
    public class BATCHCHECKQUERYTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 生成批处理指令(原指令)时候的TRUNID	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLT_REF_NO { get; set; }
    }
}
