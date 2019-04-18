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
    /// 8.4.13.查询网上转网下申请的帐号列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_13 : CMBBase<RQINFO>, IRequest<RS8_4_13>
    {
        /// <summary>
        /// NTFNCAPC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCAPC";
        /// <summary>
        /// 8.4.13.查询网上转网下申请的帐号列表请求内容 默认已初始化NTBUSMODY且查询所有
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; } = new NTBUSMODY
        {
            BUSCOD = "******",
            BUSMOD = "*****",
        };
    }
}
