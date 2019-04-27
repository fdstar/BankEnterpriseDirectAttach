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
    /// 25.1.查询网上自助还款业务控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS25_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQCDCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQCDCTL";
        /// <summary>
        /// 25.1.查询网上自助还款业务控制信息响应集合
        /// </summary>
        [XmlElement("NTQALACCZ")]
        public List<NTQALACCZ> List { get; set; }
    }
}
