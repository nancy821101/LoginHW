using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginHW.Filters
{
    public sealed class BanWordAttribute : ValidationAttribute
    {
        public string Input { get; set; }

        public BanWordAttribute(string input)
        {
            this.Input = input;
        }
        public override bool IsValid(object value)
        {
            //權責分清楚，沒有輸入不算錯
            if (value == null)
            {
                return true;
            }

            if (value is string)
            {
                //輸入值是字串才判斷
                List<string> list = new List<string>(this.Input.Split(','));
                if (list.Any(x => value.ToString().Contains(x)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}