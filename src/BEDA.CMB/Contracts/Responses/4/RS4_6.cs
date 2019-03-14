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
    /// 4.6.大批量代发工资经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS4_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGCSAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCSAL";
        /// <summary>
        /// 4.6.大批量代发工资经办响应内容
        /// </summary>
        public NTAGCAGCZ1 NTAGCAGCZ1 { get; set; }
    }
    /// <summary>
    /// 4.6.大批量代发工资经办响应内容
    /// </summary>
    public class NTAGCAGCZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
