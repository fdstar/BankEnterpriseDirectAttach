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
    /// 28.1.5.详情查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS28_1_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDUMINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDUMINF";
        /// <summary>
        /// 28.1.5.详情查询响应内容
        /// </summary>
        public NTDUMINFZ1 NTDUMINFZ1 { get; set; }
        /// <summary>
        /// 28.1.5.详情查询响应内容
        /// </summary>
        public NTDUMADXZ1 NTDUMADXZ1 { get; set; }
        /// <summary>
        /// 28.1.5.详情查询响应内容
        /// </summary>
        public NTDUMDLXZ1 NTDUMDLXZ1 { get; set; }
        /// <summary>
        /// 28.1.5.详情查询响应内容
        /// </summary>
        public NTOPRDPXZ1 NTOPRDPXZ1 { get; set; }
        /// <summary>
        /// 28.1.5.详情查询响应内容
        /// </summary>
        public NTOPRDRXZ1 NTOPRDRXZ1 { get; set; }
    }
    /// <summary>
    /// 28.1.5.详情查询响应内容
    /// </summary>
    public class NTDUMINFZ1
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务类型	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型	C(4)	DUMA：新增虚拟户 DUMD：关闭虚拟户 DUPY：付款 DUMR：退款
        /// DUPY与DUMR共用NTOPRDPXZ1接口，为DUMR时需要返回NTOPRDRXZ1接口
        /// </summary>
        public string OPRTYP { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 用户名	Z(32)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 用户姓名	Z(20)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果描述	Z(192)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)	Y：是 N：否
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
    /// <summary>
    /// 28.1.5.详情查询响应内容
    /// </summary>
    public class NTDUMADXZ1
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(200)
        /// </summary>
        public string DYANAM { get; set; }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 28.1.5.详情查询响应内容
    /// </summary>
    public class NTDUMDLXZ1
    {
        /// <summary>
        /// 活期结算账户	C(35)
        /// </summary>
        public string INBACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DYANBR { get; set; }
    }
    /// <summary>
    /// 28.1.5.详情查询响应内容
    /// </summary>
    public class NTOPRDPXZ1
    {
        /// <summary>
        /// 转出分行号	C(2)    结算账户开户行
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号	C(35)   	结算账户
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DUMNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3   只支持人民币
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 系统内标志	C(1)	Y：行内 N：行外
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 收方分行号	C(3)	附录A.1   BNKFLG为Y时非空
        /// </summary>
        public string OPPBBK { get; set; }
        /// <summary>
        /// 收方开户行行号	C(20)   	联行号
        /// </summary>
        public string OPPBBN { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(100)
        /// </summary>
        public string CRTADR { get; set; }
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
        /// 结算通道	C(1)	F：快速 N：普通
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途	Z(62)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z(200)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 业务种类	C(6)	100001=普通汇兑 101001=慈善捐款 101002 =其他 默认100001
        /// </summary>
        public string TRSTYP { get; set; }
    }
    /// <summary>
    /// 28.1.5.详情查询响应内容
    /// </summary>
    public class NTOPRDRXZ1
    {
        /// <summary>
        /// 原交易套号	C(15)
        /// </summary>
        public string SETNBR { get; set; }
        /// <summary>
        /// 原交易流水号	C(15)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 是否退息	C(1)	Y：退息 N：不退息
        /// </summary>
        public string INTFLG { get; set; }
        /// <summary>
        /// 利息	M
        /// </summary>
        public decimal INTAMT { get; set; }
    }
}
