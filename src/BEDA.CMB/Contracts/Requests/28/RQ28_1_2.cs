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
    /// 28.1.2.关闭虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_1_2 : CMBBase<RQINFO>, IRequest<RS28_1_2>
    {
        /// <summary>
        /// NTDUMDLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMDLT";
        /// <summary>
        /// 28.1.2.关闭虚拟户请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.1.2.关闭虚拟户请求内容
        /// </summary>
        public NTDUMDLTX1 NTDUMDLTX1 { get; set; }
        /// <summary>
        /// 28.1.2.关闭虚拟户请求内容
        /// </summary>
        public NTDUMDLTX2 NTDUMDLTX2 { get; set; }
    }
    /// <summary>
    /// 28.1.2.关闭虚拟户请求内容
    /// </summary>
    public class NTDUMDLTX1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
    }
    /// <summary>
    /// 28.1.2.关闭虚拟户请求内容
    /// </summary>
    public class NTDUMDLTX2
    {
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
