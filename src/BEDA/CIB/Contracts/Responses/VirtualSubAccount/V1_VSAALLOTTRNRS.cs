using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.6.4虚拟子账户利息分配响应主体
    /// </summary>
    public class V1_VSAALLOTTRNRS : IResponse
    {
        /// <summary>
        /// 3.6.4虚拟子账户利息分配响应主体
        /// </summary>
        public VSAALLOTTRNRS VSAALLOTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.6.4虚拟子账户利息分配响应主体
    /// </summary>
    public class VSAALLOTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.6.4虚拟子账户利息分配响应内容  PATTERN为1时才返回
        /// </summary>
        [XmlElement(Order = 2)]
        public VSAALLOTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.6.4虚拟子账户利息分配响应内容
    /// </summary>
    public class VSAALLOTTRN_RSBODY
    {
        /// <summary>
        /// 18位主账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string MAINACCT { get; set; }
        /// <summary>
        /// 主账户户名
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 利息分配总笔数，整数
        /// </summary>
        [XmlElement(Order = 2)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 3.6.4虚拟子账户利息分配响应集合
        /// </summary>
        [XmlElement("VSAALLOTINFO", Order = 3)]
        public List<VSAALLOTINFO> List { get; set; }
        /// <summary>
        /// 支付指令处理状态
        /// </summary>
        [XmlElement(Order = 4)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.6.4虚拟子账户利息分配响应明细
    /// </summary>
    public class VSAALLOTINFO
    {
        /// <summary>
        /// 子账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string SUBACCT { get; set; }
        /// <summary>
        /// 子账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string SUBNAME { get; set; }
        /// <summary>
        /// 子账户利息
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal INTEREST { get; set; }
        /// <summary>
        /// 单笔核心交易处理结果
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 单笔核心交易处理结果信息
        /// </summary>
        [XmlElement(Order = 4)]
        public string MSG { get; set; }
    }
}
