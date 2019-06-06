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
    /// 代发工资明细查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLSALDET : RqBase<RS_DLSALDET>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLSALDET"; set { } }
        /// <summary>
        /// 客户流水号char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 请求记录条数，最大为20
        /// </summary>
        [XmlElement("pageNumber")]
        public int PageNumber { get; set; } = 20;
        /// <summary>
        /// 起始记录号 char(4)
        /// </summary>
        [XmlElement("startRecord")]
        public int StartRecord { get; set; }
    }
}
