using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 登录响应消息实体
    /// </summary>
    public class SONRS
    {
        /// <summary>
        /// 交易处理状态，必回
        /// </summary>
        [XmlElement(Order = 0)]
        public STATUS STATUS { get; set; }
        /// <summary>
        /// 服务端日期时间，yyyy-MM-dd HH:mm:ss，必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string DTSERVER { get; set; }
        /// <summary>
        /// 客户端要求生成USERKEY时发送key值，非必回，仅在GENUSERKEY为”Y”时必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string USERKEY { get; set; }
        /// <summary>
        /// USERKEY的有效时间(服务器时间)，非必回，仅在GENUSERKEY为”Y”时必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string TSKEYEXPIRE { get; set; }
        /// <summary>
        /// 服务器响应信息使用的语言，目前仅提供CHS(中文简体)，非必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string LANGUAGE { get; set; }
        /// <summary>
        /// 服务器需要保存会话COOKIE，则发送，否则不发送，客户端在下次请求中应包含，非必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SESSCOOKIE { get; set; }
    }
}
