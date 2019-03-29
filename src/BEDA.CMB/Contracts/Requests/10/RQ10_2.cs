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
    /// 10.2.现金池账户额度积数查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ10_2 : CMBBase<RQINFO>, IRequest<RS10_2>
    {
        /// <summary>
        /// SDKNTCACINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCACINF";
        /// <summary>
        /// 10.2.现金池账户额度积数查询请求内容
        /// </summary>
        public NTAUBRTVY NTAUBRTVY { get; set; }
        /// <summary>
        /// 10.2.现金池账户额度积数查询请求集合
        /// </summary>
        [XmlElement("NTAUBRTVX")]
        public List<NTAUBRTVX> List { get; set; }
    }
    /// <summary>
    /// 10.2.现金池账户额度积数查询请求内容
    /// </summary>
    public class NTAUBRTVY
    {
        /// <summary>
        /// 开始日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 开始日期 	D, 对应<see cref="BEGDAT"/>
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
        /// 终止日期 	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期 	D, 对应<see cref="ENDDAT"/>
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
    /// <summary>
    /// 10.2.现金池账户额度积数查询请求内容
    /// </summary>
    public class NTAUBRTVX
    {
        /// <summary>
        /// 子公司协议序号	N(5)    取自10.1返回接口NTCACLSTZ1字段FCTVAL
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 协议编号 	C(10)   取自10.1返回接口NTCACLSTZ1字段FCTVAL
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 扩充字段	C(20)
        /// </summary>
        public string FCTVAL { get; set; }
    }
}
