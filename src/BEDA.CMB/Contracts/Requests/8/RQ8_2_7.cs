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
    /// 8.2.7.智能现金池投资计划经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_2_7 : CMBBase<RQINFO>, IRequest<RS8_2_7>
    {
        /// <summary>
        /// NTFNPOPR    
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNPOPR";
        /// <summary>
        /// 8.2.7.智能现金池投资计划经办请求内容
        /// </summary>
        public NTFNPOPRX NTFNPOPRX { get; set; }
    }
    /// <summary>
    /// 8.2.7.智能现金池投资计划经办请求内容
    /// </summary>
    public class NTFNPOPRX
    {
        /// <summary>
        /// 业务模式         	C(5)
        /// </summary>
        public string BUSMOD { get; set; }
        /// <summary>
        /// 计划编号         	C(24)   修改或删除时必填
        /// </summary>
        public string TAAAPP { get; set; }
        /// <summary>
        /// 分行号           	C(2)    新增时必输
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号             	C(35)   新增时必输
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 协议号	C(10)   新增时必输
        /// </summary>
        public string FNDCTR { get; set; }
        /// <summary>
        /// 基金操作类型     	C(4)	J022=智能投资 J024=智能赎回 新增时必输
        /// </summary>
        public string TRSCOD { get; set; }
        /// <summary>
        /// 交易代码         	C(3)	ADD：增加 UPD：修改 DLT：删除
        /// </summary>
        public string MNTTYP { get; set; }
        /// <summary>
        /// 基金代码         	C(8)    新增时必输
        /// </summary>
        public string FNDCOD { get; set; }
        /// <summary>
        /// 期满金／份额     	M   新增时有效
        /// </summary>
        public decimal? STKCUT { get; set; }
        /// <summary>
        /// 每期买入／赎回金／	M	TRSTYP为0时，不能为0 TRSTYP为1时，为0 定额投资或赎回下新增和修改时必填
        /// </summary>
        public decimal? TRSAMT { get; set; }
        /// <summary>
        /// 计划开始日期     	D   新增、修改时必填
        /// </summary>
        [XmlIgnore]
        public DateTime? BEGDAT { get; set; }
        /// <summary>
        /// 计划开始日期     	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.BEGDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 投资周期    	C(3)    新增、修改时必填
        /// </summary>
        public string FIXTUN { get; set; }
        /// <summary>
        /// 投资周期单位	C(1)	D/W/M   新增、修改时必填
        /// </summary>
        public string FIXUNT { get; set; }
        /// <summary>
        /// 期满方式    	C(1)    新增时有效
        /// </summary>
        public string TUNTYP { get; set; }
        /// <summary>
        /// 执行类型    	C(1)	0=指定份额 1=智能补足活期 新增、修改时必填
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 活期留存金额	M	TRSTYP为0时，为0 TRSTYP为1时，不为0  留存投资下新增、修改时必填
        /// </summary>
        public decimal? CURAMT { get; set; }
        /// <summary>
        /// 触发金额    	M	TRSTYP为0时，为0    留存投资下新增时必填
        /// </summary>
        public decimal? TRGAMT { get; set; }
        /// <summary>
        /// 业务参考号  	C(30)
        /// </summary>
        public string YURREF { get; set; }
    }
}
