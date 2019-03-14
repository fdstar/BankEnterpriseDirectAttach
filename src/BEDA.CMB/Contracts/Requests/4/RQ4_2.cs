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
    /// 4.2.直接代发代扣请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_2 : CMBBase<RQINFO>, IRequest<RS4_2>
    {
        /// <summary>
        /// AgentRequest
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "AgentRequest";
        /// <summary>
        /// 4.2.直接代发代扣请求内容 支付概要
        /// </summary>
        public SDKATSRQX SDKATSRQX { get; set; }
        /// <summary>
        /// 4.2.直接代发代扣请求内容  支付明细  
        /// </summary>
        [XmlElement("SDKATDRQX")]
        public List<SDKATDRQX> List { get; set; }
    }
    /// <summary>
    /// 4.2.直接代发代扣请求内容 支付概要
    /// </summary>
    public class SDKATSRQX
    {
        /// <summary>	
        /// 业务类别	C(6)	
        /// N03010:代发工资
        /// N03020:代发
        /// N03030:代扣
        /// 
        /// 默认为代发工资: N03010
        /// </summary>
        public string BUSCOD { get; set; } = "N03010";
        /// <summary>
        /// 业务模式编号	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务模式名称	Z(62)
        /// 编号和名称填写其一，填写编号则名称无效。可通过前置机或者查询可经办的业务模式信息（ListMode）获得，必须使用无审批的业务模式
        /// </summary>
        public string MODALS { get; set; }
        /// <summary>
        /// 交易代码名称	Z	附录A.45
        /// 为空时默认BYSA：代发工资，代发和代扣时必填，可通过4.1获得可以使用的交易代码，也可以通过前置机获取
        /// </summary>
        public string C_TRSTYP { get; set; }
        /// <summary>
        /// 交易代码	C(4)    附录A.45
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 期望日期	D
        /// 不用填写，不支持期望日直接代发
        /// </summary>
        [XmlIgnore]
        public DateTime? EPTDAT { get; set; }
        /// <summary>
        /// 期望日期	D, 对应<see cref="EPTDAT"/>
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.EPTDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EPTDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EPTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 转出账号/转入账号	C(35)
        /// 代发为转出账号；代扣为转入账号
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 分行代码	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 分行名称	附录A.1   代码和名称不能同时为空。同时有值时BBKNBR有效。
        /// </summary>
        public string BANKAREA { get; set; }
        /// <summary>
        /// 总金额	M
        /// </summary>
        public decimal SUM { get; set; }
        /// <summary>
        /// 总笔数	N(4)
        /// </summary>
        public int TOTAL { get; set; }
        /// <summary>
        /// 币种代码	N(2)	附录A.3   默认10：人民币
        /// </summary>
        public string CCYNBR { get; set; } = "10";
        /// <summary>
        /// 币种名称	Z(1,10)	附录A.3   同时有值时CCYNBR有效
        /// </summary>
        public string CURRENCY { get; set; }
        /// <summary>
        /// 业务参考号	C(1,30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 用途	Z(1,42)
        /// </summary>
        public string MEMO { get; set; }
        /// <summary>
        /// 虚拟户编号	C(1,20) 记账宝使用
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 直连经办网银审批标志	C(1)	Y：直连经办、网银审批；
        /// 空或者其他值：直连经办、无需审批
        /// 为Y时必须使用有审批岗的模式；不为Y时，必须使用无审批岗的模式
        /// </summary>
        public string GRTFLG { get; set; }
    }
    /// <summary>
    /// 4.2.直接代发代扣请求内容 支付明细
    /// </summary>
    public class SDKATDRQX
    {
        /// <summary>
        /// 收款账号/被扣款账号	C(1,35)
        /// 非空，可以是旧版一卡通、新版一卡通或存折，旧版一卡通应包含4位分行地区码和8位卡号（共12位），新版一卡通为16位，存折必须加4位分行地区码（共14位）。如：075512888888（旧版一卡通）或07551288888811（存折））
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名	Z(1,62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 系统内标志	C(1)
        /// Y:开户行是招商银行。 N：开户行是他行。为空默认为招行
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 他行户口开户行	Z(1,62) 当BNKFLG=N时必填
        /// </summary>
        public string EACBNK { get; set; }
        /// <summary>
        /// 他行户口开户地	Z(1,62) 当BNKFLG=N时必填
        /// </summary>
        public string EACCTY { get; set; }
        /// <summary>
        /// 注释	Z(1,20)
        /// 代扣：如果签订有代扣协议，则必须填写与代扣协议一致的合作方账号（该号为扣款方的客户标识ID）
        /// </summary>
        public string TRSDSP { get; set; }
    }
}
