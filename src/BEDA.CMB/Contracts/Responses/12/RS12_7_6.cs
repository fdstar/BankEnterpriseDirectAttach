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
    /// 12.7.6.直联实时购结汇查询模式适用资源及控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXCCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXCCTL";
        /// <summary>
        /// 12.7.6.直联实时购结汇查询模式适用资源及控制信息响应集合
        /// </summary>
        [XmlElement("NTOPRACCZ")]
        public List<NTOPRACCZ> List { get; set; }
        /// <summary>
        /// 12.7.6.直联实时购结汇查询模式适用资源及控制信息响应内容
        /// </summary>
        public NTQBSCTLZ NTQBSCTLZ { get; set; }
    }
}
