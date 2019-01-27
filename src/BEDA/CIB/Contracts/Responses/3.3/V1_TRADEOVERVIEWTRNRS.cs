using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 交易概览响应主体
    /// </summary>
    public class V1_TRADEOVERVIEWTRNRS : IResponse
    {
        /// <summary>
        /// 交易概览响应
        /// </summary>
        public TRADEOVERVIEWTRNRS TRADEOVERVIEWTRNRS { get; set; }
    }
    /// <summary>
    /// 交易概览响应
    /// </summary>
    public class TRADEOVERVIEWTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 定期账户查询集合
        /// </summary>
        [XmlElement(Order = 2)]
        public TRADEOVERVIEWTRNRSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 交易概览查询结果集合
    /// </summary>
    public class TRADEOVERVIEWTRNRSBODY
    {
        /// <summary>
        /// 是否还有下一页：Y－有,N－否
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 总账户数
        /// </summary>
        [XmlElement(Order = 0)]
        public int ACCTNUMBER { get; set; }
        /// <summary>
        /// 发生交易账户数
        /// </summary>
        [XmlElement(Order = 1)]
        public int TRADEACCTNUMBER { get; set; }
        /// <summary>
        /// 收入笔数
        /// </summary>
        [XmlElement(Order = 2)]
        public int INCOMENUMBER { get; set; }
        /// <summary>
        /// 支出笔数
        /// </summary>
        [XmlElement(Order = 3)]
        public int EXPENDNUMBER { get; set; }
        /// <summary>
        /// 收入金额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal INCOMEAMT { get; set; }
        /// <summary>
        /// 支出金额
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal EXPENDAMT { get; set; }
        /// <summary>
        /// 查询结果集合
        /// </summary>
        [XmlElement("CONTENT", Order = 6)]
        public List<TRADEOVERVIEWTRNCONTENT> List { get; set; }
    }
    /// <summary>
    /// 交易概览查询结果明细
    /// </summary>
    public class TRADEOVERVIEWTRNCONTENT
    {
        /// <summary>
        /// 柜员流水号
        /// </summary>
        [XmlElement(Order = 0)]
        public string FITID { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 户名
        /// </summary>
        [XmlElement(Order = 2)]
        public string ACCTNAME { get; set; }
        /// <summary>
        /// 凭证代号，长度9位
        /// </summary>
        [XmlElement(Order = 3)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 币种,01:人民币,14:美元
        /// </summary>
        [XmlElement(Order = 4)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 现/转,0:现；1：转
        /// </summary>
        [XmlElement(Order = 5)]
        public byte CASH_TXN_IND { get; set; }
        /// <summary>
        /// 借方金额
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal? DEBIT_AMT { get; set; }
        /// <summary>
        /// 贷方金额
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? CREDIT_AMT { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement(Order = 9)]
        public string BRIEF { get; set; }
        /// <summary>
        /// 对方账号
        /// </summary>
        [XmlElement(Order = 10)]
        public string OPPT_ACCT_NUM { get; set; }
        /// <summary>
        /// 对方户名
        /// </summary>
        [XmlElement(Order = 11)]
        public string OPPT_ACCT_NAME { get; set; }
        /// <summary>
        /// 对方银行
        /// </summary>
        [XmlElement(Order = 12)]
        public string OPPT_BANK_NAME { get; set; }
        /// <summary>
        /// 对方行号
        /// </summary>
        [XmlElement(Order = 13)]
        public string OPPT_BANK_CODE { get; set; }
        /// <summary>
        /// 交易日期，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlIgnore]
        public DateTime TXN_DATE { get; set; }
        /// <summary>
        /// 开户日期yyyyMMdd ,对应<see cref="TXN_DATE"/>
        /// </summary>
        [XmlElement("TXN_DATE", Order = 14)]
        public string TXN_DATEStr
        {
            get
            {
                return this.TXN_DATE.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TXN_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 用途
        /// </summary>
        [XmlElement(Order = 15)]
        public string PURPOSE { get; set; }
    }
}
