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
    /// 12.6.3.支付机构查询汇出汇款申请明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTRTAINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTRTAINF";
        /// <summary>
        /// 12.6.3.支付机构查询汇出汇款申请明细响应内容   外汇汇款经办信息
        /// </summary>
        public NTRTAINFZ1 NTRTAINFZ1 { get; set; }
        /// <summary>
        /// 12.6.3.支付机构查询汇出汇款申请明细响应内容   附加信息
        /// </summary>
        public NTOPRRTAY1 NTOPRRTAY1 { get; set; }
    }
    /// <summary>
    /// 12.6.3.支付机构查询汇出汇款申请明细响应内容   外汇汇款经办信息
    /// </summary>
    public class NTRTAINFZ1
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式     	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 新申报标志	C(1)
        /// </summary>
        public string NEWRUL { get; set; }
        /// <summary>
        /// 汇出旧分行号	C(2)
        /// </summary>
        public string ISUBBK { get; set; }
        /// <summary>
        /// 汇款人户口	C(35)
        /// </summary>
        public string SNDEAC { get; set; }
        /// <summary>
        /// 汇出人客户号	C(10)
        /// </summary>
        public string SNDCLT { get; set; }
        /// <summary>
        /// 汇款人名称	Z(100)
        /// </summary>
        public string SNDNAM { get; set; }
        /// <summary>
        /// 汇款人地址	Z(100)
        /// </summary>
        public string SNDADR { get; set; }
        /// <summary>
        /// 汇出母公司分行	C(2)	保留字段
        /// </summary>
        public string NCSFAB { get; set; }
        /// <summary>
        /// 汇出母公司帐号	C(35)	保留字段
        /// </summary>
        public string NCSFAC { get; set; }
        /// <summary>
        /// 系统内外标记	C(1)	I-系统内，O-系统外；(招行和非招行)
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 境内外标志	C(1)	Y(境外)/ (境内)N 根据下面的字段得来
        /// </summary>
        public string CNRTAG { get; set; }
        /// <summary>
        /// 系统分类I	C(1)	I: 支付；O: 国结；X: 待定
        /// </summary>
        public string SYSCAT { get; set; }
        /// <summary>
        /// 离岸汇出标记	C(1)	离岸/在岸
        /// </summary>
        public string OSHFLG { get; set; }
        /// <summary>
        /// 汇入国家	C(3)	区分境内/境外
        /// </summary>
        public string CNRCOD { get; set; }
        /// <summary>
        /// 汇入行名址	Z(140)
        /// </summary>
        public string RCBADR { get; set; }
        /// <summary>
        /// 汇入行代理行	Z(140)	如果输入，则清分为国际结算系统
        /// </summary>
        public string RCBCRB { get; set; }
        /// <summary>
        /// 汇入行旧分行号	C(2)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// 汇入行账户行账号	C(35)
        /// </summary>
        public string RCBACC { get; set; }
        /// <summary>
        /// 汇入行（收款人）分行	C(3)
        /// </summary>
        public string PYEBBK { get; set; }
        /// <summary>
        /// 收款人名称	Z(100)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人地址	Z(100)
        /// </summary>
        public string RCVADR { get; set; }
        /// <summary>
        /// 收款人户口	C(35)
        /// </summary>
        public string RCVEAC { get; set; }
        /// <summary>
        /// 收款客户	C(10)
        /// </summary>
        public string RCVCLT { get; set; }
        /// <summary>
        /// 汇款类型	C(2)	电汇 票汇 信汇 其它
        /// </summary>
        public string RMTTYP { get; set; }
        /// <summary>
        /// 优先方式	C(1)	N：ormal普通 U：rgent加急
        /// </summary>
        public string PRYMOD { get; set; }
        /// <summary>
        /// 汇款货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 汇款金额	M
        /// </summary>
        public decimal ORTAMT { get; set; }
        /// <summary>
        /// 附言	Z(210)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 费用负担方	C(1)	OUR汇款人/BEN收款人/SHA共同
        /// </summary>
        public string CHGFOR { get; set; }
        /// <summary>
        /// 付费分行号	C(2)
        /// </summary>
        public string CHGBBK { get; set; }
        /// <summary>
        /// 付费户口	C(35)
        /// </summary>
        public string CHGEAC { get; set; }
        /// <summary>
        /// 付费货币	C(2)
        /// </summary>
        public string CHGCCY { get; set; }
        /// <summary>
        /// 付费金额	M
        /// </summary>
        public decimal CHGAMT { get; set; }
        /// <summary>
        /// 联系人	Z(40)
        /// </summary>
        public string CONPER { get; set; }
        /// <summary>
        /// 电话	C(30)
        /// </summary>
        public string CONTEL { get; set; }
        /// <summary>
        /// 备注	Z(100)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 附加信息标志	C(1)	若是Y则需取接口NTOPRRTAY1
        /// </summary>
        public string EXTFLG { get; set; }
        /// <summary>
        /// 通知方式1	C(40)	EMAIL
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式2	C(20)	手机
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 期望日        	D
        /// </summary>
        public string EPTDAT { get; set; }
        /// <summary>
        /// 期望时间      	T
        /// </summary>
        public string EPTTIM { get; set; }
        /// <summary>
        /// 期望时间 由<see cref="EPTDAT"/>和<see cref="EPTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? ExpectedTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.EPTDAT, this.EPTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
        /// <summary>
        /// 请求状态	C(3)
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	C(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	C(92)	如失败原因，拒绝理由等
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)	‘Y’：有；‘N’：无
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 汇出汇款编号	C(25)
        /// </summary>
        public string ORTREF { get; set; }
        /// <summary>
        /// 填报人名称	Z(20)
        /// </summary>
        public string APPNAM { get; set; }
        /// <summary>
        /// 填报人电话	C(20)
        /// </summary>
        public string APPTEL { get; set; }
        /// <summary>
        /// 取消／退回备注	Z(60)
        /// </summary>
        public string CNLTXT { get; set; }
        /// <summary>
        /// 特殊码 30	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
        /// <summary>
        /// 汇款方式	C(1)
        /// O/空：原币种汇款
        /// X：结售汇汇款
        /// M：小币种汇款
        /// </summary>
        public string ORTTYP { get; set; }
        /// <summary>
        /// 到账货币	C(2)    非我行挂牌的小币种汇款使用
        /// </summary>
        public string EXGCCY { get; set; }
        /// <summary>
        /// 到账金额	M
        /// </summary>
        public decimal? EXGAMT { get; set; }
        /// <summary>
        /// 影像标志	C(1)  A - 全部图片 Q - 含其他附件
        /// </summary>
        public string IMGTYP { get; set; }
        /// <summary>
        /// 影像套号	C(40)
        /// </summary>
        public string IMGNBR { get; set; }
        /// <summary>
        /// 汇入行SWIFT COD	C(11)
        /// </summary>
        public string RCBSWF { get; set; }
        /// <summary>
        /// 代理行SWIFT COD	C(11)
        /// </summary>
        public string AGBSWF { get; set; }
        /// <summary>
        /// 收款行类型	C(1)
        /// I-境内招行
        /// H-香港分行
        /// N-纽约分行
        /// S-新加坡分行
        /// O-招行系统外
        /// </summary>
        public string RCVTYP { get; set; }
    }
    /// <summary>
    /// 12.6.3.支付机构查询汇出汇款申请明细响应内容   附加信息
    /// </summary>
    public class NTOPRRTAY1
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 结算方式	C(1)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 付汇性质	C(1)
        /// </summary>
        public string NATPYM { get; set; }
        /// <summary>
        /// 交易编码１	C(6)
        /// </summary>
        public string TRSCD1 { get; set; }
        /// <summary>
        /// 交易货币１	C(2)
        /// </summary>
        public string TRSCY1 { get; set; }
        /// <summary>
        /// 交易金额１	M
        /// </summary>
        public decimal? TRSAM1 { get; set; }
        /// <summary>
        /// 交易附言１	C(30)
        /// </summary>
        public string TRSRM1 { get; set; }
        /// <summary>
        /// 交易编码２	C(6)
        /// </summary>
        public string TRSCD2 { get; set; }
        /// <summary>
        /// 交易货币２	C(2)
        /// </summary>
        public string TRSCY2 { get; set; }
        /// <summary>
        /// 交易金额２	M
        /// </summary>
        public decimal? TRSAM2 { get; set; }
        /// <summary>
        /// 交易附言２	C(30)
        /// </summary>
        public string TRSRM2 { get; set; }
        /// <summary>
        /// 是否为保税货物项下付款	C(1)
        /// </summary>
        public string IMPVRF { get; set; }
        /// <summary>
        /// 合同号	C(18)
        /// </summary>
        public string CNTNBR { get; set; }
        /// <summary>
        /// 发票号	C(18)
        /// </summary>
        public string INVNBR { get; set; }
        /// <summary>
        /// 外汇局批件号	C(20)
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
        /// <summary>
        /// 保留字段	C(20)
        /// </summary>
        public string SPLC20 { get; set; }
    }
}