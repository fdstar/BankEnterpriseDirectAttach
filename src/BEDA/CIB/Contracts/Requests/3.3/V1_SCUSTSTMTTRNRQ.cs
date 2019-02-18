using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.3.6账户余额和交易流水分页查询请求主体
    /// </summary>
    public class V1_SCUSTSTMTTRNRQ : IRequest<V1_SCUSTSTMTTRNRS>
    {
        /// <summary>
        /// 3.3.6账户余额和交易流水分页查询
        /// </summary>
        public SCUSTSTMTTRNRQ SCUSTSTMTTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.3.6账户余额和交易流水分页查询
    /// </summary>
    public class SCUSTSTMTTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 ，非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.3.6流水查询内容
        /// </summary>
        [XmlElement(Order = 2)]
        public SCUSTSTMTTRN_SCUSTSTMTRQ SCUSTSTMTRQ { get; set; }
    }
    /// <summary>
    /// 3.3.6流水查询内容
    /// </summary>
    public class SCUSTSTMTTRN_SCUSTSTMTRQ
    {
        /// <summary>
        /// 版本号，可以为空或填入2.0
        /// 空默认为原版本，填入2.0时返回2.0版本响应节点，非必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string VERSION { get; set; }
        /// <summary>
        /// 付款人账户，必输
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 包含交易流水，非必输（未指定起止时间，表示查余额；若指定起止时间，那么：1）开始时间=结束时间；2）开始时间早于结束时间，并且结束时间不为当天。。建议查询指定某一天的流水，避免网络传输带来的超时）
        /// </summary>
        [XmlElement(Order = 2)]
        public INCTRAN INCTRAN { get; set; }
        /// <summary>
        /// 查询类型：默认为1（查询） 3表示退款
        /// </summary>
        [XmlElement(Order = 3)]
        public int SELTYPE { get; set; } = 1;
    }
}
