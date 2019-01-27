using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 集团成员账户查询响应主体
    /// </summary>
    public class V1_CMMBRQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 集团成员账户查询响应
        /// </summary>
        public CMMBRQUERYTRNRS CMMBRQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 集团成员账户查询响应
    /// </summary>
    public class CMMBRQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 集团成员账户查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CMMBRQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 集团成员账户查询响应内容
    /// </summary>
    public class CMMBRQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 结算中心账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCT FUNDACCT { get; set; }
        /// <summary>
        /// 集团成员账户查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CMMBRQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 集团成员账户查询响应明细
    /// </summary>
    public class CMMBRQUERYTRN_CONTENT
    {
        /// <summary>
        /// 成员单位账户信息
        /// </summary>
        [XmlElement(Order = 0)]
        public ACCTFROM MBRACCT { get; set; }
        /// <summary>
        /// 归集类型 
        /// 0 逐笔归集 
        /// 1 定时归集 
        /// 2 定额归集（单向归集） 
        /// 3 实时定额管理(双向自动归集) 
        /// 4 不归集 
        /// 5 定时定额管理(双向自动归集) 
        /// 6 多笔归集  
        /// 9 定时限额归集
        /// </summary>
        [XmlElement(Order = 1)]
        public int TYPE { get; set; }
        /// <summary>
        /// 归集周期（频率）0 每天;1 每周;2 每旬;3 每月;4 隔天
        /// </summary>
        [XmlElement(Order = 2)]
        public int? CYCLE { get; set; }
        /// <summary>
        /// 归集日期，如果CYCLE为周，这里的数字为0-6表示周日周一到周六；CYCLE为旬，这里的数字表示旬的第1-10天；CYCLE为月，表示这个月的1-31天
        /// </summary>
        [XmlElement(Order = 3)]
        public string FRQNCY { get; set; }
        /// <summary>
        /// 归集时间，HHMMSS为管理员在企业网银归集方式设置里面设置的原值，时间范围为000000-205000，例如081120表示早上8点11分20秒
        /// </summary>
        [XmlElement(Order = 4)]
        public string TIME { get; set; }
        /// <summary>
        /// 留存金额，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? CONTRBTRATE { get; set; }
        /// <summary>
        /// 最低归集金额，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal? MINAMT { get; set; }
        /// <summary>
        /// 层级关系，0 结算中心；1 成员单位
        /// </summary>
        [XmlElement(Order = 7)]
        public int LEVEL { get; set; }
        /// <summary>
        /// 登记模式，0集团模式 1循环委托贷款模式  非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public int? PATTERN { get; set; }
    }
}
