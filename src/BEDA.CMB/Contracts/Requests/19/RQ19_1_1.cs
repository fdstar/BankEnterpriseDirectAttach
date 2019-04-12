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
    /// 19.1.1.查询有权经办的客户编号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_1_1 : CMBBase<RQINFO>, IRequest<RS19_1_1>
    {
        /// <summary>
        /// SDKECPREL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKECPREL";
        /// <summary>
        /// 19.1.1.查询有权经办的客户编号请求内容
        /// </summary>
        public NTECPMODX NTECPMODX { get; set; }
    }
    /// <summary>
    /// 19.1.1.查询有权经办的客户编号请求内容
    /// </summary>
    public class NTECPMODX
    {
        /// <summary>
        /// 业务类型	C(6)    银行承兑汇票：N06010;商业承兑汇票： N06011
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)  业务模式编号、业务模式名称不能同时为空
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(200)  业务模式编号、业务模式名称不能同时为空
        /// </summary>
        public string MODALS { get; set; }
    }
}
