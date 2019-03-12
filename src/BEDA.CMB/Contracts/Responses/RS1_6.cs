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
    /// 1.6.查询可经办业务模式响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS1_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// ListMode
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "ListMode";
        /// <summary>
        /// 1.6.查询可经办业务模式响应集合
        /// </summary>
        [XmlElement("NTQMDLSTZ")]
        public List<NTQMDLSTZ> List { get; set; }
    }
    /// <summary>
    /// 1.6.查询可经办业务模式响应内容
    /// </summary>
    public class NTQMDLSTZ
    {
        /// <summary>
        /// 业务模式编号	C（5）
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称
        /// </summary>
        public string MODALS { get; set; }
    }
}
