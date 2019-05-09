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
    /// 28.2.9.虚拟户交易转存结果查询（实时结息）响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_2_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMHTRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMHTRF";
        /// <summary>
        /// 28.2.9.虚拟户交易转存结果查询（实时结息）响应内容
        /// </summary>
        public NTDMHTRFZ1 NTDMHTRFZ1 { get; set; }
    }
    /// <summary>
    /// 28.2.9.虚拟户交易转存结果查询（实时结息）响应内容
    /// </summary>
    public class NTDMHTRFZ1
    {
        /// <summary>
        /// 转存状态	C(1)	N：不需要转存 W：待转存 S：已转存 D：已支取
        /// </summary>
        public string TRFSTS { get; set; }
    }
}
