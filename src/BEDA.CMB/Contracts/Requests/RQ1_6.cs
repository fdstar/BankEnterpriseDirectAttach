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
    /// 1.6.查询可经办业务模式
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ1_6 : CMBBase<RQINFO>, IRequest<RS1_6>
    {
        /// <summary>
        /// ListMode
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "ListMode";
        /// <summary>
        /// 1.6.查询可经办业务模式请求内容
        /// </summary>
        public SDKMDLSTX SDKMDLSTX { get; set; }
    }
    /// <summary>
    /// 1.6.查询可经办业务模式请求内容
    /// </summary>
    public class SDKMDLSTX
    {
        /// <summary>
        /// 业务类别	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
    }
}
