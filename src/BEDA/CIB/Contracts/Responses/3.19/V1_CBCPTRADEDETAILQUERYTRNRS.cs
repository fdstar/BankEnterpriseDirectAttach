using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询响应主体
    /// </summary>
    public class V1_CBCPTRADEDETAILQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.19.9跨境资金池账户交易明细查询响应主体
        /// </summary>
        public CBCPTRADEDETAILQUERYTRNRS CBCPTRADEDETAILQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询响应主体
    /// </summary>
    public class CBCPTRADEDETAILQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.19.9跨境资金池账户交易明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBCPTRADEDETAILQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询响应内容
    /// </summary>
    public class CBCPTRADEDETAILQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.19.9跨境资金池账户交易明细查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBCPTRADEDETAILQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.19.9跨境资金池账户交易明细查询响应明细
    /// </summary>
    public class CBCPTRADEDETAILQUERYTRN_CONTENT
    {
        /// <summary>
        /// 综合前置流水号(资金池流水号)
        /// </summary>
        [XmlElement(Order = 0)]
        public string ZHQZLSH { get; set; }
        /// <summary>
        /// 主机流水号(柜员流水号)
        /// </summary>
        [XmlElement(Order = 1)]
        public string ZJLSH { get; set; }
        /// <summary>
        /// 账户代号
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNO { get; set; }
        /// <summary>
        /// 账户名称
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement(Order = 4)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 对方账号
        /// </summary>
        [XmlElement(Order = 5)]
        public string TOACCTNO { get; set; }
        /// <summary>
        /// 对方账户名称
        /// </summary>
        [XmlElement(Order = 6)]
        public string TOACCTNAME { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal AMOUNT { get; set; }
        /// <summary>
        /// 货币种类
        /// </summary>
        [XmlElement(Order = 8)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 借贷方向 1-收入 2-支出
        /// </summary>
        [XmlElement(Order = 9)]
        public int TRSFRDIRECT { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement(Order = 10)]
        public string BRIEF { get; set; }
        /// <summary>
        /// 交易状态
        /// 0-交易成功
        /// 1-交易失败
        /// 2-已冲正
        /// 3-待确认
        /// 9-正在处理
        /// </summary>
        [XmlElement(Order = 11)]
        public int TRSFRSTATUS { get; set; }
        /// <summary>
        /// 响应码
        /// </summary>
        [XmlElement(Order = 12)]
        public string XYM { get; set; }
        /// <summary>
        /// 响应信息
        /// </summary>
        [XmlElement(Order = 13)]
        public string XYXX { get; set; }
        /// <summary>
        /// 起始时间 yyyy-MM-dd HH:mm:ss	必输
        /// </summary>
        [XmlIgnore]
        public DateTime? TRADETIME { get; set; }
        /// <summary>
        /// 起始时间 yyyy-MM-dd HH:mm:ss, 对应<see cref="TRADETIME"/>	必输 
        /// </summary>
        [XmlElement("TRADETIME", Order = 14)]
        public string TRADETIMEStr
        {
            get
            {
                return this.TRADETIME?.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                this.TRADETIME = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRADETIME = tmp;
                }
            }
        }
    }
}
