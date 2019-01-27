using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询响应主体
    /// </summary>
    public class V1_INQSTATETRNRS : IResponse
    {
        /// <summary>
        /// 3.13.6支付指令核心处理结果查询响应主体
        /// </summary>
        public INQSTATETRNRS INQSTATETRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询响应主体
    /// </summary>
    public class INQSTATETRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.13.6支付指令核心处理结果查询响应内容
        /// </summary>
        [XmlElement(Order = 3)]
        public TXNSTATERS TXNSTATERS { get; set; }
    }
    /// <summary>
    /// 3.13.6支付指令核心处理结果查询响应内容
    /// </summary>
    public class TXNSTATERS
    {
        /// <summary>
        /// 指令的网银系统跟踪号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 指令的客户端跟踪号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLIENTREF { get; set; }
        /// <summary>
        /// 转账信息节点	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERINFO XFERINFO { get; set; }
        /// <summary>
        /// 应答结果 0-查无记录   1-存在有效记录   2-存在无效记录 必回
        /// </summary>
        [XmlElement(Order = 3)]
        public int CORERESULT { get; set; }
        /// <summary>
        /// 跨行大小额应答结果为1时处理状态:  非必回
        /// '1'- 初始状态（代表已受理）：状态不更新，认为“处理中”
        /// '2'- 核查状态（大额无此状态，小额代表已人工核查，但未组包）：状态不更新，认为“处理中”
        /// '5'- 发送状态（代表已发送行内报文系统）：状态不更新，认为“处理中”
        /// 'G'-挂账状态：当CORECLM为'9999X026'(已销账)，等同于失败；其他情况认为“处理中”
        /// 'Y'- 成功状态（人行受理成功）：成功
        /// 'F'- 失败状态：失败
        /// </summary>
        [XmlElement(Order = 4)]
        public string CORESTATUS { get; set; }
        /// <summary>
        /// 处理码	非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string CORECLM { get; set; }
    }
}
