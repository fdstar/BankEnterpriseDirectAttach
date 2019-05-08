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
    /// 28.2.7.定期支取（实时结息）请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ28_2_7 : CMBBase<RQINFO>, IRequest<RS28_2_7>
    {
        /// <summary>
        /// NTDMHDTE
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMHDTE";
        /// <summary>
        /// 28.2.7.定期支取（实时结息）请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 28.2.7.定期支取（实时结息）请求内容
        /// </summary>
        public NTDMHDTEX1 NTDMHDTEX1 { get; set; }
    }
    /// <summary>
    /// 28.2.7.定期支取（实时结息）请求内容
    /// </summary>
    public class NTDMHDTEX1
    {
        /// <summary>
        /// 交易套号	C15)
        /// </summary>
        public string SETNBR { get; set; }
        /// <summary>
        /// 交易流水号	C15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 分行号	C2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 主账号	C35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C20)
        /// </summary>
        public string DUMNBR { get; set; }
        /// <summary>
        /// 业务参考号	C30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
