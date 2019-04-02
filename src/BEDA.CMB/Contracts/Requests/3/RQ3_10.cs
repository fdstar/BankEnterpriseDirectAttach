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
    /// 3.10.跨境划拨额度查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ3_10 : CMBBase<RQINFO>, IRequest<RS3_10>
    {
        /// <summary>
        /// NTCRBINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRBINQ";
        /// <summary>
        /// 3.10.跨境划拨额度查询请求内容
        /// 注意此处只传递 BUSMOD 和 RSV50Z
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
    }
    /// <summary>
    /// 3.10.跨境划拨额度查询请求内容
    /// </summary>
    public class NTBUSMODY
    {
        /// <summary>
        /// 业务模式	C(5)
        /// 可通过查询可经办的业务模式信息（ListMode）获得。 本查询与业务模式没有关系，故业务模式字段可空，且不同业务模式返回结果一样
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 保留字段	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
        /// <summary>
        /// 业务类型	C(6)     
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(200)
        /// </summary>
        public string MODALS { get; set; }
    }
}
