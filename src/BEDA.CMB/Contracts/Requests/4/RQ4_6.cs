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
    /// 4.6.大批量代发工资经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ4_6 : CMBBase<RQINFO>, IRequest<RS4_6>
    {
        /// <summary>
        /// NTAGCSAL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGCSAL";
        /// <summary>
        /// 4.6.大批量代发工资经办请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 4.6.大批量代发工资经办请求内容 支付概要
        /// </summary>
        public NTAGCAGCX1 NTAGCAGCX1 { get; set; }
        /// <summary>
        /// 4.6.大批量代发工资经办请求内容  支付明细  
        /// </summary>
        [XmlElement("NTAGCDTLY1")]
        public List<NTAGCDTLY1> List { get; set; }
    }
    /// <summary>
    /// 4.6.大批量代发工资经办请求内容 支付概要
    /// </summary>
    public class NTAGCAGCX1
    {
        /// <summary>	
        /// 批次开始标志	C(1)
        /// 必须为’Y’或’N’，’Y’表示批次开始，续传批次固定赋值为’N’
        /// </summary>
        public string BEGTAG { get; set; }
        /// <summary>
        /// 批次结束标志	C(1)
        /// 必须为’Y’或’N’，’Y’表示批次结束，非结束批次固定赋值为’N’
        /// </summary>
        public string ENDTAG { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// 第一次上传时必须为空；
        /// 续传时不能为空，所有续传次数流程实例号必须为同一个；
        /// 主机校验该字段值与批次开始、结束标志的匹配性
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 总金额	M
        /// 批次总金额，代发代扣系统要求第一次就要必输
        /// </summary>
        public decimal TTLAMT { get; set; }
        /// <summary>
        /// 总笔数	F(8,0)
        /// 批次总笔数，代发代扣系统要求第一次就要必输
        /// </summary>
        public long TTLCNT { get; set; }
        /// <summary>
        /// 总次数	F(3,0)
        /// 该批次数据计划分多少次上传完，代发代扣系统要求第一次就要必输
        /// </summary>
        public int TTLNUM { get; set; }
        /// <summary>
        /// 本次金额	M
        /// </summary>
        public decimal CURAMT { get; set; }
        /// <summary>
        /// 本次笔数	F(8,0)
        /// </summary>
        public long CURCNT { get; set; }
        /// <summary>
        /// 合作方协议号	C(6)    预留
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 交易货币	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 个性化短信内容	Z(22)
        /// 预留，录入则在收方入账短信里展示
        /// </summary>
        public string NTFINF { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 货币市场	C(1)	取值描述
        /// 0:不分钞汇
        /// 1:现钞
        /// 2:现汇
        /// </summary>
        public string CCYMKT { get; set; }
        /// <summary>
        /// 交易类型	C(4)	代发工资固定为“BYSA”
        /// </summary>
        public string TRSTYP { get; set; } = "BYSA";
        /// <summary>
        /// 用途	Z(42)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 期望日	D   默认为当前日期
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime { get; set; }
        /// <summary>
        /// 期望日	D
        /// </summary>
        [XmlElement("EPTDAT")]
        public string EPTDATStr
        {
            get
            {
                return this.ExpectedTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 期望时间	T   默认为‘000000’
        /// </summary>
        [XmlElement("EPTTIM")]
        public string EPTTIMStr
        {
            get
            {
                return this.ExpectedTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 网银审批标志	C(1)	Y/N
        /// </summary>
        public string GRTFLG { get; set; }
    }
    /// <summary>
    /// 4.2.直接代发代扣请求内容 支付明细
    /// </summary>
    public class NTAGCDTLY1
    {
        /// <summary>
        /// 交易序号	C(8)
        /// 需要客户自行保证批次范围内的序号唯一性
        /// </summary>
        [XmlIgnore]
        public long TRXSEQ { get; set; }
        /// <summary>
        /// 交易序号	C(8) 对应<see cref="TRXSEQ"/>
        /// 代发代扣系统要求格式为全数字，如’00000001’、’00000002’
        /// </summary>
        [XmlElement("TRXSEQ")]
        public string TRXSEQStr
        {
            get { return this.TRXSEQ.ToString("00000000"); }
            set
            {
                if (long.TryParse(value, out long tmp) && tmp > 0)
                {
                    this.TRXSEQ = tmp;
                }
            }
        }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 注释	Z(42)
        /// </summary>
        public string TRSDSP { get; set; }
        /// <summary>
        /// 系统内标志	C(1)
        /// Y:开户行是招商银行。 N：开户行是他行
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
        /// 他行快速标志	C(1)    Y:快速 N:普通
        /// </summary>
        public string FSTFLG { get; set; }
        /// <summary>
        /// 他行户口联行号	C(12)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 客户代码	C(20)
        /// 以前代扣将合作方帐号填到注释字段里，现在可以改为填到这个字段；代发可空
        /// </summary>
        public string CPRACT { get; set; }
        /// <summary>
        /// 合作方流水号	C(20)   暂无用，预留
        /// </summary>
        public string CPRREF { get; set; }
    }
}
