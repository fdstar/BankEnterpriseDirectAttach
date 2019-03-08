using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.20.3进口信用证付款承兑拒付申请请求主体
    /// </summary>
    public class V1_LCPAYAPPLYTRNRQ : IRequest<V1_LCPAYAPPLYTRNRS>
    {
        /// <summary>
        /// 3.20.3进口信用证付款承兑拒付申请请求主体
        /// </summary>
        public LCPAYAPPLYTRNRQ LCPAYAPPLYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.20.3进口信用证付款承兑拒付申请请求主体
    /// </summary>
    public class LCPAYAPPLYTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.20.3进口信用证付款承兑拒付申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCPAYAPPLYTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.20.3进口信用证付款承兑拒付申请请求内容
    /// </summary>
    public class LCPAYAPPLYTRN_RQBODY
    {
        /// <summary>
        /// 地区机构	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string BRANCHNO { get; set; }
        /// <summary>
        /// 信用证号 长度：16	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string LCREFNO { get; set; }
        /// <summary>
        /// 到单号 长度：16	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string BPREFNO { get; set; }
        /// <summary>
        /// 申请人 长度：4*35	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string APPLICANT { get; set; }
        /// <summary>
        /// 受益人 长度：4*35	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// 单据金额 长度: (15,2)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal DOCAMT { get; set; }
        /// <summary>
        /// 实际索偿金额 长度: (15,2)	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal ACTUALAMT { get; set; }
        /// <summary>
        /// 合同号 长度：25	必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string CONTRACTNO { get; set; }
        /// <summary>
        /// 申请事项 必输
        /// 1、即期付款
        /// 2、远期付款
        /// 3、承兑
        /// 4、拒付
        /// </summary>
        [XmlElement(Order = 10)]
        public int LCBPPROCESS { get; set; }
        /// <summary>
        /// 拒付结果，拒付时必输 	非必输
        /// A:保留单据，听候交单人指示；
        /// B:拒付退单；
        /// C:保留单据，等待我司接受不符点；
        /// D:按照之前从交单人处获得的指示处理。
        /// </summary>
        [XmlElement(Order = 11)]
        public string REJECTRESULTTYPE { get; set; }
        /// <summary>
        /// 备注 允许中文 6*35	非必输
        /// </summary>
        [XmlElement(Order = 12)]
        public string COMMENT { get; set; }
        /// <summary>
        /// 申请日期, yyyy-MM-dd	必输 
        /// </summary>
        [XmlIgnore]
        public DateTime APPLYDATE { get; set; }
        /// <summary>
        /// 申请日期 yyyy-MM-dd, 对应<see cref="APPLYDATE"/>	必输 
        /// </summary>
        [XmlElement("APPLYDATE", Order = 13)]
        public string APPLYDATEStr
        {
            get
            {
                return this.APPLYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPLYDATE = tmp;
                }
            }
        }
    }
}
