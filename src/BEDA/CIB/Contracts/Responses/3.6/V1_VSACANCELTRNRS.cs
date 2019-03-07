using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.8虚拟子账户删除响应主体
    /// </summary>
    public class V1_VSACANCELTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.8虚拟子账户删除响应主体
        /// </summary>
        public VSACANCELTRNRS VSACANCELTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.8虚拟子账户删除响应主体
    /// </summary>
    public class VSACANCELTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.8虚拟子账户删除响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VSACANCELTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.6.8虚拟子账户删除响应内容
    /// </summary>
    public class VSACANCELTRN_RSBODY
    {
        /// <summary>
        /// 18位主账户
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 子账户
        /// </summary>
        [XmlElement(Order = 3)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 指令处理节点
        /// </summary>
        [XmlElement(Order = 20)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
