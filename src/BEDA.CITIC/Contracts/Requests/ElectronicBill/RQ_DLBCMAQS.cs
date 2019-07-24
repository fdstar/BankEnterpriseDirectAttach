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
    /// 通用签收经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMAQS : RqBase<RS_DLBCMAQS>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMAQS"; set { } }
        /// <summary>
        /// 签收交易请求代码 char(8) 见附录4.1.2
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
        /// <summary>
        /// 客户流水号 varchar (20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 业务流水标识 char(10)
        /// </summary>
        [XmlElement("bussqNo")]
        public string BussqNo { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 签收结果 char(4)，SU00同意，SU01拒绝
        /// </summary>
        [XmlElement("sgnrRes")]
        public string SgnrRes { get; set; }
        /// <summary>
        /// 签收人信用等级 char(3)，可空
        /// </summary>
        [XmlElement("sgnrRate")]
        public string SgnrRate { get; set; }
        /// <summary>
        /// 签收人评级机构 varchar(60)，可空
        /// </summary>
        [XmlElement("sgnrAgcy")]
        public string SgnrAgcy { get; set; }
        /// <summary>
        /// 签收人评级到期日char(8)格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? SgnrDueDate { get; set; }
        /// <summary>
        /// 签收人评级到期日char(8)格式YYYYMMDD, 对应<see cref="SgnrDueDate"/>
        /// </summary>
        [XmlElement("sgnrDueDate")]
        public string SgnrDueDateStr
        {
            get
            {
                return this.SgnrDueDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.SgnrDueDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SgnrDueDate = tmp;
                }
            }
        }
        /// <summary>
        /// 签收人地址 varchar(256)，保证签收时必输，预留
        /// </summary>
        [XmlElement("sgnrAddr")]
        public string SgnrAddr { get; set; }
        /// <summary>
        /// 拒付理由代码 char(4)，提示付款签收并且签收结果为SU01拒绝时，拒付理由代码必输，值域参见附录4.1.6
        /// </summary>
        [XmlElement("refuseRsnCd")]
        public string RefuseRsnCd { get; set; }
        /// <summary>
        /// 拒付备注varchar(256)，拒付理由代码为DC09时非空
        /// </summary>
        [XmlElement("refuseRsn")]
        public string RefuseRsn { get; set; }
        /// <summary>
        /// 协议号 char(30)，可空，承兑、贴现签收时有效
        /// </summary>
        [XmlElement("protocolNo")]
        public string ProtocolNo { get; set; }
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
