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
    /// 3.5.查询批量支付经办结果响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS3_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// GetBatchPayOprRes
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "GetBatchPayOprRes";
        /// <summary>
        /// 3.5.查询批量支付经办结果响应集合
        /// </summary>
        [XmlElement("SDQPYRSTZ")]
        public List<SDQPYRSTZ> List { get; set; }
    }
    /// <summary>
    /// 3.5.查询批量支付经办结果响应内容
    /// </summary>
    public class SDQPYRSTZ
    {
        /// <summary>
        /// 流水号	C(10)   批量经办时，用来表示第几笔记录
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6
        /// REQSTS=FIN时，RTNFLG才有意义
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	C(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本	Z(256)
        /// </summary>
        public string ERRTXT { get; set; }
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
        /// 付方帐号	N（35）
        /// </summary>
        public string DBTACC { get; set; }
        /// <summary>
        /// 付方开户地区代码	C（2）	附录A.1
        /// </summary>
        public string DBTBBK { get; set; }
        /// <summary>
        /// 付方开户地区	Z（12）	附录A.1
        /// </summary>
        public string C_DBTBBK { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 币种代码	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 币种名称	Z（10）	附录A.3
        /// </summary>
        public string C_CCYNBR { get; set; }
        /// <summary>
        /// 结算方式	Z（12）	快速 | 普通
        /// 只对跨行交易有效；同行都是实时到账
        /// </summary>
        public string STLCHN { get; set; }
        /// <summary>
        /// 结算方式	Z（12）	快速 | 普通
        /// 只对跨行交易有效；同行都是实时到账
        /// </summary>
        public string C_STLCHN { get; set; }
        /// <summary>
        /// 用途	Z（62）
        /// 对应对账单中的摘要NARTXT
        /// </summary>
        public string NUSAGE { get; set; }
        /// <summary>
        /// 业务摘要	Z（200）	
        /// 用于企业付款时填写说明或者备注
        /// </summary>
        public string BUSNAR { get; set; }
        /// <summary>
        /// 收方帐号	N（35）
        /// </summary>
        public string CRTACC { get; set; }
        /// <summary>
        /// 收方帐户名	Z（62）
        /// </summary>
        public string CRTNAM { get; set; }
        /// <summary>
        /// 收方长户名	Z(200)
        /// </summary>
        public string LRVEAN { get; set; }
        /// <summary>
        /// 收方行号	C(30)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 收方开户行	Z（62）	
        /// </summary>
        public string CRTBNK { get; set; }
        /// <summary>
        /// 城市代码	C(4)	附录A.18
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 收方省份	Z（16）	附录A.18
        /// </summary>
        public string CRTPVC { get; set; }
        /// <summary>
        /// 收方城市	Z（20）	附录A.18
        /// </summary>
        public string CRTCTY { get; set; }
        /// <summary>
        /// 收方县/区	Z（20）
        /// </summary>
        public string CRTDTR { get; set; }
        /// <summary>
        /// 收方电子邮件	C（36）
        /// 收款方的电子邮件地址，用于交易 成功后邮件通知
        /// </summary>
        public string NTFCH1 { get; set; }
        /// <summary>
        /// 收方移动电话	C（16）
        /// 收款方的移动电话，用于交易 成功后短信通知
        /// </summary>
        public string NTFCH2 { get; set; }
        /// <summary>
        /// 收方编号	C（20）
        /// 用于标识收款方的编号。非受限收方模式下可重复
        /// </summary>
        public string CRTSQN { get; set; }
    }
}
