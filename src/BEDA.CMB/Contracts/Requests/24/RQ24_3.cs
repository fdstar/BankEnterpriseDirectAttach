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
    /// 24.3.网银电子对账经办请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ24_3 : CMBBase<RQINFO>, IRequest<RS24_3>
    {
        /// <summary>
        /// NTNSTOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNSTOPR";
        /// <summary>
        /// 24.3.网银电子对账经办请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 24.3.网银电子对账经办请求集合
        /// </summary>
        [XmlElement("NTNSTOPRX")]
        public List<NTNSTOPRX> List { get; set; }
    }
    /// <summary>
    /// 24.3.网银电子对账经办请求内容
    /// </summary>
    public class NTNSTOPRX
    {
        /// <summary>
        /// 流水号        	C(10) 
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 批次号       	C(7)  
        /// </summary>
        public string BCHNBR { get; set; }
        /// <summary>
        /// 条形码编号   	C(14) 
        /// </summary>
        public string BARCOD { get; set; }
        /// <summary>
        /// 每页账户顺序号	C(2)  
        /// </summary>
        public string BARSEQ { get; set; }
        /// <summary>
        /// 户口号       	C(35) 
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 账户序号     	C(5)  
        /// </summary>
        public string ACTSEQ { get; set; }
        /// <summary>
        /// 活期账号     	C(35) 
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 对账月份     	C(6)  
        /// </summary>
        public string YERMTH { get; set; }
        /// <summary>
        /// 余额核对状态 	C(1) 
        /// 可能取值：余额相符：Y；余额不符：N；调节相符：S。余额不符（不为Y），原因必输
        /// </summary>
        public string BALFLG { get; set; }
        /// <summary>
        /// 业务参考号   	C(30) 
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 余额调节原因类型	C(5) 
        /// 余额不符（不为Y），需选择下面几种原因固定顺序
        /// 目前有五种（可多选，选中用1，不选用0。如客户选中前两项传值为11000）
        /// 1、客户已收账，银行未收账 
        /// 2、客户未收账，银行已收账
        /// 3、客户未付账，银行已付账 
        /// 4、客户已付账，银行未付账
        /// 5、其它
        /// 余额相符时，只能传入00000
        /// </summary>
        public string ADJCAS { get; set; }
        /// <summary>
        /// 联系电话        	Z(100)  余额不符（不为Y），手机号必输
        /// </summary>
        public string TELNBR { get; set; }
        /// <summary>
        /// 余额对账不符原因	Z(100)  余额不符（不为Y），原因必输
        /// </summary>
        public string LOGTXT { get; set; }
        
    }
}
