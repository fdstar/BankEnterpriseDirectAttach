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
    /// 保证申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBOZHSQ : RqBase<RS_DLBOZHSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBOZHSQ"; set { } }
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
        /// 保证人名称 varchar(122)
        /// </summary>
        [XmlElement("warrtrName")]
        public string WarrtrName { get; set; }
        /// <summary>
        /// 保证人账号 char(32)
        /// </summary>
        [XmlElement("warrtrAccNo")]
        public string WarrtrAccNo { get; set; }
        /// <summary>
        /// 保证人行号 varchar(20)
        /// </summary>
        [XmlElement("warrtrBnm")]
        public string WarrtrBnm { get; set; }
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
