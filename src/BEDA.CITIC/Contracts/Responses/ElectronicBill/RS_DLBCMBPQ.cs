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
    /// 票据正面信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMBPQ : RsBase
    {
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 出票人承诺 varchar(256)
        /// </summary>
        [XmlElement("DRUNCNPAY")]
        public string DRUNCNPAY { get; set; }
        /// <summary>
        /// 出票日 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime ISSDATE { get; set; }
        /// <summary>
        /// 出票日 char(8)格式YYYYMMDD, 对应<see cref="ISSDATE"/>
        /// </summary>
        [XmlElement("ISSDATE")]
        public string ISSDATEStr
        {
            get
            {
                return this.ISSDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISSDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到期日 char(8)格式YYYYMMDD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE")]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据状态 char(6)，见附录4.1.8 
        /// </summary>
        [XmlElement("BILSTAT")]
        public string BILSTAT { get; set; }
        /// <summary>
        /// 票据类型 char(4)，AC01银承，AC02商承
        /// </summary>
        [XmlElement("BILLTYP")]
        public string BILLTYP { get; set; }
        /// <summary>
        /// 票面金额 decimal(15，2)
        /// </summary>
        [XmlElement("PAYAMT")]
        public decimal PAYAMT { get; set; }
        /// <summary>
        /// 出票人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("DRWRNAM")]
        public string DRWRNAM { get; set; }
        /// <summary>
        /// 出票人开户账号 char(32)
        /// </summary>
        [XmlElement("DRWRACC")]
        public string DRWRACC { get; set; }
        /// <summary>
        /// 出票人开户行行号 varchar(20)
        /// </summary>
        [XmlElement("DRWRBNM")]
        public string DRWRBNM { get; set; }
        /// <summary>
        /// 出票人信用等级 char(3)
        /// </summary>
        [XmlElement("DRCDRAT")]
        public string DRCDRAT { get; set; }
        /// <summary>
        /// 出票人评级到期日 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? RDUEDAT { get; set; }
        /// <summary>
        /// 出票人评级到期日 char(8)格式YYYYMMDD, 对应<see cref="RDUEDAT"/>
        /// </summary>
        [XmlElement("RDUEDAT")]
        public string RDUEDATStr
        {
            get
            {
                return this.RDUEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RDUEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RDUEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人评级主体 char(20)
        /// </summary>
        [XmlElement("DRRAGCY")]
        public string DRRAGCY { get; set; }
        /// <summary>
        /// 能否转让 char(4)，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("DFENDMK")]
        public string DFENDMK { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)
        /// </summary>
        [XmlElement("PYEENAM")]
        public string PYEENAM { get; set; }
        /// <summary>
        /// 收款人开户账号 char(32)
        /// </summary>
        [XmlElement("PYEEACC")]
        public string PYEEACC { get; set; }
        /// <summary>
        /// 收款人开户行行号 varchar(20)
        /// </summary>
        [XmlElement("PYEEBNM")]
        public string PYEEBNM { get; set; }
        /// <summary>
        /// 交易合同号 char(32)
        /// </summary>
        [XmlElement("CONTRNM")]
        public string CONTRNM { get; set; }
        /// <summary>
        /// 承兑人名称 varchar(122)
        /// </summary>
        [XmlElement("ACCPNAM")]
        public string ACCPNAM { get; set; }
        /// <summary>
        /// 承兑人开户账号 char(32)
        /// </summary>
        [XmlElement("ACCPACC")]
        public string ACCPACC { get; set; }
        /// <summary>
        /// 承兑人开户行行号 varchar(20)
        /// </summary>
        [XmlElement("ACCPBNM")]
        public string ACCPBNM { get; set; }
        /// <summary>
        /// 承兑日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime SGNRDAT { get; set; }
        /// <summary>
        /// 承兑日期 char(8) 格式YYYYMMDD, 对应<see cref="SGNRDAT"/>
        /// </summary>
        [XmlElement("SGNRDAT")]
        public string SGNRDATStr
        {
            get
            {
                return this.SGNRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SGNRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑人评级主体 char(20)
        /// </summary>
        [XmlElement("ACRAGCY")]
        public string ACRAGCY { get; set; }
        /// <summary>
        /// 承兑人信用等级 char(3)
        /// </summary>
        [XmlElement("ACCDRAT")]
        public string ACCDRAT { get; set; }
        /// <summary>
        /// 承兑人评级到期日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? ACRADAT { get; set; }
        /// <summary>
        /// 承兑人评级到期日 char(8) 格式YYYYMMDD, 对应<see cref="ACRADAT"/>
        /// </summary>
        [XmlElement("ACRADAT")]
        public string ACRADATStr
        {
            get
            {
                return this.ACRADAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ACRADAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACRADAT = tmp;
                }
            }
        }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public List<CITICCollection<GuarantorInfo>> List { get; set; }
    }
    /// <summary>
    /// 保证人信息
    /// </summary>
    public class GuarantorInfo
    {
        /// <summary>
        /// 出票保证人名称 varchar(122)
        /// </summary>
        [XmlElement("DRGRTNAM")]
        public string DRGRTNAM { get; set; }
        /// <summary>
        /// 出票保证人地址 varchar(256)
        /// </summary>
        [XmlElement("DRGRTADR")]
        public string DRGRTADR { get; set; }
        /// <summary>
        /// 出票保证人日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? DRGRTDAT { get; set; }
        /// <summary>
        /// 出票保证人日期 char(8) 格式YYYYMMDD, 对应<see cref="DRGRTDAT"/>
        /// </summary>
        [XmlElement("DRGRTDAT")]
        public string DRGRTDATStr
        {
            get
            {
                return this.DRGRTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.DRGRTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRGRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑保证人名称 varchar(122)
        /// </summary>
        [XmlElement("ACGRTNAM")]
        public string ACGRTNAM { get; set; }
        /// <summary>
        /// 承兑保证人地址 varchar(256)
        /// </summary>
        [XmlElement("ACGRTADR")]
        public string ACGRTADR { get; set; }
        /// <summary>
        /// 承兑保证人日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? ACGRTDAT { get; set; }
        /// <summary>
        /// 承兑保证人日期 char(8) 格式YYYYMMDD, 对应<see cref="ACGRTDAT"/>
        /// </summary>
        [XmlElement("ACGRTDAT")]
        public string ACGRTDATStr
        {
            get
            {
                return this.ACGRTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ACGRTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACGRTDAT = tmp;
                }
            }
        }
    }
}