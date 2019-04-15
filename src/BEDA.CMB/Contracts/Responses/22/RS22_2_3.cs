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
    /// 22.2.3.票据挂失止付定制查询设置维护查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_2_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBLQMQY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQMQY";
        /// <summary>
        /// 22.2.3.票据挂失止付定制查询设置维护查询响应集合
        /// </summary>
        [XmlElement("NTBLQWAUZ1")]
        public List<NTBLQWAUZ1> List { get; set; }
        /// <summary>
        /// 22.2.3.票据挂失止付定制查询设置维护查询响应内容
        /// </summary>
        public Requests.NTBLQWAUY1 NTBLQWAUY1 { get; set; }
    }
    /// <summary>
    /// 22.2.3.票据挂失止付定制查询设置维护查询响应内容
    /// </summary>
    public class NTBLQWAUZ1
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
        /// 查询账号分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据张数	F(3,0)
        /// </summary>
        public int BILCNT { get; set; }
        /// <summary>
        /// 票据总金额	M
        /// </summary>
        public decimal TOLAMT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 经办日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 维护方式	C(3)
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务请求结果	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作步骤	C(6)
        /// </summary>
        public string OPRSTP { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述	Z(192)
        /// </summary>
        public string ERRDSP { get; set; }
    }
}
