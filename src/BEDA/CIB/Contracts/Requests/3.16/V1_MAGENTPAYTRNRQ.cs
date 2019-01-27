using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
    /// </summary>
    public class V1_MAGENTPAYTRNRQ
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
        /// </summary>
        public MAGENTPAYTRNRQ MAGENTPAYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求主体
    /// </summary>
    public class MAGENTPAYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public MAGENTPAYRQ MAGENTPAYRQ { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）请求内容
    /// </summary>
    public class MAGENTPAYRQ
    {
        /// <summary>
        /// 代付信息	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public MAGENTPAYINFO MAGENTPAYINFO { get; set; }
    }
    /// <summary>
    /// 3.16.1收付直通车资金代付及指令查询（不采用工作流）代付信息
    /// </summary>
    public class MAGENTPAYINFO
    {
        /// <summary>
        /// 付款人账户
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTFROM ACCTFROM { get; set; }
    }
}
