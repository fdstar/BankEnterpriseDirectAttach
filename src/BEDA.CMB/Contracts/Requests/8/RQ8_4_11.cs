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
    /// 8.4.11.查询有权操作通知存款帐号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_4_11 : CMBBase<RQINFO>, IRequest<RS8_4_11>
    {
        /// <summary>
        /// NTSMAACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSMAACC";
        /// <summary>
        /// 8.4.11.查询有权操作通知存款帐号请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
