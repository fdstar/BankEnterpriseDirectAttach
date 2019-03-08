using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.4.7批量托收或子账户托收明细查询响应主体
    /// </summary>
    public class V1_FBBATCHSTMTTRNRS : IResponse
    {
        /// <summary>
        /// 3.4.7批量托收或子账户托收明细查询响应
        /// </summary>
        public FBBATCHSTMTTRNRS FBBATCHSTMTTRNRS { get; set; }
    }
    /// <summary>
    /// 3.4.7批量托收或子账户托收明细查询响应
    /// </summary>
    public class FBBATCHSTMTTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.4.7批量托收或子账户托收明细查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public FBBATCHSTMTTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.4.7批量托收或子账户托收明细查询响应内容
    /// </summary>
    public class FBBATCHSTMTTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 受理编号，12位
        /// </summary>
        [XmlElement(Order = 0)]
        public string ACPTNO { get; set; }
        /// <summary>
        /// 收款账户(兴业银行账户)，32位
        /// 子账户托收返回22位或24位子账户
        /// </summary>
        [XmlElement(Order = 1)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 收款人账户名称，最长60位
        /// </summary>
        [XmlElement(Order = 2)]
        public string NAME { get; set; }
        /// <summary>
        /// 企业编码， 最长20位
        /// </summary>
        [XmlElement(Order = 3)]
        public string FIRMCODE { get; set; }
        /// <summary>
        /// 业务编码， 5位。 <see cref="Requests.GATHERRQINFO.BIZCODE"/>	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string BIZCODE { get; set; }
        /// <summary>
        /// 托收摘要代号 <see cref="Requests.GATHERRQINFO.SUMM"/> 非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SUMM { get; set; }
        /// <summary>
        /// 回款期限:1/2/3天 默认为3天
        /// </summary>
        [XmlElement(Order = 6)]
        public int LIMITDAYS { get; set; }
        /// <summary>
        /// 标题，最大30位
        /// </summary>
        [XmlElement(Order = 7)]
        public string TITLE { get; set; }
        /// <summary>
        /// 凭证号，7位数字；可不填，默认使用电子凭证号。
        /// </summary>
        [XmlElement(Order = 8)]
        public string CHEQUENUM { get; set; }
        /// <summary>
        /// 交易类型（借0/贷1）
        /// </summary>
        [XmlElement(Order = 9)]
        public int TRNTYPE { get; set; } = 1;
        /// <summary>
        /// 总笔数，最长11位
        /// </summary>
        [XmlElement(Order = 10)]
        public long TOTALCNT { get; set; }
        /// <summary>
        /// 总金额，decimal(17,2)，即整数位最长15位，小数位2位
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal TOTALAMT { get; set; }
        /// <summary>
        /// 批次用途，最大30位	非必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string USE { get; set; }
        /// <summary>
        /// 批次备注，60位
        /// </summary>
        [XmlElement(Order = 13)]
        public string MEMO { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement(Order = 14)]
        public XFERPRCCODEEnum STATUS { get; set; }
        /// <summary>
        /// 执行情况，最长60位
        /// </summary>
        [XmlElement(Order = 15)]
        public string EXECINFO { get; set; }
        /// <summary>
        /// 3.4.7付款信息集合
        /// </summary>
        [XmlElement("CONTENT", Order = 16)]
        public List<FBBATCHSTMTTRN_PAYINFO> List { get; set; }
    }
    /// <summary>
    /// 3.4.7付款信息
    /// 此处<see cref="Requests.RQPAYINFO.BIZCODE0"/>和<see cref="Requests.RQPAYINFO.BIZCODE1"/>为必回
    /// 另外<see cref="Requests.RQPAYINFO.BIZCODE2"/>此处业务中不存在
    /// </summary>
    public class FBBATCHSTMTTRN_PAYINFO : Requests.RQPAYINFO
    {
        /// <summary>
        /// 托收备注，最长60位
        /// </summary>
        [XmlElement(Order = 9)]
        public string MEMO { get; set; }
        /// <summary>
        /// 托收结果代码，整数。非0表示错误， 
        /// -1：表示处理未提交
        /// 0: 托收成功
        /// 1：托收失败
        /// 2：银行处理中 必回
        /// 3：销账处理
        /// </summary>
        [XmlElement(Order = 10)]
        public int RESULT { get; set; }
        /// <summary>
        /// 错误信息，最大60位
        /// </summary>
        [XmlElement(Order = 11)]
        public string ERRMSG { get; set; }
    }
}
