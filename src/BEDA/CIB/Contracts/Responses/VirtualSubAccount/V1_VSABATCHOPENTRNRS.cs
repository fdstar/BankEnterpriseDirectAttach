using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.2虚拟子账户批量开户响应主体（最多20笔）
    /// </summary>
    public class V1_VSABATCHOPENTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.2虚拟子账户批量开户响应主体（最多20笔）
        /// </summary>
        public VSABATCHOPENTRNRS VSABATCHOPENTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户响应主体（最多20笔）
    /// </summary>
    public class VSABATCHOPENTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.2虚拟子账户批量开户响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public VSABATCHOPENTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户响应内容
    /// </summary>
    public class VSABATCHOPENTRN_RSBODY
    {
        /// <summary>
        /// 18位主账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 主账户户名	非必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 总笔数，整数	非必输
        /// </summary>
        [XmlElement(Order = 2)]
        public int? TOTALCOUNT { get; set; }
        /// <summary>
        /// 3.6.2虚拟子账户批量开户响应集合
        /// </summary>
        [XmlElement("VSAOPENINFO", Order = 2)]
        public List<VSAOPENINFORS> List { get; set; }
    }
    /// <summary>
    /// 3.6.2虚拟子账户批量开户响应明细
    /// </summary>
    public class VSAOPENINFORS
    {
        /// <summary>
        /// 子账户，必须为6位数字且在010000-999989之间
        /// </summary>
        [XmlElement(Order = 0)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 子账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBNAME { get; set; }
        /// <summary>
        /// 单笔核心交易处理结果
        /// </summary>
        [XmlElement(Order = 2)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 单笔核心交易处理结果信息
        /// </summary>
        [XmlElement(Order = 3)]
        public string MSG { get; set; }
    }
}
