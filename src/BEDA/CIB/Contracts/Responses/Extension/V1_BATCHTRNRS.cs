using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.1批量汇款指令提交（暂不推荐）响应主体
    /// </summary>
    public class V1_BATCHTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.1批量汇款指令提交（暂不推荐）响应主体
        /// </summary>
        public BATCHTRNRS BATCHTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.1批量汇款指令提交（暂不推荐）响应主体
    /// </summary>
    public class BATCHTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 转账付出指令内容
        /// </summary>
        [XmlElement(Order = 3)]
        public BATCHRS BATCHRS { get; set; }
    }
    /// <summary>
    /// 3.13.1批量汇款指令提交（暂不推荐）响应内容
    /// </summary>
    public class BATCHRS 
    {
        /// <summary>
        /// 服务器该笔交易的标识 长度12位
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 转账信息
        /// </summary>
        [XmlElement(Order = 1)]
        public Requests.BATCHINFO BATCHINFO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
