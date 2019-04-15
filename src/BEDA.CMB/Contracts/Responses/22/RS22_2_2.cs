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
    /// 22.2.2.查询票据挂失止付定制查询设置明细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_2_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBLQDTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQDTL";
        /// <summary>
        /// 22.2.2.查询票据挂失止付定制查询设置明细信息响应集合
        /// </summary>
        [XmlElement("NTBLQSETY1")]
        public List<Requests.NTBLQSETY1> List { get; set; }
    }
}
