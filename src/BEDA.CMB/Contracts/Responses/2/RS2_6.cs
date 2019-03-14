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
    /// 2.6.查询分行号信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS2_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetBbkInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetBbkInfo";
        /// <summary>
        /// 2.6.查询分行号信息响应集合
        /// </summary>
        [XmlElement("NTACCBBKZ")]
        public List<NTACCBBKZ> List { get; set; }
    }
    /// <summary>
    /// 2.6.查询分行号信息响应内容
    /// </summary>
    public class NTACCBBKZ
    {
        /// <summary>
        /// 分行号	C（2）	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 分行名称	Z(62)
        /// </summary>
        public string C_BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C（35）
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
