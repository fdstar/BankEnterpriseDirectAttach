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
    /// 3.21.2同步电子回单请求主体
    /// </summary>
    public class V1_ASYNRECEIPTINFOTRNRQ : IRequest<V1_ASYNRECEIPTINFOTRNRS>
    {
        /// <summary>
        /// 3.21.2同步电子回单请求主体
        /// </summary>
        public ASYNRECEIPTINFOTRNRQ ASYNRECEIPTINFOTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.21.2同步电子回单请求主体
    /// </summary>
    public class ASYNRECEIPTINFOTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.21.2同步电子回单请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNRECEIPTINFOTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.21.2同步电子回单请求内容
    /// </summary>
    public class ASYNRECEIPTINFOTRN_RQBODY
    {
        /// <summary>
        /// 查询页数默认为1
        /// </summary>
        [XmlAttribute]
        public int PAGE { get; set; } = 1;
        /// <summary>
        /// 批次号（客户端唯一的交易流水号）	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string CLT_REF_NO { get; set; }
    }
}
