using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_01()
        {
            //RQ1_4Sample();
            //RQ1_5Sample();
            //RQ1_6Sample();
            //RQ1_8Sample();
            //RQ1_9Sample();
        }

        #region 1.系统管理
        /// <summary>
        /// 1.4.取新的通知
        /// </summary>
        public static void RQ1_4Sample()
        {
            var rq = new RQ1_4();
            var rs = client.Execute<RQ1_4, RS1_4>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.5.取系统信息
        /// </summary>
        public static void RQ1_5Sample()
        {
            var rq = new RQ1_5()
            {
                SDKSYINFX = new SDKSYINFX()
            };
            var rs = client.Execute<RQ1_5, RS1_5>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.6.查询可经办业务模式
        /// </summary>
        public static void RQ1_6Sample()
        {
            var rq = new RQ1_6()
            {
                SDKMDLSTX = new SDKMDLSTX
                {
                    BUSCOD = "N02030"
                }
            };
            var rs = client.Execute<RQ1_6, RS1_6>(rq, "银企直连专用集团1");
            var txt = string.Join("\r", rs.List.Select(x => x.BUSMOD));
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.8.查询历史通知
        /// </summary>
        public static void RQ1_8Sample()
        {
            var rq = new RQ1_8()
            {
                FBDLRHMGX = new FBDLRHMGX
                {
                    BGNDAT = DateTime.Now.AddDays(-7),
                    ENDDAT = DateTime.Now,
                    //MSGTYP = "NCBUSFIN"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_8, RS1_8>(rq, "银企直连专用集团1");
            var txt1 = string.Join("\r", rs.NCDRTPAYList?.Select(x => x.BBKNBR + "," + x.KEYVAL).Distinct());
            var txt2 = string.Join("\r", rs.NCCRTTRSList?.Select(x => x.BBKNBR + "," + x.ACCNBR).Distinct());
            var txt3 = string.Join("\r", rs.NCDBTTRSList?.Select(x => x.BBKNBR + "," + x.ACCNBR).Distinct());
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 1.9.查询历史通知（新）
        /// </summary>
        public static void RQ1_9Sample()
        {
            var rq = new RQ1_9()
            {
                DCHISMSGX = new DCHISMSGX
                {
                    BGNDAT = DateTime.Now.AddDays(-100),
                    ENDDAT = DateTime.Now,
                    RECNUM = "100",
                    MSGTYP = "NCBCHOPR"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_9, RS1_9>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
