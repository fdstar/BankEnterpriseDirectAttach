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
    /// 代发工资导入响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSALIMP : RsBase
    {
        /// <summary>
        /// 批次号 char(3)
        /// </summary>
        [XmlElement("batchNo")]
        public string BatchNo { get; set; }
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get; set; }
        /// <summary>
        /// 总金额 decimal(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public int TotalAmount { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
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
    }
}
