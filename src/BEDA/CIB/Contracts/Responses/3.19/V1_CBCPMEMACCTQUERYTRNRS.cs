using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.7跨境资金池成员账号信息查询响应主体
    /// </summary>
    public class V1_CBCPMEMACCTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.7跨境资金池成员账号信息查询响应主体
        /// </summary>
        public CBCPMEMACCTQUERYTRNRS CBCPMEMACCTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.7跨境资金池成员账号信息查询响应主体
    /// </summary>
    public class CBCPMEMACCTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.7跨境资金池成员账号信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPMEMACCTQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.7跨境资金池成员账号信息查询响应内容
    /// </summary>
    public class CBCPMEMACCTQUERYTRN_RSBODY
    {
        /// <summary>
        /// 成员活期账户代号 18位	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 成员活期账户名称，60位	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 主账号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string MAINACCTNO { get; set; }
        /// <summary>
        /// 主账户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string MAINACCTNAME { get; set; }
        /// <summary>
        /// 成员序号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string SEQNO { get; set; }
        /// <summary>
        /// 币种	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 资金性质  必回
        /// 2-经常项目
        /// 3-资本项目
        /// 4-NRA项目
        /// 5-无实体账号账户(指的是无实体账户的国际成员账户)
        /// </summary>
        [XmlElement(Order = 6)]
        public int ACCTTYPE { get; set; }
        /// <summary>
        /// 账户余额	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal ACCOUNTBALANCE { get; set; }
        /// <summary>
        /// 账户可用余额	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal AVAILABLEBALANCE { get; set; }
        /// <summary>
        /// 上存金额	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal SUMUPAMOUNT { get; set; }
        /// <summary>
        /// 透支额度	必回
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal MAXOVERAMOUNT { get; set; }
        /// <summary>
        /// 可透支额度	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal AVAILABLEOVERAMOUNT { get; set; }
        /// <summary>
        /// 累计上存积数	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal TOTALSUMUPSOCRE { get; set; }
        /// <summary>
        /// 累计透支积数	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal TOTALOVERSOCRE { get; set; }
    }
}
