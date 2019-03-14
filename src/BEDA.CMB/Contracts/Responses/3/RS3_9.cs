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
    /// 3.9.批量查询支付信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSTLINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTLINF";
        /// <summary>
        /// 3.9.批量查询支付信息响应集合
        /// </summary>
        [XmlElement("NTQPAYQYZ")]
        public List<NTQPAYQYZ> List { get; set; }
    }
    /// <summary>
    /// 3.9.批量查询支付信息响应内容
    /// </summary>
    public class NTQPAYQYZ
    {
        /// <summary>
        /// 业务代码	C(6)	附录A.4
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 付方开户地区代码	C(2)	附录A.1
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方帐号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 付方帐户名	C(200)
        /// </summary>
        public string DBTNAM { get; set; }
        /// <summary>
        /// 付方开户行	Z(62)
        /// </summary>
        public string DBTBNK { get; set; }
        /// <summary>
        /// 付方行地址	Z(62)
        /// </summary>
        public string DBTADR { get; set; }
        /// <summary>
        /// 收方开户地区代码	C(2)	附录A.1
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方帐户名	Z(200)
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方大额行号	C(12)   二代支付新增
        /// </summary>
        public string RCVBRD { get; set; }
        /// <summary>
        /// 收方开户行	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 母公司开户地区代码	C(2)	附录A.1
        /// </summary>
        public string GRPBBK { get; set; }
        /// <summary>
        /// 母公司帐号	C(35)   只对集团支付有效
        /// </summary>
        public string GRPACC { get; set; }
        /// <summary>
        /// 母公司帐户名	Z(62)   只对集团支付有效
        /// </summary>
        public string GRPNAM { get; set; }
        /// <summary>
        /// 币种代码	N(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public string TRSAMT { get; set; }
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
        /// 系统内外标志	C(1)	“Y”表示系统内， “N”表示系统外
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 同城异地标志	C(1)	“Y”表示同城业务； “N”表示异地业务
        /// </summary>
        public string REGFLG { get; set; }
        /// <summary>
        /// 结算方式代码	C(1)	N-普通；F-快速
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 用途	Z(28)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 收方电子邮件	C(36)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 收方移动电话	C(16)
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPRDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务摘要	Z(196)
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 业务请求状态代码	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果代码	C(1)	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 操作别名	Z(28)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 结果摘要	Z(88)
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 退票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RTNDAT { get; set; }
        /// <summary>
        /// 退票日期	D, 对应<see cref="RTNDAT"/>
        /// </summary>
        [XmlElement("RTNDAT")]
        public string RTNDATStr
        {
            get
            {
                return this.RTNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RTNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RTNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 是否有附件信息	C(1)	“Y”表示有附件，“N”表示无附件
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 经办用户登录名	Z(30)
        /// </summary>
        public string LGNNAM { get; set; }
        /// <summary>
        /// 经办用户姓名	Z(30)
        /// </summary>
        public string USRNAM { get; set; }
        /// <summary>
        /// 业务种类	C(6)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 收费方式	C(1)	N = 不收费    Y = 收费  
        /// </summary>
        public string FEETYP { get; set; }
        /// <summary>
        /// 收方公私标志	C(1)	A=对公 P=个人 X=信用卡	
        /// </summary>
        public string RCVTYP { get; set; }
        /// <summary>
        /// 汇款业务状态	C(1)	A =待提出 C=已撤销 D =已删除 P =已提出 R=已退票 W=待处理（待确认）
        /// </summary>
        public string BUSSTS { get; set; }
        /// <summary>
        /// 受理机构	C(6)
        /// </summary>
        public string TRSBRN { get; set; }
        /// <summary>
        /// 转汇机构	C(6)
        /// </summary>
        public string TRNBRN { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// 虚拟户支付时前十位为虚拟户编号
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
