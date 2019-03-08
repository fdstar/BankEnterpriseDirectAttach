using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.13.2批量工资指令提交（暂不推荐）响应主体
    /// </summary>
    public class V1_BPAYOFFTRNRS : IResponse
    {
        /// <summary>
        /// 3.13.2批量工资指令提交（暂不推荐）响应主体
        /// </summary>
        public BPAYOFFTRNRS BPAYOFFTRNRS { get; set; }
    }
    /// <summary>
    /// 3.13.2批量工资指令提交（暂不推荐）响应主体
    /// </summary>
    public class BPAYOFFTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 批量工资指令响应
        /// </summary>
        [XmlElement(Order = 3)]
        public BPAYOFFRS BPAYOFFRS { get; set; }
    }
    /// <summary>
    /// 3.13.2批量工资指令提交（暂不推荐）响应内容
    /// </summary>
    public class BPAYOFFRS
    {
        /// <summary>
        /// 服务器该笔交易的标识 长度12位
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 批量工资指令
        /// </summary>
        [XmlElement(Order = 1)]
        public Requests.BPAYOFFINFO BPAYOFFINFO { get; set; }
        /// <summary>
        /// 指令处理状态
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
