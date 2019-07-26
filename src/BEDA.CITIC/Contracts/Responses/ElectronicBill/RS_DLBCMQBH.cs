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
    /// 票据历史信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMQBH : RsBase
    {
        /// <summary>
        /// 总记录数 char(4)
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 票据类型 char(4) AC01银承，AC02商承
        /// </summary>
        [XmlElement("BILLTYP")]
        public string BILLTYP { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillHistory> List { get; set; }
    }
    /// <summary>
    /// 票据历史信息
    /// </summary>
    public class BillHistory
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
        /// 请求方类别 char(4) 见附录4.1.5
        /// </summary>
        [XmlElement("APPTYPE")]
        public string APPTYPE { get; set; }
        /// <summary>
        /// 请求方名称 varchar(122)
        /// </summary>
        [XmlElement("APPNAME")]
        public string APPNAME { get; set; }
        /// <summary>
        /// 请求方组织机构代码 char(20)
        /// </summary>
        [XmlElement("APPCODE")]
        public string APPCODE { get; set; }
        /// <summary>
        /// 请求方账号 char(32)
        /// </summary>
        [XmlElement("APPACCT")]
        public string APPACCT { get; set; }
        /// <summary>
        /// 请求方备注 varchar(256)
        /// </summary>
        [XmlElement("APPMEMO")]
        public string APPMEMO { get; set; }
        /// <summary>
        /// 接收方类别 char(4) 见附录4.1.5
        /// </summary>
        [XmlElement("RCVTYPE")]
        public string RCVTYPE { get; set; }
        /// <summary>
        /// 接收方名称 varchar(122)
        /// </summary>
        [XmlElement("RCVNAME")]
        public string RCVNAME { get; set; }
        /// <summary>
        /// 接收方组织机构代码 char(20)
        /// </summary>
        [XmlElement("RCVCODE")]
        public string RCVCODE { get; set; }
        /// <summary>
        /// 接收方账号 char(32)
        /// </summary>
        [XmlElement("RCVACCT")]
        public string RCVACCT { get; set; }
        /// <summary>
        /// 接收方备注 varchar(256)
        /// </summary>
        [XmlElement("RCVMEMO")]
        public string RCVMEMO { get; set; }
        /// <summary>
        /// 签收日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime SGNRDAT { get; set; }
        /// <summary>
        /// 签收日期 char(8) 格式YYYYMMDD, 对应<see cref="SGNRDAT"/>
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
        /// 清算方式 char(4)，可空，SM00线上清算，SM01线下清算
        /// </summary>
        [XmlElement("STLMTHD")]
        public string STLMTHD { get; set; }
        /// <summary>
        /// 不得转让标记 char(4)，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("ENDORMK")]
        public string ENDORMK { get; set; }
        /// <summary>
        /// 利率 decimal(9，7)
        /// </summary>
        [XmlElement("INTRRAT")]
        public decimal INTRRAT { get; set; }
        /// <summary>
        /// 赎回利率 decimal(9，7)
        /// </summary>
        [XmlElement("RPDRATE")]
        public decimal RPDRATE { get; set; }
        /// <summary>
        /// 金额 decimal(15，2)
        /// </summary>
        [XmlElement("REALAMT")]
        public decimal REALAMT { get; set; }
        /// <summary>
        /// 赎回实付金额 decimal(15，2)
        /// </summary>
        [XmlElement("RPDAMNT")]
        public decimal RPDAMNT { get; set; }
        /// <summary>
        /// 贴现种类 char(4)，RM00买断式，RM01回购式
        /// </summary>
        [XmlElement("DSNTTYP")]
        public string DSNTTYP { get; set; }
        /// <summary>
        /// 赎回开放日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? RPDOPDT { get; set; }
        /// <summary>
        /// 赎回开放日 char(8) 格式YYYYMMDD, 对应<see cref="RPDOPDT"/>
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
        /// 赎回截止日 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? RPDDUDT { get; set; }
        /// <summary>
        /// 赎回截止日 char(8) 格式YYYYMMDD, 对应<see cref="RPDDUDT"/>
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
        /// 申请日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime APPDATE { get; set; }
        /// <summary>
        /// 申请日期 char(8) 格式YYYYMMDD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE")]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 提示付款金额 decimal(15，2)
        /// </summary>
        [XmlElement("PPAYAMT")]
        public decimal PPAYAMT { get; set; }
        /// <summary>
        /// 拒付理由代码 char(4) 见附录4.1.6
        /// </summary>
        [XmlElement("DSHNRCD")]
        public string DSHNRCD { get; set; }
        /// <summary>
        /// 拒付备注信息 varchar(256)
        /// </summary>
        [XmlElement("DSHNRSN")]
        public string DSHNRSN { get; set; }
        /// <summary>
        /// 逾期原因说明 varchar(256)
        /// </summary>
        [XmlElement("ODUERSN")]
        public string ODUERSN { get; set; }
        /// <summary>
        /// 追索类型 char(4)，RT00拒付追索，RT01非拒付追索
        /// </summary>
        [XmlElement("RCRSTYP")]
        public string RCRSTYP { get; set; }
        /// <summary>
        /// 清偿日期 char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? AGRRDAT { get; set; }
        /// <summary>
        /// 清偿日期 char(8) 格式YYYYMMDD, 对应<see cref="AGRRDAT"/>
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
        /// 背面备注 varchar(256)
        /// </summary>
        [XmlElement("BACKMEM")]
        public string BACKMEM { get; set; }
        /// <summary>
        /// 保证人地址 varchar(256)
        /// </summary>
        [XmlElement("WAREADR")]
        public string WAREADR { get; set; }
        /// <summary>
        /// 承兑人信用等级 char(3)
        /// </summary>
        [XmlElement("ACCDRAT")]
        public string ACCDRAT { get; set; }
        /// <summary>
        /// 承兑人评级机构 char(20)
        /// </summary>
        [XmlElement("ACRAGCY")]
        public string ACRAGCY { get; set; }
        /// <summary>
        /// 承兑人评级到期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? ACRADAT { get; set; }
        /// <summary>
        /// 承兑人评级到期char(8) 格式YYYYMMDD, 对应<see cref="ACRADAT"/>
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
        /// 合同编号 char(32)
        /// </summary>
        [XmlElement("CONTRACTNO")]
        public string CONTRACTNO { get; set; }
        /// <summary>
        /// 发票编号 char(20)
        /// </summary>
        [XmlElement("INVOICENO")]
        public string INVOICENO { get; set; }
    }
}