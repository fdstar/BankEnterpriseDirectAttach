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
    /// 21.1.1.查询业务经办业务控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_1_1 : CMBBase<RQINFO>, IRequest<RS21_1_1>
    {
        /// <summary>
        /// NTQEBCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQEBCTL";
        /// <summary>
        /// 21.1.1.查询业务经办业务控制信息请求内容
        /// 注意此处只传递 BUSCOD 和  BUSMOD
        /// BUSCOD可选值为：
        /// N31010=网银贷记
        /// N31011=网银借记
        /// N31012 = 第三方贷记
        /// N31013=跨行账户信息查询
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
}
