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
    /// 8.1.2.查询登记机构NTFNDTAA响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_1_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNDTAA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDTAA";
        /// <summary>
        /// 8.1.2.查询登记机构NTFNDTAA响应集合
        /// </summary>
        [XmlElement("NTFNDTAAZ")]
        public List<NTFNDTAAZ> List { get; set; }
    }
    /// <summary>
    /// 8.1.2.查询登记机构NTFNDTAA响应内容
    /// </summary>
    public class NTFNDTAAZ
    {
        /// <summary>
        /// 登记机构代码	C(3)
        /// </summary>
        public string TAACOD { get; set; }
        /// <summary>
        /// 登记机构名称	Z(42)
        /// </summary>
        public string TAANAM { get; set; }
    }
}
