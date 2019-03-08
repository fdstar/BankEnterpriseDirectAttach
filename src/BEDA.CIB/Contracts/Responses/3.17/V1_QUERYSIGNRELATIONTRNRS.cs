using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询响应主体
    /// </summary>
    public class V1_QUERYSIGNRELATIONTRNRS : IResponse
    {
        /// <summary>
        /// 3.17.4资金池签约关系及余额查询响应主体
        /// </summary>
        public QUERYSIGNRELATIONTRNRS QUERYSIGNRELATIONTRNRS { get; set; }
    }
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询响应主体
    /// </summary>
    public class QUERYSIGNRELATIONTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.17.4资金池签约关系及余额查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public QUERYSIGNRELATIONTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询响应内容
    /// </summary>
    public class QUERYSIGNRELATIONTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 主账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public MAINACCTINFO MAINACCTINFO { get; set; }
        /// <summary>
        /// 3.17.4资金池签约关系及余额查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 2)]
        public List<QUERYSIGNRELATIONTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.17.4资金池签约关系及余额查询响应明细
    /// </summary>
    public class QUERYSIGNRELATIONTRN_CONTENT
    {
        /// <summary>
        /// 成员账户
        /// </summary>
        [XmlElement(Order = 0)]
        public string MEMACCTNO { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement(Order = 1)]
        public string MEMACCTNAME { get; set; }
        /// <summary>
        /// 成员账号余额
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal MEMBLCAMT { get; set; }
        /// <summary>
        /// 保证金账号
        /// </summary>
        [XmlElement(Order = 3)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 保证金账号名称
        /// </summary>
        [XmlElement(Order = 4)]
        public string BAILACCTNAME { get; set; }
        /// <summary>
        /// 保证金账户余额，decimal(15,2) 即整数位最长13位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal BAILBLCAMT { get; set; }
        /// <summary>
        /// 担保账户类型 2-保证金账户 3-定期质押账户
        /// </summary>
        [XmlElement(Order = 6)]
        public int BAILACCTTYPE { get; set; }
    }
    /// <summary>
    /// 主账户信息
    /// </summary>
    public class MAINACCTINFO
    {
        /// <summary>
        /// 主账号
        /// </summary>
        [XmlElement(Order = 1)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账号名称
        /// </summary>
        [XmlElement(Order = 2)]
        public string MIANACCTNAME { get; set; }
        /// <summary>
        /// 主账号余额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal MAINBLCAMT { get; set; }
    }
}
