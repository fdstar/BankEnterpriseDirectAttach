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
    /// 业务通知查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMBNQ : RsBase
    {
        /// <summary>
        /// 总记录数 char(3)
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillNotice> List { get; set; }
    }
    /// <summary>
    /// 业务通知
    /// </summary>
    public class BillNotice
    {
        /// <summary>
        /// 通知类型 char(4) 见附录4.1.11
        /// </summary>
        [XmlElement("INFOTYP")]
        public string INFOTYP { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
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
        /// 通知日期 char(8)格式YYYYMMDD 下发通知日期，即系统收到通知的日期
        /// </summary>
        [XmlIgnore]
        public DateTime OCCURDT { get; set; }
        /// <summary>
        /// 通知日期 char(8)格式YYYYMMDD, 对应<see cref="OCCURDT"/>
        /// </summary>
        [XmlElement("OCCURDT")]
        public string OCCURDTStr
        {
            get
            {
                return this.OCCURDT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OCCURDT = tmp;
                }
            }
        }
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
        /// 申请人行号 varchar(20)，可空
        /// </summary>
        [XmlElement("APPBNM")]
        public string APPBNM { get; set; }
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
        /// 接收人行号 varchar(20)，可空
        /// </summary>
        [XmlElement("RCVBNM")]
        public string RCVBNM { get; set; }
        /// <summary>
        /// 业务发生日期 char(8)格式YYYYMMDD 撤票日期、保证签收日期、同意清偿日期
        /// </summary>
        [XmlIgnore]
        public DateTime TRANDAT { get; set; }
        /// <summary>
        /// 业务发生日期 char(8)格式YYYYMMDD, 对应<see cref="TRANDAT"/>
        /// </summary>
        [XmlElement("TRANDAT")]
        public string TRANDATStr
        {
            get
            {
                return this.TRANDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TRANDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 处理结果 char(7)
        /// </summary>
        [XmlElement("PROCNUM")]
        public string PROCNUM { get; set; }
        /// <summary>
        /// 处理信息 varchar(256)
        /// </summary>
        [XmlElement("PROCINF")]
        public string PROCINF { get; set; }
        /// <summary>
        /// 票据交易状态 char(3) 见附录4.1.7
        /// </summary>
        [XmlElement("TRASTAT")]
        public string TRASTAT { get; set; }
    }
}