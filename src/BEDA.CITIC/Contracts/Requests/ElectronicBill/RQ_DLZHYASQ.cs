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
    /// 质押申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLZHYASQ : RqBase<RS_DLZHYASQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLZHYASQ"; set { } }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 质权人名称 varchar(122)
        /// </summary>
        [XmlElement("cobkName")]
        public string CobkName { get; set; }
        /// <summary>
        /// 质权人账号 varchar(32)
        /// </summary>
        [XmlElement("cobkAccNo")]
        public string CobkAccNo { get; set; }
        /// <summary>
        /// 质权人开户行行号 varchar(20)
        /// </summary>
        [XmlElement("cobkBnm")]
        public string CobkBnm { get; set; }
        /// <summary>
        /// 质权人是否为中信银行标志 char(1) 0：是，1：不是
        /// </summary>
        [XmlElement("cobkIsCitic")]
        public string CobkIsCitic { get; set; }
        /// <summary>
        /// ECDS批次号 varchar(10) 可空；不为空时必须为数字
        /// </summary>
        [XmlElement("ecdsBatNo")]
        public string EcdsBatNo { get; set; }
        /// <summary>
        /// 经办备注 varchar(256)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
        /// <summary>
        /// 预约支付标志 0：非预约1：预约 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 预约支付时间
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 预约支付日期 预约时非空 char(8) 格式YYYYMMDD
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
    }
}
