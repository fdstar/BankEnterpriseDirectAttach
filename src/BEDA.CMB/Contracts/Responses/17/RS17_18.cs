using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 17.18.流水号查询虚拟户交易信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_18 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMTQR2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMTQR2";
        /// <summary>
        /// 17.18.流水号查询虚拟户交易信息响应内容
        /// </summary>
        public NTDMTQR2Z1 NTDMTQR2Z1 { get; set; }
    }
    /// <summary>
    /// 17.18.流水号查询虚拟户交易信息响应内容
    /// </summary>
    public class NTDMTQR2Z1
    {
        /// <summary>
        /// 内部账簿账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 记账流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 收付方账号	C(35)
        /// </summary>
        public string RPYACC { get; set; }
        /// <summary>
        /// 收付方名称	Z(62)
        /// </summary>
        public string RPYNAM { get; set; }
        /// <summary>
        /// 联行号	A(20)
        /// </summary>
        public string RPYBBN { get; set; }
        /// <summary>
        /// 开户行	Z(62)
        /// </summary>
        public string RPYBNK { get; set; }
        /// <summary>
        /// 开户地	Z(62)
        /// </summary>
        public string RPYADR { get; set; }
    }
}
