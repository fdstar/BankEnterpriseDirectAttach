using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 17.3.新增虚拟户请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_3 : CMBBase<RQINFO>, IRequest<RS17_3>
    {
        /// <summary>
        /// NTDMAADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAADD";
        /// <summary>
        /// 17.3.新增虚拟户请求内容
        /// </summary>
        public NTDMAADDX NTDMAADDX { get; set; }
    }
    /// <summary>
    /// 17.3.新增虚拟户请求内容
    /// </summary>
    public class NTDMAADDX
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)   不超过10位
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 额度控制标志	C(1)	Y： 允许透支 N：不允许透支
        /// </summary>
        public string OVRCTL { get; set; }
        /// <summary>
        /// 退票处理方式	C(1)	Y:退回原虚拟户 N：退回结算户
        /// </summary>
        public string BCKTYP { get; set; }
    }
}
