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
    /// 代理扣收企业款请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLAGEPUB : RqBase<RS_DLAGEPUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLAGEPUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 总笔数  必须为数字char(4)
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get { return this.Collection?.List?.Count ?? 0; } set { } }
        /// <summary>
        /// 总金额 deciam(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get { return this.Collection?.List?.Sum(x => x.TranAmount) ?? 0; } set { } }
        /// <summary>
        /// 收款账号 char(19)
        /// </summary>
        [XmlElement("rcvAccountNo")]
        public string RcvAccountNo { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 延期支付时间，预约时非空，时间点可选范围 100000，120000，140000，160000
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 延期支付日期char(8)　格式YYYYMMDD ，预约时非空
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
        /// 延期支付时间char(6)  格式hhmmss，只限100000，120000，140000，160000 四个时间点，预约时非空
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
        /// <summary>
        /// 备注varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<WithholdFunds> Collection { get; set; }
    }
}
