using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.9指令回单查询响应主体
    /// </summary>
    public class V1_RECEIPTTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.9指令回单查询响应
        /// </summary>
        public RECEIPTTRNRS RECEIPTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.9指令回单查询响应
    /// </summary>
    public class RECEIPTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.9指令回单查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public RECEIPTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.4.9指令回单查询响应内容
    /// </summary>
    public class RECEIPTTRN_RSBODY
    {
        /// <summary>
        /// 指令回单号
        /// </summary>
        [XmlElement(Order = 0)]
        public string RECEIPTNO { get; set; }
        /// <summary>
        /// 指令的网银跟踪号
        /// </summary>
        [XmlElement(Order = 1)]
        public string SRVRID { get; set; }
        /// <summary>
        /// 付款人账户信息
        /// </summary>
        [XmlElement(Order = 2)]
        public ACCTFROM ACCTFROM { get; set; }
        /// <summary>
        /// 总笔数
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT { get; set; }
        /// <summary>
        /// 总金额，Decimal(17,2)
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMOUNT { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement(Order = 5)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 货币符号,RMB,目前仅支持RMB	非必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string CURSYM { get; set; }
        /// <summary>
        /// 支付用途，最大60位
        /// </summary>
        [XmlElement(Order = 7)]
        public string PURPOSE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? DTDUE { get; set; }
        /// <summary>
        /// 客户端期望的转账执行日期，格式：YYYY-MM-DD, 对应<see cref="DTDUE"/>
        /// </summary>
        [XmlElement("DTDUE", Order = 8)]
        public string DTDUEStr
        {
            get
            {
                return this.DTDUE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DTDUE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 备注，最大60位	非必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 3.4.9批量收款人列表，批量指令会有多条数据
        /// </summary>
        [XmlElement("XFERINFO", Order = 10)]
        public List<RECEIPTTRN_XFERINFO> List { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        [XmlElement(Order = 11)]
        public string SUBMITOR { get; set; }
        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement(Order = 12)]
        public string CHECKER { get; set; }
        /// <summary>
        /// 授权人
        /// </summary>
        [XmlElement(Order = 13)]
        public string GRANTOR { get; set; }
        /// <summary>
        /// 支付指令处理状态
        /// </summary>
        [XmlElement(Order = 14)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
    /// <summary>
    /// 3.4.9批量收款人信息
    /// </summary>
    public class RECEIPTTRN_XFERINFO
    {
        /// <summary>
        /// 序号,最大5位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 收款人账户信息
        /// </summary>
        [XmlElement(Order = 1)]
        public ACCTTO ACCTTO { get; set; }
        /// <summary>
        /// 转账金额，不能为空、空格且金额必须大于0.01，必须为数值型，Decimal(17,2)，即整数位最长15位，小数位2位	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal TRNAMT { get; set; }
        /// <summary>
        /// 核心交易处理结果
        /// </summary>
        [XmlElement(Order = 3)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 核心交易处理结果信息
        /// </summary>
        [XmlElement(Order = 4)]
        public string MSG { get; set; }
    }
}
