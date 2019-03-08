using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.11.1.2贵金属库存查询响应主体
    /// </summary>
    public class V1_PMINVNQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.11.1.2贵金属库存查询响应主体
        /// </summary>
        public PMINVNQUERYTRNRS PMINVNQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.11.1.2贵金属库存查询响应主体
    /// </summary>
    public class PMINVNQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.11.1.2贵金属库存查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public PMINVNQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.11.1.2贵金属库存查询响应内容
    /// </summary>
    public class PMINVNQUERYTRN_RSBODY : BANKACCT
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.11.1.2贵金属库存查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 10)]
        public List<PMINVNQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.11.1.2贵金属库存查询响应内容
    /// </summary>
    public class PMINVNQUERYTRN_CONTENT
    {
        /// <summary>
        /// 品种代码，
        /// 201 AU99.99       
        /// 202 AU99.95       
        /// 203 PT99.95       
        /// 207 AU100g
        /// </summary>
        [XmlElement(Order = 3)]
        public string PRODNO { get; set; }
        /// <summary>
        /// 库存总量
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALCNT { get; set; }
        /// <summary>
        /// 可用库存
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal AVBLCNT { get; set; }
        /// <summary>
        /// 冻结库存
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal FREEZGCNT { get; set; }
        /// <summary>
        /// 待提库存
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal PICKCNT { get; set; }
        /// <summary>
        /// 当日买入
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal CURRBUY { get; set; }
        /// <summary>
        /// 当日卖出
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal CURRSALE { get; set; }
        /// <summary>
        /// 当日提出
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal CURRPICK { get; set; }
        /// <summary>
        /// 库存均价
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal ASP { get; set; }
    }
}
