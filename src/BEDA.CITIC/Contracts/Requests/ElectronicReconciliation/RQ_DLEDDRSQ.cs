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
    /// 回单信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLEDDRSQ : RqBase<RS_DLEDDRSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLEDDRSQ"; set { } }
        /// <summary>
        /// 查询类型char(1),  1：T+0；2：T+1
        /// </summary>
        [XmlElement("qryType")]
        public int QryType { get; set; }
        /// <summary>
        /// 账号varchar(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 回单类型char(1)，0：全部；1：转账类；2：利息类；3：收费类；4：电子缴税；5：网银结售汇；6：现金管理转账
        /// </summary>
        [XmlElement("billType")]
        public int BillType { get; set; }
        /// <summary>
        /// 最小额度decimal (15.2)
        /// </summary>
        [XmlElement("minAmt")]
        public decimal MinAmt { get; set; }
        /// <summary>
        /// 最大额度decimal (15.2)
        /// </summary>
        [XmlElement("maxAmt")]
        public decimal MaxAmt { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 起始日期char(8) 格式YYYYMMDD, 对应<see cref="StartDate"/>
        /// </summary>
        [XmlElement("startDate")]
        public string StartDateStr
        {
            get
            {
                return this.StartDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 终止日期char(8) 格式YYYYMMDD, 对应<see cref="EndDate"/>
        /// </summary>
        [XmlElement("endDate")]
        public string EndDateStr
        {
            get
            {
                return this.EndDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EndDate = tmp;
                }
            }
        }
        /// <summary>
        /// 每页记录数int(4)
        /// </summary>
        [XmlElement("pageSize")]
        public int PageSize { get; set; }
        /// <summary>
        /// 起始记录号int(4)
        /// </summary>
        [XmlElement("startNo")]
        public int StartNo { get; set; }
    }
}
