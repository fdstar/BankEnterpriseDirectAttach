using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests.AccountManagement
{
    /// <summary>
    /// 支付联行信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBNKCOD : RqBase<RS_DLBNKCOD>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBNKCOD"; set { } }
        /// <summary>
        /// 省名称，可空 varchar(42)
        /// </summary>
        [XmlElement("provinceName")]
        public string ProvinceName { get; set; }
        /// <summary>
        /// 城市名称，可空 varchar(42)
        /// </summary>
        [XmlElement("cityName")]
        public string CityName { get; set; }
        /// <summary>
        /// 银行名称，可空 varchar(62)
        /// </summary>
        [XmlElement("bankName")]
        public string BankName { get; set; }
        /// <summary>
        /// 支付联行号，可空，支付联行号和支付联行名称必填1个 varchar(20)
        /// </summary>
        [XmlElement("tgfi")]
        public string Tgfi { get; set; }
        /// <summary>
        /// 支付联行名称，可空， 支付联行号和支付联行名称必填1个，varchar(122)
        /// </summary>
        [XmlElement("tgname")]
        public string Tgname { get; set; }
    }
}
