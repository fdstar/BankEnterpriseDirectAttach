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
    /// 27.18.划拨详情查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_18 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTHTXINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTHTXINF";
        /// <summary>
        /// 27.18.划拨详情查询响应内容
        /// </summary>
        public NTHTXINFZ1 NTHTXINFZ1 { get; set; }
    }
    /// <summary>
    /// 27.18.划拨详情查询响应内容
    /// </summary>
    public class NTHTXINFZ1
    {
        /// <summary>
        /// 下级户口分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 下级户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 下级户口户名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 上级户口分行号	C(2)
        /// </summary>
        public string MUMBBK { get; set; }
        /// <summary>
        /// 上级户口号   	C(35)
        /// </summary>
        public string MUMEAC { get; set; }
        /// <summary>
        /// 上级户口户名	Z(62)
        /// </summary>
        public string MUMNAM { get; set; }
        /// <summary>
        /// 划拨方向     	C(1)    U：上划， D：下拨
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 划拨金额     	M
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 对方参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
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
        /// 经办日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 经办日期	D, 对应<see cref="OPRDAT"/>
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
        /// 操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 错误文本	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 头寸余额限制标志	C(1)    	Y：是或者N:否
        /// </summary>
        public string NMLFLG { get; set; }
    }
}
