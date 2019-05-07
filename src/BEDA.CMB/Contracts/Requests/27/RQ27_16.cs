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
    /// 27.16.手工划拨请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ27_16 : CMBBase<RQINFO>, IRequest<RS27_16>
    {
        /// <summary>
        /// NTOPRBHT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRBHT";
        /// <summary>
        /// 27.16.手工划拨请求内容
        /// </summary>
        public NTBUSMODY NTBUSMODY { get; set; }
        /// <summary>
        /// 27.16.手工划拨请求内容
        /// </summary>
        public NTOPRHTXX1 NTOPRHTXX1 { get; set; }
    }
    /// <summary>
    /// 27.16.手工划拨请求内容
    /// </summary>
    public class NTOPRHTXX1
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号       	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 上级户口分行号	C(2)
        /// </summary>
        public string MUMBBK { get; set; }
        /// <summary>
        /// 上级户口号   	C(35)
        /// </summary>
        public string MUMEAC { get; set; }
        /// <summary>
        /// 划拨方向     	C(1)    U：上划， D：下拨
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 划拨金额     	M
        /// </summary>
        public decimal TRXAMT { get; set; }
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
        /// 对方参考号   	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 头寸余额限制标志	C(1)    Y或者N,输入为Y，且划拨方向为D：下拨时，检查头寸余额限制
        /// </summary>
        public string NMLFLG { get; set; }
        /// <summary>
        /// 流水号	C(10)
        /// </summary>
        public string SQRNBR { get; set; }
    }
}
