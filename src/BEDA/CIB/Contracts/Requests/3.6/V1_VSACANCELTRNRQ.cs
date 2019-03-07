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
    /// 3.6.8虚拟子账户删除请求主体
    /// </summary>
    public class V1_VSACANCELTRNRQ : IRequest<V1_VSACANCELTRNRS>
    {
        /// <summary>
        /// 3.6.8虚拟子账户删除请求主体
        /// </summary>
        public VSACANCELTRNRQ VSACANCELTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.6.8虚拟子账户删除请求主体
    /// </summary>
    public class VSACANCELTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.6.8虚拟子账户删除请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VSACANCELTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.6.8虚拟子账户删除请求内容
    /// </summary>
    public class VSACANCELTRN_RQBODY
    {
        /// <summary>
        /// 18位主账户	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 子账户	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string SUBACCT { get; set; }
    }
}
