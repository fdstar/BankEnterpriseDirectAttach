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
    /// 8.3.4.理财产品购买经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_3_4 : CMBBase<RQINFO>, IRequest<RS8_3_4>
    {
        /// <summary>
        /// NTQDBOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDBOPR";
        /// <summary>
        /// 8.3.4.理财产品购买经办请求内容
        /// </summary>
        public NTQDBOPRX NTQDBOPRX { get; set; }
    }
    /// <summary>
    /// 8.3.4.理财产品购买经办请求内容
    /// </summary>
    public class NTQDBOPRX
    {
        /// <summary>
        /// 业务模式编号	C(5)    不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(62)   不能同时为空，必须填一个。（如果两者都不为空以BUSMOD为准）
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)	
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 购买数量	N(13)
        /// </summary>
        public long ORDQTY { get; set; }
        /// <summary>
        /// 认购炒汇	C(2)	N=现钞 Y=现汇
        /// </summary>
        public string CCYMKT { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
