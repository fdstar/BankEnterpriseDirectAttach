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
    /// 通知回执信息请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCDRRSM : RqBase<RS_DLCDRRSM>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCDRRSM"; set { } }
        /// <summary>
        /// 通知书类型varchar(10)，企业端回查交易的交易码，目前只有发货（DLCDRGNQ）、移库（DLCDTWNQ）、解除质押通知（DLCDUINQ）3种
        /// </summary>
        [XmlElement("ntcTp")]
        public string NtcTp { get; set; }
        /// <summary>
        /// 通知书编号 varchar(20)， SCF系统通过B2C的通知编号推送交易发送给企业端
        /// </summary>
        [XmlElement("rlsmgntcNo")]
        public string RlsmgntcNo { get; set; }
        /// <summary>
        /// 是否确认varchar(2)，可空，0：否；1：是
        /// </summary>
        [XmlElement("whetappr")]
        public string Whetappr { get; set; }
        /// <summary>
        /// 借款企业ID，varchar(20) ，可空
        /// </summary>
        [XmlElement("loncpId")]
        public string LoncpId { get; set; }
        /// <summary>
        /// 回执日期  char(8)，格式YYYYMMDD，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? RrDate { get; set; }
        /// <summary>
        /// 回执日期  char(8)，格式YYYYMMDD，可空, 对应<see cref="RrDate"/>
        /// </summary>
        [XmlElement("rrDate")]
        public string RrDateStr
        {
            get
            {
                return this.RrDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.RrDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RrDate = tmp;
                }
            }
        }
        /// <summary>
        /// 回执发送人编号varchar(20) ，可空
        /// </summary>
        [XmlElement("rrsnderNo")]
        public string RrsnderNo { get; set; }
        /// <summary>
        /// 回执发送人名称 varchar(122) ，可空
        /// </summary>
        [XmlElement("rrsnderNm")]
        public string RrsnderNm { get; set; }
        /// <summary>
        /// 回执内容varchar(200) ，可空
        /// </summary>
        [XmlElement("rrcontent")]
        public string Rrcontent { get; set; }
        /// <summary>
        /// 属性1 varchar(30)，可空，按约定上送
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
        /// <summary>
        /// 属性2 varchar(60)，可空，按约定上送
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 属性3  varchar(100)，按约定上送，可空
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
    }
}
