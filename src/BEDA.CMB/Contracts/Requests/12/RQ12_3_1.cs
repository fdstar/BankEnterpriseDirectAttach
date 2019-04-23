using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.3.1.支付机构经办汇出汇款申请请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_3_1 : CMBBase<RQINFO>, IRequest<RS12_3_1>
    {
        /// <summary>
        /// SDKNTOPRRTA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTOPRRTA";
        /// <summary>
        /// 12.3.1.支付机构经办汇出汇款申请请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.3.1.支付机构经办汇出汇款申请请求内容 基本信息
        /// </summary>
        public NTOPRRTAX1 NTOPRRTAX1 { get; set; }
        /// <summary>
        /// 12.3.1.支付机构经办汇出汇款申请请求内容 附加信息
        /// </summary>
        public NTOPRRTAY1 NTOPRRTAY1 { get; set; }
    }
    /// <summary>
    /// 12.3.1.支付机构经办汇出汇款申请请求内容 基本信息
    /// </summary>
    public class NTOPRRTAX1
    {
        /// <summary>
        /// 业务参考号	C(30)   参考号前三位按下面的个规则来填写，否则有可能会经办不通过
        /// 1、  汇入时，IRT
        /// 2、 汇出时，ORT
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 汇出分行号	C(2)
        /// </summary>
        public string ISUBBK { get; set; }
        /// <summary>
        /// 汇款人账号	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 系统内外标记	C(1)	I：招行 O：非招行
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 境内外标志	C(1)	Y：境内 N：境外
        /// </summary>
        public string CNRTAG { get; set; }
        /// <summary>
        /// 汇入国家	C(3)	三位英文国家代码
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 汇入行SWIFT COD	C(11)
        /// </summary>
        public string RCBSWF { get; set; }
        /// <summary>
        /// 汇入行名址	Z(140)
        /// </summary>
        public string RCBADR { get; set; }
        /// <summary>
        /// 代理行SWIFT COD	C(11)
        /// </summary>
        public string AGBSWF { get; set; }
        /// <summary>
        /// 汇入行代理行名称地址	C(140)
        /// </summary>
        public string RCBCRB { get; set; }
        /// <summary>
        /// 汇入行代理行账号	S(34)
        /// </summary>
        public string RCBACC { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)  收款人名称＋收款人地址总长不能超过140个字符
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人地址	Z(100)  收款人名称＋收款人地址总长不能超过140个字符
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 收款人账户	S（34）
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 汇款类型	C(2)	TT：电汇 DD：票汇 MT：信汇(/其它)
        /// </summary>
        public string RMTTYP { get; set; }
        /// <summary>
        /// 优先方式	C(1)	N：普通 U：加急
        /// </summary>
        public string PRYMOD { get; set; }
        /// <summary>
        /// 汇款货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 汇款金额	M	必须大于0
        /// </summary>
        public decimal ORTAMT { get; set; }
        /// <summary>
        /// 附言	Z(140)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 费用负担方	C(1)	B:收款人 O:汇款人 S:共同
        /// </summary>
        public string CHGFOR { get; set; }
        /// <summary>
        /// 付费分行号	C(2)    必须等于汇出分行号（ISUBBK）
        /// </summary>
        public string CHGBBK { get; set; }
        /// <summary>
        /// 付费账号	C(35)   收方付费（CHGFOR=B）时付费账号必须与汇出账号相同
        /// </summary>
        public string CHGEAC { get; set; }
        /// <summary>
        /// 填报人名称	Z(20)
        /// </summary>
        public string APPNAM { get; set; }
        /// <summary>
        /// 填报人电话	C(20)
        /// </summary>
        public string APPTEL { get; set; }
        /// <summary>
        /// 备注	Z(100)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 期望日	D
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
        /// 期望时间	T
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
        /// 汇款类型	C(1)	O：原币种汇款 X：结售汇汇款 M：小币种汇款
        /// 选择M时，CCYNBR应该为美元或者欧元；支付机构业务项下，为满足监管要求，不能选X
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 到账货币	C(2)    小币种汇款必填
        /// </summary>
        public string EXGCCY { get; set; }
        /// <summary>
        /// 新版本标志	C(1)    固定填B
        /// </summary>
        public string UBKTYP { get; set; } = "B";
        /// <summary>
        /// 保留字	C(30)   第二位按如下定义输入： 1：支付机构跨境电商外汇集中收付 其他不是支付机构的业务
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 12.3.1.支付机构经办汇出汇款申请请求内容 附加信息
    /// </summary>
    public class NTOPRRTAY1
    {
        /// <summary>
        /// 结算方式	C(1)
        /// A:预付货款
        /// P:货到付款
        /// R:退款
        /// O:其他
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 是否为保税货物项下付款	C(1)	Y：是，N：否
        /// </summary>
        public string IMPVRF { get; set; }
        /// <summary>
        /// 付汇性质	C(1)    现改为境内支付必输
        /// 1:保税区 
        /// 2:出口加工区
        /// 3:钻石交易区 
        /// 5:深加工结转
        /// 6:其他
        /// 7:其他特殊经济区域
        /// </summary>
        public string NATPYM { get; set; }
        /// <summary>
        /// 交易编码１	C(6)	境内：A.12涉外支出交易编码；境外：A.11国际支出交易编码
        /// </summary>
        public string TRSCD1 { get; set; }
        /// <summary>
        /// 交易货币１	C(2)	等于汇款货币
        /// </summary>
        public string TRSCY1 { get; set; }
        /// <summary>
        /// 交易金额１	M	交易金额1+交易金额2=汇款金额
        /// </summary>
        public decimal TRSAM1 { get; set; }
        /// <summary>
        /// 交易附言１	Z(50)   境外支付(CNRTAG=N)时，必输
        /// </summary>
        public string TRSRM1 { get; set; }
        /// <summary>
        /// 交易编码２	C(6)	境内：A.12涉外支出交易编码；境外：A.11国际支出交易编码
        /// </summary>
        public string TRSCD2 { get; set; }
        /// <summary>
        /// 易货币２	C(2)	等于汇款货币
        /// </summary>
        public string TRSCY2 { get; set; }
        /// <summary>
        /// 交易金额２	M	交易金额1+交易金额2=汇款金额
        /// </summary>
        public decimal? TRSAM2 { get; set; }
        /// <summary>
        /// 交易附言２	Z(50)
        /// </summary>
        public string TRSRM2 { get; set; }
        /// <summary>
        /// 合同号	Z(20)
        /// </summary>
        public string CNTNBR { get; set; }
        /// <summary>
        /// 发票号	Z(35)
        /// </summary>
        public string INVNBR { get; set; }
        /// <summary>
        /// 外汇局批件号	C(20)   增加： 当交易编码1或2是属于A.13资本项下支出交易编码时，必输
        /// </summary>
        public string IMPNBR { get; set; }
        /// <summary>
        /// 现汇金额	M
        /// </summary>
        public decimal? CFCAMT { get; set; }
        /// <summary>
        /// 现汇帐号	C(35)
        /// </summary>
        public string CFCACC { get; set; }
        /// <summary>
        /// 购汇金额	M
        /// </summary>
        public decimal? BFCAMT { get; set; }
        /// <summary>
        /// 购汇帐号	C(35)
        /// </summary>
        public string BFCACC { get; set; }
        /// <summary>
        /// 其他金额	M
        /// </summary>
        public decimal? OTHAMT { get; set; }
        /// <summary>
        /// 其他帐号	C(35)
        /// </summary>
        public string OTHACC { get; set; }
    }
}
