using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 8.4.7.活期转通知存款经办请求响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSMAOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMAOPR";
        /// <summary>
        /// 8.4.7.活期转通知存款经办请求响应内容
        /// </summary>
        public NTSMAOPRZ NTSMAOPRZ { get; set; }
    }
    /// <summary>
    /// 8.4.7.活期转通知存款经办请求响应内容
    /// </summary>
    public class NTSMAOPRZ
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 通知存款帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
