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
    /// 17.26.单笔设置公司卡非关联付方账号的入账方式请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_26 : CMBBase<RQINFO>, IRequest<RS17_26>
    {
        /// <summary>
        /// NTDMDRMD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRMD";
        /// <summary>
        /// 17.26.单笔设置公司卡非关联付方账号的入账方式请求内容
        /// </summary>
        public NTDMDRMDX1 NTDMDRMDX1 { get; set; }
    }
    /// <summary>
    /// 17.26.单笔设置公司卡非关联付方账号的入账方式请求内容
    /// </summary>
    public class NTDMDRMDX1
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
        /// 虚拟户	C(20)  公司卡关联的非默认虚拟户
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 公司卡号	C(20)
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 入账方式	C(1)	Y：非关联账号入对应虚拟户账 N：非关联账号入默认虚拟户账
        /// </summary>
        public string TLYOPR { get; set; }
    }
}
