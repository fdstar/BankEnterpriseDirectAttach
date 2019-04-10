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
    /// 17.21.修改虚拟户非关联付款方入账方式请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_21 : CMBBase<RQINFO>, IRequest<RS17_21>
    {
        /// <summary>
        /// NTDMATMN
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMATMN";
        /// <summary>
        /// 17.21.修改虚拟户非关联付款方入账方式请求内容
        /// </summary>
        public NTDMATMNX1 NTDMATMNX1 { get; set; }
    }
    /// <summary>
    /// 17.21.修改虚拟户非关联付款方入账方式请求内容
    /// </summary>
    public class NTDMATMNX1
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
    }
}
