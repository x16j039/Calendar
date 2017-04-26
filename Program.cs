using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datenow = DateTime.Now;
            Console.Write("{0}年 {1}月\n", datenow.Year, datenow.Month);

            //現在の年月の１日を取得
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1", datenow.Year, datenow.Month));
            //DisplayCalemdar(dateFirst); //カレンダーの表示
            Console.ReadLine();
        }

        //1か月分のカレンダーを画面に表示
        //パラメータ
        //      dateFirst: 表示したい年月の１日を表すDateTime
        static void DisplayCalemdar(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;

            //曜日タイトルの表示
            Console.Write("--------------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            //１日の開始まで空白を表示する
            for (week = 0; week < (int)dateFirst.DayOfWeek; week++) Console.Write("   ");

            //月の終わりの日まで１週間ごとに日にちを表示
            while (month == dateFirst.Month)
            {
                for(; week<7 && month == dateFirst.Month; week++)
                {
                    Console.Write("{0, 2} ", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1); //翌日にする
                }
                Console.Write("\n");
                week = 0;
            }
        }
    }
}
