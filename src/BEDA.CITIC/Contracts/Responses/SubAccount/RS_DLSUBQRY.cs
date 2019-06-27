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
    /// 附属账户参数设置查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSUBQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountParameters> List { get; set; }
    }
    /// <summary>
    /// 附属账户参数设置
    /// </summary>
    public class SubAccountParameters
    {
        /// <summary>
        /// 批次号 varchar(10)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 附属账户名称 varchar(122)
        /// </summary>
        [XmlElement("subAccNm")]
        public string SubAccNm { get; set; }
        /// <summary>
        /// 利率 decimal(9,7)
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 透支类型 char(1) 0：不允许透支；1：限额透支；2：全额透支
        /// </summary>
        [XmlElement("overType")]
        public int OverType { get; set; }
        /// <summary>
        /// 透支利率 decimal(9,7) 透支类型为1（限额透支）或2(全额透支)时，透支利率非空；透支类型为0(不允许透支)时默认为0.0000000
        /// </summary>
        [XmlElement("overRate")]
        public decimal? OverRate { get; set; }
        /// <summary>
        /// 透支金额 decimal(15,2) 透支类型为1（限额透支）时，透支利率非空；透支类型为其他时默认为0.00
        /// </summary>
        [XmlElement("overAmt")]
        public decimal? OverAmt { get; set; }
        /// <summary>
        /// 计息方式 char(1) 0：不计息；1：不分段计息；2：分段计息
        /// </summary>
        [XmlElement("rateCalType")]
        public int RateCalType { get; set; }
        /// <summary>
        /// 利息分配方式 char(1) 0：不自动分配；1：自动分配
        /// </summary>
        [XmlElement("rateAsnType")]
        public int RateAsnType { get; set; }
        /// <summary>
        /// 手续费率分配方式 char(1) 0：不自动分配；1：自动分配
        /// </summary>
        [XmlElement("feeAsnType")]
        public int FeeAsnType { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 预约标志 0：非预约1：预约 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlElement("preDate")]
        public string PreDate { get; set; }
        /// <summary>
        /// 预约时间char(6) 格式hhmmss
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
        /// 经办日期 char(8) YYYYMMDD
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDate { get; set; }
        /// <summary>
        /// 经办时间 char(6) 格式hhmmss
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
        [XmlElement("Stt")]
        public string Stt { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
