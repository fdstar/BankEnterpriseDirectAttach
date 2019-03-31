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
    /// 11.3.查询代理清算申请详细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS11_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTAGPINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTAGPINF";
        /// <summary>
        /// 11.3.查询代理清算申请详细信息响应集合
        /// </summary>
        [XmlElement("NTAGPINFZ1")]
        public List<NTAGPINFZ1> List { get; set; }
    }
    /// <summary>
    /// 11.3.查询代理清算申请详细信息响应内容
    /// </summary>
    public class NTAGPINFZ1
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
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 汇款人账号	C(35)
        /// </summary>
        public string RMTACC { get; set; }
        /// <summary>
        /// 汇款人名称	Z(62)
        /// </summary>
        public string RMTNAM { get; set; }
        /// <summary>
        /// 汇款行名称	Z(62)
        /// </summary>
        public string RMTBNK { get; set; }
        /// <summary>
        /// 发报行代理行	Z(62)
        /// </summary>
        public string AGTBNK { get; set; }
        /// <summary>
        /// 转出分行号	C(2)
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 转出帐号	C(35)
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 收方分行号	C(2)
        /// </summary>
        public string CRTBBK { get; set; }
        /// <summary>
        /// 收方帐号	C(35)
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方户名	Z(62)	
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方行名称	Z(62)
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 收方行地址	Z(62)	
        /// </summary>
        public string CRTADR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 交易金额 	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 系统内标志	C(1)	Y=系统内， N=系统外
        /// </summary>
        public string BNKFLG { get; set; }
        /// <summary>
        /// 结算通道	C(1)	N：普通  F：快速
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 费用负担方	C(1)	B=收款人，O=汇款人，S=共同
        /// </summary>
        public string CHGFOR { get; set; }
        /// <summary>
        /// 摘要	Z(100)
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 附言	Z(210)
        /// </summary>
        public string INFTXT { get; set; }
        /// <summary>
        /// 通知方式一	C(40)
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 通知方式二	C(20)
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
        /// 请求状态	C(3)	A.5 业务请求状态
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	C(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 结果摘要	Z(92)   如失败原因，拒绝理由等
        /// </summary>
        public string RTNNAR { get; set; }
        /// <summary>
        /// 是否有附件信息	C(1)    Y：有 N：无
        /// </summary>
        public string ATHFLG { get; set; }
        /// <summary>
        /// 业务种类	C(6)	100001=普通汇兑 二代支付新增
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 收费方式	C(1)	N: 实时扣收 Y: 批量扣收 	二代支付新增，空则为实时扣收
        /// </summary>
        public string FEEMOD { get; set; }
    }
}
