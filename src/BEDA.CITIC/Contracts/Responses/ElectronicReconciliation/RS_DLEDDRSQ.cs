using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 回单信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLEDDRSQ : RsBase
    {
        /// <summary>
        /// 总记录数 int
        /// </summary>
        [XmlElement("totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<Reconciliation> List { get; set; }
    }
    /// <summary>
    /// 回单信息
    /// </summary>
    public class Reconciliation
    {
        /// <summary>
        /// 回单编号varchar(28)
        /// </summary>
        [XmlElement("bresqNo")]
        public string BresqNo { get; set; }
        /// <summary>
        /// 回单类型varchar(6)，100000：存款回单；100001：取款回单；200000：转账回单；200001：缴税回单；300000：收费回单；400000定期回单；400001：活期回单
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 交易发起方流水号varchar(36)
        /// </summary>
        [XmlElement("transeqNo")]
        public string TranseqNo { get; set; }
        /// <summary>
        /// 交易发起方交易码（T+1返回） varchar(8)
        /// </summary>
        [XmlElement("tranCode")]
        public string TranCode { get; set; }
        /// <summary>
        /// 交易日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易日期char(8)，格式YYYYMMDD, 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交易金额decimal(15.2)
        /// </summary>
        [XmlElement("tranAmt")]
        public decimal TranAmt { get; set; }
        /// <summary>
        /// 付款人账号（T+1返回） varchar(19)
        /// </summary>
        [XmlElement("payerAccNo")]
        public string PayerAccNo { get; set; }
        /// <summary>
        /// 付款人户名（T+1返回） varchar(122)
        /// </summary>
        [XmlElement("payerAccNm")]
        public string PayerAccNm { get; set; }
        /// <summary>
        /// 收款人账号（T+1返回） varchar(19)
        /// </summary>
        [XmlElement("payeeAccNo")]
        public string PayeeAccNo { get; set; }
        /// <summary>
        /// 收款人户名（T+1返回） varchar(122)
        /// </summary>
        [XmlElement("payeeAccNm")]
        public string PayeeAccNm { get; set; }
        /// <summary>
        /// 币种（T+1返回）varchar(3)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 业务类型（T+1返回）varchar(6)
        /// </summary>
        [XmlElement("bizType")]
        public string BizType { get; set; }
        /// <summary>
        /// 业务类型描述（T+1返回）varchar(32)
        /// </summary>
        [XmlElement("bizTpdes")]
        public string BizTpdes { get; set; }
        /// <summary>
        /// 回单状态（T+0返回）varchar(1)，1：正常；2：冲正；3：被冲正；4：当日冲正
        /// </summary>
        [XmlElement("brStt")]
        public string BrStt { get; set; }
        /// <summary>
        /// 对手方账号（T+0返回） varchar(19)
        /// </summary>
        [XmlElement("otherRaccNo1")]
        public string OtherRaccNo1 { get; set; }
        /// <summary>
        /// 对手方账户名（T+0返回） varchar(122)
        /// </summary>
        [XmlElement("otherRaccNm1")]
        public string OtherRaccNm1 { get; set; }
        /// <summary>
        /// 对手方附属账户（T+0返回） varchar(19)
        /// </summary>
        [XmlElement("otherRaccNo2")]
        public string OtherRaccNo2 { get; set; }
        /// <summary>
        /// 对手方附属账户名（T+0返回） varchar(122)
        /// </summary>
        [XmlElement("otherRaccNm2")]
        public string OtherRaccNm2 { get; set; }
        /// <summary>
        /// 借贷标识（T+0返回）varchar(1)， C：贷/收；D：借/付
        /// </summary>
        [XmlElement("cdfg")]
        public string Cdfg { get; set; }
        /// <summary>
        /// 己方账号(T+0) varchar(19)
        /// </summary>
        [XmlElement("accNo1")]
        public string AccNo1 { get; set; }
        /// <summary>
        /// 己方账户名(T+0) varchar(122)
        /// </summary>
        [XmlElement("accNm1")]
        public string AccNm1 { get; set; }
        /// <summary>
        /// 己方附属账号(T+0) varchar(19)
        /// </summary>
        [XmlElement("accNo2")]
        public string AccNo2 { get; set; }
        /// <summary>
        /// 己方附属账户名(T+0) varchar(122)
        /// </summary>
        [XmlElement("accNm2")]
        public string AccNm2 { get; set; }
        /// <summary>
        /// 己方客户内部账号(T+0) varchar(19)
        /// </summary>
        [XmlElement("accNo3")]
        public string AccNo3 { get; set; }
        /// <summary>
        /// 己方客户内部账户名(T+0) varchar(122)
        /// </summary>
        [XmlElement("accNm3")]
        public string AccNm3 { get; set; }
        /// <summary>
        /// 对方客户内部账号(T+0) varchar(19)
        /// </summary>
        [XmlElement("otherRaccNo3")]
        public string OtherRaccNo3 { get; set; }
        /// <summary>
        /// 对方客户内部账户名(T+0)  varchar(122)
        /// </summary>
        [XmlElement("otherRaccNm3")]
        public string OtherRaccNm3 { get; set; }
        /// <summary>
        /// 交易币种(T+0)  varchar(3)
        /// </summary>
        [XmlElement("cryType1")]
        public string CryType1 { get; set; }
        /// <summary>
        /// 钞汇标识(T+0)  varchar(1)
        /// </summary>
        [XmlElement("cashFlag1")]
        public string CashFlag1 { get; set; }
        /// <summary>
        /// 账户序号(T+0)  varchar(6)
        /// </summary>
        [XmlElement("accSeq1")]
        public string AccSeq1 { get; set; }
        /// <summary>
        /// 对手方交易币种(T+0) varchar(3)
        /// </summary>
        [XmlElement("cryType2")]
        public string CryType2 { get; set; }
        /// <summary>
        /// 对手方钞汇标识(T+0) varchar(1)
        /// </summary>
        [XmlElement("cashFlag2")]
        public string CashFlag2 { get; set; }
        /// <summary>
        /// 对手方账户序号(T+0) varchar(6)
        /// </summary>
        [XmlElement("accSeq2")]
        public string AccSeq2 { get; set; }
    }
}
