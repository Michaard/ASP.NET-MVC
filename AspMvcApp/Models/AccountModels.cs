using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data;

namespace AspMvcApp.Models
{
    public class LogOnModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm password")]
        public string ConfirmPassword { get; set; }

        public DataTable RegexTable { get; set; }
        
        public List<string> RegexDescriptionList { get; set; }

        [Required]
        [DisplayName("Password rule")]
        public string SelectedRegex { get; set; }

        public RegisterModel()
        {
            AspDatabase db = new AspDatabase();
            this.RegexDescriptionList = new List<string>();

            this.RegexTable = db.LoadDataFromRegexDatabase();

            for (int i = 0; i < RegexTable.Rows.Count; i++)
            {
                this.RegexDescriptionList.Add(RegexTable.Rows[i]["description"].ToString());
            }
        }
    }
}
