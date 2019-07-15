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
    /// 备付金特殊交易响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBFJPAY : RsBase
    {
    }
}
