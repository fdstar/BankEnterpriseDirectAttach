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
    /// 账号名称校验响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLACCCHK : RsBase
    {
        /// <summary>
        /// 匹配状态 0：匹配；1：名称和账号不符；2：账号与账号类型不匹配char(1)
        /// </summary>
        [XmlElement("flag")]
        public int Flag { get; set; }
    }
}
