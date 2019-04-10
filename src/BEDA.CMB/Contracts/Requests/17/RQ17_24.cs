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
    /// 17.24.查询虚拟户关联公司卡列表(续传)请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_24 : CMBBase<RQINFO>, IRequest<RS17_24>
    {
        /// <summary>
        /// NTDCDRLD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDCDRLD";
        /// <summary>
        /// 17.24.查询虚拟户关联公司卡列表(续传)请求内容
        /// </summary>
        public NTDCDRLDX1 NTDCDRLDX1 { get; set; }
    }
    /// <summary>
    /// 17.24.查询虚拟户关联公司卡列表(续传)请求内容
    /// </summary>
    public class NTDCDRLDX1
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
        /// 起始公司卡卡号	C(35)   为空时，从头开始查询 非空时，从指定公司卡卡号开始查询
        /// </summary>
        public string CDSNBR { get; set; }
    }
}
