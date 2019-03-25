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
    /// 24.1.网银对账待经办数据查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS24_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNSTQRY1
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTQRY1";
        /// <summary>
        /// 24.1.网银对账待经办数据查询响应内容
        /// 如果返回该接口，且CNTFLG字段为N时表示还有数据需要对账,先对完当前待经办数据再查询剩余数据,没有返回表示待经办数据已经查完
        /// </summary>
        public Requests.NTNSTQRYX NTNSTQRYX { get; set; }
        /// <summary>
        /// 24.1.网银对账待经办数据查询响应集合
        /// </summary>
        [XmlElement("NTNSTQRYZ")]
        public List<NTNSTQRYZ> List { get; set; }
    }
    /// <summary>
    /// 24.1.网银对账待经办数据查询响应内容
    /// </summary>
    public class NTNSTQRYZ
    {
        /// <summary>
        /// 批次号         	C(7) 
        /// </summary>
        public string BCHNBR { get; set; }
        /// <summary>
        /// 对账中心机构   	C(6) 
        /// </summary>
        public string PRCBRN { get; set; }
        /// <summary>
        /// 对账月份       	C(6) 
        /// </summary>
        public string YERMTH { get; set; }
        /// <summary>
        /// 客户号         	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 账户序号       	C(5) 
        /// </summary>
        public string ACTSEQ { get; set; }
        /// <summary>
        /// 资金户口       	C(8) 
        /// </summary>
        public string IACNBR { get; set; }
        /// <summary>
        /// 户口           	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 定期保证金标志 	C(1) 
        /// </summary>
        public string TDSTAG { get; set; }
        /// <summary>
        /// 账户代码       	C(5) 
        /// </summary>
        public string ACTCOD { get; set; }
        /// <summary>
        /// 货币           	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志      	C(1)   
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户方向      	C(1)   
        /// </summary>
        public string ACTDIR { get; set; }
        /// <summary>
        /// 核算种类      	C(8)   
        /// </summary>
        public string LGRTYP { get; set; }
        /// <summary>
        /// 明细账机构    	C(6)  
        /// </summary>
        public string ACTBRN { get; set; }
        /// <summary>
        /// 总账机构       	C(6) 
        /// </summary>
        public string LGRBRN { get; set; }
        /// <summary>
        /// 月底余额      	C(15)  
        /// </summary>
        public decimal ACTBAL { get; set; }
        /// <summary>
        /// 条形码编号    	C(14)  
        /// </summary>
        public string BARCOD { get; set; }
        /// <summary>
        /// 每页账户顺序号	C(2)   
        /// </summary>
        public string BARSEQ { get; set; }
        /// <summary>
        /// 客户每期总页号	C(7)  
        /// </summary>
        public int PAGNBR { get; set; }
        /// <summary>
        /// 客户每期页号  	C(5)   
        /// </summary>
        public int PAGNB2 { get; set; }
        /// <summary>
        /// 打印次数        	C(3) 
        /// </summary>
        public int PRTTIM { get; set; }
        /// <summary>
        /// 工作流验印次数  	C(2) 
        /// </summary>
        public int FALNUM { get; set; }
        /// <summary>
        /// 工作流系统流水号
        /// </summary>
        public string FLWNBR { get; set; }
        /// <summary>
        /// 对账类型        	C(1) E， 电子对账 P， 纸质对账
        /// </summary>
        public string STMTYP { get; set; }
        /// <summary>
        /// 余额核对状态    	C(1) Y，余额相符 N，余额不符 S, 调节相符 F, 调节不符
        /// </summary>
        public string BALFLG { get; set; }
        /// <summary>
        /// 余额核对日期    	D
        /// </summary>
        [XmlIgnore]
        public DateTime BALDAT { get; set; }
        /// <summary>
        /// 余额核对日期    	D, 对应<see cref="BALDAT"/>
        /// </summary>
        [XmlElement("BALDAT")]
        public string BALDATStr
        {
            get
            {
                return this.BALDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BALDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 客户处理状态    	C(1) 1，待经办 2，待复核 3，复核通过
        /// </summary>
        public string ECTFLG { get; set; }
        /// <summary>
        /// 状态            	C(1) 1，已生成数据 3，对账中 5，对账完成
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 联系电话        	Z(100)
        /// </summary>
        public string TELNBR { get; set; }
        /// <summary>
        /// 活期账号        	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 错误信息	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 特殊码  	C(20)
        /// </summary>
        public string SPLC20 { get; set; }
    }
}
