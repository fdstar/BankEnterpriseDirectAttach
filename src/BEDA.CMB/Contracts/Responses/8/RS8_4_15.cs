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
    /// 8.4.15.网上转网下申请查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// QueryTransfer
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "QueryTransfer";
        /// <summary>
        /// 8.4.15.网上转网下申请查询响应集合
        /// </summary>
        [XmlElement("NTFNCAPQZ")]
        public List<NTFNCAPQZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.15.网上转网下申请查询响应内容
    /// </summary>
    public class NTFNCAPQZ
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期/通知存款帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 申请日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime APPDAT { get; set; }
        /// <summary>
        /// 申请日期	D, 对应<see cref="APPDAT"/>
        /// </summary>
        [XmlElement("APPDAT")]
        public string APPDATStr
        {
            get
            {
                return this.APPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 系统处理日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PRCDAT { get; set; }
        /// <summary>
        /// 系统处理日期	D, 对应<see cref="PRCDAT"/>
        /// </summary>
        [XmlElement("PRCDAT")]
        public string PRCDATStr
        {
            get
            {
                return this.PRCDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PRCDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PRCDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 状态	C(1)    A-未处理,C—已处理,D-已取消
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
