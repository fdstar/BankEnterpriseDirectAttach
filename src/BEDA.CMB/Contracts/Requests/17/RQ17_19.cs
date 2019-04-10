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
    /// 17.19.修改虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_19 : CMBBase<RQINFO>, IRequest<RS17_19>
    {
        /// <summary>
        /// NTDMAMNT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAMNT";
        /// <summary>
        /// 17.19.修改虚拟户请求内容
        /// </summary>
        public NTDMAMNTX1 NTDMAMNTX1 { get; set; }
    }
    /// <summary>
    /// 17.19.修改虚拟户请求内容
    /// </summary>
    public class NTDMAMNTX1
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
        /// 虚拟户编号	C (20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 额度控制标志	C(1)	Y：允许透支 N：不允许透支
        /// </summary>
        public string OVRCTL { get; set; }
    }
}
