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
    /// 19.3.12.查询机构号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_3_12 : CMBBase<RQINFO>, IRequest<RS19_3_12>
    {
        /// <summary>
        /// SDKDPTNBR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKDPTNBR";
        /// <summary>
        /// 19.3.12.查询机构号请求内容
        /// </summary>
        public NTMNUDSPX NTMNUDSPX { get; set; }
    }
    /// <summary>
    /// 19.3.12.查询机构号请求内容
    /// </summary>
    public class NTMNUDSPX
    {
        /// <summary>
        /// 分行代码	C(10)   由查询分行代码查询取得
        /// </summary>
        public string MNUCOD { get; set; }
    }
}
