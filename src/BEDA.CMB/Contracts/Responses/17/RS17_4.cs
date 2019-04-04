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
    /// 17.4.关闭虚拟户响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMADLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMADLT";
        /// <summary>
        /// 17.4.关闭虚拟户响应集合
        /// </summary>
        [XmlElement("NTDMADLTZ")]
        public List<NTDMADLTZ> List { get; set; }
    }
    /// <summary>
    /// 17.4.关闭虚拟户响应内容
    /// </summary>
    public class NTDMADLTZ
    {
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 处理状态	C(1)	S：成功 F：失败
        /// </summary>
        public string PRCSTS { get; set; }
        /// <summary>
        /// 返回码	C(7)	SUC0000：成功 其他：失败
        /// </summary>
        public string RTNCOD { get; set; }
        /// <summary>
        /// 返回信息	Z(92)   返回码不是 SUC0000时，会返回相关提示信息
        /// </summary>
        public string RTNTXT { get; set; }
    }
}
