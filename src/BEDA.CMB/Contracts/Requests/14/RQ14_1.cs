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
    /// 14.1.查询用户有权协议列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ14_1 : CMBBase<RQINFO>, IRequest<RS14_1>
    {
        /// <summary>
        /// SDKNTQRYPTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTQRYPTL";
        /// <summary>
        /// 14.1.查询用户有权协议列表请求内容
        /// 注意此处只传递 BUSMOD 和 MODALS
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
