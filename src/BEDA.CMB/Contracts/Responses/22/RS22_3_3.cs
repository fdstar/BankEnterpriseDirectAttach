using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 22.3.3.票据查询查复响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILRQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILRQY";
        /// <summary>
        /// 22.3.3.票据查询查复响应内容
        /// </summary>
        public NTBILRQYZ0 NTBILRQYZ0 { get; set; }
        /// <summary>
        /// 22.3.3.票据查询查复响应集合
        /// </summary>
        [XmlElement("NTBILRQYZ1")]
        public List<NTBILRQYZ1> List { get; set; }
    }
    /// <summary>
    /// 22.3.3.票据查询查复响应内容
    /// </summary>
    public class NTBILRQYZ0
    {
        /// <summary>
        /// 平台流水号	c(15)
        /// </summary>
        public string SELNBR { get; set; }
        /// <summary>
        /// 总金额	M
        /// </summary>
        public decimal TTLAMT { get; set; }
        /// <summary>
        /// 总笔数	F(6,0)
        /// </summary>
        public int TTLNUM { get; set; }
    }
    /// <summary>
    /// 22.3.3.票据查询查复响应内容
    /// </summary>
    public class NTBILRQYZ1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 申请账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据标示号	C(20)
        /// </summary>
        public string BILSYN { get; set; }
        /// <summary>
        /// 票据种类	C(1)
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票据类型	C(1)    0纸质票据 1电子票据 目前只有‘0’
        /// </summary>
        public string BILKND { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 托管日期	D
        /// </summary>
        public string INPDAT { get; set; }
        /// <summary>
        /// 托管时间	T
        /// </summary>
        public string INPTIM { get; set; }
        /// <summary>
        /// 托管时间 由<see cref="INPDAT"/>和<see cref="INPTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TrusteeshipTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.INPDAT, this.INPTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 托管机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 出票日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 出票日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 银票出票人或商票付款人	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 付款行名称/付款人开户行名称	Z(62)
        /// </summary>
        public string PAYBNK { get; set; }
        /// <summary>
        /// 收款人全称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 查询书编号	C(20)
        /// </summary>
        public string RQSNBR { get; set; }
        /// <summary>
        /// 查询日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RQSDAT { get; set; }
        /// <summary>
        /// 查询日期	D, 对应<see cref="RQSDAT"/>
        /// </summary>
        [XmlElement("RQSDAT")]
        public string RQSDATStr
        {
            get
            {
                return this.RQSDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RQSDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RQSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 查复书号码	C(20)
        /// </summary>
        public string RPYNBR { get; set; }
        /// <summary>
        /// 查复日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RPYDAT { get; set; }
        /// <summary>
        /// 查复日期	D, 对应<see cref="RPYDAT"/>
        /// </summary>
        [XmlElement("RPYDAT")]
        public string RPYDATStr
        {
            get
            {
                return this.RPYDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RPYDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RPYDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 票据状态	C(1)    
        /// 0待银行处理;
        /// 1正常;
        /// 2公示催告;
        /// 3挂失止付
        /// </summary>
        public string BILSTS { get; set; }
    }
}
