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
    /// 定期型智能存款解除关联请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLFITMFX : RqBase<RS_DLFITMFX>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLFITMFX"; set { } }
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 定期账号(账户序号) varchar(6)
        /// </summary>
        [XmlElement("fixAccNo")]
        public string FixAccNo { get; set; }
        /// <summary>
        /// 智能存款账号char(19)
        /// </summary>
        [XmlElement("finAccNo")]
        public string FinAccNo { get; set; }
        /// <summary>
        /// 备注varchar(60)，可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
