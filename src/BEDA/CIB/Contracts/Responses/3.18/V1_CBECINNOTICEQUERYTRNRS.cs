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
    /// 3.18.10跨境电商收汇通知查询响应主体
    /// </summary>
    public class V1_CBECINNOTICEQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.18.10跨境电商收汇通知查询响应主体
        /// </summary>
        public CBECINNOTICEQUERYTRNRS CBECINNOTICEQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.18.10跨境电商收汇通知查询响应主体
    /// </summary>
    public class CBECINNOTICEQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.18.10跨境电商收汇通知查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public CBECINNOTICEQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.18.10跨境电商收汇通知查询响应内容
    /// </summary>
    public class CBECINNOTICEQUERYTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.18.10跨境电商收汇通知查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 1)]
        public List<CBECINNOTICEQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.18.10跨境电商收汇通知查询响应明细
    /// </summary>
    public class CBECINNOTICEQUERYTRN_CONTENT
    {
        /// <summary>
        /// 地区机构号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string BRANCH_NO { get; set; }
        /// <summary>
        /// 网银客户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string NCID { get; set; }
        /// <summary>
        /// 核心客户号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CID { get; set; }
        /// <summary>
        /// STL业务编号	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string STL_BIZ_NO { get; set; }
        /// <summary>
        /// 业务创建日期	必回
        /// </summary>
        [XmlIgnore]
        public DateTime BIZ_DATE { get; set; }
        /// <summary>
        /// 业务创建日期, 对应<see cref="BIZ_DATE"/>	必回
        /// </summary>
        [XmlElement("BIZ_DATE", Order = 4)]
        public string BIZ_DATEStr
        {
            get
            {
                return this.BIZ_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BIZ_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 通知时间	必回
        /// </summary>
        [XmlIgnore]
        public DateTime CREATE_DATE { get; set; }
        /// <summary>
        /// 通知时间, 对应<see cref="CREATE_DATE"/>	必回
        /// </summary>
        [XmlElement("CREATE_DATE", Order = 5)]
        public string CREATE_DATEStr
        {
            get
            {
                return this.CREATE_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CREATE_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 业务类型  集中收汇:JZS； 轧差收汇:GCS 必回
        /// </summary>
        [XmlElement(Order = 6)]
        public string BUSN_TYPE { get; set; }
        /// <summary>
        /// 国际收支申报编号	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public string BLNC_PYMT_NO { get; set; }
        /// <summary>
        /// 汇款币种	必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string CURRENCY { get; set; }
        /// <summary>
        /// 汇款金额	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal REMIT_AMOUNT { get; set; }
        /// <summary>
        /// 原始汇款币种	非必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string ORGNL_CURRENCY { get; set; }
        /// <summary>
        /// 原始汇款金额	非必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal ORGNL_AMT { get; set; }
        /// <summary>
        /// 汇款人账号	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string REMITTER_ACCT_NO { get; set; }
        /// <summary>
        /// 汇款人名称	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public string REMITTER_ACCT_NAME { get; set; }
        /// <summary>
        /// 收款人账号	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string PAYEE_ACCT_NO { get; set; }
        /// <summary>
        /// 收款人客户号或SWIFT CODE	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string PAYEE_NCID { get; set; }
        /// <summary>
        /// 收款人名称及地址	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string PAYEE_ACCT_NAME { get; set; }
        /// <summary>
        /// 汇款人开户银行账号或清算代码	非必回
        /// </summary>
        [XmlElement(Order = 17)]
        public string REMITTER_BANK_NO { get; set; }
        /// <summary>
        /// 汇款人开户银行SWIFT CODE	非必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string REMITTER_SWIFT_CODE { get; set; }
        /// <summary>
        /// 汇款人开户银行名称及地址	非必回
        /// </summary>
        [XmlElement(Order = 19)]
        public string REMITTER_BANK_NAME { get; set; }
        /// <summary>
        /// 发报行致收报行信息	非必回
        /// </summary>
        [XmlElement(Order = 20)]
        public string SEND_MSG { get; set; }
        /// <summary>
        /// 费用承担  非必回
        /// BEN-Beneficiary Customer
        /// OUR-Ordering Customer
        /// SHA-Shared
        /// </summary>
        [XmlElement(Order = 21)]
        public string BEAR_EXPENSES { get; set; }
        /// <summary>
        /// 费用币别	非必回
        /// </summary>
        [XmlElement(Order = 22)]
        public string BEAR_CURRENCY { get; set; }
        /// <summary>
        /// 费用金额	非必回
        /// </summary>
        [XmlElement(Order = 23)]
        public decimal? BEAR_AMOUNT { get; set; }
        /// <summary>
        /// 汇款附言	非必回
        /// </summary>
        [XmlElement(Order = 24)]
        public string REMIT_MEMO { get; set; }
        /// <summary>
        /// 结算方式  必回
        /// L－信用证
        /// G－保函
        /// C－托收
        /// T－电汇
        /// D－票汇
        /// M－信汇
        /// O－其他
        /// </summary>
        [XmlElement(Order = 25)]
        public string SETTLE_WAY { get; set; }
        /// <summary>
        /// 汇款人常驻国家（地区）代码	必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string COUNTRY_CODE { get; set; }
    }
}
