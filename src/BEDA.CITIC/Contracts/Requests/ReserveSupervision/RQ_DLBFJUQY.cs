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
    /// 白名单(查询)请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBFJUQY : RqBase<RS_DLBFJUQY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBFJUQY"; set { } }
        /// <summary>
        /// 账户类别char(1)，0：对公；1：个人
        /// </summary>
        [XmlElement("accType")]
        public int AccType { get; set; }
        /// <summary>
        /// 收款人账号 char(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 收款人名称 varchar(122)
        /// </summary>
        [XmlElement("accNm")]
        public string AccNm { get; set; }
    }
}
