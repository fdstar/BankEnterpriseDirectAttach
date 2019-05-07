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
    /// 27.20.多级现金池设置综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS27_20 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTMTLQRC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTMTLQRC";
        /// <summary>
        /// 27.20.多级现金池设置综合查询响应集合
        /// </summary>
        [XmlElement("NTMTLQRCZ1")]
        public List<NTMTLQRCZ1> List { get; set; }
    }
    /// <summary>
    /// 27.20.多级现金池设置综合查询响应内容
    /// </summary>
    public class NTMTLQRCZ1
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务编码	C(6)
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 操作类型	C(4)
        /// </summary>
        public string INAOPR { get; set; }
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(200)
        /// </summary>
        public string ACCNAM { get; set; }
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
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 请求状态
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
    }
}
