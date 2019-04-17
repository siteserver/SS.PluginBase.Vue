﻿using System;

namespace SS.PluginBase.Vue
{
    public enum EDateFormatType
    {
        Month,				//6月18日
        Day,				//2006-6-18
        Year,				//2006年6月
        Chinese,		    //2006年6月18日
    }

    public class EDateFormatTypeUtils
    {
        public static string GetValue(EDateFormatType type)
        {
            if (type == EDateFormatType.Month)
            {
                return "Month";
            }
            if (type == EDateFormatType.Day)
            {
                return "Day";
            }
            if (type == EDateFormatType.Year)
            {
                return "Year";
            }
            if (type == EDateFormatType.Chinese)
            {
                return "Chinese";
            }
            throw new Exception();
        }

        public static string GetText(EDateFormatType type)
        {
            if (type == EDateFormatType.Month)
            {
                return "6月18日";
            }
            if (type == EDateFormatType.Day)
            {
                return "2006-6-18";
            }
            if (type == EDateFormatType.Year)
            {
                return "2006年6月";
            }
            if (type == EDateFormatType.Chinese)
            {
                return "2006年6月18日";
            }
            throw new Exception();
        }

        public static EDateFormatType GetEnumType(string typeStr)
        {
            var retVal = EDateFormatType.Month;

            if (Equals(EDateFormatType.Month, typeStr))
            {
                retVal = EDateFormatType.Month;
            }
            else if (Equals(EDateFormatType.Day, typeStr))
            {
                retVal = EDateFormatType.Day;
            }
            else if (Equals(EDateFormatType.Year, typeStr))
            {
                retVal = EDateFormatType.Year;
            }
            else if (Equals(EDateFormatType.Chinese, typeStr))
            {
                retVal = EDateFormatType.Chinese;
            }

            return retVal;
        }

        public static bool Equals(EDateFormatType type, string typeStr)
        {
            if (string.IsNullOrEmpty(typeStr)) return false;
            if (string.Equals(GetValue(type).ToLower(), typeStr.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static bool Equals(string typeStr, EDateFormatType type)
        {
            return Equals(type, typeStr);
        }
    }
}