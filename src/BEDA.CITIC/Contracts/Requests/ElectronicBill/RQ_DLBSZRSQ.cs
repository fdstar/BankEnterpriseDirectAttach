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
    /// 背书转让申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBSZRSQ : RqBase<RS_DLBSZRSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBSZRSQ"; set { } }
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
        /// 被背书人名称 varchar(122) 
        /// </summary>
        [XmlElement("endorserName")]
        public string EndorserName { get; set; }
        /// <summary>
        /// 被背书人账号 varchar(32)
        /// </summary>
        [XmlElement("endorserAccNo")]
        public string EndorserAccNo { get; set; }
        /// <summary>
        /// 被背书人行号 varchar(20)
        /// </summary>
        [XmlElement("endorserBnm")]
        public string EndorserBnm { get; set; }
        /// <summary>
        /// 转让标记char(4)，EM00可再转让，EM01不得转让
        /// </summary>
        [XmlElement("endorseMk")]
        public string EndorseMk { get; set; }
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
