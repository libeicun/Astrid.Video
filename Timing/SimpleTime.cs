﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Astrid.Timing {
    class SimpleTime {
        private int hour = 0;
        private int minute = 0;
        private int second = 0;
        private int totalSecond = 0;

        public SimpleTime(int hour, int minute, int second) {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            updateTotalS();
        }
        public SimpleTime(int totalSecond) {
            this.totalSecond = totalSecond;
            this.hour = totalSecond / 3600;
            this.minute = (totalSecond % 3600) / 60;
            this.second = (totalSecond % 3600) % 60;
        }
        public SimpleTime(DateTime dateTime):this(dateTime.Hour, dateTime.Minute, dateTime.Second) {
            
        }



        public int Hour {
            get{
                return hour;
            }
            set{
                hour = value;
                updateTotalS();
            }
        }
        public int Minute {
            get{
                return minute;
            }
                        set{
                minute = value;
                updateTotalS();
            }
        }
        public int Second {
            get {
                return second;
            }            set{
                second = value;
                updateTotalS();
            }
        }
        public int TotalSecond{
            get{
                return totalSecond;
            }
        }


        public bool IsSameAs(DateTime dateTime) {
            
            return this.Equals(new SimpleTime(dateTime));
        }

        public SimpleTime getBefore(SimpleTime time) {
            return new SimpleTime(this.TotalSecond - time.TotalSecond);
        }
        public SimpleTime getAfter(SimpleTime time) {
            return new SimpleTime(this.TotalSecond + time.TotalSecond);
        }
        public bool isBefore(SimpleTime anotherTime) {
            return this.TotalSecond <= anotherTime.TotalSecond;
        }
        public bool isBetween(SimpleTime t1, SimpleTime t2) {
            int s1 = t1.TotalSecond;
            int s2 = t2.TotalSecond;
            int s = this.TotalSecond;
            return (s1 <= s && s <= s2) || (s1 >= s && s >= s2);
        }

        private void updateTotalS() {
            totalSecond = this.hour * 3600 + this.minute * 60 + this.second;
        }


        public override String ToString() {
            return hour.ToString() + "时 " +minute.ToString() + "分 " +second.ToString() + "秒";
        }

        public override bool Equals(object obj) {
            SimpleTime t = (SimpleTime)obj;
            return this.TotalSecond == t.TotalSecond;
        }

    }
}
