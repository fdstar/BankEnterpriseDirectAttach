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
    /// 12.5.5.汇入汇款款项确认信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_5_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIRAQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIRAQRY";
        /// <summary>
        /// 12.5.5.汇入汇款款项确认信息查询响应集合
        /// </summary>
        [XmlElement("NTIRAQRYZ")]
        public List<NTIRAQRYZ> List { get; set; }
    }
    /// <summary>
    /// 12.5.5.汇入汇款款项确认信息查询响应内容
    /// </summary>
    public class NTIRAQRYZ
    {
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 业务模式	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 客户名称   	Z(62)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 入账帐号   	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 汇入编号   	C(16)
        /// </summary>
        public string IRMNBR { get; set; }
        /// <summary>
        /// 汇入款性质 	C(1) 	C 资本项目 G 货物贸易 S 服务贸易
        /// </summary>
        public string IRMTYP { get; set; }
        /// <summary>
        /// 交易币种   	C(2) 	附录A.3
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
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
        /// 处理机构	C(6) 
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 同意标志	C(1) 	Y/N
        /// </summary>
        public string CFMFLG { get; set; }
        /// <summary>
        /// 交易编码	C(6) 
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 请求状态	C(3) 	附录A.5
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 请求结果	C(1) 	附录A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 失败原因	Z(62)
        /// </summary>
        public string RSNTXT { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
