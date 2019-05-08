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
    /// 27.22.内部计价结息经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_22 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTOPRINT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTOPRINT";
        /// <summary>
        /// 27.22.内部计价结息经办响应内容
        /// </summary>
        public NTOPRINTZ1 NTOPRINTZ1 { get; set; }
    }
    /// <summary>
    /// 27.22.内部计价结息经办响应内容
    /// </summary>
    public class NTOPRINTZ1
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
        /// 错误码       	C(7)    成功则返回SUC0000
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本     	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 上级账号	C(35)
        /// </summary>
        public string TOPEAC { get; set; }
        /// <summary>
        /// 下级账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 结息开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 结息开始日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 结息结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结息结束日期	D, 对应<see cref="ENDDAT"/>
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
}
