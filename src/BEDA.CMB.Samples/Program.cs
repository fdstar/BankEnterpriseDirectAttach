﻿using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.系统管理
            //RQ1_4Sample();
            //RQ1_5Sample();
            //RQ1_6Sample();
            //RQ1_8Sample();
            //RQ1_9Sample();
            #endregion

            #region 2.账户管理
            //RQ2_1Sample();
            //RQ2_2Sample();
            //RQ2_3Sample();
            #endregion

            Console.ReadLine();
        }

        #region 基础部分
        const string loginName = "银企直连专用集团1";
        const string ip = "127.0.0.1";
        const int port = 8082;
        static ICMBClient client = new CMBClient(ip, port);
        #endregion

        #region 1.系统管理
        /// <summary>
        /// 1.4.取新的通知
        /// </summary>
        public static void RQ1_4Sample()
        {
            var rq = new RQ1_4();
            var rs = client.Execute<RQ1_4, RS1_4>(rq, loginName);
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
            var rs = client.Execute<RQ1_5, RS1_5>(rq, loginName);
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
            var rs = client.Execute<RQ1_6, RS1_6>(rq, loginName);
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
            var rs = client.Execute<RQ1_8, RS1_8>(rq, loginName);
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
                    BGNDAT = DateTime.Now.AddDays(-7),
                    ENDDAT = DateTime.Now,
                    RECNUM = "100"
                    //MSGTYP = "NCBUSFIN"
                    //NCBCHOPR 
                    //NCDRTPAY  
                    //NCCRTTRS
                    //NCDBTTRS
                    //NCBUSFIN
                }
            };
            var rs = client.Execute<RQ1_9, RS1_9>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion

        #region 2.账户管理
        /// <summary>
        /// 2.1.查询可查询/可经办的账户列表
        /// </summary>
        public static void RQ2_1Sample()
        {
            var rq = new RQ2_1()
            {
                SDKACLSTX = new SDKACLSTX
                {
                     BUSCOD= "N02030",
                     BUSMOD= "00001"
                }
            };
            var rs = client.Execute<RQ2_1, RS2_1>(rq, loginName);
            var txt = string.Join("\r", rs.List.Select(x => x.BBKNBR + "," + x.ACCNBR));
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.2.查询账户详细信息
        /// </summary>
        public static void RQ2_2Sample()
        {
            var rq = new RQ2_2()
            {
                List = new List<SDKACINFX>
                {
                   new SDKACINFX{
                        BBKNBR="59",
                        ACCNBR="591902896732601",
                   },
                   new SDKACINFX{
                       BBKNBR="59",
                       ACCNBR ="591902896810104"
                   }
                }
            };
            var rs = client.Execute<RQ2_2, RS2_2>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 2.3.查询账户交易信息
        /// </summary>
        public static void RQ2_3Sample()
        {
            var rq = new RQ2_3()
            {
                SDKTSINFX = new SDKTSINFX
                {
                    BBKNBR = "59",
                    ACCNBR = "591902896710201",
                    BGNDAT = DateTime.Now.AddDays(-100),
                    ENDDAT = DateTime.Now.AddDays(-1),
                }
            };
            var rs = client.Execute<RQ2_3, RS2_3>(rq, loginName);
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
