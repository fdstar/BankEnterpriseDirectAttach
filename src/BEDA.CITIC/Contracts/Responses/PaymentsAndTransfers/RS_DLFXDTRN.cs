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
    /// 信银国际外汇买卖（香港账户-集团客户）响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFXDTRN : RsBase
    {
    }
}