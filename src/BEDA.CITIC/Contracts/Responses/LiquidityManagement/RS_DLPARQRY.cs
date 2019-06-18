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
    /// 现金池自动规则管理经办结果查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPARQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CashPoolAutoRuleResult> List { get; set; }
    }
    /// <summary>
    /// 现金池自动规则管理经办结果
    /// </summary>
    public class CashPoolAutoRuleResult
    {
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 成员单位账户名称 varchar(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 交易类型char(1) 0：自动归集参数设置；1自动下拨参数设置；2：联动下拨参数设置
        /// </summary>
        [XmlElement("tranType")]
        public int TranType { get; set; }
        /// <summary>
        /// 下次归集日期 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? NextCollDate { get; set; }
        /// <summary>
        /// 下次归集日期, 对应<see cref="NextCollDate"/>
        /// </summary>
        [XmlElement("nextCollDate")]
        public string NextCollDateStr
        {
            get
            {
                return this.NextCollDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.NextCollDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NextCollDate = tmp;
                }
            }
        }
        /// <summary>
        /// 下次下拨日期 char(8)格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime? NextPayDate { get; set; }
        /// <summary>
        /// 下次下拨日期, 对应<see cref="NextPayDate"/>
        /// </summary>
        [XmlElement("nextPayDate")]
        public string NextPayDateStr
        {
            get
            {
                return this.NextPayDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.NextPayDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NextPayDate = tmp;
                }
            }
        }
        /// <summary>
        /// 联动自动拨款标志 char(1)交易类型为2时非空， 0：不自动拨款；1：自动拨款
        /// </summary>
        [XmlElement("relatePayFlag")]
        public int RelatePayFlag { get; set; }
        /// <summary>
        /// 预约标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDate { get; set; }
        /// <summary>
        /// 预约时间char(6)，格式hhmmss
        /// </summary>
        [XmlElement("preTime")]
        public string PreTime { get; set; }
        /// <summary>
        /// 预约时间 由<see cref="PreDate"/>和<see cref="PreTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.PreDate, this.PreTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 经办人姓名 varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 经办日期char(8) 格式：YYYYMMDD
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDate { get; set; }
        /// <summary>
        /// 经办时间 char(6)  格式：hhmmss
        /// </summary>
        [XmlElement("operateTime")]
        public string OperateTime { get; set; }
        /// <summary>
        /// 经办时间 由<see cref="OperateDate"/>和<see cref="OperateTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OperateDate, this.OperateTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 制单状态 varchar(2) 状态取值见附录4.2
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
