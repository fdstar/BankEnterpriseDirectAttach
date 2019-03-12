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
    /// 2.1.查询可查询/可经办的账户列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// ListAccount
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "ListAccount";
        /// <summary>
        /// 2.1.查询可查询/可经办的账户列表响应集合
        /// </summary>
        [XmlElement("NTQACLSTZ")]
        public List<NTQACLSTZ> List { get; set; }
    }
    /// <summary>
    /// 2.1.查询可查询/可经办的账户列表响应内容
    /// </summary>
    public class NTQACLSTZ
    {
        /// <summary>
        /// 币种	C（2,2）	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 分行号	C（2,2）  附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名	Z（62）
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 公司名称	Z（62）
        /// </summary>
        public string C_RELNBR { get; set; }
    }
}
