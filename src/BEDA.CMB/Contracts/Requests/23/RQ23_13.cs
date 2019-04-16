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
    /// 23.13.查询消费额度设置信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ23_13 : CMBBase<RQINFO>, IRequest<RS23_13>
    {
        /// <summary>
        /// NTCRDINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDINF";
        /// <summary>
        /// 23.13.查询消费额度设置信息请求内容
        /// </summary>
        public NTCRDINFX NTCRDINFX { get; set; }
    }
    /// <summary>
    /// 23.13.查询消费额度设置信息请求内容
    /// </summary>
    public class NTCRDINFX
    {
        /// <summary>
        /// 流程号  	C(10)
        /// </summary>
        public string REQNBR { get; set; }
    }
}
