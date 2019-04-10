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
    /// 17.20.设置虚拟户关联付款方信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_20 : CMBBase<RQINFO>, IRequest<RS17_20>
    {
        /// <summary>
        /// NTDMARLT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMARLT";
        /// <summary>
        /// 17.20.设置虚拟户关联付款方信息请求内容
        /// </summary>
        public NTDMARLTX1 NTDMARLTX1 { get; set; }
    }
    /// <summary>
    /// 17.20.设置虚拟户关联付款方信息请求内容
    /// </summary>
    public class NTDMARLTX1
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
        /// 入账方式	C(1)	Y：非关联账号入对应虚拟户账 N：非关联账号入默认虚拟户账
        /// </summary>
        public string TLYOPR { get; set; }
        /// <summary>
        /// 付款方账号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
    }
}
