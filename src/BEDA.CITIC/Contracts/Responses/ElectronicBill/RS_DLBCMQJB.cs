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
    /// 可操作票据查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMQJB : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillInfo> List { get; set; }
    }
    /// <summary>
    /// 票据利息
    /// </summary>
    public class BillInfo
    {
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 操作类型 char(2)，见附录4.1.4
        /// </summary>
        [XmlElement("INFOTYPE")]
        public string INFOTYPE { get; set; }
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
        /// 转让标记 char(4)，可空，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("ENDORMK")]
        public string ENDORMK { get; set; }
        /// <summary>
        /// 到期无条件支付委托 char(4)，可空，若不为空只能是CC00
        /// </summary>
        [XmlElement("UNCNPAY")]
        public string UNCNPAY { get; set; }
        /// <summary>
        /// 业务流水标识 char(10)，可空
        /// </summary>
        [XmlElement("BUSSQNO")]
        public string BUSSQNO { get; set; }
        /// <summary>
        /// 出票人类型 char(4)，可空，见附录：4.1.5
        /// </summary>
        [XmlElement("DRWRTYP")]
        public string DRWRTYP { get; set; }
        /// <summary>
        /// 出票人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("DRWRNAM")]
        public string DRWRNAM { get; set; }
        /// <summary>
        /// 出票人组织机构代码证 varchar(20)，可空
        /// </summary>
        [XmlElement("DRWRCOD")]
        public string DRWRCOD { get; set; }
        /// <summary>
        /// 出票人开户账号 char(32)，可空
        /// </summary>
        [XmlElement("DRWRACC")]
        public string DRWRACC { get; set; }
        /// <summary>
        /// 出票人开户行行号 varchar(20)，可空
        /// </summary>
        [XmlElement("DRWRBNM")]
        public string DRWRBNM { get; set; }
        /// <summary>
        /// 出票人信用等级 char(3)，可空
        /// </summary>
        [XmlElement("DRCDRAT")]
        public string DRCDRAT { get; set; }
        /// <summary>
        /// 出票人评级机构 varchar(60)，可空
        /// </summary>
        [XmlElement("DRRAGCY")]
        public string DRRAGCY { get; set; }
        /// <summary>
        /// 出票人评级到期日 char(8)格式YYYYMMDD，可空
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
        /// 承兑人类型 char(4)，可空 见附录4.1.5
        /// </summary>
        [XmlElement("ACCPTYP")]
        public string ACCPTYP { get; set; }
        /// <summary>
        /// 承兑人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("ACCPNAM")]
        public string ACCPNAM { get; set; }
        /// <summary>
        /// 承兑人组织机构代码证 char(20)，可空
        /// </summary>
        [XmlElement("ACCPCOD")]
        public string ACCPCOD { get; set; }
        /// <summary>
        /// 承兑人开户账号 char(32)，可空
        /// </summary>
        [XmlElement("ACCPACC")]
        public string ACCPACC { get; set; }
        /// <summary>
        /// 承兑人开户行行号 varchar(20)，可空
        /// </summary>
        [XmlElement("ACCPBNM")]
        public string ACCPBNM { get; set; }
        /// <summary>
        /// 收款人类型 char(4)，可空 见附录4.1.5
        /// </summary>
        [XmlElement("PYEETYP")]
        public string PYEETYP { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("PYEENAM")]
        public string PYEENAM { get; set; }
        /// <summary>
        /// 收款人组织机构代码证 char(20)，可空
        /// </summary>
        [XmlElement("PYEECOD")]
        public string PYEECOD { get; set; }
        /// <summary>
        /// 收款人开户账号 char(32)，可空
        /// </summary>
        [XmlElement("PYEEACC")]
        public string PYEEACC { get; set; }
        /// <summary>
        /// 收款人开户行行号 varchar(20)，可空
        /// </summary>
        [XmlElement("PYEEBNM")]
        public string PYEEBNM { get; set; }
        /// <summary>
        /// 票据状态 char(6)，可空，见附录4.1.8 
        /// </summary>
        [XmlElement("BILSTAT")]
        public string BILSTAT { get; set; }
        /// <summary>
        /// 申请日期 长度 char(8)格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? APPDATE { get; set; }
        /// <summary>
        /// 申请日期 长度 char(8)格式YYYYMMDD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE")]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE?.ToString("yyyyMMdd");
            }
            set
            {
                this.APPDATE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 申请人类型 char(4)，可空 见附录4.1.5
        /// </summary>
        [XmlElement("APPTYPE")]
        public string APPTYPE { get; set; }
        /// <summary>
        /// 申请人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("APPNAME")]
        public string APPNAME { get; set; }
        /// <summary>
        /// 申请人账号 char(32)，可空
        /// </summary>
        [XmlElement("APPACCT")]
        public string APPACCT { get; set; }
        /// <summary>
        /// 申请人组织机构代码 char(20)，可空
        /// </summary>
        [XmlElement("APPCODE")]
        public string APPCODE { get; set; }
        /// <summary>
        /// 申请人行号 varchar(20)，可空
        /// </summary>
        [XmlElement("APPBNM")]
        public string APPBNM { get; set; }
        /// <summary>
        /// 接收人类型 char(4)，可空，见附录4.1.5
        /// </summary>
        [XmlElement("RCVTYPE")]
        public string RCVTYPE { get; set; }
        /// <summary>
        /// 接收人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("RCVNAME")]
        public string RCVNAME { get; set; }
        /// <summary>
        /// 接收人账号 char(32)，可空
        /// </summary>
        [XmlElement("RCVACCT")]
        public string RCVACCT { get; set; }
        /// <summary>
        /// 接收人组织机构代码 char(20)，可空
        /// </summary>
        [XmlElement("RCVCODE")]
        public string RCVCODE { get; set; }
        /// <summary>
        /// 接收人行号 varchar(20)，可空
        /// </summary>
        [XmlElement("RCVBNM")]
        public string RCVBNM { get; set; }
        /// <summary>
        /// 贴现类型 char(4)，可空，RM00买断式，RM01回购式
        /// </summary>
        [XmlElement("RPDMARK")]
        public string RPDMARK { get; set; }
        /// <summary>
        /// 交易类型 char(4)，可空，TT00贴现，TT01转贴现，TT02再贴现，TT03贴现(本行)
        /// </summary>
        [XmlElement("TRANTYP")]
        public string TRANTYP { get; set; }
        /// <summary>
        /// 贴现利率 decimal(9，7)，可空
        /// </summary>
        [XmlElement("INTRRAT")]
        public decimal? INTRRAT { get; set; }
        /// <summary>
        /// 实付金额 decimal(15，2)，可空
        /// </summary>
        [XmlElement("REALAMT")]
        public decimal? REALAMT { get; set; }
        /// <summary>
        /// 回购起始日 char(8)格式YYYYMMDD， 可空
        /// </summary>
        [XmlIgnore]
        public DateTime? RPDOPDT { get; set; }
        /// <summary>
        /// 回购起始日 char(8)格式YYYYMMDD, 对应<see cref="RPDOPDT"/>
        /// </summary>
        [XmlElement("RPDOPDT")]
        public string RPDOPDTStr
        {
            get
            {
                return this.RPDOPDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RPDOPDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RPDOPDT = tmp;
                }
            }
        }
        /// <summary>
        /// 回购到期日 char(8)格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? RPDDUDT { get; set; }
        /// <summary>
        /// 回购到期日 char(8)格式YYYYMMDD, 对应<see cref="RPDDUDT"/>
        /// </summary>
        [XmlElement("RPDDUDT")]
        public string RPDDUDTStr
        {
            get
            {
                return this.RPDDUDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RPDDUDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RPDDUDT = tmp;
                }
            }
        }
        /// <summary>
        /// 回购利率 decimal(9，7)，可空
        /// </summary>
        [XmlElement("RPDRATE")]
        public decimal? RPDRATE { get; set; }
        /// <summary>
        /// 回购实付金额 decimal(15，2)，可空
        /// </summary>
        [XmlElement("RPDAMNT")]
        public decimal? RPDAMNT { get; set; }
        /// <summary>
        /// 清算方式 char(4)，可空，SM00线上清算，SM01线下清算
        /// </summary>
        [XmlElement("STLMTHD")]
        public string STLMTHD { get; set; }
        /// <summary>
        /// 保证类型 char(4)，可空，GT00持票人保证，GT01承兑人保证，GT02背书保证
        /// </summary>
        [XmlElement("GUARTYP")]
        public string GUARTYP { get; set; }
        /// <summary>
        /// 拒付理由 char(4)，可空，见附录4.1.6
        /// </summary>
        [XmlElement("DSHNRCD")]
        public string DSHNRCD { get; set; }
        /// <summary>
        /// 拒付备注 varchar(256)，可空
        /// </summary>
        [XmlElement("DSHNRSN")]
        public string DSHNRSN { get; set; }
        /// <summary>
        /// 追索类型 char(4)，可空，RT00拒付追索，RT01非拒付追索
        /// </summary>
        [XmlElement("RCRSTYP")]
        public string RCRSTYP { get; set; }
        /// <summary>
        /// 追索日期 char(8)格式YYYYMMDD， 可空
        /// </summary>
        [XmlIgnore]
        public DateTime? RCRSDAT { get; set; }
        /// <summary>
        /// 追索日期 char(8)格式YYYYMMDD, 对应<see cref="RCRSDAT"/>
        /// </summary>
        [XmlElement("RCRSDAT")]
        public string RCRSDATStr
        {
            get
            {
                return this.RCRSDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RCRSDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCRSDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 追索金额 decimal(15，2)，可空
        /// </summary>
        [XmlElement("RCRSAMT")]
        public decimal? RCRSAMT { get; set; }
        /// <summary>
        /// 同意清偿日期 char(8)格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? AGRRDAT { get; set; }
        /// <summary>
        /// 同意清偿日期 char(8)格式YYYYMMDD, 对应<see cref="AGRRDAT"/>
        /// </summary>
        [XmlElement("AGRRDAT")]
        public string AGRRDATStr
        {
            get
            {
                return this.AGRRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.AGRRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.AGRRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 同意清偿金额 decimal(15，2)，可空
        /// </summary>
        [XmlElement("AGRRAMT")]
        public decimal? AGRRAMT { get; set; }
        /// <summary>
        /// 交易合同编号 char(30)，可空
        /// </summary>
        [XmlElement("CONTRACTNO")]
        public string CONTRACTNO { get; set; }
        /// <summary>
        /// 发票编号  char(30)，可空
        /// </summary>
        [XmlElement("INVOICENO")]
        public string INVOICENO { get; set; }
        /// <summary>
        /// 票据交易状态 char(3)，可空，见附录4.1.7
        /// </summary>
        [XmlElement("TRASTAT")]
        public string TRASTAT { get; set; }
        /// <summary>
        /// 交易日期 char(8)格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? TRANDAT { get; set; }
        /// <summary>
        /// 交易日期 char(8)格式YYYYMMDD, 对应<see cref="TRANDAT"/>
        /// </summary>
        [XmlElement("TRANDAT")]
        public string TRANDATStr
        {
            get
            {
                return this.TRANDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.TRANDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRANDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易流水号 char(20)，可空
        /// </summary>
        [XmlElement("TRANNUM")]
        public string TRANNUM { get; set; }
        /// <summary>
        /// 交易备注 varchar(256)，可空
        /// </summary>
        [XmlElement("MEMO")]
        public string MEMO { get; set; }
        /// <summary>
        /// ECDS批次号 char(10)，可空
        /// </summary>
        [XmlElement("ECDSBATNO")]
        public string ECDSBATNO { get; set; }
        /// <summary>
        /// 入账行行号 varchar(20)，可空
        /// </summary>
        [XmlElement("RECDBNM")]
        public string RECDBNM { get; set; }
        /// <summary>
        /// 票面转让标志 char(4)，可空，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("DFENDMK")]
        public string DFENDMK { get; set; }
        /// <summary>
        /// 追索理由代码 char(4)，可空，非拒付追索时填写， RC00承兑人被依法宣告破产，RC01 承兑人因违法被责令终止活动
        /// </summary>
        [XmlElement("RCRSBCD")]
        public string RCRSBCD { get; set; }
        /// <summary>
        /// 逾期原因说明 varchar(256)，可空
        /// </summary>
        [XmlElement("ODUERSN")]
        public string ODUERSN { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("CRYTYPE")]
        public string CRYTYPE { get; set; }
    }
}