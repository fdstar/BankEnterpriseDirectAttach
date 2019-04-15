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
    /// 19.3.11.查询分行代码响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_3_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKBBKNBR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKBBKNBR";
        /// <summary>
        /// 19.3.11.查询分行代码响应集合
        /// </summary>
        [XmlElement("NTMNUDSPZ")]
        public List<NTMNUDSPZ> List { get; set; }
    }
    /// <summary>
    /// 19.3.11.查询分行代码响应内容
    /// </summary>
    public class NTMNUDSPZ
    {
        /// <summary>
        /// 分行代码	C(10)
        /// </summary>
        public string MNUCOD { get; set; }
        /// <summary>
        /// 分行名称	Z(42)
        /// </summary>
        public string MNUNAM { get; set; }
        /// <summary>
        /// 机构号	C(10)
        /// </summary>
        public string TRDCOD { get; set; }
        /// <summary>
        /// 机构名称	Z(42)
        /// </summary>
        public string TRDNAM { get; set; }
    }
}
