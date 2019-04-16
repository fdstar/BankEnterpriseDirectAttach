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
    /// 23.14.查询批量公司卡处理信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_14 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPSBLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPSBLST";
        /// <summary>
        /// 23.14.查询批量公司卡处理信息响应集合
        /// </summary>
        [XmlElement("NTPSBLSTZ")]
        public List<NTPSBLSTZ> List { get; set; }
    }
    /// <summary>
    /// 23.14.查询批量公司卡处理信息响应内容
    /// </summary>
    public class NTPSBLSTZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 公司卡号 	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 姓名     	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 分行号   	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 公司结算户	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 错误码   	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述 	Z(192)
        /// </summary>
        public string RTNTXT { get; set; }
    }
}
