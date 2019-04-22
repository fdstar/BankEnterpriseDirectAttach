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
    /// 8.8.4.查询券商编号及保证金账号请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_8_4 : CMBBase<RQINFO>, IRequest<RS8_8_4>
    {
        /// <summary>
        /// NTSECCNV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECCNV";
        /// <summary>
        /// 8.8.4.查询券商编号及保证金账号请求内容
        /// </summary>
        public NTSECCNVX NTSECCNVX { get; set; }
    }
    /// <summary>
    /// 8.8.4.查询券商编号及保证金账号请求内容
    /// </summary>
    public class NTSECCNVX
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 银行帐号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 业务类别	C(2)
        /// 10： 三方存管业务
        /// 11：融资融券业务
        /// 12: 个股期权
        /// </summary>
        public string BIZTYP { get; set; }
        /// <summary>
        /// 货币代码	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
