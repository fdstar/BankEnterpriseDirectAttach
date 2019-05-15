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
        static void Part_11()
        {
            //RQ11_1Sample(); //test
            //RQ11_2Sample(); //test
            //RQ11_3Sample(); //test
            //RQ11_4Sample();
        }

        #region 11.代理清算
        /// <summary>
        /// 11.1.代理清算申请经办
        /// </summary>
        public static void RQ11_1Sample()
        {
            var rq = new RQ11_1()
            {
                NTOPRMODX = new NTOPRMODX
                {
                    BUSMOD = "00001"
                },
                List = new List<NTOPRAGPX1>
                {
                    new NTOPRAGPX1
                    {
                        YURREF=GetYURREF("11.1"),
                        DBTBBK="59",
                        DBTACC="591902896710812",
                        RMTACC="591902896710812",
                        RMTNAM="银企直连专用账户9",
                        RMTBNK="招商银行福州分行",
                        CRTACC="591902896810209",
                        CRTNAM="银企直连专用账户10",
                        CRTBNK="招商银行福州分行",
                        CRTADR="福建省福州市",
                        BNKFLG="Y",
                        CCYNBR="10",
                        TRSAMT=5,
                        STLCHN="N",
                        CHGFOR="O",
                    }
                }
            };
            var rs = client.Execute<RQ11_1, RS11_1>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 11.2.查询所有代理清算申请
        /// </summary>
        public static void RQ11_2Sample()
        {
            var rq = new RQ11_2()
            {
                NTAGPLSTX1 = new NTAGPLSTX1
                {
                    BGNDAT = DateTime.Now.AddMonths(-9),
                    ENDDAT = DateTime.Now.AddMonths(-7),
                }
            };
            var rs = client.Execute<RQ11_2, RS11_2>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 11.3.查询代理清算申请详细信息
        /// </summary>
        public static void RQ11_3Sample()
        {
            var rq = new RQ11_3()
            {
                List = new List<NTAGPINFX1>
                {
                    new NTAGPINFX1
                    {
                        REQNBR="0030223292"
                    }
                }
            };
            var rs = client.Execute<RQ11_3, RS11_3>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 11.4.查询代理清算批量经办处理结果
        /// </summary>
        public static void RQ11_4Sample()
        {
            var rq = new RQ11_4()
            {
                NTQPYRSTX = new NTQPYRSTX
                {
                    RSTSET = "2MLKL8G0FA"
                }
            };
            var rs = client.Execute<RQ11_4, RS11_4>(rq, "银企直连专用集团1");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
