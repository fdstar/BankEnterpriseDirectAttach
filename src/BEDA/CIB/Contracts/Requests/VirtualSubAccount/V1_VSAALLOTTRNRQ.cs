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
    /// 3.6.4虚拟子账户利息分配请求主体
    /// </summary>
    public class V1_VSAALLOTTRNRQ : IRequest<V1_VSAALLOTTRNRS>
    {
        /// <summary>
        /// 3.6.4虚拟子账户利息分配请求主体
        /// </summary>
        public VSAALLOTTRNRQ VSAALLOTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.4虚拟子账户利息分配请求主体
    /// </summary>
    public class VSAALLOTTRNRQ:BIZRQBASE
    {
        /// <summary>
        /// 3.6.4虚拟子账户利息分配请求内容
        /// </summary>
        [XmlElement(Order = 1)]
        public VSAALLOTTRN_INQUIRYINFO INQUIRYINFO { get; set; }
    }
    /// <summary>
    /// 3.6.4虚拟子账户利息分配请求内容
    /// </summary>
    public class VSAALLOTTRN_INQUIRYINFO
    {
        /// <summary>
        /// 18位主账户	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 子账户:ALL全部子账户 XXXX-具体子账户 默认ALL	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBACCT { get; set; } = "ALL";
        /// <summary>
        /// 查询模式，非必输
        /// 1-返回RSBODY响应体，含核心交易结果
        /// </summary>
        [XmlElement(Order = 2)]
        public string PATTERN { get; set; }
    }
}
