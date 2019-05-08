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
    /// 28.2.1.虚拟户当天交易查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_1 : CMBBase<RQINFO>, IRequest<RS28_2_1>
    {
        /// <summary>
        /// NTDMTQRD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQRD";
        /// <summary>
        /// 28.2.1.虚拟户当天交易查询请求内容
        /// </summary>
        public NTDMTQRDY1 NTDMTQRDY1 { get; set; }
    }
    /// <summary>
    /// 28.2.1.虚拟户当天交易查询请求内容
    /// </summary>
    public class NTDMTQRDY1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   	为空时查虚拟户所有交易
        /// </summary>
        public string DYANBR { get; set; }
    }
}
