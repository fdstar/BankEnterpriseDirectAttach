using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回响应主体
    /// </summary>
    public class V1_EBREDMTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回响应主体
        /// </summary>
        public EBREDMTRNRS EBREDMTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回响应主体
    /// </summary>
    public class EBREDMTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBREDMTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.8电子商业汇票贴现赎回/转贴现赎回响应内容
    /// </summary>
    public class EBREDMTRN_RSBODY : XFERPRCSTS_RSBODY
    {
    }
}
