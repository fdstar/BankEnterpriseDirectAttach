using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 账户信息查询响应主体
    /// </summary>
    public class SECURITIES_MSGSRSV1_ACCOUNTQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 账户信息查询响应
        /// </summary>
        public ACCOUNTQUERYTRNRS ACCOUNTQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 账户信息查询响应
    /// </summary>
    public class ACCOUNTQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 账户信息，必回
        /// </summary>
        [XmlElement(Order = 2)]
        public ACCOUNTRSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 账户信息查询结果集合
    /// </summary>
    public class ACCOUNTRSBODY
    {
        /// <summary>
        /// 查询账户代号，最长32位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 1)]
        public string NAME { get; set; }
        /// <summary>
        /// 开户人组织机构代码证，最小1位,最大10位
        /// </summary>
        [XmlElement(Order = 2)]
        public string ORGID { get; set; }
        /// <summary>
        /// 账户类型，2位小数 ( 0-一般户，1-基本户，2-临时户，3-专用户，4-纳税户，5-个人存款户,9-其它, a-经常项目外汇结算户,b-经常项目外汇专用户,c-资本项目资本金户, d-资本项目外汇贷款专户,e-资本项目外汇还本付息专户,f-外债(外债转贷款)专户, g-资本项目外汇专用户,n-银行外汇存款户,o-非银行金融机构外汇存款户, p-境外银行外汇存款户,q-境外非银行金融机构外汇存款户,r-证券公司B股资金清算户, s-证券公司外汇资本金户,t-证券公司外汇自有资金户,u-证券公司客户交易结算资金专用户)
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCTTYPE { get; set; }
        /// <summary>
        /// 开户行名称，最大60位
        /// </summary>
        [XmlElement(Order = 4)]
        public string BANKDESC { get; set; }
        /// <summary>
        /// 开户行地址
        /// </summary>
        [XmlElement(Order = 5)]
        public string BANKADDR { get; set; }
        /// <summary>
        /// 币种,2位
        /// </summary>
        [XmlElement(Order = 6)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 是否冻结 (1-有效，2-销户，3-挂失，4-冻结，5-不动户，7-已入账，8-销账未成功（出付），9-退票（出付）A-结清，B-控制，C-抵押，D-回收，F-协防，G-公示催告,H-久悬，I-开户暂封 )
        /// </summary>
        [XmlElement(Order = 7)]
        public string ISFREEZE { get; set; }
        /// <summary>
        /// 是否归集 (0-归集 1-不归集)
        /// </summary>
        [XmlElement(Order = 8)]
        public byte ISGATHER { get; set; }
        /// <summary>
        /// 人行联行号
        /// </summary>
        [XmlElement(Order = 9)]
        public string RSLTID { get; set; }
        /// <summary>
        /// 开户日期yyyy-MM-dd
        /// </summary>
        [XmlElement(Order = 10)]
        public string OPENDATE { get; set; }
        /// <summary>
        /// 账户实时余额
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal BALAREAL { get; set; }
        /// <summary>
        /// 账户可用余额
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal BALAMT { get; set; }
    }
}
