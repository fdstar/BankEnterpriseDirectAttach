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
    /// 17.30.查询单个虚拟户的历史余额请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ17_30 : CMBBase<RQINFO>, IRequest<RS17_30>
    {
        /// <summary>
        /// NTDMAHAD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMAHAD";
        /// <summary>
        /// 17.30.查询单个虚拟户的历史余额请求内容
        /// </summary>
        public NTDMAHADX1 NTDMAHADX1 { get; set; }
    }
    /// <summary>
    /// 17.30.查询单个虚拟户的历史余额请求内容
    /// </summary>
    public class NTDMAHADX1
    {
        /// <summary>
        /// 分行号	C(2) 
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 开始日期	D   支持查询本年和去年的历史数据 一次查询间隔不能超过3个月
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 开始日期	D, 对应<see cref="BEGDAT"/>
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
        /// 结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 结束日期	D, 对应<see cref="ENDDAT"/>
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
