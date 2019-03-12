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
    /// 2.1.查询可查询/可经办的账户列表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_1 : CMBBase<RQINFO>, IRequest<RS2_1>
    {
        /// <summary>
        /// ListAccount
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "ListAccount";
        /// <summary>
        /// 2.1.查询可查询/可经办的账户列表请求内容
        /// </summary>
        public SDKACLSTX SDKACLSTX { get; set; }
    }
    /// <summary>
    /// 2.1.查询可查询/可经办的账户列表请求内容
    /// </summary>
    public class SDKACLSTX
    {
        /// <summary>
        /// 业务类别	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// 某个业务有哪些可经办的业务模式，可通过查询可经办的业务模式信息（ListMode） 获得。账务查询（"BUSCOD=N01010"）时忽略该项
        /// </summary>
        public string BUSMOD { get; set; }
    }
}
