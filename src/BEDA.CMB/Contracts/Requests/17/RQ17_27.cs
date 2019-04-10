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
    /// 17.27.删除公司卡关联付款方信息请求报文说明请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_27 : CMBBase<RQINFO>, IRequest<RS17_27>
    {
        /// <summary>
        /// NTDMDRDD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRDD";
        /// <summary>
        /// 17.27.删除公司卡关联付款方信息请求报文说明请求内容
        /// </summary>
        public NTDMDRDDX1 NTDMDRDDX1 { get; set; }
    }
    /// <summary>
    /// 17.27.删除公司卡关联付款方信息请求报文说明请求内容
    /// </summary>
    public class NTDMDRDDX1
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
        /// 虚拟户	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 公司卡号	C(20)
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 关联付款方账号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
    }
}
