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
    /// 22.3.1.查询票据管家业务控制信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ22_3_1 : CMBBase<RQINFO>, IRequest<RS22_3_1>
    {
        /// <summary>
        /// NTBILCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILCTL";
        /// <summary>
        /// 22.3.1.查询票据管家业务控制信息请求内容
        /// 查询所有模式账号列表时 BUSMOD 传入“*****”，否则传入具体业务模式编号 默认已赋值“*****”
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; } = new NTBUSMODY
        {
            BUSMOD = "*****"
        };
    }
}
