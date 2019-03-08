using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 集团服务账户可用额度查询响应主体
    /// </summary>
    public class V1_CMAVBLQUOTATRNRS : IResponse
    {
        /// <summary>
        /// 集团服务账户可用额度查询响应主体
        /// </summary>
        public CMAVBLQUOTATRNRS CMAVBLQUOTATRNRS { get; set; }
    }
    /// <summary>
    /// 集团服务账户可用额度查询响应主体
    /// </summary>
    public class CMAVBLQUOTATRNRS : BIZRSBASE
    {
        /// <summary>
        /// 集团服务账户可用额度查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMAVBLQUOTATRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团服务账户可用额度查询响应内容
    /// </summary>
    public class CMAVBLQUOTATRN_RSBODY
    {
        /// <summary>
        /// 结算中心账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public CMAVBLQUOTATRN_ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 成员单位账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 成员单位账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 留存金额，decimal(15,2)，即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal CONTRBTRATE { get; set; }
    }
    /// <summary>
    /// 结算中心账户信息
    /// </summary>
    public class CMAVBLQUOTATRN_ACCT
    {
        /// <summary>
        /// 结算中心账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 结算中心账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
    }
}
