using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 票据库交易申请响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBADAPP : RsBase
    {
        /// <summary>
        /// 批次号varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
    }
}
