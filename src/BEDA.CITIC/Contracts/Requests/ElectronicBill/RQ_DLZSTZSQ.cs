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
    /// 追索通知申请经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLZSTZSQ : RqBase<RS_DLZSTZSQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLZSTZSQ"; set { } }
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
        /// 追索类型 char(4)，RT00拒付追索，RT01非拒付追索
        /// </summary>
        [XmlElement("rcrsType")]
        public string RcrsType { get; set; }
        /// <summary>
        /// 追索金额 decimal(15.2)
        /// </summary>
        [XmlElement("rcrsAmt")]
        public decimal RcrsAmt { get; set; }
        /// <summary>
        /// 被追索人组织机构代码 char(32)
        /// </summary>
        [XmlElement("rcvgCode")]
        public string RcvgCode { get; set; }
        /// <summary>
        /// 被追索人名称 varchar(122)
        /// </summary>
        [XmlElement("rcvgName")]
        public string RcvgName { get; set; }
        /// <summary>
        /// 被追索人账号 varchar(32)
        /// </summary>
        [XmlElement("rcvgAccNo")]
        public string RcvgAccNo { get; set; }
        /// <summary>
        /// 被追索人开户行行号 varchar(20)
        /// </summary>
        [XmlElement("rcvgBnm")]
        public string RcvgBnm { get; set; }
        /// <summary>
        /// 追索理由代码 char(4)，非拒付追索时非空，RC00承兑人被依法宣告破产 RC01承兑人因违法被责令终止活动
        /// </summary>
        [XmlElement("rcrsRsnCode")]
        public string RcrsRsnCode { get; set; }
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
