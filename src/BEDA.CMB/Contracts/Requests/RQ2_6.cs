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
    /// 2.6.查询分行号信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ2_6 : CMBBase<RQINFO>, IRequest<RS2_6>
    {
        /// <summary>
        /// GetBbkInfo
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetBbkInfo";
        /// <summary>
        /// 2.6.查询分行号信息请求内容
        /// </summary>
        public NTACCBBKY NTACCBBKY { get; set; }
    }
    /// <summary>
    /// 2.6.查询分行号信息请求内容
    /// </summary>
    public class NTACCBBKY
    {
        /// <summary>
        /// 账号	C(1,35) 空表示查询该用户有权查询的所有账号
        /// </summary>
        public string ACCNBR { get; set; }
    }
}
