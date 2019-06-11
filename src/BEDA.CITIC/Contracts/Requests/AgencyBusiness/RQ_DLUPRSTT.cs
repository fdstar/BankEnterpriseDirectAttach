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
    /// 银联对私付款单笔状态查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLUPRSTT : RqBase<RS_DLUPRSTT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLUPRSTT"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 交易序号 int(5)，可空，当待查询对私付款交易为批量经办时该字段必输
        /// </summary>
        public int? ID { get; set; }
    }
}
