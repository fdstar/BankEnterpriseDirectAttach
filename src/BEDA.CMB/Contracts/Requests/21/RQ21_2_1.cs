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
    /// 21.2.1.网银贷记请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ21_2_1 : CMBBase<RQINFO>, IRequest<RS21_2_1>
    {
        /// <summary>
        /// NTIBCOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIBCOPR";
        /// <summary>
        /// 21.2.1.网银贷记请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 21.2.1.网银贷记请求集合  重复次数1~30
        /// </summary>
        [XmlElement("NTIBCOPRX")]
        public List<NTIBCOPRX> List { get; set; }
    }
    /// <summary>
    /// 21.2.1.网银贷记请求内容
    /// </summary>
    public class NTOPRMODX
    {
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
    }
    /// <summary>
    /// 21.2.1.网银贷记请求内容
    /// </summary>
    public class NTIBCOPRX
    {
        /// <summary>
        /// 流水号	C(10)   批次内唯一，批量经办时用作响应结果与请求的对应字段
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 付款账号银行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 付款账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 协议号	C(10)   贷记内部协议号
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)   成功和在途的业务唯一
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 币种	C(2)	附录 A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 收方编号	C(20)
        /// </summary>
        public string CRTSQN { get; set; }
        /// <summary>
        /// 通知方式一	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式二	C(40)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 收款人户名	Z(100)
        /// </summary>
        public string CDTNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string CDTEAC { get; set; }
        /// <summary>
        /// 收款行行号	C(12)
        /// </summary>
        public string CDTBRD { get; set; }
        /// <summary>
        /// 业务类型编码	C(4)	附录A.49
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 业务种类编码	C(5)
        /// </summary>
        public string TRSCAT { get; set; }
        /// <summary>
        /// 附言	Z(235)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 保留字 30
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
