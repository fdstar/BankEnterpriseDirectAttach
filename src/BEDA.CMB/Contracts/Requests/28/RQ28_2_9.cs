using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 28.2.9.虚拟户交易转存结果查询（实时结息）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_9 : CMBBase<RQINFO>, IRequest<RS28_2_9>
    {
        /// <summary>
        /// NTDMHTRF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMHTRF";
        /// <summary>
        /// 28.2.9.虚拟户交易转存结果查询（实时结息）请求内容
        /// </summary>
        public NTDMHTRFX1 NTDMHTRFX1 { get; set; }
    }
    /// <summary>
    /// 28.2.9.虚拟户交易转存结果查询（实时结息）请求内容
    /// </summary>
    public class NTDMHTRFX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DUMNBR { get; set; }
        /// <summary>
        /// 交易套号	C(15)
        /// </summary>
        public string ORGSET { get; set; }
        /// <summary>
        /// 交易流水号	C(15)
        /// </summary>
        public string ORGTRX { get; set; }
    }
}
