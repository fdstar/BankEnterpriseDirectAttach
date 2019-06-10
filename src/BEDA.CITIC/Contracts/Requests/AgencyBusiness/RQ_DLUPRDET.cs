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
    /// 银联对私付款明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLUPRDET : RqBase<RS_DLUPRDET>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLUPRDET"; set { } }
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 明细状态 char(1)， 0：成功；1：失败；2：未知；可空，为空时查询全部类型
        /// </summary>
        [XmlElement("stt")]
        public string Stt { get; set; }
    }
}
