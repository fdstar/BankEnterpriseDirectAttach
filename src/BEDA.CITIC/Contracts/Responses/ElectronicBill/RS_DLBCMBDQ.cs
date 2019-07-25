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
    /// 票据信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMBDQ : RsBase
    {
        /// <summary>
        /// 总记录数 char(4)
        /// </summary>
        [XmlElement("totalNum")]
        public int TotalNum { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillInfo> List { get; set; }
    }
    /// <summary>
    /// 票据信息
    /// </summary>
    public class BillInfo
    {
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("BILLNUM")]
        public string BILLNUM { get; set; }
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
        /// 转让标记 char(4)，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("ENDORMK")]
        public string ENDORMK { get; set; }
        /// <summary>
        /// 出票人类型 char(4)，见附录：4.1.5
        /// </summary>
        [XmlElement("DRWRTYP")]
        public string DRWRTYP { get; set; }
        /// <summary>
        /// 出票人名称 varchar(122)，可空
        /// </summary>
        [XmlElement("DRWRNAM")]
        public string DRWRNAM { get; set; }
        /// <summary>
        /// 出票人组织机构代码证 varchar(20)
        /// </summary>
        [XmlElement("DRWRCOD")]
        public string DRWRCOD { get; set; }
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
        /// 出票人评级机构 varchar(60)
        /// </summary>
        [XmlElement("DRRAGCY")]
        public string DRRAGCY { get; set; }
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
        /// 承兑人类型 char(4)， 见附录4.1.5
        /// </summary>
        [XmlElement("ACCPTYP")]
        public string ACCPTYP { get; set; }
        /// <summary>
        /// 承兑人名称 varchar(122)
        /// </summary>
        [XmlElement("ACCPNAM")]
        public string ACCPNAM { get; set; }
        /// <summary>
        /// 承兑人组织机构代码证 char(20)
        /// </summary>
        [XmlElement("ACCPCOD")]
        public string ACCPCOD { get; set; }
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
        /// 收款人类型 char(4)， 见附录4.1.5
        /// </summary>
        [XmlElement("PYEETYP")]
        public string PYEETYP { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)
        /// </summary>
        [XmlElement("PYEENAM")]
        public string PYEENAM { get; set; }
        /// <summary>
        /// 收款人组织机构代码证 char(20)
        /// </summary>
        [XmlElement("PYEECOD")]
        public string PYEECOD { get; set; }
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
        /// 票据状态 char(6)，见附录4.1.8 
        /// </summary>
        [XmlElement("BILSTAT")]
        public string BILSTAT { get; set; }
    }
}