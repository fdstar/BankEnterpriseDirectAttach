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
    /// 8.6.5.组合存款业务申请明细查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_6_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMAINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMAINQ";
        /// <summary>
        /// 8.6.5.组合存款业务申请明细查询响应内容
        /// </summary>
        public NTCMAINQZ1 NTCMAINQZ1 { get; set; }
        /// <summary>
        /// 8.6.5.组合存款业务申请明细查询响应内容  OPRTYP= FDRL时非空
        /// </summary>
        public NTCMARLTX1 NTCMARLTX1 { get; set; }
        /// <summary>
        /// 8.6.5.组合存款业务申请明细查询响应内容  OPRTYP= FDRD时非空
        /// </summary>
        public NTCMARLDX1 NTCMARLDX1 { get; set; }
    }
    /// <summary>
    /// 8.6.5.组合存款业务申请明细查询响应内容
    /// </summary>
    public class NTCMAINQZ1
    {
        /// <summary>
        /// 操作类型	C(3)    FDRL-关联智能定期账号 FDRD-取消关联智能定期账号
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误描述	Z(92)
        /// </summary>
        public string RTNNAR { get; set; }
    }
    /// <summary>
    /// 8.6.5.组合存款业务申请明细查询响应内容  OPRTYP= FDRL时非空
    /// </summary>
    public class NTCMARLTX1
    {
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 定期分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 活期分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 8.6.5.组合存款业务申请明细查询响应内容  OPRTYP= FDRD时非空
    /// </summary>
    public class NTCMARLDX1
    {
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 定期分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 活期分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 协议编号	C(8)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
