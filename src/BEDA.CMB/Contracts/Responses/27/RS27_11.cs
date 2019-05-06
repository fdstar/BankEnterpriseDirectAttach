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
    /// 27.11.子账户内部户限额查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_11 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTILMQR2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTILMQR2";
        /// <summary>
        /// 27.11.子账户内部户限额查询响应集合
        /// </summary>
        [XmlElement("NTILMQRYZ1")]
        public List<NTILMQRYZ1> List { get; set; }
    }
}
