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
    /// 27.16.手工划拨响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_16 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRBHT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRBHT";
        /// <summary>
        /// 27.16.手工划拨响应内容
        /// </summary>
        public NTOPRBHTZ1 NTOPRBHTZ1 { get; set; }
    }
    /// <summary>
    /// 27.16.手工划拨响应内容
    /// </summary>
    public class NTOPRBHTZ1
    {
        /// <summary>
        /// 流水号       	C(10)	
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 上级户口	C(35)
        /// </summary>
        public string OBJEAC { get; set; }
        /// <summary>
        /// 下级户口	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 划拨方向	C(1)    U：上划，D：下拨
        /// </summary>
        public string TRXDIR { get; set; }
        /// <summary>
        /// 划拨金额	C(15)
        /// </summary>
        public decimal TRXAMT { get; set; }
        /// <summary>
        /// 请求状态     	C(3)    附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名     	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)    附录 A.6  REQSTS=FIN时，RTNFLG才有意义
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码       	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本     	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
