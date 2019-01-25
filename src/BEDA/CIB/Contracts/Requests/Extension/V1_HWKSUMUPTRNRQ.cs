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
    /// 3.13.5手动归集请求主体
    /// </summary>
    public class V1_HWKSUMUPTRNRQ : IRequest<V1_HWKSUMUPTRNRS>
    {
        /// <summary>
        /// 3.13.5手动归集请求主体
        /// </summary>
        public HWKSUMUPTRNRQ HWKSUMUPTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.13.5手动归集请求主体
    /// </summary>
    public class HWKSUMUPTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 在响应报文中包含该内容 	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CLTCOOKIE { get; set; }
        /// <summary>
        /// 3.13.5手动归集请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public HWKSUMUPRQ HWKSUMUPRQ { get; set; }
    }
    /// <summary>
    /// 3.13.5手动归集请求内容
    /// </summary>
    public class HWKSUMUPRQ
    {
        /// <summary>
        /// 手工归集请求	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public HWKSUMUPINFO HWKSUMUPINFO { get; set; }
    }
    /// <summary>
    /// 手工归集请求
    /// </summary>
    public class HWKSUMUPINFO
    {
        /// <summary>
        /// 结算中心账号,长度18	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string CENTERACCTID { get; set; }
        /// <summary>
        /// 需要归集的成员单位账号 若此处为空，或者此处长度为0，则表示是整个结算中心手动归集。	非必输
        /// </summary>
        [XmlArray("MEMBERACCTS", Order = 2)]
        public List<MEMBERACCT> List { get; set; }
    }
    /// <summary>
    /// 成员账户
    /// </summary>
    public class MEMBERACCT
    {
        /// <summary>
        /// 账户ID,长度18	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称,长度50	非必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
    }
    /// <summary>
    /// 需要归集的成员单位账号
    /// </summary>
    public class MEMBERACCTS
    {
        /// <summary>
        /// 0..n,目前只支持1个账户	必输
        /// </summary>
        [XmlElement("MEMBERACCT", Order = 0)]
        public List<ACCT> List { get; set; }
    }
}
