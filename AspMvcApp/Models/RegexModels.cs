using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcApp.Models
{
    public class RegexModel
    {
        [Required]
        [DisplayName("Rule name")]
        public string Name { get; set; }
        
        [DisplayName("Minimum password lenght")]
        public int MinLength { get; set; }
        public bool ChMinLength { get; set; }
        
        [DisplayName("Maximum password lenght")]
        public int MaxLength { get; set; }
        public bool ChMaxLength { get; set; }
        
        [DisplayName("Minimum number of uppercase letters")]
        public int MinUpperCase { get; set; }
        public bool ChUpperCase { get; set; }
        
        [DisplayName("Minimum number of lowercase letters")]
        public int MinLowerCase { get; set; }
        public bool ChLowerCase { get; set; }
        
        [DisplayName("Minimum number of special signs")]
        public int MinSpecialSigns { get; set; }
        public bool ChSpecialSigns { get; set; }
        
        [DisplayName("Minimum number of digits")]
        public int MinDigits { get; set; }
        public bool ChDigits { get; set; }

        public string ToString()
        {
            string regexDesc = "";
            if (this.ChMinLength) regexDesc += "Minimum password length = " + this.MinLength + ";";
            if (this.ChMaxLength) regexDesc += "Maximum password length = " + this.MaxLength + ";";
            if (this.ChUpperCase) regexDesc += "Minimum number of uppercase letters = " + this.MinUpperCase + ";";
            if (this.ChLowerCase) regexDesc += "Minimum number of lowercase letters = " + this.MinLowerCase + ";";
            if (this.ChSpecialSigns) regexDesc += "Minimum number of special signs = " + this.MinSpecialSigns + ";";
            if (this.ChDigits) regexDesc += "Minimum number of digits = " + this.MinDigits + ";";

            if (regexDesc.Equals("")) regexDesc = "Simple password - type anything you like;";

            return regexDesc;
        }

        public static string CreateRegexString(int minLength, bool chMinLength, int maxLength, bool chMaxLength, int minUppercase, bool chUppercase, int minLowercase, bool chLowercase, int minSpecialSigns, bool chSpecialSigns, int minDigits, bool chDigits)
        {
            string length, uppercase, lowercase, specsigs, digits;
            int min, max;
            if (chMinLength == true)
                min = minLength;
            else
                min = 0;
            if (chMaxLength == true)
                max = maxLength;
            else
                max = Int32.MaxValue;
            length = "(?=^.{" + min + "," + max + "}$)";
            if (chUppercase == true)
                uppercase = "(?=(.*[A-Z]){" + minUppercase + ",})";
            else
                uppercase = null;
            if (chLowercase == true)
                lowercase = "(?=(.*[a-z]){" + minLowercase + ",})";
            else
                lowercase = null;
            if (chDigits == true)
                digits = @"(?=(.*\d){" + minDigits + ",})";
            else
                digits = null;
            if (chSpecialSigns == true)
                specsigs = @"(?=(.*[^\da-zA-Z]){" + minSpecialSigns + ",})";
            else
                specsigs = null;
            string result = length + uppercase + lowercase + digits + specsigs;
            return result;
        }
    }
}