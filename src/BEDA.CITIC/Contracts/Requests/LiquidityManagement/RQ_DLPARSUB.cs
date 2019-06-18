using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 现金池自动规则管理经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLPARSUB : RqBase<RS_DLPARSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLPARSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 现金池ID  char(8) 由现金池信息查询结果获取
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 交易类型char(1) 0：自动归集参数；1自动下拨参数；2：联动下拨参数
        /// </summary>
        [XmlElement("tranType")]
        public int TranType { get; set; }
        /// <summary>
        /// 下次归集日期 char(8) 交易类型为0时非空， 格式YYYYMMDD
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
        /// 下次下拨日期 char(8)交易类型为1时非空， 格式YYYYMMDD
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
        /// 启动联动下拨预约标志 char(1) 交易类型为2时非空0：非预约；1：预约
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 启用联动预约时间
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 启用联动预约日期char(8) 延期启动联动时非空，格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 启用联动预约时间char(6) 延期启动联动时非空，格式hhmmss
        /// </summary>
        [XmlElement("preTime")]
        public string PreTimeStr
        {
            get
            {
                return this.AppointmentTime?.ToString("HHmmss");
            }
            set { }
        }
    }
}
