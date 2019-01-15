using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 付款查询请求交易响应主体
    /// </summary>
    public class V1_XFERINQTRNRS : IResponse
    {
        /// <summary>
        /// 付款查询请求交易返回
        /// </summary>
        public XFERINQTRNRS XFERINQTRNRS { get; set; }
    }
    /// <summary>
    /// 付款查询请求交易返回
    /// </summary>
    public class XFERINQTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 如果客户端发送COOKIE，同步的历史记录不包括原有的CLTCOOKIE	非必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERINQRS XFERINQRS { get; set; }
    }
    /// <summary>
    /// 查询响应主体
    /// </summary>
    public class XFERINQRS
    {
        /// <summary>
        /// 查询到的记录列表
        /// </summary>
        public XFERLIST XFERLIST { get; set; }
    }
    /// <summary>
    /// 查询到的记录列表
    /// </summary>
    public class XFERLIST
    {
        /// <summary>
        /// Y/N表示有/没有查询到记录
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 请求进账记录的起始纪录号(SRVRID)，必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string FROM { get; set; }
        /// <summary>
        /// 表示响应中最后一笔交易的SRVRID。值为－1时候表示无此记录
        /// </summary>
        [XmlElement(Order = 1)]
        public string TO { get; set; }
        /// <summary>
        /// 记录集合
        /// </summary>
        [XmlElement("XFER", Order = 2)]
        public List<XFER> List { get; set; }
    }
    /// <summary>
    /// 交易记录结果
    /// </summary>
    public class XFER
    {
        /// <summary>
        /// 服务器交易ID
        /// </summary>
        [XmlElement(Order = 0)]
        public string SRVRTID { get; set; }
        /// <summary>
        /// 交易信息
        /// </summary>
        [XmlElement(Order = 1)]
        public XFERINFO XFERINFO { get; set; }
        /// <summary>
        /// 交易结果
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
