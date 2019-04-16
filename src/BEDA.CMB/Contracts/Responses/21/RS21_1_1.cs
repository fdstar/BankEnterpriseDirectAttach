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
    /// 21.1.1.查询业务经办业务控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQEBCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQEBCTL";
        /// <summary>
        /// 21.1.1.查询业务经办业务控制信息响应内容     单记录
        /// 输入接口字段BUSMOD不为空时才返回数据
        /// </summary>
        public NTQBSCTLZ NTQBSCTLZ { get; set; }
        /// <summary>
        /// 21.1.1.查询业务经办业务控制信息响应集合     多记录
        /// </summary>
        [XmlElement("NTQEBACCZ")]
        public List<NTQEBACCZ> List { get; set; }
    }
    /// <summary>
    /// 21.1.1.查询业务经办业务控制信息响应内容     单记录
    /// 输入接口字段BUSMOD不为空时才返回数据
    /// </summary>
    public class NTQBSCTLZ
    {
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额下限	M
        /// </summary>
        public decimal LOWAMT { get; set; }
        /// <summary>
        /// 金额上限	M
        /// </summary>
        public decimal HGHAMT { get; set; }
        /// <summary>
        /// 是否有收方限制	C(1)
        /// </summary>
        public string RCVLMT { get; set; }
        /// <summary>
        /// 校验和	C(10)
        /// </summary>
        public string CHKSUM { get; set; }
        /// <summary>
        /// 额度限制标志	C(1)
        /// </summary>
        public string LMTFLG { get; set; }
        /// <summary>
        /// 保留字段 50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
    /// <summary>
    /// 21.1.1.查询业务经办业务控制信息响应内容     多记录
    /// </summary>
    public class NTQEBACCZ
    {
        /// <summary>
        /// 银行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 我行帐号标志	C(1)	Y:我行行内帐号 N:他行帐号
        /// </summary>
        public string INNFLG { get; set; }
        /// <summary>
        /// 帐户名称	Z(200)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 行号	C(12)
        /// </summary>
        public string BNKBRD { get; set; }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string ACCFLG { get; set; }
        /// <summary>
        /// 保留字 30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
